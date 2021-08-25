using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using QRAttendanceSystem.Properties;
using ZXing;

namespace QRAttendanceSystem
{
    public partial class Homepage : Form
    {
        readonly Shadow Shadow;
        readonly Sheets Sheets;
        FilterInfoCollection CaptureDevice;
        VideoCaptureDevice FinalFrame;
        NewFrameEventHandler NewFrameEventHandler;
        Boolean ProcessFlag;

        public Homepage()
        {
            InitializeComponent();
            this.Sheets = new Sheets();
            this.Shadow = new Shadow();
            this.Shadow.VisibleChanged += new EventHandler(Shadow_VisibleChanged);
            this.Shadow.sheets = this.Sheets;
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo Device in CaptureDevice)
            {
                CBBOX_Device.Items.Add(Device.Name);
            }

            CBBOX_Device.SelectedIndex = 0;
            ProcessFlag = true;
            QRBoxTimer.Enabled = true;
            QRBoxTimer.Start();
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalFrame.SignalToStop();
        }
         
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            PTBOX_QR.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QRBoxTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ProcessFlag)
                {
                    BarcodeReader Reader = new BarcodeReader();
                    ZXing.Result result = Reader.Decode((Bitmap)PTBOX_QR.Image);

                    if (result != null)
                    {
                        string decoded = result.ToString().Trim();
                        if (decoded != "")
                        {
                            ProcessFlag = false;
                            ValidateDecoded(decoded);
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void TIMER_Clock_Tick(object sender, EventArgs e)
        {
            LABEL_Time.Text = DateTime.Now.ToLongTimeString().ToUpper();
            LABEL_Date.Text = DateTime.Now.ToLongDateString();
        }

        private void ValidateDecoded(String Decode) {
            String[] Values = Decode.Split(';');

            if (Values.Length > 0 && Values[0].Equals(Settings.Default.Admin_QRFlag) && Values.Length == Constants.data_columns.Length + 1)
            {
                this.Shadow.Width = this.Width;
                this.Shadow.Height = this.Height;
                this.Shadow.OpenResultForm(Values, this);
            }
            else {
                LABEL_Message.Text = "Invalid Attendance QR";
            }
        }

        private void Shadow_VisibleChanged(object sender, System.EventArgs e)
        {
            if (!Shadow.Visible) {
                ProcessFlag = true;
            }
        }

        private void CBBOX_Device_SelectedValueChanged(object sender, EventArgs e)
        {
            if (FinalFrame != null && FinalFrame.IsRunning)
            {
                FinalFrame.NewFrame -= NewFrameEventHandler;
                FinalFrame.SignalToStop();
            }
            FinalFrame = new VideoCaptureDevice(CaptureDevice[CBBOX_Device.SelectedIndex].MonikerString);
            NewFrameEventHandler = new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.NewFrame += NewFrameEventHandler;
            FinalFrame.Start();
        }

        private void BTN_Admin_Click(object sender, EventArgs e)
        {
            this.Shadow.Width = this.Width;
            this.Shadow.Height = this.Height;
            this.Shadow.OpenAdminForm();
        }
    }
}
