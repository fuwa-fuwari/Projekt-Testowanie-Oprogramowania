namespace ProjektMagazyn
{
    partial class NewPasswordPrompt
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
            this.tbx_newpass = new System.Windows.Forms.TextBox();
            this.tbx_repeat_newpass = new System.Windows.Forms.TextBox();
            this.lbl_newpass = new System.Windows.Forms.Label();
            this.lbl_repeat_newpass = new System.Windows.Forms.Label();
            this.btn_set_newpass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Należy ustawić nowe hasło po jego odzyskaniu";
            // 
            // tbx_newpass
            // 
            this.tbx_newpass.Location = new System.Drawing.Point(43, 78);
            this.tbx_newpass.Name = "tbx_newpass";
            this.tbx_newpass.PasswordChar = '*';
            this.tbx_newpass.Size = new System.Drawing.Size(225, 20);
            this.tbx_newpass.TabIndex = 1;
            // 
            // tbx_repeat_newpass
            // 
            this.tbx_repeat_newpass.Location = new System.Drawing.Point(43, 136);
            this.tbx_repeat_newpass.Name = "tbx_repeat_newpass";
            this.tbx_repeat_newpass.PasswordChar = '*';
            this.tbx_repeat_newpass.Size = new System.Drawing.Size(225, 20);
            this.tbx_repeat_newpass.TabIndex = 2;
            // 
            // lbl_newpass
            // 
            this.lbl_newpass.AutoSize = true;
            this.lbl_newpass.Location = new System.Drawing.Point(40, 62);
            this.lbl_newpass.Name = "lbl_newpass";
            this.lbl_newpass.Size = new System.Drawing.Size(65, 13);
            this.lbl_newpass.TabIndex = 3;
            this.lbl_newpass.Text = "Nowe hasło";
            // 
            // lbl_repeat_newpass
            // 
            this.lbl_repeat_newpass.AutoSize = true;
            this.lbl_repeat_newpass.Location = new System.Drawing.Point(40, 120);
            this.lbl_repeat_newpass.Name = "lbl_repeat_newpass";
            this.lbl_repeat_newpass.Size = new System.Drawing.Size(104, 13);
            this.lbl_repeat_newpass.TabIndex = 4;
            this.lbl_repeat_newpass.Text = "Powtórz nowe hasło";
            // 
            // btn_set_newpass
            // 
            this.btn_set_newpass.Location = new System.Drawing.Point(43, 178);
            this.btn_set_newpass.Name = "btn_set_newpass";
            this.btn_set_newpass.Size = new System.Drawing.Size(225, 23);
            this.btn_set_newpass.TabIndex = 5;
            this.btn_set_newpass.Text = "Zmień hasło";
            this.btn_set_newpass.UseVisualStyleBackColor = true;
            this.btn_set_newpass.Click += new System.EventHandler(this.btn_set_newpass_Click);
            // 
            // NewPasswordPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 233);
            this.Controls.Add(this.btn_set_newpass);
            this.Controls.Add(this.lbl_repeat_newpass);
            this.Controls.Add(this.lbl_newpass);
            this.Controls.Add(this.tbx_repeat_newpass);
            this.Controls.Add(this.tbx_newpass);
            this.Controls.Add(this.label1);
            this.Name = "NewPasswordPrompt";
            this.Text = "Ustaw nowe hasło";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_newpass;
        private System.Windows.Forms.TextBox tbx_repeat_newpass;
        private System.Windows.Forms.Label lbl_newpass;
        private System.Windows.Forms.Label lbl_repeat_newpass;
        private System.Windows.Forms.Button btn_set_newpass;
    }
}