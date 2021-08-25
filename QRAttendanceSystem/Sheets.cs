using System;
using System.Collections.Generic;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using QRAttendanceSystem.Properties;

namespace QRAttendanceSystem
{
    public class Sheets
    {
        SheetsService sheetsService;

        public Sheets()
        {
            InitializeSpreadsheet();
        }

        public void InitializeSpreadsheet()
        {
            UserCredential credential;
            string[] Scopes = { SheetsService.Scope.Spreadsheets };

            using (var stream =
                new FileStream(Constants.spreadsheet_credential, FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            this.sheetsService = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = Constants.application_name,
            });
        }

        public SheetsService GetSheetsService() {
            return this.sheetsService;
        }

        public void SubmitList(IList<IList<Object>> values, BackgroundWorker submitResultWorker)
        {
            
            int retries = 0;

            while (retries < Settings.Default.GoogleSheet_Retries) {
                try {
                    SpreadsheetsResource.ValuesResource.AppendRequest request =
                            this.sheetsService.Spreadsheets.Values.Append(new ValueRange() { Values = values }, Settings.Default.GoogleSheet_SheetID, Settings.Default.GoogleSheet_Range);

                    submitResultWorker.ReportProgress(40);

                    request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;

                    submitResultWorker.ReportProgress(60);

                    request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;

                    submitResultWorker.ReportProgress(80);

                    var response = request.Execute();

                    submitResultWorker.ReportProgress(100);

                    break;
                }
                catch
                {
                    retries += 1;

                    if (retries < Settings.Default.GoogleSheet_Retries)
                    {
                        continue;
                    }
                    else {
                        submitResultWorker.ReportProgress(0);
                    }
                }
            }
        }
    }
}
