namespace ProjektMagazyn
{
    partial class Administrator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importujCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyszukajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbx_add_user = new System.Windows.Forms.GroupBox();
            this.dtpckr_birthdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_pesel = new System.Windows.Forms.Label();
            this.tbx_pesel = new System.Windows.Forms.TextBox();
            this.grpbx_address = new System.Windows.Forms.GroupBox();
            this.lbl_street_number = new System.Windows.Forms.Label();
            this.tbx_locale_number = new System.Windows.Forms.TextBox();
            this.tbx_street_number = new System.Windows.Forms.TextBox();
            this.tbx_street = new System.Windows.Forms.TextBox();
            this.tbx_city = new System.Windows.Forms.TextBox();
            this.lbl_locale_number = new System.Windows.Forms.Label();
            this.lbl_street = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_user_surname = new System.Windows.Forms.Label();
            this.tbx_user_surname = new System.Windows.Forms.TextBox();
            this.tbx_user_name = new System.Windows.Forms.TextBox();
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.tbx_user_login = new System.Windows.Forms.TextBox();
            this.lbl_user_login = new System.Windows.Forms.Label();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.tbx_phone = new System.Windows.Forms.TextBox();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.lbl_required = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpbx_add_user.SuspendLayout();
            this.grpbx_address.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel administratora";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUżytkownikaToolStripMenuItem,
            this.edytujUżytkownikaToolStripMenuItem,
            this.wyszukajToolStripMenuItem,
            this.wylogujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajUżytkownikaToolStripMenuItem
            // 
            this.dodajUżytkownikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularzToolStripMenuItem,
            this.importujCsvToolStripMenuItem});
            this.dodajUżytkownikaToolStripMenuItem.Name = "dodajUżytkownikaToolStripMenuItem";
            this.dodajUżytkownikaToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.dodajUżytkownikaToolStripMenuItem.Text = "Dodaj użytkownika";
            // 
            // formularzToolStripMenuItem
            // 
            this.formularzToolStripMenuItem.Name = "formularzToolStripMenuItem";
            this.formularzToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.formularzToolStripMenuItem.Text = "Formularz";
            this.formularzToolStripMenuItem.Click += new System.EventHandler(this.formularzToolStripMenuItem_Click);
            // 
            // importujCsvToolStripMenuItem
            // 
            this.importujCsvToolStripMenuItem.Name = "importujCsvToolStripMenuItem";
            this.importujCsvToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.importujCsvToolStripMenuItem.Text = "Importuj csv";
            // 
            // edytujUżytkownikaToolStripMenuItem
            // 
            this.edytujUżytkownikaToolStripMenuItem.Name = "edytujUżytkownikaToolStripMenuItem";
            this.edytujUżytkownikaToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.edytujUżytkownikaToolStripMenuItem.Text = "Edytuj użytkownika";
            // 
            // wyszukajToolStripMenuItem
            // 
            this.wyszukajToolStripMenuItem.Name = "wyszukajToolStripMenuItem";
            this.wyszukajToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.wyszukajToolStripMenuItem.Text = "Wyszukaj";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // grpbx_add_user
            // 
            this.grpbx_add_user.Controls.Add(this.lbl_required);
            this.grpbx_add_user.Controls.Add(this.btn_add_user);
            this.grpbx_add_user.Controls.Add(this.label2);
            this.grpbx_add_user.Controls.Add(this.tbx_phone);
            this.grpbx_add_user.Controls.Add(this.tbx_email);
            this.grpbx_add_user.Controls.Add(this.label3);
            this.grpbx_add_user.Controls.Add(this.lbl_birthdate);
            this.grpbx_add_user.Controls.Add(this.dtpckr_birthdate);
            this.grpbx_add_user.Controls.Add(this.lbl_pesel);
            this.grpbx_add_user.Controls.Add(this.tbx_pesel);
            this.grpbx_add_user.Controls.Add(this.grpbx_address);
            this.grpbx_add_user.Controls.Add(this.lbl_user_surname);
            this.grpbx_add_user.Controls.Add(this.tbx_user_surname);
            this.grpbx_add_user.Controls.Add(this.tbx_user_name);
            this.grpbx_add_user.Controls.Add(this.lbl_user_name);
            this.grpbx_add_user.Controls.Add(this.tbx_user_login);
            this.grpbx_add_user.Controls.Add(this.lbl_user_login);
            this.grpbx_add_user.Location = new System.Drawing.Point(18, 70);
            this.grpbx_add_user.Name = "grpbx_add_user";
            this.grpbx_add_user.Size = new System.Drawing.Size(623, 368);
            this.grpbx_add_user.TabIndex = 4;
            this.grpbx_add_user.TabStop = false;
            this.grpbx_add_user.Text = "Dodaj użytkownika";
            // 
            // dtpckr_birthdate
            // 
            this.dtpckr_birthdate.Location = new System.Drawing.Point(121, 139);
            this.dtpckr_birthdate.Name = "dtpckr_birthdate";
            this.dtpckr_birthdate.Size = new System.Drawing.Size(200, 20);
            this.dtpckr_birthdate.TabIndex = 9;
            // 
            // lbl_pesel
            // 
            this.lbl_pesel.AutoSize = true;
            this.lbl_pesel.Location = new System.Drawing.Point(398, 36);
            this.lbl_pesel.Name = "lbl_pesel";
            this.lbl_pesel.Size = new System.Drawing.Size(45, 13);
            this.lbl_pesel.TabIndex = 8;
            this.lbl_pesel.Text = "PESEL*";
            // 
            // tbx_pesel
            // 
            this.tbx_pesel.Location = new System.Drawing.Point(445, 33);
            this.tbx_pesel.Name = "tbx_pesel";
            this.tbx_pesel.Size = new System.Drawing.Size(131, 20);
            this.tbx_pesel.TabIndex = 7;
            // 
            // grpbx_address
            // 
            this.grpbx_address.Controls.Add(this.lbl_street_number);
            this.grpbx_address.Controls.Add(this.tbx_locale_number);
            this.grpbx_address.Controls.Add(this.tbx_street_number);
            this.grpbx_address.Controls.Add(this.tbx_street);
            this.grpbx_address.Controls.Add(this.tbx_city);
            this.grpbx_address.Controls.Add(this.lbl_locale_number);
            this.grpbx_address.Controls.Add(this.lbl_street);
            this.grpbx_address.Controls.Add(this.lbl_city);
            this.grpbx_address.Location = new System.Drawing.Point(29, 179);
            this.grpbx_address.Name = "grpbx_address";
            this.grpbx_address.Size = new System.Drawing.Size(292, 152);
            this.grpbx_address.TabIndex = 6;
            this.grpbx_address.TabStop = false;
            this.grpbx_address.Text = "Adres";
            // 
            // lbl_street_number
            // 
            this.lbl_street_number.AutoSize = true;
            this.lbl_street_number.Location = new System.Drawing.Point(13, 88);
            this.lbl_street_number.Name = "lbl_street_number";
            this.lbl_street_number.Size = new System.Drawing.Size(77, 13);
            this.lbl_street_number.TabIndex = 7;
            this.lbl_street_number.Text = "Numer posesji*";
            // 
            // tbx_locale_number
            // 
            this.tbx_locale_number.Location = new System.Drawing.Point(92, 118);
            this.tbx_locale_number.Name = "tbx_locale_number";
            this.tbx_locale_number.Size = new System.Drawing.Size(178, 20);
            this.tbx_locale_number.TabIndex = 6;
            // 
            // tbx_street_number
            // 
            this.tbx_street_number.Location = new System.Drawing.Point(92, 85);
            this.tbx_street_number.Name = "tbx_street_number";
            this.tbx_street_number.Size = new System.Drawing.Size(178, 20);
            this.tbx_street_number.TabIndex = 5;
            // 
            // tbx_street
            // 
            this.tbx_street.Location = new System.Drawing.Point(92, 52);
            this.tbx_street.Name = "tbx_street";
            this.tbx_street.Size = new System.Drawing.Size(178, 20);
            this.tbx_street.TabIndex = 4;
            // 
            // tbx_city
            // 
            this.tbx_city.Location = new System.Drawing.Point(92, 19);
            this.tbx_city.Name = "tbx_city";
            this.tbx_city.Size = new System.Drawing.Size(178, 20);
            this.tbx_city.TabIndex = 3;
            // 
            // lbl_locale_number
            // 
            this.lbl_locale_number.AutoSize = true;
            this.lbl_locale_number.Location = new System.Drawing.Point(17, 121);
            this.lbl_locale_number.Name = "lbl_locale_number";
            this.lbl_locale_number.Size = new System.Drawing.Size(69, 13);
            this.lbl_locale_number.TabIndex = 2;
            this.lbl_locale_number.Text = "Numer lokalu";
            // 
            // lbl_street
            // 
            this.lbl_street.AutoSize = true;
            this.lbl_street.Location = new System.Drawing.Point(55, 55);
            this.lbl_street.Name = "lbl_street";
            this.lbl_street.Size = new System.Drawing.Size(31, 13);
            this.lbl_street.TabIndex = 1;
            this.lbl_street.Text = "Ulica";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(18, 22);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(72, 13);
            this.lbl_city.TabIndex = 0;
            this.lbl_city.Text = "Miejscowość*";
            // 
            // lbl_user_surname
            // 
            this.lbl_user_surname.AutoSize = true;
            this.lbl_user_surname.Location = new System.Drawing.Point(131, 102);
            this.lbl_user_surname.Name = "lbl_user_surname";
            this.lbl_user_surname.Size = new System.Drawing.Size(57, 13);
            this.lbl_user_surname.TabIndex = 5;
            this.lbl_user_surname.Text = "Nazwisko*";
            // 
            // tbx_user_surname
            // 
            this.tbx_user_surname.Location = new System.Drawing.Point(190, 99);
            this.tbx_user_surname.Name = "tbx_user_surname";
            this.tbx_user_surname.Size = new System.Drawing.Size(131, 20);
            this.tbx_user_surname.TabIndex = 4;
            // 
            // tbx_user_name
            // 
            this.tbx_user_name.Location = new System.Drawing.Point(190, 66);
            this.tbx_user_name.Name = "tbx_user_name";
            this.tbx_user_name.Size = new System.Drawing.Size(131, 20);
            this.tbx_user_name.TabIndex = 3;
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Location = new System.Drawing.Point(158, 69);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(30, 13);
            this.lbl_user_name.TabIndex = 2;
            this.lbl_user_name.Text = "Imię*";
            // 
            // tbx_user_login
            // 
            this.tbx_user_login.Location = new System.Drawing.Point(190, 33);
            this.tbx_user_login.Name = "tbx_user_login";
            this.tbx_user_login.Size = new System.Drawing.Size(131, 20);
            this.tbx_user_login.TabIndex = 1;
            // 
            // lbl_user_login
            // 
            this.lbl_user_login.AutoSize = true;
            this.lbl_user_login.Location = new System.Drawing.Point(26, 36);
            this.lbl_user_login.Name = "lbl_user_login";
            this.lbl_user_login.Size = new System.Drawing.Size(162, 13);
            this.lbl_user_login.TabIndex = 0;
            this.lbl_user_login.Text = "Identyfikator użytkownika - login*";
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Location = new System.Drawing.Point(36, 142);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(83, 13);
            this.lbl_birthdate.TabIndex = 10;
            this.lbl_birthdate.Text = "Data urodzenia*\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Numer telefonu*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adres e-mail*";
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(445, 66);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(131, 20);
            this.tbx_email.TabIndex = 14;
            // 
            // tbx_phone
            // 
            this.tbx_phone.Location = new System.Drawing.Point(445, 99);
            this.tbx_phone.Name = "tbx_phone";
            this.tbx_phone.Size = new System.Drawing.Size(131, 20);
            this.tbx_phone.TabIndex = 15;
            // 
            // btn_add_user
            // 
            this.btn_add_user.Location = new System.Drawing.Point(363, 307);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(213, 23);
            this.btn_add_user.TabIndex = 17;
            this.btn_add_user.Text = "Dodaj użytkownika";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // lbl_required
            // 
            this.lbl_required.AutoSize = true;
            this.lbl_required.Location = new System.Drawing.Point(363, 288);
            this.lbl_required.Name = "lbl_required";
            this.lbl_required.Size = new System.Drawing.Size(85, 13);
            this.lbl_required.TabIndex = 18;
            this.lbl_required.Text = "*pola wymagane";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbx_add_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System magazynowy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpbx_add_user.ResumeLayout(false);
            this.grpbx_add_user.PerformLayout();
            this.grpbx_address.ResumeLayout(false);
            this.grpbx_address.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajUżytkownikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importujCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujUżytkownikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyszukajToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpbx_add_user;
        private System.Windows.Forms.TextBox tbx_user_name;
        private System.Windows.Forms.Label lbl_user_name;
        private System.Windows.Forms.TextBox tbx_user_login;
        private System.Windows.Forms.Label lbl_user_login;
        private System.Windows.Forms.Label lbl_user_surname;
        private System.Windows.Forms.TextBox tbx_user_surname;
        private System.Windows.Forms.GroupBox grpbx_address;
        private System.Windows.Forms.Label lbl_locale_number;
        private System.Windows.Forms.Label lbl_street;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.TextBox tbx_city;
        private System.Windows.Forms.TextBox tbx_street_number;
        private System.Windows.Forms.TextBox tbx_street;
        private System.Windows.Forms.TextBox tbx_locale_number;
        private System.Windows.Forms.Label lbl_pesel;
        private System.Windows.Forms.TextBox tbx_pesel;
        private System.Windows.Forms.Label lbl_street_number;
        private System.Windows.Forms.DateTimePicker dtpckr_birthdate;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_phone;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_required;
        private System.Windows.Forms.Button btn_add_user;
    }
}