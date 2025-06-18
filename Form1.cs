using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace VigenereFileEncryptor
{
    public partial class Form1 : Form
    {
        private string selectedFilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = ofd.FileName;
                    lblFileName.Text = Path.GetFileName(selectedFilePath);
                    lblStatus.Text = "Файл выбран: " + selectedFilePath;
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath) || string.IsNullOrEmpty(txtPassword.Text))
            {
                lblStatus.Text = "Выберите файл и введите пароль!";
                return;
            }
            try
            {
                VigenereEncryptFile(selectedFilePath, txtPassword.Text);
                lblStatus.Text = "Файл зашифрован: " + selectedFilePath + ".vig";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Ошибка: " + ex.Message;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath) || string.IsNullOrEmpty(txtPassword.Text))
            {
                lblStatus.Text = "Выберите файл и введите пароль!";
                return;
            }
            try
            {
                VigenereDecryptFile(selectedFilePath, txtPassword.Text);
                lblStatus.Text = "Файл расшифрован: " + selectedFilePath;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Ошибка: " + ex.Message;
            }
        }

        private void VigenereEncryptFile(string inputPath, string password)
        {
            byte[] keyBytes;
            using (SHA256 sha256 = SHA256.Create())
            {
                keyBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
            byte[] fileBytes = File.ReadAllBytes(inputPath);
            byte[] result = new byte[fileBytes.Length];
            for (int i = 0; i < fileBytes.Length; i++)
            {
                result[i] = (byte)(fileBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }
            File.WriteAllBytes(inputPath + ".enc", result);
        }

        private void VigenereDecryptFile(string inputPath, string password)
        {
            byte[] keyBytes;
            using (SHA256 sha256 = SHA256.Create())
            {
                keyBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
            byte[] fileBytes = File.ReadAllBytes(inputPath);
            byte[] result = new byte[fileBytes.Length];
            for (int i = 0; i < fileBytes.Length; i++)
            {
                result[i] = (byte)(fileBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }
            string outputPath = inputPath.EndsWith(".enc") ? inputPath.Substring(0, inputPath.Length - 4): inputPath + ".dec";
            File.WriteAllBytes(outputPath, result);
        }
    }
}
