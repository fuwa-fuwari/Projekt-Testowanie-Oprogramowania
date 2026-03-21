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
            this.btn_test = new System.Windows.Forms.Button();
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
            this.btn_unlock_edit = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbx_select_user_edit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbx_gender_edit = new System.Windows.Forms.ComboBox();
            this.btn_cancel_edit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_save_edit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.msktbx_phone_edit = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_email_edit = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpckr_birthdate_edit = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.msktbx_pesel_edit = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.msktbx_locale_number_edit = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_street_number_edit = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_street_edit = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_city_edit = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.msktbx_user_surname_edit = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_user_name_edit = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.msktbx_user_login_edit = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dotNetBarTabControl_main_view.SuspendLayout();
            this.tabPage_overview.SuspendLayout();
            this.tabPage_manage_users.SuspendLayout();
            this.dotNetBarTabControl_manage_users.SuspendLayout();
            this.tabPage_add_user.SuspendLayout();
            this.grpbx_address.SuspendLayout();
            this.tabPage_edit_user.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.dotNetBarTabControl_manage_users.SelectedIndexChanged += new System.EventHandler(this.dotNetBarTabControl_manage_users_SelectedIndexChanged);
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
            this.tabPage_edit_user.Controls.Add(this.btn_unlock_edit);
            this.tabPage_edit_user.Controls.Add(this.label17);
            this.tabPage_edit_user.Controls.Add(this.cmbx_select_user_edit);
            this.tabPage_edit_user.Controls.Add(this.label4);
            this.tabPage_edit_user.Controls.Add(this.cmbx_gender_edit);
            this.tabPage_edit_user.Controls.Add(this.btn_cancel_edit);
            this.tabPage_edit_user.Controls.Add(this.label5);
            this.tabPage_edit_user.Controls.Add(this.btn_save_edit);
            this.tabPage_edit_user.Controls.Add(this.label6);
            this.tabPage_edit_user.Controls.Add(this.msktbx_phone_edit);
            this.tabPage_edit_user.Controls.Add(this.msktbx_email_edit);
            this.tabPage_edit_user.Controls.Add(this.label7);
            this.tabPage_edit_user.Controls.Add(this.label8);
            this.tabPage_edit_user.Controls.Add(this.dtpckr_birthdate_edit);
            this.tabPage_edit_user.Controls.Add(this.label9);
            this.tabPage_edit_user.Controls.Add(this.msktbx_pesel_edit);
            this.tabPage_edit_user.Controls.Add(this.groupBox1);
            this.tabPage_edit_user.Controls.Add(this.label14);
            this.tabPage_edit_user.Controls.Add(this.msktbx_user_surname_edit);
            this.tabPage_edit_user.Controls.Add(this.msktbx_user_name_edit);
            this.tabPage_edit_user.Controls.Add(this.label15);
            this.tabPage_edit_user.Controls.Add(this.msktbx_user_login_edit);
            this.tabPage_edit_user.Controls.Add(this.label16);
            this.tabPage_edit_user.Location = new System.Drawing.Point(140, 4);
            this.tabPage_edit_user.Name = "tabPage_edit_user";
            this.tabPage_edit_user.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_edit_user.Size = new System.Drawing.Size(597, 527);
            this.tabPage_edit_user.TabIndex = 1;
            this.tabPage_edit_user.Text = "Edytuj";
            this.tabPage_edit_user.UseVisualStyleBackColor = true;
            // 
            // btn_unlock_edit
            // 
            this.btn_unlock_edit.Location = new System.Drawing.Point(25, 81);
            this.btn_unlock_edit.Name = "btn_unlock_edit";
            this.btn_unlock_edit.Size = new System.Drawing.Size(121, 23);
            this.btn_unlock_edit.TabIndex = 62;
            this.btn_unlock_edit.Text = "Edytuj";
            this.btn_unlock_edit.UseVisualStyleBackColor = true;
            this.btn_unlock_edit.Click += new System.EventHandler(this.btn_unlock_edit_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 13);
            this.label17.TabIndex = 61;
            this.label17.Text = "Wybierz użytkownika:";
            // 
            // cmbx_select_user_edit
            // 
            this.cmbx_select_user_edit.FormattingEnabled = true;
            this.cmbx_select_user_edit.Location = new System.Drawing.Point(25, 45);
            this.cmbx_select_user_edit.Name = "cmbx_select_user_edit";
            this.cmbx_select_user_edit.Size = new System.Drawing.Size(121, 21);
            this.cmbx_select_user_edit.TabIndex = 60;
            this.cmbx_select_user_edit.SelectedIndexChanged += new System.EventHandler(this.cmbx_select_user_edit_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Płeć";
            // 
            // cmbx_gender_edit
            // 
            this.cmbx_gender_edit.Enabled = false;
            this.cmbx_gender_edit.FormattingEnabled = true;
            this.cmbx_gender_edit.Items.AddRange(new object[] {
            "kobieta",
            "mężczyzna"});
            this.cmbx_gender_edit.Location = new System.Drawing.Point(353, 116);
            this.cmbx_gender_edit.Name = "cmbx_gender_edit";
            this.cmbx_gender_edit.Size = new System.Drawing.Size(131, 21);
            this.cmbx_gender_edit.TabIndex = 58;
            // 
            // btn_cancel_edit
            // 
            this.btn_cancel_edit.BackColor = System.Drawing.Color.White;
            this.btn_cancel_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel_edit.Location = new System.Drawing.Point(192, 486);
            this.btn_cancel_edit.Name = "btn_cancel_edit";
            this.btn_cancel_edit.Size = new System.Drawing.Size(115, 23);
            this.btn_cancel_edit.TabIndex = 57;
            this.btn_cancel_edit.Text = "Anuluj";
            this.btn_cancel_edit.UseVisualStyleBackColor = false;
            this.btn_cancel_edit.Click += new System.EventHandler(this.btn_cancel_edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "*pola wymagane";
            // 
            // btn_save_edit
            // 
            this.btn_save_edit.BackColor = System.Drawing.Color.White;
            this.btn_save_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_edit.Location = new System.Drawing.Point(369, 486);
            this.btn_save_edit.Name = "btn_save_edit";
            this.btn_save_edit.Size = new System.Drawing.Size(115, 23);
            this.btn_save_edit.TabIndex = 55;
            this.btn_save_edit.Text = "Zapisz";
            this.btn_save_edit.UseVisualStyleBackColor = false;
            this.btn_save_edit.Click += new System.EventHandler(this.btn_save_edit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Numer telefonu*";
            // 
            // msktbx_phone_edit
            // 
            this.msktbx_phone_edit.Enabled = false;
            this.msktbx_phone_edit.Location = new System.Drawing.Point(353, 214);
            this.msktbx_phone_edit.Mask = "000000000";
            this.msktbx_phone_edit.Name = "msktbx_phone_edit";
            this.msktbx_phone_edit.Size = new System.Drawing.Size(131, 20);
            this.msktbx_phone_edit.TabIndex = 53;
            this.msktbx_phone_edit.ValidatingType = typeof(int);
            // 
            // msktbx_email_edit
            // 
            this.msktbx_email_edit.Enabled = false;
            this.msktbx_email_edit.Location = new System.Drawing.Point(353, 182);
            this.msktbx_email_edit.Name = "msktbx_email_edit";
            this.msktbx_email_edit.Size = new System.Drawing.Size(131, 20);
            this.msktbx_email_edit.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Adres e-mail*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Data urodzenia*\r\n";
            // 
            // dtpckr_birthdate_edit
            // 
            this.dtpckr_birthdate_edit.Enabled = false;
            this.dtpckr_birthdate_edit.Location = new System.Drawing.Point(284, 261);
            this.dtpckr_birthdate_edit.Name = "dtpckr_birthdate_edit";
            this.dtpckr_birthdate_edit.Size = new System.Drawing.Size(200, 20);
            this.dtpckr_birthdate_edit.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "PESEL*";
            // 
            // msktbx_pesel_edit
            // 
            this.msktbx_pesel_edit.Enabled = false;
            this.msktbx_pesel_edit.Location = new System.Drawing.Point(353, 149);
            this.msktbx_pesel_edit.Mask = "00000000000";
            this.msktbx_pesel_edit.Name = "msktbx_pesel_edit";
            this.msktbx_pesel_edit.Size = new System.Drawing.Size(131, 20);
            this.msktbx_pesel_edit.TabIndex = 47;
            this.msktbx_pesel_edit.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.msktbx_locale_number_edit);
            this.groupBox1.Controls.Add(this.msktbx_street_number_edit);
            this.groupBox1.Controls.Add(this.msktbx_street_edit);
            this.groupBox1.Controls.Add(this.msktbx_city_edit);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(192, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 152);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adres";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Numer posesji*";
            // 
            // msktbx_locale_number_edit
            // 
            this.msktbx_locale_number_edit.Enabled = false;
            this.msktbx_locale_number_edit.Location = new System.Drawing.Point(92, 118);
            this.msktbx_locale_number_edit.Name = "msktbx_locale_number_edit";
            this.msktbx_locale_number_edit.Size = new System.Drawing.Size(178, 20);
            this.msktbx_locale_number_edit.TabIndex = 6;
            // 
            // msktbx_street_number_edit
            // 
            this.msktbx_street_number_edit.Enabled = false;
            this.msktbx_street_number_edit.Location = new System.Drawing.Point(92, 85);
            this.msktbx_street_number_edit.Name = "msktbx_street_number_edit";
            this.msktbx_street_number_edit.Size = new System.Drawing.Size(178, 20);
            this.msktbx_street_number_edit.TabIndex = 5;
            // 
            // msktbx_street_edit
            // 
            this.msktbx_street_edit.Enabled = false;
            this.msktbx_street_edit.Location = new System.Drawing.Point(92, 52);
            this.msktbx_street_edit.Name = "msktbx_street_edit";
            this.msktbx_street_edit.Size = new System.Drawing.Size(178, 20);
            this.msktbx_street_edit.TabIndex = 4;
            // 
            // msktbx_city_edit
            // 
            this.msktbx_city_edit.Enabled = false;
            this.msktbx_city_edit.Location = new System.Drawing.Point(92, 19);
            this.msktbx_city_edit.Name = "msktbx_city_edit";
            this.msktbx_city_edit.Size = new System.Drawing.Size(178, 20);
            this.msktbx_city_edit.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Numer lokalu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ulica";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Miejscowość*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(294, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Nazwisko*";
            // 
            // msktbx_user_surname_edit
            // 
            this.msktbx_user_surname_edit.Enabled = false;
            this.msktbx_user_surname_edit.Location = new System.Drawing.Point(353, 83);
            this.msktbx_user_surname_edit.Name = "msktbx_user_surname_edit";
            this.msktbx_user_surname_edit.Size = new System.Drawing.Size(131, 20);
            this.msktbx_user_surname_edit.TabIndex = 44;
            // 
            // msktbx_user_name_edit
            // 
            this.msktbx_user_name_edit.Enabled = false;
            this.msktbx_user_name_edit.Location = new System.Drawing.Point(353, 50);
            this.msktbx_user_name_edit.Name = "msktbx_user_name_edit";
            this.msktbx_user_name_edit.Size = new System.Drawing.Size(131, 20);
            this.msktbx_user_name_edit.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(321, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Imię*";
            // 
            // msktbx_user_login_edit
            // 
            this.msktbx_user_login_edit.BackColor = System.Drawing.Color.White;
            this.msktbx_user_login_edit.Enabled = false;
            this.msktbx_user_login_edit.Location = new System.Drawing.Point(353, 17);
            this.msktbx_user_login_edit.Name = "msktbx_user_login_edit";
            this.msktbx_user_login_edit.Size = new System.Drawing.Size(131, 20);
            this.msktbx_user_login_edit.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(189, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Identyfikator użytkownika - login*";
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
            this.tabPage_edit_user.ResumeLayout(false);
            this.tabPage_edit_user.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage_overview;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.ComboBox cmbx_gender;
        private Label label1;
        private Button btn_test;
        private TabPage tabPage_edit_user;
        private Label label4;
        private ComboBox cmbx_gender_edit;
        private Button btn_cancel_edit;
        private Label label5;
        private Button btn_save_edit;
        private Label label6;
        private MaskedTextBox msktbx_phone_edit;
        private MaskedTextBox msktbx_email_edit;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpckr_birthdate_edit;
        private Label label9;
        private MaskedTextBox msktbx_pesel_edit;
        private GroupBox groupBox1;
        private Label label10;
        private MaskedTextBox msktbx_locale_number_edit;
        private MaskedTextBox msktbx_street_number_edit;
        private MaskedTextBox msktbx_street_edit;
        private MaskedTextBox msktbx_city_edit;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private MaskedTextBox msktbx_user_surname_edit;
        private MaskedTextBox msktbx_user_name_edit;
        private Label label15;
        private MaskedTextBox msktbx_user_login_edit;
        private Label label16;
        private Label label17;
        private ComboBox cmbx_select_user_edit;
        private Button btn_unlock_edit;
    }
}