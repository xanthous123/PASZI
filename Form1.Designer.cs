namespace VigenereFileEncryptor;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Button btnSelectFile;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnEncrypt;
    private System.Windows.Forms.Button btnDecrypt;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Label lblFileName;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.btnSelectFile = new System.Windows.Forms.Button();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.btnEncrypt = new System.Windows.Forms.Button();
        this.btnDecrypt = new System.Windows.Forms.Button();
        this.lblStatus = new System.Windows.Forms.Label();
        this.lblFileName = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // btnSelectFile
        // 
        this.btnSelectFile.Location = new System.Drawing.Point(30, 30);
        this.btnSelectFile.Name = "btnSelectFile";
        this.btnSelectFile.Size = new System.Drawing.Size(120, 30);
        this.btnSelectFile.TabIndex = 0;
        this.btnSelectFile.Text = "Выбрать файл";
        this.btnSelectFile.UseVisualStyleBackColor = true;
        this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
        // 
        // lblFileName
        // 
        this.lblFileName.Location = new System.Drawing.Point(170, 30);
        this.lblFileName.Name = "lblFileName";
        this.lblFileName.Size = new System.Drawing.Size(400, 30);
        this.lblFileName.TabIndex = 5;
        this.lblFileName.Text = "Файл не выбран";
        // 
        // txtPassword
        // 
        this.txtPassword.Location = new System.Drawing.Point(30, 80);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.Size = new System.Drawing.Size(200, 23);
        this.txtPassword.TabIndex = 1;
        this.txtPassword.UseSystemPasswordChar = true;
        this.txtPassword.PlaceholderText = "Пароль";
        // 
        // btnEncrypt
        // 
        this.btnEncrypt.Location = new System.Drawing.Point(30, 130);
        this.btnEncrypt.Name = "btnEncrypt";
        this.btnEncrypt.Size = new System.Drawing.Size(120, 30);
        this.btnEncrypt.TabIndex = 2;
        this.btnEncrypt.Text = "Зашифровать";
        this.btnEncrypt.UseVisualStyleBackColor = true;
        this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
        // 
        // btnDecrypt
        // 
        this.btnDecrypt.Location = new System.Drawing.Point(170, 130);
        this.btnDecrypt.Name = "btnDecrypt";
        this.btnDecrypt.Size = new System.Drawing.Size(120, 30);
        this.btnDecrypt.TabIndex = 3;
        this.btnDecrypt.Text = "Расшифровать";
        this.btnDecrypt.UseVisualStyleBackColor = true;
        this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
        // 
        // lblStatus
        // 
        this.lblStatus.Location = new System.Drawing.Point(30, 180);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(540, 30);
        this.lblStatus.TabIndex = 4;
        this.lblStatus.Text = "";
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(600, 250);
        this.Controls.Add(this.btnSelectFile);
        this.Controls.Add(this.lblFileName);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.btnEncrypt);
        this.Controls.Add(this.btnDecrypt);
        this.Controls.Add(this.lblStatus);
        this.Name = "Form1";
        this.Text = "Vigenere File Encryptor";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
