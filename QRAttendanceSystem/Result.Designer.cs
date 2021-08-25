
namespace QRAttendanceSystem
{
    partial class Result
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.LABEL_LastName = new System.Windows.Forms.Label();
            this.LABEL_FirstName = new System.Windows.Forms.Label();
            this.LABEL_Retry = new System.Windows.Forms.Label();
            this.submitResultWorker = new System.ComponentModel.BackgroundWorker();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 342);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(614, 10);
            this.progressBar.TabIndex = 0;
            // 
            // LABEL_LastName
            // 
            this.LABEL_LastName.Font = new System.Drawing.Font("Segoe UI Black", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LABEL_LastName.Location = new System.Drawing.Point(0, 89);
            this.LABEL_LastName.Name = "LABEL_LastName";
            this.LABEL_LastName.Size = new System.Drawing.Size(614, 54);
            this.LABEL_LastName.TabIndex = 2;
            this.LABEL_LastName.Text = "Pasigado,";
            this.LABEL_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL_FirstName
            // 
            this.LABEL_FirstName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LABEL_FirstName.Location = new System.Drawing.Point(0, 142);
            this.LABEL_FirstName.Name = "LABEL_FirstName";
            this.LABEL_FirstName.Size = new System.Drawing.Size(614, 37);
            this.LABEL_FirstName.TabIndex = 3;
            this.LABEL_FirstName.Text = "Anton John B.";
            this.LABEL_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL_Retry
            // 
            this.LABEL_Retry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LABEL_Retry.Location = new System.Drawing.Point(0, 313);
            this.LABEL_Retry.Name = "LABEL_Retry";
            this.LABEL_Retry.Size = new System.Drawing.Size(614, 23);
            this.LABEL_Retry.TabIndex = 4;
            this.LABEL_Retry.Text = "Recording your attendance";
            this.LABEL_Retry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitResultWorker
            // 
            this.submitResultWorker.WorkerReportsProgress = true;
            this.submitResultWorker.WorkerSupportsCancellation = true;
            this.submitResultWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.submitResultWorker_DoWork);
            this.submitResultWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.submitResultWorker_ProgressChanged);
            this.submitResultWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.submitResultWorker_RunWorkerCompleted);
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.Controls.Add(this.label1);
            this.ErrorPanel.Controls.Add(this.label4);
            this.ErrorPanel.Location = new System.Drawing.Point(0, 0);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(614, 352);
            this.ErrorPanel.TabIndex = 5;
            this.ErrorPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please try again.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(589, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "There was a problem submitting your attendance";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 352);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.LABEL_Retry);
            this.Controls.Add(this.LABEL_FirstName);
            this.Controls.Add(this.LABEL_LastName);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Result";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Result_FormClosing);
            this.Shown += new System.EventHandler(this.Result_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Result_KeyPress);
            this.ErrorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label LABEL_LastName;
        private System.Windows.Forms.Label LABEL_FirstName;
        private System.Windows.Forms.Label LABEL_Retry;
        private System.ComponentModel.BackgroundWorker submitResultWorker;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}