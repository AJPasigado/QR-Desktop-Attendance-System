using QRAttendanceSystem.Properties;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QRAttendanceSystem
{
    public partial class Admin : Form
    {
        public Sheets sheets;
        public Shadow shadow;
        Label activeButton;

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Shown(object sender, EventArgs e)
        {
            activeButton = CG_Title;
            GenerateQR();
        }

        private void GenerateQR() {
            String code = String.Format(
                "{0};{1};{2};{3}",
                Settings.Default.Admin_QRFlag,
                CG_LastName.Text,
                CG_FirstName.Text,
                CG_MIddleName.Text
            );

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            CG_QRBox.Image = qrCode.GetGraphic(20);
            CG_QRBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CG_LastName_TextChanged(object sender, EventArgs e)
        {
            GenerateQR();
        }

        private void CG_FirstName_TextChanged(object sender, EventArgs e)
        {
            GenerateQR();
        }

        private void CG_MIddleName_TextChanged(object sender, EventArgs e)
        {
            GenerateQR();
        }

        #region Button Hovers
        private void AL_Title_Enter(object sender, EventArgs e)
        {
            AL_Title.ForeColor = Color.Black;
            AL_Desc.ForeColor = Color.Black;
        }

        private void AL_Title_Leave(object sender, EventArgs e)
        {
            AL_Title.ForeColor = Color.DimGray;
            AL_Desc.ForeColor = Color.DimGray;
        }

        private void AL_Desc_MouseEnter(object sender, EventArgs e)
        {
            AL_Title.ForeColor = Color.Black;
            AL_Desc.ForeColor = Color.Black;
        }

        private void AL_Desc_MouseLeave(object sender, EventArgs e)
        {
            AL_Title.ForeColor = Color.DimGray;
            AL_Desc.ForeColor = Color.DimGray;
        }

        private void CT_Title_MouseEnter(object sender, EventArgs e)
        {
            if (activeButton != CT_Title)
            {
                CT_Title.ForeColor = Color.Black;
                CT_Desc.ForeColor = Color.Black;
            }
        }

        private void CT_Title_MouseLeave(object sender, EventArgs e)
        {
            if (activeButton != CT_Title)
            {
                CT_Title.ForeColor = Color.DimGray;
                CT_Desc.ForeColor = Color.DimGray;
            }
        }

        private void CT_Desc_MouseEnter(object sender, EventArgs e)
        {
            if (activeButton != CT_Title)
            {
                CT_Title.ForeColor = Color.Black;
                CT_Desc.ForeColor = Color.Black;
            }
        }

        private void CT_Desc_MouseLeave(object sender, EventArgs e)
        {
            if (activeButton != CT_Title)
            {
                CT_Title.ForeColor = Color.DimGray;
                CT_Desc.ForeColor = Color.DimGray;
            }
        }

        private void CA_Title_MouseEnter(object sender, EventArgs e)
        {
            if (activeButton != CA_Title)
            {
                CA_Title.ForeColor = Color.Black;
            }
        }

        private void CA_Title_MouseLeave(object sender, EventArgs e)
        {
            if (activeButton != CA_Title)
            {
                CA_Title.ForeColor = Color.DimGray;
            }
        }

        private void CG_Title_MouseEnter(object sender, EventArgs e)
        {
            if (activeButton != CG_Title)
            {
                CG_Title.ForeColor = Color.Black;
                CG_Desc.ForeColor = Color.Black;
            }
        }

        private void CG_Desc_MouseLeave(object sender, EventArgs e)
        {
            if (activeButton != CG_Title)
            {
                CG_Title.ForeColor = Color.DimGray;
                CG_Desc.ForeColor = Color.DimGray;
            }
        }

        private void CG_Title_MouseLeave(object sender, EventArgs e)
        {
            if (activeButton != CG_Title)
            {
                CG_Title.ForeColor = Color.DimGray;
                CG_Desc.ForeColor = Color.DimGray;
            }
        }

        private void CG_Desc_MouseEnter(object sender, EventArgs e)
        {
            if (activeButton != CG_Title)
            {
                CG_Title.ForeColor = Color.Black;
                CG_Desc.ForeColor = Color.Black;
            }
        }
        #endregion

        private void AL_Title_Click(object sender, EventArgs e)
        {
            String url = String.Format("https://docs.google.com/spreadsheets/d/{0}", Settings.Default.GoogleSheet_SheetID);
            Process.Start("explorer", url);
        }

        private void CG_ClearButton_Click(object sender, EventArgs e)
        {
            CG_LastName.Clear();
            CG_FirstName.Clear();
            CG_MIddleName.Clear();
        }

        private void CG_SaveQR_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPEG Image|*.jpg";
            saveFileDialog1.Title = "Save QR Code";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                CG_QRBox.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
           
                fs.Close();
            }
        }

        private void CA_Title_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CS_CloseSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.shadow.CloseForm();
        }

        private void AdminPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (GetHashString(AdminPassword.Text) == Settings.Default.Admin_Password)
                {
                    Panel_Password.Hide();
                    this.ActiveControl = CG_LastName;
                }
                else {
                    Label_InvalidPassword.Show();
                }
            }
        }

        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        private void CT_Title_Click(object sender, EventArgs e)
        {
            CG_Panel.Hide();
            CT_Panel.Show();
            activeButton = CT_Title;
            CG_Title.ForeColor = Color.DimGray;
            CG_Desc.ForeColor = Color.DimGray;

            LoadConstants();
        }

        private void CG_Title_Click(object sender, EventArgs e)
        {
            CG_Panel.Show();
            CT_Panel.Hide();
            activeButton = CG_Title;
            CT_Title.ForeColor = Color.DimGray;
            CT_Desc.ForeColor = Color.DimGray;
        }

        private void LoadConstants() {
            CT_SheetID.Text = "";
            CT_SheetRange.Text = "";
            CT_SheetID.PlaceholderText = Settings.Default.GoogleSheet_SheetID;
            CT_SheetRange.PlaceholderText = Settings.Default.GoogleSheet_Range;
            CT_Retries.Value = Settings.Default.GoogleSheet_Retries;

            CT_AdminPassword.Text = "";
            CT_QRFlag.Text = "";
            CT_QRFlag.PlaceholderText = Settings.Default.Admin_QRFlag;

            flags = Enumerable.Repeat(false, 5).ToList();
        }

        List<bool> flags = Enumerable.Repeat(false, 5).ToList();

        private void CT_SheetID_TextChanged(object sender, EventArgs e)
        {
            flags[0] = CT_SheetID.Text != "";
            CheckSave();
        }

        private void CT_SheetRange_TextChanged(object sender, EventArgs e)
        {
            flags[1] = CT_SheetRange.Text != "";
            CheckSave();
        }

        private void CT_Retries_ValueChanged(object sender, EventArgs e)
        {
            flags[2] = CT_Retries.Value != Settings.Default.GoogleSheet_Retries;
            CheckSave();
        }

        private void CT_AdminPassword_TextChanged(object sender, EventArgs e)
        {
            flags[3] = CT_AdminPassword.Text != "";
            CheckSave();
        }

        private void CT_QRFlag_TextChanged(object sender, EventArgs e)
        {
            flags[4] = CT_QRFlag.Text != "";
            CheckSave();
        }

        private void CT_SaveButton_Click(object sender, EventArgs e)
        {
            if (flags.Contains(true)) {
                if (CT_SheetID.Text != "") Settings.Default.GoogleSheet_SheetID = CT_SheetID.Text;
                if (CT_SheetRange.Text != "") Settings.Default.GoogleSheet_Range = CT_SheetRange.Text;
                if (CT_Retries.Value != Settings.Default.GoogleSheet_Retries) Settings.Default.GoogleSheet_Retries = CT_Retries.Value;
                if (CT_AdminPassword.Text != "") Settings.Default.Admin_Password = GetHashString(CT_AdminPassword.Text);
                if (CT_QRFlag.Text != "") Settings.Default.Admin_QRFlag = CT_QRFlag.Text;
                Settings.Default.Save();
                CT_LabelSaved.Show();
                LoadConstants();
            }
        }

        private void CheckSave()
        {
            if (flags.Contains(true))
            {
                CT_SaveButton.ForeColor = Color.Black;
            }
            else {
                CT_SaveButton.ForeColor = Color.DimGray;
            }

            CT_LabelSaved.Hide();
        }
    }
}
