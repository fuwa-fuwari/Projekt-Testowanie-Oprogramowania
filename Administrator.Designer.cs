using System.Windows.Forms;

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
            this.dotNetBarTabControl_main_view = new TabControls.DotNetBarTabControl();
            this.tabPage_overview = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_manage_users = new System.Windows.Forms.TabPage();
            this.dotNetBarTabControl_manage_users = new TabControls.DotNetBarTabControl();
            this.tabPage_add_user = new System.Windows.Forms.TabPage();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.cmbx_gender = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_required = new System.Windows.Forms.Label();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.msktbx_phone = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_email = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.dtpckr_birthdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_pesel = new System.Windows.Forms.Label();
            this.msktbx_pesel = new System.Windows.Forms.MaskedTextBox();
            this.grpbx_address = new System.Windows.Forms.GroupBox();
            this.lbl_street_number = new System.Windows.Forms.Label();
            this.msktbx_locale_number = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_street_number = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_street = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_city = new System.Windows.Forms.MaskedTextBox();
            this.lbl_locale_number = new System.Windows.Forms.Label();
            this.lbl_street = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_user_surname = new System.Windows.Forms.Label();
            this.msktbx_user_surname = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_user_name = new System.Windows.Forms.MaskedTextBox();
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.msktbx_user_login = new System.Windows.Forms.MaskedTextBox();
            this.lbl_user_login = new System.Windows.Forms.Label();
            this.tabPage_edit_user = new System.Windows.Forms.TabPage();
            this.btn_test = new System.Windows.Forms.Button();
            this.dotNetBarTabControl_main_view.SuspendLayout();
            this.tabPage_overview.SuspendLayout();
            this.tabPage_manage_users.SuspendLayout();
            this.dotNetBarTabControl_manage_users.SuspendLayout();
            this.tabPage_add_user.SuspendLayout();
            this.grpbx_address.SuspendLayout();
            this.SuspendLayout();
            // 
            // dotNetBarTabControl_main_view
            // 
            this.dotNetBarTabControl_main_view.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.dotNetBarTabControl_main_view.Controls.Add(this.tabPage_overview);
            this.dotNetBarTabControl_main_view.Controls.Add(this.tabPage_manage_users);
            this.dotNetBarTabControl_main_view.ItemSize = new System.Drawing.Size(44, 142);
            this.dotNetBarTabControl_main_view.Location = new System.Drawing.Point(12, 12);
            this.dotNetBarTabControl_main_view.Multiline = true;
            this.dotNetBarTabControl_main_view.Name = "dotNetBarTabControl_main_view";
            this.dotNetBarTabControl_main_view.SelectedIndex = 0;
            this.dotNetBarTabControl_main_view.Size = new System.Drawing.Size(887, 535);
            this.dotNetBarTabControl_main_view.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.dotNetBarTabControl_main_view.TabIndex = 2;
            // 
            // tabPage_overview
            // 
            this.tabPage_overview.Controls.Add(this.label1);
            this.tabPage_overview.Location = new System.Drawing.Point(146, 4);
            this.tabPage_overview.Name = "tabPage_overview";
            this.tabPage_overview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_overview.Size = new System.Drawing.Size(737, 527);
            this.tabPage_overview.TabIndex = 1;
            this.tabPage_overview.Text = "Przegląd";
            this.tabPage_overview.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Co tutaj?";
            // 
            // tabPage_manage_users
            // 
            this.tabPage_manage_users.Controls.Add(this.dotNetBarTabControl_manage_users);
            this.tabPage_manage_users.Location = new System.Drawing.Point(146, 4);
            this.tabPage_manage_users.Name = "tabPage_manage_users";
            this.tabPage_manage_users.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_manage_users.Size = new System.Drawing.Size(737, 527);
            this.tabPage_manage_users.TabIndex = 0;
            this.tabPage_manage_users.Text = "Zarządzaj użytkownikami";
            this.tabPage_manage_users.UseVisualStyleBackColor = true;
            // 
            // dotNetBarTabControl_manage_users
            // 
            this.dotNetBarTabControl_manage_users.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.dotNetBarTabControl_manage_users.Controls.Add(this.tabPage_add_user);
            this.dotNetBarTabControl_manage_users.Controls.Add(this.tabPage_edit_user);
            this.dotNetBarTabControl_manage_users.ItemSize = new System.Drawing.Size(44, 136);
            this.dotNetBarTabControl_manage_users.Location = new System.Drawing.Point(0, -4);
            this.dotNetBarTabControl_manage_users.Multiline = true;
            this.dotNetBarTabControl_manage_users.Name = "dotNetBarTabControl_manage_users";
            this.dotNetBarTabControl_manage_users.SelectedIndex = 0;
            this.dotNetBarTabControl_manage_users.Size = new System.Drawing.Size(741, 535);
            this.dotNetBarTabControl_manage_users.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.dotNetBarTabControl_manage_users.TabIndex = 0;
            // 
            // tabPage_add_user
            // 
            this.tabPage_add_user.Controls.Add(this.btn_test);
            this.tabPage_add_user.Controls.Add(this.lbl_gender);
            this.tabPage_add_user.Controls.Add(this.cmbx_gender);
            this.tabPage_add_user.Controls.Add(this.btn_cancel);
            this.tabPage_add_user.Controls.Add(this.lbl_required);
            this.tabPage_add_user.Controls.Add(this.btn_add_user);
            this.tabPage_add_user.Controls.Add(this.label2);
            this.tabPage_add_user.Controls.Add(this.msktbx_phone);
            this.tabPage_add_user.Controls.Add(this.msktbx_email);
            this.tabPage_add_user.Controls.Add(this.label3);
            this.tabPage_add_user.Controls.Add(this.lbl_birthdate);
            this.tabPage_add_user.Controls.Add(this.dtpckr_birthdate);
            this.tabPage_add_user.Controls.Add(this.lbl_pesel);
            this.tabPage_add_user.Controls.Add(this.msktbx_pesel);
            this.tabPage_add_user.Controls.Add(this.grpbx_address);
            this.tabPage_add_user.Controls.Add(this.lbl_user_surname);
            this.tabPage_add_user.Controls.Add(this.msktbx_user_surname);
            this.tabPage_add_user.Controls.Add(this.msktbx_user_name);
            this.tabPage_add_user.Controls.Add(this.lbl_user_name);
            this.tabPage_add_user.Controls.Add(this.msktbx_user_login);
            this.tabPage_add_user.Controls.Add(this.lbl_user_login);
            this.tabPage_add_user.Location = new System.Drawing.Point(140, 4);
            this.tabPage_add_user.Name = "tabPage_add_user";
            this.tabPage_add_user.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_add_user.Size = new System.Drawing.Size(597, 527);
            this.tabPage_add_user.TabIndex = 0;
            this.tabPage_add_user.Text = "Dodaj użytkownika";
            this.tabPage_add_user.UseVisualStyleBackColor = true;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(274, 127);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(30, 13);
            this.lbl_gender.TabIndex = 38;
            this.lbl_gender.Text = "Płeć";
            // 
            // cmbx_gender
            // 
            this.cmbx_gender.FormattingEnabled = true;
            this.cmbx_gender.Items.AddRange(new object[] {
            "kobieta",
            "mężczyzna"});
            this.cmbx_gender.Location = new System.Drawing.Point(310, 124);
            this.cmbx_gender.Name = "cmbx_gender";
            this.cmbx_gender.Size = new System.Drawing.Size(131, 21);
            this.cmbx_gender.TabIndex = 37;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(149, 494);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(115, 23);
            this.btn_cancel.TabIndex = 36;
            this.btn_cancel.Text = "Anuluj";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_required
            // 
            this.lbl_required.AutoSize = true;
            this.lbl_required.Location = new System.Drawing.Point(193, 468);
            this.lbl_required.Name = "lbl_required";
            this.lbl_required.Size = new System.Drawing.Size(85, 13);
            this.lbl_required.TabIndex = 35;
            this.lbl_required.Text = "*pola wymagane";
            // 
            // btn_add_user
            // 
            this.btn_add_user.BackColor = System.Drawing.Color.White;
            this.btn_add_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_user.Location = new System.Drawing.Point(326, 494);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(115, 23);
            this.btn_add_user.TabIndex = 34;
            this.btn_add_user.Text = "Zapisz";
            this.btn_add_user.UseVisualStyleBackColor = false;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Numer telefonu*";
            // 
            // msktbx_phone
            // 
            this.msktbx_phone.Location = new System.Drawing.Point(310, 222);
            this.msktbx_phone.Mask = "000000000";
            this.msktbx_phone.Name = "msktbx_phone";
            this.msktbx_phone.Size = new System.Drawing.Size(131, 20);
            this.msktbx_phone.TabIndex = 32;
            this.msktbx_phone.ValidatingType = typeof(int);
            // 
            // msktbx_email
            // 
            this.msktbx_email.Location = new System.Drawing.Point(310, 190);
            this.msktbx_email.Name = "msktbx_email";
            this.msktbx_email.Size = new System.Drawing.Size(131, 20);
            this.msktbx_email.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Adres e-mail*";
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Location = new System.Drawing.Point(156, 272);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(83, 13);
            this.lbl_birthdate.TabIndex = 29;
            this.lbl_birthdate.Text = "Data urodzenia*\r\n";
            // 
            // dtpckr_birthdate
            // 
            this.dtpckr_birthdate.Location = new System.Drawing.Point(241, 269);
            this.dtpckr_birthdate.Name = "dtpckr_birthdate";
            this.dtpckr_birthdate.Size = new System.Drawing.Size(200, 20);
            this.dtpckr_birthdate.TabIndex = 28;
            // 
            // lbl_pesel
            // 
            this.lbl_pesel.AutoSize = true;
            this.lbl_pesel.Location = new System.Drawing.Point(263, 160);
            this.lbl_pesel.Name = "lbl_pesel";
            this.lbl_pesel.Size = new System.Drawing.Size(45, 13);
            this.lbl_pesel.TabIndex = 27;
            this.lbl_pesel.Text = "PESEL*";
            // 
            // msktbx_pesel
            // 
            this.msktbx_pesel.Location = new System.Drawing.Point(310, 157);
            this.msktbx_pesel.Mask = "00000000000";
            this.msktbx_pesel.Name = "msktbx_pesel";
            this.msktbx_pesel.Size = new System.Drawing.Size(131, 20);
            this.msktbx_pesel.TabIndex = 26;
            this.msktbx_pesel.ValidatingType = typeof(int);
            // 
            // grpbx_address
            // 
            this.grpbx_address.Controls.Add(this.lbl_street_number);
            this.grpbx_address.Controls.Add(this.msktbx_locale_number);
            this.grpbx_address.Controls.Add(this.msktbx_street_number);
            this.grpbx_address.Controls.Add(this.msktbx_street);
            this.grpbx_address.Controls.Add(this.msktbx_city);
            this.grpbx_address.Controls.Add(this.lbl_locale_number);
            this.grpbx_address.Controls.Add(this.lbl_street);
            this.grpbx_address.Controls.Add(this.lbl_city);
            this.grpbx_address.Location = new System.Drawing.Point(149, 309);
            this.grpbx_address.Name = "grpbx_address";
            this.grpbx_address.Size = new System.Drawing.Size(292, 152);
            this.grpbx_address.TabIndex = 25;
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
            // msktbx_locale_number
            // 
            this.msktbx_locale_number.Location = new System.Drawing.Point(92, 118);
            this.msktbx_locale_number.Name = "msktbx_locale_number";
            this.msktbx_locale_number.Size = new System.Drawing.Size(178, 20);
            this.msktbx_locale_number.TabIndex = 6;
            // 
            // msktbx_street_number
            // 
            this.msktbx_street_number.Location = new System.Drawing.Point(92, 85);
            this.msktbx_street_number.Name = "msktbx_street_number";
            this.msktbx_street_number.Size = new System.Drawing.Size(178, 20);
            this.msktbx_street_number.TabIndex = 5;
            // 
            // msktbx_street
            // 
            this.msktbx_street.Location = new System.Drawing.Point(92, 52);
            this.msktbx_street.Name = "msktbx_street";
            this.msktbx_street.Size = new System.Drawing.Size(178, 20);
            this.msktbx_street.TabIndex = 4;
            // 
            // msktbx_city
            // 
            this.msktbx_city.Location = new System.Drawing.Point(92, 19);
            this.msktbx_city.Name = "msktbx_city";
            this.msktbx_city.Size = new System.Drawing.Size(178, 20);
            this.msktbx_city.TabIndex = 3;
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
            this.lbl_user_surname.Location = new System.Drawing.Point(251, 94);
            this.lbl_user_surname.Name = "lbl_user_surname";
            this.lbl_user_surname.Size = new System.Drawing.Size(57, 13);
            this.lbl_user_surname.TabIndex = 24;
            this.lbl_user_surname.Text = "Nazwisko*";
            // 
            // msktbx_user_surname
            // 
            this.msktbx_user_surname.Location = new System.Drawing.Point(310, 91);
            this.msktbx_user_surname.Name = "msktbx_user_surname";
            this.msktbx_user_surname.Size = new System.Drawing.Size(131, 20);
            this.msktbx_user_surname.TabIndex = 23;
            // 
            // msktbx_user_name
            // 
            this.msktbx_user_name.Location = new System.Drawing.Point(310, 58);
            this.msktbx_user_name.Name = "msktbx_user_name";
            this.msktbx_user_name.Size = new System.Drawing.Size(131, 20);
            this.msktbx_user_name.TabIndex = 22;
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Location = new System.Drawing.Point(278, 61);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(30, 13);
            this.lbl_user_name.TabIndex = 21;
            this.lbl_user_name.Text = "Imię*";
            // 
            // msktbx_user_login
            // 
            this.msktbx_user_login.BackColor = System.Drawing.Color.White;
            this.msktbx_user_login.Location = new System.Drawing.Point(310, 25);
            this.msktbx_user_login.Name = "msktbx_user_login";
            this.msktbx_user_login.Size = new System.Drawing.Size(131, 20);
            this.msktbx_user_login.TabIndex = 20;
            // 
            // lbl_user_login
            // 
            this.lbl_user_login.AutoSize = true;
            this.lbl_user_login.Location = new System.Drawing.Point(146, 28);
            this.lbl_user_login.Name = "lbl_user_login";
            this.lbl_user_login.Size = new System.Drawing.Size(162, 13);
            this.lbl_user_login.TabIndex = 19;
            this.lbl_user_login.Text = "Identyfikator użytkownika - login*";
            // 
            // tabPage_edit_user
            // 
            this.tabPage_edit_user.Location = new System.Drawing.Point(140, 4);
            this.tabPage_edit_user.Name = "tabPage_edit_user";
            this.tabPage_edit_user.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_edit_user.Size = new System.Drawing.Size(597, 527);
            this.tabPage_edit_user.TabIndex = 1;
            this.tabPage_edit_user.Text = "Edytuj";
            this.tabPage_edit_user.UseVisualStyleBackColor = true;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(70, 121);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(93, 23);
            this.btn_test.TabIndex = 39;
            this.btn_test.Text = "dane testowe";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(911, 559);
            this.Controls.Add(this.dotNetBarTabControl_main_view);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System magazynowy";
            this.dotNetBarTabControl_main_view.ResumeLayout(false);
            this.tabPage_overview.ResumeLayout(false);
            this.tabPage_overview.PerformLayout();
            this.tabPage_manage_users.ResumeLayout(false);
            this.dotNetBarTabControl_manage_users.ResumeLayout(false);
            this.tabPage_add_user.ResumeLayout(false);
            this.tabPage_add_user.PerformLayout();
            this.grpbx_address.ResumeLayout(false);
            this.grpbx_address.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControls.DotNetBarTabControl dotNetBarTabControl_main_view;
        private System.Windows.Forms.TabPage tabPage_manage_users;
        private TabControls.DotNetBarTabControl dotNetBarTabControl_manage_users;
        private System.Windows.Forms.TabPage tabPage_add_user;
        private System.Windows.Forms.Label lbl_required;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msktbx_phone;
        private System.Windows.Forms.MaskedTextBox msktbx_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.DateTimePicker dtpckr_birthdate;
        private System.Windows.Forms.Label lbl_pesel;
        private System.Windows.Forms.MaskedTextBox msktbx_pesel;
        private System.Windows.Forms.GroupBox grpbx_address;
        private System.Windows.Forms.Label lbl_street_number;
        private System.Windows.Forms.MaskedTextBox msktbx_locale_number;
        private System.Windows.Forms.MaskedTextBox msktbx_street_number;
        private System.Windows.Forms.MaskedTextBox msktbx_street;
        private System.Windows.Forms.MaskedTextBox msktbx_city;
        private System.Windows.Forms.Label lbl_locale_number;
        private System.Windows.Forms.Label lbl_street;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_user_surname;
        private System.Windows.Forms.MaskedTextBox msktbx_user_surname;
        private System.Windows.Forms.MaskedTextBox msktbx_user_name;
        private System.Windows.Forms.Label lbl_user_name;
        private System.Windows.Forms.MaskedTextBox msktbx_user_login;
        private System.Windows.Forms.Label lbl_user_login;
        private System.Windows.Forms.TabPage tabPage_edit_user;
        private System.Windows.Forms.TabPage tabPage_overview;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.ComboBox cmbx_gender;
        private Label label1;
        private Button btn_test;
    }
}