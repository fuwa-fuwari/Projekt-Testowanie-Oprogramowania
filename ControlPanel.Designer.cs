using System.Windows.Forms;

namespace ProjektMagazyn
{
    partial class ControlPanel
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
            this.btn_show_forgotten = new System.Windows.Forms.Button();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_forget = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dvg_user_list = new System.Windows.Forms.DataGridView();
            this.tabPage_users = new System.Windows.Forms.TabPage();
            this.dotNetBarTabControl_manage_users = new TabControls.DotNetBarTabControl();
            this.tabPage_add_user = new System.Windows.Forms.TabPage();
            this.msktbx_password = new System.Windows.Forms.MaskedTextBox();
            this.lbl_password = new System.Windows.Forms.Label();
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
            this.tabPage_view_user = new System.Windows.Forms.TabPage();
            this.btn_close_view = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_gender_view = new System.Windows.Forms.ComboBox();
            this.btn_edit_from_view = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.msktbx_phone_view = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_email_view = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpckr_birthdate_view = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.msktbx_pesel_view = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.msktbx_locale_number_view = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_street_number_view = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_street_view = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_city_view = new System.Windows.Forms.MaskedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.msktbx_user_surname_view = new System.Windows.Forms.MaskedTextBox();
            this.msktbx_user_name_view = new System.Windows.Forms.MaskedTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.msktbx_user_login_view = new System.Windows.Forms.MaskedTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPage_roles = new System.Windows.Forms.TabPage();
            this.dotNetBarTabControl_manage_roles = new TabControls.DotNetBarTabControl();
            this.tabPage_roles_overview = new System.Windows.Forms.TabPage();
            this.btn_filter_perms = new System.Windows.Forms.Button();
            this.cmbx_permissions = new System.Windows.Forms.ComboBox();
            this.dvg_users_perms = new System.Windows.Forms.DataGridView();
            this.lbl_roles = new System.Windows.Forms.Label();
            this.dgv_roles = new System.Windows.Forms.DataGridView();
            this.tabPage_edit_roles = new System.Windows.Forms.TabPage();
            this.btn_cancel_role = new System.Windows.Forms.Button();
            this.clb_roles = new System.Windows.Forms.CheckedListBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btn_save_role_changes = new System.Windows.Forms.Button();
            this.lbl_choose_user = new System.Windows.Forms.Label();
            this.cmbx_select_user_role_edit = new System.Windows.Forms.ComboBox();
            this.clb_add_user_role = new System.Windows.Forms.CheckedListBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.dotNetBarTabControl_main_view.SuspendLayout();
            this.tabPage_overview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_user_list)).BeginInit();
            this.tabPage_users.SuspendLayout();
            this.dotNetBarTabControl_manage_users.SuspendLayout();
            this.tabPage_add_user.SuspendLayout();
            this.grpbx_address.SuspendLayout();
            this.tabPage_edit_user.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_view_user.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage_roles.SuspendLayout();
            this.dotNetBarTabControl_manage_roles.SuspendLayout();
            this.tabPage_roles_overview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_users_perms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roles)).BeginInit();
            this.tabPage_edit_roles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dotNetBarTabControl_main_view
            // 
            this.dotNetBarTabControl_main_view.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.dotNetBarTabControl_main_view.Controls.Add(this.tabPage_overview);
            this.dotNetBarTabControl_main_view.Controls.Add(this.tabPage_users);
            this.dotNetBarTabControl_main_view.Controls.Add(this.tabPage_roles);
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
            this.tabPage_overview.Controls.Add(this.btn_show_forgotten);
            this.tabPage_overview.Controls.Add(this.tbx_search);
            this.tabPage_overview.Controls.Add(this.btn_search);
            this.tabPage_overview.Controls.Add(this.btn_forget);
            this.tabPage_overview.Controls.Add(this.btn_refresh);
            this.tabPage_overview.Controls.Add(this.dvg_user_list);
            this.tabPage_overview.Location = new System.Drawing.Point(146, 4);
            this.tabPage_overview.Name = "tabPage_overview";
            this.tabPage_overview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_overview.Size = new System.Drawing.Size(737, 527);
            this.tabPage_overview.TabIndex = 1;
            this.tabPage_overview.Text = "Przegląd";
            this.tabPage_overview.UseVisualStyleBackColor = true;
            // 
            // btn_show_forgotten
            // 
            this.btn_show_forgotten.Location = new System.Drawing.Point(4, 221);
            this.btn_show_forgotten.Name = "btn_show_forgotten";
            this.btn_show_forgotten.Size = new System.Drawing.Size(120, 36);
            this.btn_show_forgotten.TabIndex = 9;
            this.btn_show_forgotten.Text = "Wyświetl zapomnianych";
            this.btn_show_forgotten.UseVisualStyleBackColor = true;
            this.btn_show_forgotten.Click += new System.EventHandler(this.btn_show_forgotten_Click);
            // 
            // tbx_search
            // 
            this.tbx_search.Location = new System.Drawing.Point(130, 72);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(589, 20);
            this.tbx_search.TabIndex = 8;
            this.tbx_search.Text = "(Podaj imię, nazwisko lub PESEL)";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(4, 62);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(120, 39);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Wyszukaj";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_forget
            // 
            this.btn_forget.Location = new System.Drawing.Point(4, 170);
            this.btn_forget.Name = "btn_forget";
            this.btn_forget.Size = new System.Drawing.Size(120, 36);
            this.btn_forget.TabIndex = 6;
            this.btn_forget.Text = "Zapomnij użytkownika";
            this.btn_forget.UseVisualStyleBackColor = true;
            this.btn_forget.Click += new System.EventHandler(this.btn_forget_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(3, 116);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(120, 39);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Odswież listę";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dvg_user_list
            // 
            this.dvg_user_list.AllowUserToAddRows = false;
            this.dvg_user_list.AllowUserToDeleteRows = false;
            this.dvg_user_list.AllowUserToResizeColumns = false;
            this.dvg_user_list.AllowUserToResizeRows = false;
            this.dvg_user_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_user_list.Location = new System.Drawing.Point(130, 107);
            this.dvg_user_list.Name = "dvg_user_list";
            this.dvg_user_list.ReadOnly = true;
            this.dvg_user_list.Size = new System.Drawing.Size(589, 398);
            this.dvg_user_list.TabIndex = 4;
            this.dvg_user_list.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_user_list_CellContentDoubleClick);
            // 
            // tabPage_users
            // 
            this.tabPage_users.Controls.Add(this.dotNetBarTabControl_manage_users);
            this.tabPage_users.Location = new System.Drawing.Point(146, 4);
            this.tabPage_users.Name = "tabPage_users";
            this.tabPage_users.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_users.Size = new System.Drawing.Size(737, 527);
            this.tabPage_users.TabIndex = 0;
            this.tabPage_users.Text = "Zarządzaj użytkownikami";
            this.tabPage_users.UseVisualStyleBackColor = true;
            // 
            // dotNetBarTabControl_manage_users
            // 
            this.dotNetBarTabControl_manage_users.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.dotNetBarTabControl_manage_users.Controls.Add(this.tabPage_add_user);
            this.dotNetBarTabControl_manage_users.Controls.Add(this.tabPage_edit_user);
            this.dotNetBarTabControl_manage_users.Controls.Add(this.tabPage_view_user);
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
            this.tabPage_add_user.Controls.Add(this.lbl_role);
            this.tabPage_add_user.Controls.Add(this.clb_add_user_role);
            this.tabPage_add_user.Controls.Add(this.msktbx_password);
            this.tabPage_add_user.Controls.Add(this.lbl_password);
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
            // msktbx_password
            // 
            this.msktbx_password.BackColor = System.Drawing.Color.White;
            this.msktbx_password.Location = new System.Drawing.Point(366, 27);
            this.msktbx_password.Name = "msktbx_password";
            this.msktbx_password.Size = new System.Drawing.Size(131, 20);
            this.msktbx_password.TabIndex = 43;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(307, 30);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 42;
            this.lbl_password.Text = "Password";
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(18, 448);
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
            this.lbl_gender.Location = new System.Drawing.Point(134, 129);
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
            this.cmbx_gender.Location = new System.Drawing.Point(170, 126);
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
            this.label2.Location = new System.Drawing.Point(85, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Numer telefonu*";
            // 
            // msktbx_phone
            // 
            this.msktbx_phone.Location = new System.Drawing.Point(170, 224);
            this.msktbx_phone.Mask = "000000000";
            this.msktbx_phone.Name = "msktbx_phone";
            this.msktbx_phone.Size = new System.Drawing.Size(131, 20);
            this.msktbx_phone.TabIndex = 32;
            this.msktbx_phone.ValidatingType = typeof(int);
            // 
            // msktbx_email
            // 
            this.msktbx_email.Location = new System.Drawing.Point(170, 192);
            this.msktbx_email.Name = "msktbx_email";
            this.msktbx_email.Size = new System.Drawing.Size(131, 20);
            this.msktbx_email.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 195);
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
            this.lbl_pesel.Location = new System.Drawing.Point(123, 162);
            this.lbl_pesel.Name = "lbl_pesel";
            this.lbl_pesel.Size = new System.Drawing.Size(45, 13);
            this.lbl_pesel.TabIndex = 27;
            this.lbl_pesel.Text = "PESEL*";
            // 
            // msktbx_pesel
            // 
            this.msktbx_pesel.Location = new System.Drawing.Point(170, 159);
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
            this.lbl_user_surname.Location = new System.Drawing.Point(111, 96);
            this.lbl_user_surname.Name = "lbl_user_surname";
            this.lbl_user_surname.Size = new System.Drawing.Size(57, 13);
            this.lbl_user_surname.TabIndex = 24;
            this.lbl_user_surname.Text = "Nazwisko*";
            // 
            // msktbx_user_surname
            // 
            this.msktbx_user_surname.Location = new System.Drawing.Point(170, 93);
            this.msktbx_user_surname.Name = "msktbx_user_surname";
            this.msktbx_user_surname.Size = new System.Drawing.Size(131, 20);
            this.msktbx_user_surname.TabIndex = 23;
            // 
            // msktbx_user_name
            // 
            this.msktbx_user_name.Location = new System.Drawing.Point(170, 60);
            this.msktbx_user_name.Name = "msktbx_user_name";
            this.msktbx_user_name.Size = new System.Drawing.Size(131, 20);
            this.msktbx_user_name.TabIndex = 22;
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Location = new System.Drawing.Point(138, 63);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(30, 13);
            this.lbl_user_name.TabIndex = 21;
            this.lbl_user_name.Text = "Imię*";
            // 
            // msktbx_user_login
            // 
            this.msktbx_user_login.BackColor = System.Drawing.Color.White;
            this.msktbx_user_login.Location = new System.Drawing.Point(170, 27);
            this.msktbx_user_login.Name = "msktbx_user_login";
            this.msktbx_user_login.Size = new System.Drawing.Size(131, 20);
            this.msktbx_user_login.TabIndex = 20;
            // 
            // lbl_user_login
            // 
            this.lbl_user_login.AutoSize = true;
            this.lbl_user_login.Location = new System.Drawing.Point(6, 30);
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
            this.btn_unlock_edit.Size = new System.Drawing.Size(155, 23);
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
            this.cmbx_select_user_edit.Size = new System.Drawing.Size(155, 21);
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
            // tabPage_view_user
            // 
            this.tabPage_view_user.Controls.Add(this.btn_close_view);
            this.tabPage_view_user.Controls.Add(this.label1);
            this.tabPage_view_user.Controls.Add(this.cmbx_gender_view);
            this.tabPage_view_user.Controls.Add(this.btn_edit_from_view);
            this.tabPage_view_user.Controls.Add(this.label18);
            this.tabPage_view_user.Controls.Add(this.label19);
            this.tabPage_view_user.Controls.Add(this.msktbx_phone_view);
            this.tabPage_view_user.Controls.Add(this.msktbx_email_view);
            this.tabPage_view_user.Controls.Add(this.label20);
            this.tabPage_view_user.Controls.Add(this.label21);
            this.tabPage_view_user.Controls.Add(this.dtpckr_birthdate_view);
            this.tabPage_view_user.Controls.Add(this.label22);
            this.tabPage_view_user.Controls.Add(this.msktbx_pesel_view);
            this.tabPage_view_user.Controls.Add(this.groupBox2);
            this.tabPage_view_user.Controls.Add(this.label27);
            this.tabPage_view_user.Controls.Add(this.msktbx_user_surname_view);
            this.tabPage_view_user.Controls.Add(this.msktbx_user_name_view);
            this.tabPage_view_user.Controls.Add(this.label28);
            this.tabPage_view_user.Controls.Add(this.msktbx_user_login_view);
            this.tabPage_view_user.Controls.Add(this.label29);
            this.tabPage_view_user.Location = new System.Drawing.Point(140, 4);
            this.tabPage_view_user.Name = "tabPage_view_user";
            this.tabPage_view_user.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_view_user.Size = new System.Drawing.Size(597, 527);
            this.tabPage_view_user.TabIndex = 2;
            this.tabPage_view_user.Text = "Podgląd użytkownika";
            this.tabPage_view_user.UseVisualStyleBackColor = true;
            // 
            // btn_close_view
            // 
            this.btn_close_view.BackColor = System.Drawing.Color.White;
            this.btn_close_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close_view.Location = new System.Drawing.Point(331, 498);
            this.btn_close_view.Name = "btn_close_view";
            this.btn_close_view.Size = new System.Drawing.Size(115, 23);
            this.btn_close_view.TabIndex = 59;
            this.btn_close_view.Text = "Zamknij";
            this.btn_close_view.UseVisualStyleBackColor = false;
            this.btn_close_view.Click += new System.EventHandler(this.btn_close_view_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Płeć";
            // 
            // cmbx_gender_view
            // 
            this.cmbx_gender_view.Enabled = false;
            this.cmbx_gender_view.FormattingEnabled = true;
            this.cmbx_gender_view.Items.AddRange(new object[] {
            "kobieta",
            "mężczyzna"});
            this.cmbx_gender_view.Location = new System.Drawing.Point(315, 116);
            this.cmbx_gender_view.Name = "cmbx_gender_view";
            this.cmbx_gender_view.Size = new System.Drawing.Size(131, 21);
            this.cmbx_gender_view.TabIndex = 57;
            // 
            // btn_edit_from_view
            // 
            this.btn_edit_from_view.BackColor = System.Drawing.Color.White;
            this.btn_edit_from_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_from_view.Location = new System.Drawing.Point(154, 498);
            this.btn_edit_from_view.Name = "btn_edit_from_view";
            this.btn_edit_from_view.Size = new System.Drawing.Size(115, 23);
            this.btn_edit_from_view.TabIndex = 56;
            this.btn_edit_from_view.Text = "Edytuj";
            this.btn_edit_from_view.UseVisualStyleBackColor = false;
            this.btn_edit_from_view.Click += new System.EventHandler(this.btn_edit_from_view_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(198, 460);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "*pola wymagane";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(230, 217);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 13);
            this.label19.TabIndex = 53;
            this.label19.Text = "Numer telefonu*";
            // 
            // msktbx_phone_view
            // 
            this.msktbx_phone_view.Enabled = false;
            this.msktbx_phone_view.Location = new System.Drawing.Point(315, 214);
            this.msktbx_phone_view.Mask = "000000000";
            this.msktbx_phone_view.Name = "msktbx_phone_view";
            this.msktbx_phone_view.ReadOnly = true;
            this.msktbx_phone_view.Size = new System.Drawing.Size(131, 20);
            this.msktbx_phone_view.TabIndex = 52;
            this.msktbx_phone_view.ValidatingType = typeof(int);
            // 
            // msktbx_email_view
            // 
            this.msktbx_email_view.Enabled = false;
            this.msktbx_email_view.Location = new System.Drawing.Point(315, 182);
            this.msktbx_email_view.Name = "msktbx_email_view";
            this.msktbx_email_view.ReadOnly = true;
            this.msktbx_email_view.Size = new System.Drawing.Size(131, 20);
            this.msktbx_email_view.TabIndex = 51;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(245, 185);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "Adres e-mail*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(161, 264);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 13);
            this.label21.TabIndex = 49;
            this.label21.Text = "Data urodzenia*\r\n";
            // 
            // dtpckr_birthdate_view
            // 
            this.dtpckr_birthdate_view.Enabled = false;
            this.dtpckr_birthdate_view.Location = new System.Drawing.Point(246, 261);
            this.dtpckr_birthdate_view.Name = "dtpckr_birthdate_view";
            this.dtpckr_birthdate_view.Size = new System.Drawing.Size(200, 20);
            this.dtpckr_birthdate_view.TabIndex = 48;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(268, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "PESEL*";
            // 
            // msktbx_pesel_view
            // 
            this.msktbx_pesel_view.Enabled = false;
            this.msktbx_pesel_view.Location = new System.Drawing.Point(315, 149);
            this.msktbx_pesel_view.Mask = "00000000000";
            this.msktbx_pesel_view.Name = "msktbx_pesel_view";
            this.msktbx_pesel_view.ReadOnly = true;
            this.msktbx_pesel_view.Size = new System.Drawing.Size(131, 20);
            this.msktbx_pesel_view.TabIndex = 46;
            this.msktbx_pesel_view.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.msktbx_locale_number_view);
            this.groupBox2.Controls.Add(this.msktbx_street_number_view);
            this.groupBox2.Controls.Add(this.msktbx_street_view);
            this.groupBox2.Controls.Add(this.msktbx_city_view);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Location = new System.Drawing.Point(154, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 152);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 88);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 13);
            this.label23.TabIndex = 7;
            this.label23.Text = "Numer posesji*";
            // 
            // msktbx_locale_number_view
            // 
            this.msktbx_locale_number_view.Enabled = false;
            this.msktbx_locale_number_view.Location = new System.Drawing.Point(92, 118);
            this.msktbx_locale_number_view.Name = "msktbx_locale_number_view";
            this.msktbx_locale_number_view.ReadOnly = true;
            this.msktbx_locale_number_view.Size = new System.Drawing.Size(178, 20);
            this.msktbx_locale_number_view.TabIndex = 6;
            // 
            // msktbx_street_number_view
            // 
            this.msktbx_street_number_view.Enabled = false;
            this.msktbx_street_number_view.Location = new System.Drawing.Point(92, 85);
            this.msktbx_street_number_view.Name = "msktbx_street_number_view";
            this.msktbx_street_number_view.ReadOnly = true;
            this.msktbx_street_number_view.Size = new System.Drawing.Size(178, 20);
            this.msktbx_street_number_view.TabIndex = 5;
            // 
            // msktbx_street_view
            // 
            this.msktbx_street_view.Enabled = false;
            this.msktbx_street_view.Location = new System.Drawing.Point(92, 52);
            this.msktbx_street_view.Name = "msktbx_street_view";
            this.msktbx_street_view.ReadOnly = true;
            this.msktbx_street_view.Size = new System.Drawing.Size(178, 20);
            this.msktbx_street_view.TabIndex = 4;
            // 
            // msktbx_city_view
            // 
            this.msktbx_city_view.Enabled = false;
            this.msktbx_city_view.Location = new System.Drawing.Point(92, 19);
            this.msktbx_city_view.Name = "msktbx_city_view";
            this.msktbx_city_view.ReadOnly = true;
            this.msktbx_city_view.Size = new System.Drawing.Size(178, 20);
            this.msktbx_city_view.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 121);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Numer lokalu";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(55, 55);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "Ulica";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(72, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Miejscowość*";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(256, 86);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 13);
            this.label27.TabIndex = 44;
            this.label27.Text = "Nazwisko*";
            // 
            // msktbx_user_surname_view
            // 
            this.msktbx_user_surname_view.Enabled = false;
            this.msktbx_user_surname_view.Location = new System.Drawing.Point(315, 83);
            this.msktbx_user_surname_view.Name = "msktbx_user_surname_view";
            this.msktbx_user_surname_view.ReadOnly = true;
            this.msktbx_user_surname_view.Size = new System.Drawing.Size(131, 20);
            this.msktbx_user_surname_view.TabIndex = 43;
            // 
            // msktbx_user_name_view
            // 
            this.msktbx_user_name_view.Enabled = false;
            this.msktbx_user_name_view.Location = new System.Drawing.Point(315, 50);
            this.msktbx_user_name_view.Name = "msktbx_user_name_view";
            this.msktbx_user_name_view.ReadOnly = true;
            this.msktbx_user_name_view.Size = new System.Drawing.Size(131, 20);
            this.msktbx_user_name_view.TabIndex = 42;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(283, 53);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(30, 13);
            this.label28.TabIndex = 41;
            this.label28.Text = "Imię*";
            // 
            // msktbx_user_login_view
            // 
            this.msktbx_user_login_view.BackColor = System.Drawing.Color.White;
            this.msktbx_user_login_view.Enabled = false;
            this.msktbx_user_login_view.Location = new System.Drawing.Point(315, 17);
            this.msktbx_user_login_view.Name = "msktbx_user_login_view";
            this.msktbx_user_login_view.ReadOnly = true;
            this.msktbx_user_login_view.Size = new System.Drawing.Size(131, 20);
            this.msktbx_user_login_view.TabIndex = 40;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(151, 20);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(162, 13);
            this.label29.TabIndex = 39;
            this.label29.Text = "Identyfikator użytkownika - login*";
            // 
            // tabPage_roles
            // 
            this.tabPage_roles.Controls.Add(this.dotNetBarTabControl_manage_roles);
            this.tabPage_roles.Location = new System.Drawing.Point(146, 4);
            this.tabPage_roles.Name = "tabPage_roles";
            this.tabPage_roles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_roles.Size = new System.Drawing.Size(737, 527);
            this.tabPage_roles.TabIndex = 2;
            this.tabPage_roles.Text = "Zarządzaj uprawnieniami";
            this.tabPage_roles.UseVisualStyleBackColor = true;
            // 
            // dotNetBarTabControl_manage_roles
            // 
            this.dotNetBarTabControl_manage_roles.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.dotNetBarTabControl_manage_roles.Controls.Add(this.tabPage_roles_overview);
            this.dotNetBarTabControl_manage_roles.Controls.Add(this.tabPage_edit_roles);
            this.dotNetBarTabControl_manage_roles.ItemSize = new System.Drawing.Size(44, 136);
            this.dotNetBarTabControl_manage_roles.Location = new System.Drawing.Point(-2, -4);
            this.dotNetBarTabControl_manage_roles.Multiline = true;
            this.dotNetBarTabControl_manage_roles.Name = "dotNetBarTabControl_manage_roles";
            this.dotNetBarTabControl_manage_roles.SelectedIndex = 0;
            this.dotNetBarTabControl_manage_roles.Size = new System.Drawing.Size(741, 535);
            this.dotNetBarTabControl_manage_roles.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.dotNetBarTabControl_manage_roles.TabIndex = 1;
            // 
            // tabPage_roles_overview
            // 
            this.tabPage_roles_overview.Controls.Add(this.btn_filter_perms);
            this.tabPage_roles_overview.Controls.Add(this.cmbx_permissions);
            this.tabPage_roles_overview.Controls.Add(this.dvg_users_perms);
            this.tabPage_roles_overview.Controls.Add(this.lbl_roles);
            this.tabPage_roles_overview.Controls.Add(this.dgv_roles);
            this.tabPage_roles_overview.Location = new System.Drawing.Point(140, 4);
            this.tabPage_roles_overview.Name = "tabPage_roles_overview";
            this.tabPage_roles_overview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_roles_overview.Size = new System.Drawing.Size(597, 527);
            this.tabPage_roles_overview.TabIndex = 0;
            this.tabPage_roles_overview.Text = "Przegląd uprawnień";
            this.tabPage_roles_overview.UseVisualStyleBackColor = true;
            this.tabPage_roles_overview.Enter += new System.EventHandler(this.dotNetBarTabControl_manage_roles_SelectedIndexChanged);
            // 
            // btn_filter_perms
            // 
            this.btn_filter_perms.Location = new System.Drawing.Point(310, 252);
            this.btn_filter_perms.Name = "btn_filter_perms";
            this.btn_filter_perms.Size = new System.Drawing.Size(204, 23);
            this.btn_filter_perms.TabIndex = 4;
            this.btn_filter_perms.Text = "Filtruj";
            this.btn_filter_perms.UseVisualStyleBackColor = true;
            this.btn_filter_perms.Click += new System.EventHandler(this.btn_filter_perms_Click);
            // 
            // cmbx_permissions
            // 
            this.cmbx_permissions.FormattingEnabled = true;
            this.cmbx_permissions.Location = new System.Drawing.Point(77, 252);
            this.cmbx_permissions.Name = "cmbx_permissions";
            this.cmbx_permissions.Size = new System.Drawing.Size(208, 21);
            this.cmbx_permissions.TabIndex = 3;
            // 
            // dvg_users_perms
            // 
            this.dvg_users_perms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_users_perms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_users_perms.Location = new System.Drawing.Point(77, 279);
            this.dvg_users_perms.Name = "dvg_users_perms";
            this.dvg_users_perms.ReadOnly = true;
            this.dvg_users_perms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvg_users_perms.Size = new System.Drawing.Size(438, 201);
            this.dvg_users_perms.TabIndex = 2;
            // 
            // lbl_roles
            // 
            this.lbl_roles.AutoSize = true;
            this.lbl_roles.Location = new System.Drawing.Point(74, 35);
            this.lbl_roles.Name = "lbl_roles";
            this.lbl_roles.Size = new System.Drawing.Size(159, 13);
            this.lbl_roles.TabIndex = 1;
            this.lbl_roles.Text = "Uprawnienia nadane w systemie";
            // 
            // dgv_roles
            // 
            this.dgv_roles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_roles.Location = new System.Drawing.Point(77, 51);
            this.dgv_roles.Name = "dgv_roles";
            this.dgv_roles.Size = new System.Drawing.Size(438, 165);
            this.dgv_roles.TabIndex = 0;
            // 
            // tabPage_edit_roles
            // 
            this.tabPage_edit_roles.Controls.Add(this.btn_cancel_role);
            this.tabPage_edit_roles.Controls.Add(this.clb_roles);
            this.tabPage_edit_roles.Controls.Add(this.label30);
            this.tabPage_edit_roles.Controls.Add(this.btn_save_role_changes);
            this.tabPage_edit_roles.Controls.Add(this.lbl_choose_user);
            this.tabPage_edit_roles.Controls.Add(this.cmbx_select_user_role_edit);
            this.tabPage_edit_roles.Location = new System.Drawing.Point(140, 4);
            this.tabPage_edit_roles.Name = "tabPage_edit_roles";
            this.tabPage_edit_roles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_edit_roles.Size = new System.Drawing.Size(597, 527);
            this.tabPage_edit_roles.TabIndex = 1;
            this.tabPage_edit_roles.Text = "Edytuj uprawnienia";
            this.tabPage_edit_roles.UseVisualStyleBackColor = true;
            this.tabPage_edit_roles.Enter += new System.EventHandler(this.tabPage_edit_roles_Enter);
            // 
            // btn_cancel_role
            // 
            this.btn_cancel_role.Location = new System.Drawing.Point(51, 277);
            this.btn_cancel_role.Name = "btn_cancel_role";
            this.btn_cancel_role.Size = new System.Drawing.Size(92, 23);
            this.btn_cancel_role.TabIndex = 9;
            this.btn_cancel_role.Text = "Anuluj";
            this.btn_cancel_role.UseVisualStyleBackColor = true;
            this.btn_cancel_role.Click += new System.EventHandler(this.btn_cancel_role_Click);
            // 
            // clb_roles
            // 
            this.clb_roles.FormattingEnabled = true;
            this.clb_roles.Location = new System.Drawing.Point(51, 141);
            this.clb_roles.Name = "clb_roles";
            this.clb_roles.Size = new System.Drawing.Size(493, 94);
            this.clb_roles.TabIndex = 8;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(48, 313);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(327, 13);
            this.label30.TabIndex = 7;
            this.label30.Text = "// jak user posiada uprawnienie to checkbox ładuje się zaznaczony";
            // 
            // btn_save_role_changes
            // 
            this.btn_save_role_changes.Location = new System.Drawing.Point(175, 277);
            this.btn_save_role_changes.Name = "btn_save_role_changes";
            this.btn_save_role_changes.Size = new System.Drawing.Size(92, 23);
            this.btn_save_role_changes.TabIndex = 6;
            this.btn_save_role_changes.Text = "Zapisz";
            this.btn_save_role_changes.UseVisualStyleBackColor = true;
            this.btn_save_role_changes.Click += new System.EventHandler(this.btn_save_role_changes_Click);
            // 
            // lbl_choose_user
            // 
            this.lbl_choose_user.AutoSize = true;
            this.lbl_choose_user.Location = new System.Drawing.Point(48, 80);
            this.lbl_choose_user.Name = "lbl_choose_user";
            this.lbl_choose_user.Size = new System.Drawing.Size(107, 13);
            this.lbl_choose_user.TabIndex = 1;
            this.lbl_choose_user.Text = "Wybierz użytkownika";
            // 
            // cmbx_select_user_role_edit
            // 
            this.cmbx_select_user_role_edit.FormattingEnabled = true;
            this.cmbx_select_user_role_edit.Location = new System.Drawing.Point(51, 96);
            this.cmbx_select_user_role_edit.Name = "cmbx_select_user_role_edit";
            this.cmbx_select_user_role_edit.Size = new System.Drawing.Size(493, 21);
            this.cmbx_select_user_role_edit.TabIndex = 0;
            this.cmbx_select_user_role_edit.SelectedIndexChanged += new System.EventHandler(this.cmbx_select_user_role_edit_SelectedIndexChanged);
            // 
            // clb_add_user_role
            // 
            this.clb_add_user_role.FormattingEnabled = true;
            this.clb_add_user_role.Location = new System.Drawing.Point(310, 93);
            this.clb_add_user_role.Name = "clb_add_user_role";
            this.clb_add_user_role.Size = new System.Drawing.Size(212, 79);
            this.clb_add_user_role.TabIndex = 44;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(307, 67);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(219, 13);
            this.lbl_role.TabIndex = 45;
            this.lbl_role.Text = "Uprawnienie* (przynajmniej jedno wymagane)";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(911, 559);
            this.Controls.Add(this.dotNetBarTabControl_main_view);
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System magazynowy";
            this.dotNetBarTabControl_main_view.ResumeLayout(false);
            this.tabPage_overview.ResumeLayout(false);
            this.tabPage_overview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_user_list)).EndInit();
            this.tabPage_users.ResumeLayout(false);
            this.dotNetBarTabControl_manage_users.ResumeLayout(false);
            this.tabPage_add_user.ResumeLayout(false);
            this.tabPage_add_user.PerformLayout();
            this.grpbx_address.ResumeLayout(false);
            this.grpbx_address.PerformLayout();
            this.tabPage_edit_user.ResumeLayout(false);
            this.tabPage_edit_user.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_view_user.ResumeLayout(false);
            this.tabPage_view_user.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage_roles.ResumeLayout(false);
            this.dotNetBarTabControl_manage_roles.ResumeLayout(false);
            this.tabPage_roles_overview.ResumeLayout(false);
            this.tabPage_roles_overview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_users_perms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roles)).EndInit();
            this.tabPage_edit_roles.ResumeLayout(false);
            this.tabPage_edit_roles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControls.DotNetBarTabControl dotNetBarTabControl_main_view;
        private System.Windows.Forms.TabPage tabPage_users;
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
        private Button btn_forget;
        private Button btn_refresh;
        private DataGridView dvg_user_list;
        private TextBox tbx_search;
        private Button btn_search;
        private Button btn_show_forgotten;
        private TabPage tabPage_view_user;
        private Label label1;
        private ComboBox cmbx_gender_view;
        private Button btn_edit_from_view;
        private Label label18;
        private Label label19;
        private MaskedTextBox msktbx_phone_view;
        private MaskedTextBox msktbx_email_view;
        private Label label20;
        private Label label21;
        private DateTimePicker dtpckr_birthdate_view;
        private Label label22;
        private MaskedTextBox msktbx_pesel_view;
        private GroupBox groupBox2;
        private Label label23;
        private MaskedTextBox msktbx_locale_number_view;
        private MaskedTextBox msktbx_street_number_view;
        private MaskedTextBox msktbx_street_view;
        private MaskedTextBox msktbx_city_view;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private MaskedTextBox msktbx_user_surname_view;
        private MaskedTextBox msktbx_user_name_view;
        private Label label28;
        private MaskedTextBox msktbx_user_login_view;
        private Label label29;
        private Button btn_close_view;
        private MaskedTextBox msktbx_password;
        private Label lbl_password;
        private TabPage tabPage_roles;
        private TabControls.DotNetBarTabControl dotNetBarTabControl_manage_roles;
        private TabPage tabPage_roles_overview;
        private TabPage tabPage_edit_roles;
        private DataGridView dgv_roles;
        private Label lbl_choose_user;
        private ComboBox cmbx_select_user_role_edit;
        private Label label30;
        private Button btn_save_role_changes;
        private Label lbl_roles;
        private CheckedListBox clb_roles;
        private Button btn_cancel_role;
        private DataGridView dvg_users_perms;
        private Button btn_filter_perms;
        private ComboBox cmbx_permissions;
        private CheckedListBox clb_add_user_role;
        private Label lbl_role;
    }
}