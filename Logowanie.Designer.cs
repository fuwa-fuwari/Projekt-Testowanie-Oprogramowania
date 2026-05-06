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
            this.grpbx_login = new System.Windows.Forms.GroupBox();
            this.btn_reset_password = new System.Windows.Forms.Button();
            this.lbl_timeout_status = new System.Windows.Forms.Label();
            this.lbl_login_status = new System.Windows.Forms.Label();
            this.grpbx_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(62, 71);
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
            this.lbl_password.Location = new System.Drawing.Point(62, 116);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(59, 24);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "hasło";
            // 
            // tbx_login
            // 
            this.tbx_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_login.Location = new System.Drawing.Point(153, 72);
            this.tbx_login.Name = "tbx_login";
            this.tbx_login.Size = new System.Drawing.Size(229, 24);
            this.tbx_login.TabIndex = 2;
            // 
            // tbx_password
            // 
            this.tbx_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(153, 117);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(229, 24);
            this.tbx_password.TabIndex = 3;
            // 
            // btn_zaloguj
            // 
            this.btn_zaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zaloguj.Location = new System.Drawing.Point(222, 195);
            this.btn_zaloguj.Name = "btn_zaloguj";
            this.btn_zaloguj.Size = new System.Drawing.Size(160, 31);
            this.btn_zaloguj.TabIndex = 4;
            this.btn_zaloguj.Text = "Zaloguj";
            this.btn_zaloguj.UseVisualStyleBackColor = true;
            this.btn_zaloguj.Click += new System.EventHandler(this.btn_zaloguj_Click);
            // 
            // grpbx_login
            // 
            this.grpbx_login.Controls.Add(this.lbl_login_status);
            this.grpbx_login.Controls.Add(this.lbl_timeout_status);
            this.grpbx_login.Controls.Add(this.btn_reset_password);
            this.grpbx_login.Controls.Add(this.lbl_login);
            this.grpbx_login.Controls.Add(this.btn_zaloguj);
            this.grpbx_login.Controls.Add(this.lbl_password);
            this.grpbx_login.Controls.Add(this.tbx_password);
            this.grpbx_login.Controls.Add(this.tbx_login);
            this.grpbx_login.Location = new System.Drawing.Point(268, 179);
            this.grpbx_login.Name = "grpbx_login";
            this.grpbx_login.Size = new System.Drawing.Size(424, 251);
            this.grpbx_login.TabIndex = 5;
            this.grpbx_login.TabStop = false;
            this.grpbx_login.Text = "logowanie";
            // 
            // btn_reset_password
            // 
            this.btn_reset_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset_password.Location = new System.Drawing.Point(38, 195);
            this.btn_reset_password.Name = "btn_reset_password";
            this.btn_reset_password.Size = new System.Drawing.Size(160, 31);
            this.btn_reset_password.TabIndex = 5;
            this.btn_reset_password.Text = "Odzyskaj hasło";
            this.btn_reset_password.UseVisualStyleBackColor = true;
            this.btn_reset_password.Click += new System.EventHandler(this.btn_reset_password_Click);
            // 
            // lbl_timeout_status
            // 
            this.lbl_timeout_status.AutoSize = true;
            this.lbl_timeout_status.Location = new System.Drawing.Point(153, 148);
            this.lbl_timeout_status.Name = "lbl_timeout_status";
            this.lbl_timeout_status.Size = new System.Drawing.Size(91, 13);
            this.lbl_timeout_status.TabIndex = 6;
            this.lbl_timeout_status.Text = "lbl_timeout_status";
            // 
            // lbl_login_status
            // 
            this.lbl_login_status.AutoSize = true;
            this.lbl_login_status.Location = new System.Drawing.Point(153, 161);
            this.lbl_login_status.Name = "lbl_login_status";
            this.lbl_login_status.Size = new System.Drawing.Size(79, 13);
            this.lbl_login_status.TabIndex = 7;
            this.lbl_login_status.Text = "lbl_login_status";
            // 
            // Logowanie
            // 
            this.AcceptButton = this.btn_zaloguj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 600);
            this.Controls.Add(this.grpbx_login);
            this.KeyPreview = true;
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System magazynowy";
            this.grpbx_login.ResumeLayout(false);
            this.grpbx_login.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tbx_login;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_zaloguj;
        private System.Windows.Forms.GroupBox grpbx_login;
        private System.Windows.Forms.Button btn_reset_password;
        private System.Windows.Forms.Label lbl_timeout_status;
        private System.Windows.Forms.Label lbl_login_status;
    }
}

