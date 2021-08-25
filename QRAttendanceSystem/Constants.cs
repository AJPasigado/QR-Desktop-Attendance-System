using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRAttendanceSystem
{
    class Constants
    {
        public static Boolean debug = true;
        public static String application_name = "QR Attendance System";
        public static String application_flag = "QR Attendance System by @Ajacence";

        public static String spreadsheet_range = "Attendance!A2";
        public static String spreadsheet_Id = "17W76_IJm6ixYQIf0vTg91q4F26c1nOdq62K5Ooxoql4";
        public static String spreadsheet_credential = "credentials.json";
        public static int spreadsheet_retries = 5;

        public static String[] data_columns = { "First Name", "Last Name", "Middle Name"};
    }
}
