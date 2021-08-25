using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace QRAttendanceSystem
{
    public partial class Result : Form
    {
        public Shadow shadow;
        public Sheets sheets;
        public string[] values;

        public Result()
        {
            InitializeComponent();
        }

        private void Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Constants.debug) shadow.CloseForm(this);
        }


        public void SubmitAttendance()
        {
            submitResultWorker.ReportProgress(1);

            IList<Object> obj = new List<Object>();
            obj.Add(DateTime.Now.ToShortTimeString());
            obj.Add(DateTime.Now.ToString("dd/MM/yyyy"));

            for (int i = 1; i < this.values.Length; i++) {
                obj.Add(this.values[i]);
            }
            
            IList<IList<Object>> values = new List<IList<Object>>();
            values.Add(obj);

            submitResultWorker.ReportProgress(10);

            this.sheets.SubmitList(values, submitResultWorker);

            Thread.Sleep(1000);
        }

        private void submitResultWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SubmitAttendance();
        }

        private void submitResultWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void Result_Shown(object sender, EventArgs e)
        {
            LABEL_LastName.Text = this.values[1];
            LABEL_FirstName.Text = this.values[2] + " " + this.values[3];
            progressBar.Value = 0;
            submitResultWorker.RunWorkerAsync();
        }

        private void submitResultWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > progressBar.Value)
            {
                progressBar.Value = e.ProgressPercentage;
            }
            else if (e.ProgressPercentage == 0) {
                ErrorPanel.Show();
                submitResultWorker.CancelAsync();
            }
            else
            {
                LABEL_Retry.Text = "Retrying...";
            }
        }

        private void Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            submitResultWorker.CancelAsync();
            this.shadow.CloseForm();
        }
    }
}
