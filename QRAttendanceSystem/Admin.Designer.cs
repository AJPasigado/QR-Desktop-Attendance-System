
namespace QRAttendanceSystem
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.CG_Title = new System.Windows.Forms.Label();
            this.CG_Desc = new System.Windows.Forms.Label();
            this.AL_Desc = new System.Windows.Forms.Label();
            this.AL_Title = new System.Windows.Forms.Label();
            this.CS_CloseSystem = new System.Windows.Forms.Label();
            this.CT_Desc = new System.Windows.Forms.Label();
            this.CT_Title = new System.Windows.Forms.Label();
            this.CA_Title = new System.Windows.Forms.Label();
            this.CG_Panel = new System.Windows.Forms.Panel();
            this.CG_SaveQR = new System.Windows.Forms.Label();
            this.CG_ClearButton = new System.Windows.Forms.Label();
            this.CG_QRBox = new System.Windows.Forms.PictureBox();
            this.CG_MIddleName = new System.Windows.Forms.TextBox();
            this.CG_FirstName = new System.Windows.Forms.TextBox();
            this.CG_LastName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CG_QRSaveBox = new System.Windows.Forms.SaveFileDialog();
            this.Panel_Password = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminPassword = new System.Windows.Forms.TextBox();
            this.CT_Panel = new System.Windows.Forms.Panel();
            this.CT_LabelSaved = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CT_QRFlag = new System.Windows.Forms.TextBox();
            this.CT_AdminPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CT_Retries = new System.Windows.Forms.NumericUpDown();
            this.CT_SaveButton = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CT_SheetRange = new System.Windows.Forms.TextBox();
            this.CT_SheetID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Label_InvalidPassword = new System.Windows.Forms.Label();
            this.CG_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CG_QRBox)).BeginInit();
            this.Panel_Password.SuspendLayout();
            this.CT_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_Retries)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "QR Attendance System";
            // 
            // CG_Title
            // 
            this.CG_Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CG_Title.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CG_Title.Location = new System.Drawing.Point(56, 135);
            this.CG_Title.Name = "CG_Title";
            this.CG_Title.Size = new System.Drawing.Size(251, 26);
            this.CG_Title.TabIndex = 2;
            this.CG_Title.Text = "Code Generator";
            this.CG_Title.Click += new System.EventHandler(this.CG_Title_Click);
            this.CG_Title.MouseEnter += new System.EventHandler(this.CG_Title_MouseEnter);
            this.CG_Title.MouseLeave += new System.EventHandler(this.CG_Title_MouseLeave);
            // 
            // CG_Desc
            // 
            this.CG_Desc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CG_Desc.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CG_Desc.Location = new System.Drawing.Point(56, 161);
            this.CG_Desc.Name = "CG_Desc";
            this.CG_Desc.Size = new System.Drawing.Size(251, 26);
            this.CG_Desc.TabIndex = 3;
            this.CG_Desc.Text = "Create a QR code for a user";
            this.CG_Desc.Click += new System.EventHandler(this.CG_Title_Click);
            this.CG_Desc.MouseEnter += new System.EventHandler(this.CG_Desc_MouseEnter);
            this.CG_Desc.MouseLeave += new System.EventHandler(this.CG_Desc_MouseLeave);
            // 
            // AL_Desc
            // 
            this.AL_Desc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AL_Desc.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AL_Desc.ForeColor = System.Drawing.Color.DimGray;
            this.AL_Desc.Location = new System.Drawing.Point(56, 240);
            this.AL_Desc.Name = "AL_Desc";
            this.AL_Desc.Size = new System.Drawing.Size(251, 26);
            this.AL_Desc.TabIndex = 5;
            this.AL_Desc.Text = "Open Google Sheets in browser";
            this.AL_Desc.Click += new System.EventHandler(this.AL_Title_Click);
            this.AL_Desc.MouseEnter += new System.EventHandler(this.AL_Desc_MouseEnter);
            this.AL_Desc.MouseLeave += new System.EventHandler(this.AL_Desc_MouseLeave);
            // 
            // AL_Title
            // 
            this.AL_Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AL_Title.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AL_Title.ForeColor = System.Drawing.Color.DimGray;
            this.AL_Title.Location = new System.Drawing.Point(56, 214);
            this.AL_Title.Name = "AL_Title";
            this.AL_Title.Size = new System.Drawing.Size(251, 26);
            this.AL_Title.TabIndex = 4;
            this.AL_Title.Text = "Attendance Log";
            this.AL_Title.Click += new System.EventHandler(this.AL_Title_Click);
            this.AL_Title.MouseEnter += new System.EventHandler(this.AL_Title_Enter);
            this.AL_Title.MouseLeave += new System.EventHandler(this.AL_Title_Leave);
            // 
            // CS_CloseSystem
            // 
            this.CS_CloseSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CS_CloseSystem.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CS_CloseSystem.ForeColor = System.Drawing.Color.Firebrick;
            this.CS_CloseSystem.Location = new System.Drawing.Point(56, 605);
            this.CS_CloseSystem.Name = "CS_CloseSystem";
            this.CS_CloseSystem.Size = new System.Drawing.Size(251, 26);
            this.CS_CloseSystem.TabIndex = 7;
            this.CS_CloseSystem.Text = "Close System";
            this.CS_CloseSystem.Click += new System.EventHandler(this.CS_CloseSystem_Click);
            // 
            // CT_Desc
            // 
            this.CT_Desc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CT_Desc.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CT_Desc.ForeColor = System.Drawing.Color.DimGray;
            this.CT_Desc.Location = new System.Drawing.Point(56, 319);
            this.CT_Desc.Name = "CT_Desc";
            this.CT_Desc.Size = new System.Drawing.Size(251, 26);
            this.CT_Desc.TabIndex = 10;
            this.CT_Desc.Text = "Edit system variables. Coming Soon!";
            this.CT_Desc.Click += new System.EventHandler(this.CT_Title_Click);
            this.CT_Desc.MouseEnter += new System.EventHandler(this.CT_Desc_MouseEnter);
            this.CT_Desc.MouseLeave += new System.EventHandler(this.CT_Desc_MouseLeave);
            // 
            // CT_Title
            // 
            this.CT_Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CT_Title.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CT_Title.ForeColor = System.Drawing.Color.DimGray;
            this.CT_Title.Location = new System.Drawing.Point(56, 293);
            this.CT_Title.Name = "CT_Title";
            this.CT_Title.Size = new System.Drawing.Size(251, 26);
            this.CT_Title.TabIndex = 9;
            this.CT_Title.Text = "Constants";
            this.CT_Title.Click += new System.EventHandler(this.CT_Title_Click);
            this.CT_Title.MouseEnter += new System.EventHandler(this.CT_Title_MouseEnter);
            this.CT_Title.MouseLeave += new System.EventHandler(this.CT_Title_MouseLeave);
            // 
            // CA_Title
            // 
            this.CA_Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CA_Title.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CA_Title.ForeColor = System.Drawing.Color.DimGray;
            this.CA_Title.Location = new System.Drawing.Point(56, 368);
            this.CA_Title.Name = "CA_Title";
            this.CA_Title.Size = new System.Drawing.Size(251, 26);
            this.CA_Title.TabIndex = 13;
            this.CA_Title.Text = "Close Admin";
            this.CA_Title.Click += new System.EventHandler(this.CA_Title_Click);
            this.CA_Title.MouseEnter += new System.EventHandler(this.CA_Title_MouseEnter);
            this.CA_Title.MouseLeave += new System.EventHandler(this.CA_Title_MouseLeave);
            // 
            // CG_Panel
            // 
            this.CG_Panel.Controls.Add(this.CG_SaveQR);
            this.CG_Panel.Controls.Add(this.CG_ClearButton);
            this.CG_Panel.Controls.Add(this.CG_QRBox);
            this.CG_Panel.Controls.Add(this.CG_MIddleName);
            this.CG_Panel.Controls.Add(this.CG_FirstName);
            this.CG_Panel.Controls.Add(this.CG_LastName);
            this.CG_Panel.Controls.Add(this.label15);
            this.CG_Panel.Controls.Add(this.label14);
            this.CG_Panel.Controls.Add(this.label13);
            this.CG_Panel.Controls.Add(this.label12);
            this.CG_Panel.Location = new System.Drawing.Point(313, 121);
            this.CG_Panel.Name = "CG_Panel";
            this.CG_Panel.Size = new System.Drawing.Size(592, 525);
            this.CG_Panel.TabIndex = 14;
            // 
            // CG_SaveQR
            // 
            this.CG_SaveQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CG_SaveQR.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CG_SaveQR.Location = new System.Drawing.Point(350, 350);
            this.CG_SaveQR.Name = "CG_SaveQR";
            this.CG_SaveQR.Size = new System.Drawing.Size(181, 26);
            this.CG_SaveQR.TabIndex = 24;
            this.CG_SaveQR.Text = "Save QR to file";
            this.CG_SaveQR.Click += new System.EventHandler(this.CG_SaveQR_Click);
            // 
            // CG_ClearButton
            // 
            this.CG_ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CG_ClearButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CG_ClearButton.Location = new System.Drawing.Point(350, 306);
            this.CG_ClearButton.Name = "CG_ClearButton";
            this.CG_ClearButton.Size = new System.Drawing.Size(93, 26);
            this.CG_ClearButton.TabIndex = 23;
            this.CG_ClearButton.Text = "Clear";
            this.CG_ClearButton.Click += new System.EventHandler(this.CG_ClearButton_Click);
            // 
            // CG_QRBox
            // 
            this.CG_QRBox.Location = new System.Drawing.Point(-1, 172);
            this.CG_QRBox.Name = "CG_QRBox";
            this.CG_QRBox.Size = new System.Drawing.Size(350, 350);
            this.CG_QRBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CG_QRBox.TabIndex = 22;
            this.CG_QRBox.TabStop = false;
            // 
            // CG_MIddleName
            // 
            this.CG_MIddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CG_MIddleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CG_MIddleName.Location = new System.Drawing.Point(149, 139);
            this.CG_MIddleName.Name = "CG_MIddleName";
            this.CG_MIddleName.PlaceholderText = "Middle Name";
            this.CG_MIddleName.Size = new System.Drawing.Size(261, 22);
            this.CG_MIddleName.TabIndex = 3;
            this.CG_MIddleName.TextChanged += new System.EventHandler(this.CG_MIddleName_TextChanged);
            // 
            // CG_FirstName
            // 
            this.CG_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CG_FirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CG_FirstName.Location = new System.Drawing.Point(149, 100);
            this.CG_FirstName.Name = "CG_FirstName";
            this.CG_FirstName.PlaceholderText = "First Name";
            this.CG_FirstName.Size = new System.Drawing.Size(261, 22);
            this.CG_FirstName.TabIndex = 2;
            this.CG_FirstName.TextChanged += new System.EventHandler(this.CG_FirstName_TextChanged);
            // 
            // CG_LastName
            // 
            this.CG_LastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CG_LastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CG_LastName.Location = new System.Drawing.Point(149, 62);
            this.CG_LastName.Name = "CG_LastName";
            this.CG_LastName.PlaceholderText = "Last Name";
            this.CG_LastName.Size = new System.Drawing.Size(261, 22);
            this.CG_LastName.TabIndex = 1;
            this.CG_LastName.TextChanged += new System.EventHandler(this.CG_LastName_TextChanged);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(31, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 22);
            this.label15.TabIndex = 18;
            this.label15.Text = "Middle Name:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(31, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 22);
            this.label14.TabIndex = 17;
            this.label14.Text = "First Name:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(31, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 22);
            this.label13.TabIndex = 16;
            this.label13.Text = "Last Name:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(31, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(251, 26);
            this.label12.TabIndex = 15;
            this.label12.Text = "User Details";
            // 
            // Panel_Password
            // 
            this.Panel_Password.Controls.Add(this.Label_InvalidPassword);
            this.Panel_Password.Controls.Add(this.label3);
            this.Panel_Password.Controls.Add(this.label2);
            this.Panel_Password.Controls.Add(this.AdminPassword);
            this.Panel_Password.Location = new System.Drawing.Point(12, 12);
            this.Panel_Password.Name = "Panel_Password";
            this.Panel_Password.Size = new System.Drawing.Size(899, 657);
            this.Panel_Password.TabIndex = 15;
            this.Panel_Password.TabStop = true;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(349, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter Admin Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(383, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Close Admin";
            this.label2.Click += new System.EventHandler(this.CA_Title_Click);
            // 
            // AdminPassword
            // 
            this.AdminPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminPassword.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdminPassword.Location = new System.Drawing.Point(292, 314);
            this.AdminPassword.Name = "AdminPassword";
            this.AdminPassword.PasswordChar = '•';
            this.AdminPassword.PlaceholderText = "Password";
            this.AdminPassword.Size = new System.Drawing.Size(314, 29);
            this.AdminPassword.TabIndex = 0;
            this.AdminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdminPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdminPassword_KeyPress);
            // 
            // CT_Panel
            // 
            this.CT_Panel.Controls.Add(this.CT_LabelSaved);
            this.CT_Panel.Controls.Add(this.label17);
            this.CT_Panel.Controls.Add(this.CT_QRFlag);
            this.CT_Panel.Controls.Add(this.CT_AdminPassword);
            this.CT_Panel.Controls.Add(this.label11);
            this.CT_Panel.Controls.Add(this.label16);
            this.CT_Panel.Controls.Add(this.label10);
            this.CT_Panel.Controls.Add(this.CT_Retries);
            this.CT_Panel.Controls.Add(this.CT_SaveButton);
            this.CT_Panel.Controls.Add(this.label5);
            this.CT_Panel.Controls.Add(this.CT_SheetRange);
            this.CT_Panel.Controls.Add(this.CT_SheetID);
            this.CT_Panel.Controls.Add(this.label6);
            this.CT_Panel.Controls.Add(this.label7);
            this.CT_Panel.Controls.Add(this.label8);
            this.CT_Panel.Controls.Add(this.label9);
            this.CT_Panel.Location = new System.Drawing.Point(313, 121);
            this.CT_Panel.Name = "CT_Panel";
            this.CT_Panel.Size = new System.Drawing.Size(592, 525);
            this.CT_Panel.TabIndex = 25;
            this.CT_Panel.Visible = false;
            // 
            // CT_LabelSaved
            // 
            this.CT_LabelSaved.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CT_LabelSaved.ForeColor = System.Drawing.Color.DimGray;
            this.CT_LabelSaved.Location = new System.Drawing.Point(228, 509);
            this.CT_LabelSaved.Name = "CT_LabelSaved";
            this.CT_LabelSaved.Size = new System.Drawing.Size(342, 14);
            this.CT_LabelSaved.TabIndex = 32;
            this.CT_LabelSaved.Text = "Changes saved!";
            this.CT_LabelSaved.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CT_LabelSaved.Visible = false;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(147, 338);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(342, 22);
            this.label17.TabIndex = 31;
            this.label17.Text = "Changing QR flag invalidates all previously  generated QR Codes.";
            // 
            // CT_QRFlag
            // 
            this.CT_QRFlag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CT_QRFlag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CT_QRFlag.Location = new System.Drawing.Point(149, 307);
            this.CT_QRFlag.Name = "CT_QRFlag";
            this.CT_QRFlag.PlaceholderText = "QR Attendance System by @Ajacence";
            this.CT_QRFlag.Size = new System.Drawing.Size(421, 22);
            this.CT_QRFlag.TabIndex = 28;
            this.CT_QRFlag.TextChanged += new System.EventHandler(this.CT_QRFlag_TextChanged);
            // 
            // CT_AdminPassword
            // 
            this.CT_AdminPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CT_AdminPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CT_AdminPassword.Location = new System.Drawing.Point(149, 269);
            this.CT_AdminPassword.Name = "CT_AdminPassword";
            this.CT_AdminPassword.PasswordChar = '•';
            this.CT_AdminPassword.PlaceholderText = "Password";
            this.CT_AdminPassword.Size = new System.Drawing.Size(421, 22);
            this.CT_AdminPassword.TabIndex = 27;
            this.CT_AdminPassword.TextChanged += new System.EventHandler(this.CT_AdminPassword_TextChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(31, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 22);
            this.label11.TabIndex = 30;
            this.label11.Text = "QR Flag:";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(31, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 22);
            this.label16.TabIndex = 29;
            this.label16.Text = "Password:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(31, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(274, 26);
            this.label10.TabIndex = 26;
            this.label10.Text = "Admin Parameters:";
            // 
            // CT_Retries
            // 
            this.CT_Retries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CT_Retries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CT_Retries.Location = new System.Drawing.Point(149, 141);
            this.CT_Retries.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.CT_Retries.Name = "CT_Retries";
            this.CT_Retries.Size = new System.Drawing.Size(421, 25);
            this.CT_Retries.TabIndex = 25;
            this.CT_Retries.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.CT_Retries.ValueChanged += new System.EventHandler(this.CT_Retries_ValueChanged);
            // 
            // CT_SaveButton
            // 
            this.CT_SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CT_SaveButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CT_SaveButton.ForeColor = System.Drawing.Color.DimGray;
            this.CT_SaveButton.Location = new System.Drawing.Point(507, 481);
            this.CT_SaveButton.Name = "CT_SaveButton";
            this.CT_SaveButton.Size = new System.Drawing.Size(62, 26);
            this.CT_SaveButton.TabIndex = 24;
            this.CT_SaveButton.Text = "Save";
            this.CT_SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CT_SaveButton.Click += new System.EventHandler(this.CT_SaveButton_Click);
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(350, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = "Clear";
            // 
            // CT_SheetRange
            // 
            this.CT_SheetRange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CT_SheetRange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CT_SheetRange.Location = new System.Drawing.Point(149, 100);
            this.CT_SheetRange.Name = "CT_SheetRange";
            this.CT_SheetRange.PlaceholderText = "Range";
            this.CT_SheetRange.Size = new System.Drawing.Size(421, 22);
            this.CT_SheetRange.TabIndex = 2;
            this.CT_SheetRange.TextChanged += new System.EventHandler(this.CT_SheetRange_TextChanged);
            // 
            // CT_SheetID
            // 
            this.CT_SheetID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CT_SheetID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CT_SheetID.Location = new System.Drawing.Point(149, 61);
            this.CT_SheetID.Name = "CT_SheetID";
            this.CT_SheetID.PlaceholderText = "Sheet ID";
            this.CT_SheetID.Size = new System.Drawing.Size(421, 22);
            this.CT_SheetID.TabIndex = 1;
            this.CT_SheetID.TextChanged += new System.EventHandler(this.CT_SheetID_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Send Retries:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(31, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Range:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(31, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sheet ID:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(31, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Google Sheet Parameters:";
            // 
            // Label_InvalidPassword
            // 
            this.Label_InvalidPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_InvalidPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_InvalidPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.Label_InvalidPassword.Location = new System.Drawing.Point(349, 374);
            this.Label_InvalidPassword.Name = "Label_InvalidPassword";
            this.Label_InvalidPassword.Size = new System.Drawing.Size(200, 26);
            this.Label_InvalidPassword.TabIndex = 16;
            this.Label_InvalidPassword.Text = "Invalid password";
            this.Label_InvalidPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_InvalidPassword.Visible = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 681);
            this.ControlBox = false;
            this.Controls.Add(this.Panel_Password);
            this.Controls.Add(this.CA_Title);
            this.Controls.Add(this.CT_Desc);
            this.Controls.Add(this.CT_Title);
            this.Controls.Add(this.CS_CloseSystem);
            this.Controls.Add(this.AL_Desc);
            this.Controls.Add(this.AL_Title);
            this.Controls.Add(this.CG_Desc);
            this.Controls.Add(this.CG_Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CT_Panel);
            this.Controls.Add(this.CG_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Shown += new System.EventHandler(this.Admin_Shown);
            this.CG_Panel.ResumeLayout(false);
            this.CG_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CG_QRBox)).EndInit();
            this.Panel_Password.ResumeLayout(false);
            this.Panel_Password.PerformLayout();
            this.CT_Panel.ResumeLayout(false);
            this.CT_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_Retries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CG_Title;
        private System.Windows.Forms.Label CG_Desc;
        private System.Windows.Forms.Label AL_Desc;
        private System.Windows.Forms.Label AL_Title;
        private System.Windows.Forms.Label CS_CloseSystem;
        private System.Windows.Forms.Label CT_Desc;
        private System.Windows.Forms.Label CT_Title;
        private System.Windows.Forms.Label CA_Title;
        private System.Windows.Forms.Panel CG_Panel;
        private System.Windows.Forms.TextBox CG_MIddleName;
        private System.Windows.Forms.TextBox CG_FirstName;
        private System.Windows.Forms.TextBox CG_LastName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox CG_QRBox;
        private System.Windows.Forms.Label CG_SaveQR;
        private System.Windows.Forms.Label CG_ClearButton;
        private System.Windows.Forms.SaveFileDialog CG_QRSaveBox;
        private System.Windows.Forms.Panel Panel_Password;
        private System.Windows.Forms.TextBox AdminPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel CT_Panel;
        private System.Windows.Forms.Label CT_SaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CT_SheetRange;
        private System.Windows.Forms.TextBox CT_SheetID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown CT_Retries;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox CT_QRFlag;
        private System.Windows.Forms.TextBox CT_AdminPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label CT_LabelSaved;
        private System.Windows.Forms.Label Label_InvalidPassword;
    }
}