namespace ProjektMagazyn
{
    partial class Logowanie
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
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tbx_login = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_zaloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(314, 154);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(51, 24);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "login";
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(306, 199);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(59, 24);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "hasło";
            // 
            // tbx_login
            // 
            this.tbx_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_login.Location = new System.Drawing.Point(371, 158);
            this.tbx_login.Name = "tbx_login";
            this.tbx_login.Size = new System.Drawing.Size(133, 20);
            this.tbx_login.TabIndex = 2;
            // 
            // tbx_password
            // 
            this.tbx_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_password.Location = new System.Drawing.Point(371, 203);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(133, 20);
            this.tbx_password.TabIndex = 3;
            // 
            // btn_zaloguj
            // 
            this.btn_zaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zaloguj.Location = new System.Drawing.Point(310, 240);
            this.btn_zaloguj.Name = "btn_zaloguj";
            this.btn_zaloguj.Size = new System.Drawing.Size(194, 33);
            this.btn_zaloguj.TabIndex = 4;
            this.btn_zaloguj.Text = "zaloguj";
            this.btn_zaloguj.UseVisualStyleBackColor = true;
            this.btn_zaloguj.Click += new System.EventHandler(this.btn_zaloguj_Click);
            // 
            // Logowanie
            // 
            this.AcceptButton = this.btn_zaloguj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_zaloguj);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_login);
            this.KeyPreview = true;
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System magazynowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tbx_login;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_zaloguj;
    }
}

