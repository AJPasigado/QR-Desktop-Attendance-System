
namespace QRAttendanceSystem
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PTBOX_QR = new System.Windows.Forms.PictureBox();
            this.LABEL_Message = new System.Windows.Forms.Label();
            this.LABEL_Time = new System.Windows.Forms.Label();
            this.LABEL_Date = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBBOX_Device = new System.Windows.Forms.ComboBox();
            this.QRBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.TIMER_Clock = new System.Windows.Forms.Timer(this.components);
            this.BTN_Admin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PTBOX_QR)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PTBOX_QR
            // 
            this.PTBOX_QR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PTBOX_QR.Location = new System.Drawing.Point(3, 191);
            this.PTBOX_QR.Name = "PTBOX_QR";
            this.PTBOX_QR.Size = new System.Drawing.Size(450, 450);
            this.PTBOX_QR.TabIndex = 1;
            this.PTBOX_QR.TabStop = false;
            // 
            // LABEL_Message
            // 
            this.LABEL_Message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LABEL_Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LABEL_Message.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LABEL_Message.Location = new System.Drawing.Point(3, 644);
            this.LABEL_Message.Name = "LABEL_Message";
            this.LABEL_Message.Size = new System.Drawing.Size(447, 53);
            this.LABEL_Message.TabIndex = 4;
            this.LABEL_Message.Text = "Please align your code inside the box to scan.";
            this.LABEL_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL_Time
            // 
            this.LABEL_Time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LABEL_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LABEL_Time.Font = new System.Drawing.Font("Segoe UI Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LABEL_Time.Location = new System.Drawing.Point(3, 0);
            this.LABEL_Time.Name = "LABEL_Time";
            this.LABEL_Time.Size = new System.Drawing.Size(450, 86);
            this.LABEL_Time.TabIndex = 8;
            this.LABEL_Time.Text = "80:80.80 AM";
            this.LABEL_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL_Date
            // 
            this.LABEL_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LABEL_Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LABEL_Date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LABEL_Date.Location = new System.Drawing.Point(3, 86);
            this.LABEL_Date.Name = "LABEL_Date";
            this.LABEL_Date.Size = new System.Drawing.Size(450, 21);
            this.LABEL_Date.TabIndex = 9;
            this.LABEL_Date.Text = "Tuesday, May 05, 2021";
            this.LABEL_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.LABEL_Time);
            this.flowLayoutPanel1.Controls.Add(this.LABEL_Date);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.CBBOX_Device);
            this.flowLayoutPanel1.Controls.Add(this.PTBOX_QR);
            this.flowLayoutPanel1.Controls.Add(this.LABEL_Message);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(382, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(450, 716);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 40);
            this.panel1.TabIndex = 10;
            // 
            // CBBOX_Device
            // 
            this.CBBOX_Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBOX_Device.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBBOX_Device.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBBOX_Device.FormattingEnabled = true;
            this.CBBOX_Device.Location = new System.Drawing.Point(3, 156);
            this.CBBOX_Device.Name = "CBBOX_Device";
            this.CBBOX_Device.Size = new System.Drawing.Size(447, 29);
            this.CBBOX_Device.TabIndex = 11;
            this.CBBOX_Device.TabStop = false;
            this.CBBOX_Device.SelectedValueChanged += new System.EventHandler(this.CBBOX_Device_SelectedValueChanged);
            // 
            // QRBoxTimer
            // 
            this.QRBoxTimer.Enabled = true;
            this.QRBoxTimer.Tick += new System.EventHandler(this.QRBoxTimer_Tick);
            // 
            // TIMER_Clock
            // 
            this.TIMER_Clock.Enabled = true;
            this.TIMER_Clock.Interval = 1000;
            this.TIMER_Clock.Tick += new System.EventHandler(this.TIMER_Clock_Tick);
            // 
            // BTN_Admin
            // 
            this.BTN_Admin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Admin.FlatAppearance.BorderSize = 0;
            this.BTN_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Admin.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Admin.Location = new System.Drawing.Point(1116, 12);
            this.BTN_Admin.Name = "BTN_Admin";
            this.BTN_Admin.Size = new System.Drawing.Size(86, 28);
            this.BTN_Admin.TabIndex = 11;
            this.BTN_Admin.Text = "Admin";
            this.BTN_Admin.UseVisualStyleBackColor = true;
            this.BTN_Admin.Click += new System.EventHandler(this.BTN_Admin_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1214, 806);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_Admin);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Homepage_FormClosing);
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PTBOX_QR)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PTBOX_QR;
        private System.Windows.Forms.Label LABEL_Message;
        private System.Windows.Forms.Label LABEL_Time;
        private System.Windows.Forms.Label LABEL_Date;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBBOX_Device;
        private System.Windows.Forms.Timer QRBoxTimer;
        private System.Windows.Forms.Timer TIMER_Clock;
        private System.Windows.Forms.Button BTN_Admin;
    }
}