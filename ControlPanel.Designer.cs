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
            this.components = new System.ComponentModel.Container();
            this.dgv_sale_basket = new System.Windows.Forms.DataGridView();
            this.btn_add_to_basket = new System.Windows.Forms.Button();
            this.lbl_history_date_from = new System.Windows.Forms.Label();
            this.tabControl_sales = new TabControls.DotNetBarTabControl();
            this.tabPage_register_sale = new System.Windows.Forms.TabPage();
            this.btn_cancel_sale = new System.Windows.Forms.Button();
            this.btn_remove_from_basket = new System.Windows.Forms.Button();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.tbx_sale_client_name = new System.Windows.Forms.TextBox();
            this.btn_register_sale = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.tbx_sale_quantity = new System.Windows.Forms.TextBox();
            this.cmbx_sale_product = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.dtp_sale_date = new System.Windows.Forms.DateTimePicker();
            this.label37 = new System.Windows.Forms.Label();
            this.tbx_sale_client_address = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.tabPage_sales_history = new System.Windows.Forms.TabPage();
            this.chk_sales_history_dates = new System.Windows.Forms.CheckBox();
            this.lbl_history_item = new System.Windows.Forms.Label();
            this.lbl_history_seller = new System.Windows.Forms.Label();
            this.lbl_history_buyer = new System.Windows.Forms.Label();
            this.lbl_history_date_to = new System.Windows.Forms.Label();
            this.dgv_sales_history = new System.Windows.Forms.DataGridView();
            this.btn_search_sales = new System.Windows.Forms.Button();
            this.tbx_history_item = new System.Windows.Forms.TextBox();
            this.tbx_history_seller = new System.Windows.Forms.TextBox();
            this.tbx_history_buyer = new System.Windows.Forms.TextBox();
            this.dtp_sales_history_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_sales_history_from = new System.Windows.Forms.DateTimePicker();
            this.tabPage_sale_details = new System.Windows.Forms.TabPage();
            this.lbl_detail_seller = new System.Windows.Forms.Label();
            this.lbl_detail_date = new System.Windows.Forms.Label();
            this.lbl_detail_address = new System.Windows.Forms.Label();
            this.lbl_detail_buyer = new System.Windows.Forms.Label();
            this.btn_close_details = new System.Windows.Forms.Button();
            this.dgv_sale_details = new System.Windows.Forms.DataGridView();
            this.tbx_detail_seller = new System.Windows.Forms.TextBox();
            this.tbx_detail_date = new System.Windows.Forms.TextBox();
            this.tbx_detail_address = new System.Windows.Forms.TextBox();
            this.tbx_detail_buyer = new System.Windows.Forms.TextBox();
            this.dotNetBarTabControl_main_view = new TabControls.DotNetBarTabControl();
            this.tabPage_my_profile = new System.Windows.Forms.TabPage();
            this.clb_profile_roles = new System.Windows.Forms.CheckedListBox();
            this.lbl_repeat_password = new System.Windows.Forms.Label();
            this.lbl_new_password = new System.Windows.Forms.Label();
            this.lbl_old_password = new System.Windows.Forms.Label();
            this.btn_change_password = new System.Windows.Forms.Button();
            this.tbx_profile_repeat_password = new System.Windows.Forms.TextBox();
            this.tbx_profile_new_password = new System.Windows.Forms.TextBox();
            this.tbx_profile_old_password = new System.Windows.Forms.TextBox();
            this.tbx_profile_email = new System.Windows.Forms.TextBox();
            this.tbx_profile_surname = new System.Windows.Forms.TextBox();
            this.tbx_profile_name = new System.Windows.Forms.TextBox();
            this.tbx_profile_login = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.tabPage_overview = new System.Windows.Forms.TabPage();
            this.lbl_search_user = new System.Windows.Forms.Label();
            this.btn_show_forgotten = new System.Windows.Forms.Button();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_forget = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dvg_user_list = new System.Windows.Forms.DataGridView();
            this.tabPage_users = new System.Windows.Forms.TabPage();
            this.dotNetBarTabControl_manage_users = new TabControls.DotNetBarTabControl();
            this.tabPage_add_user = new System.Windows.Forms.TabPage();
            this.lbl_role = new System.Windows.Forms.Label();
            this.clb_add_user_role = new System.Windows.Forms.CheckedListBox();
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
            this.lbl_postal_code = new System.Windows.Forms.Label();
            this.msktbx_postal_code = new System.Windows.Forms.MaskedTextBox();
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
            this.label69 = new System.Windows.Forms.Label();
            this.msktbx_postal_code_edit = new System.Windows.Forms.MaskedTextBox();
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
            this.dgv_users_perms = new System.Windows.Forms.DataGridView();
            this.lbl_roles = new System.Windows.Forms.Label();
            this.dgv_roles = new System.Windows.Forms.DataGridView();
            this.tabPage_edit_roles = new System.Windows.Forms.TabPage();
            this.btn_cancel_role = new System.Windows.Forms.Button();
            this.clb_roles = new System.Windows.Forms.CheckedListBox();
            this.btn_save_role_changes = new System.Windows.Forms.Button();
            this.lbl_choose_user = new System.Windows.Forms.Label();
            this.cmbx_select_user_role_edit = new System.Windows.Forms.ComboBox();
            this.tabPage_group_edit = new System.Windows.Forms.TabPage();
            this.lbl_roles_group_edit = new System.Windows.Forms.Label();
            this.lbl_users_group_edit = new System.Windows.Forms.Label();
            this.btn_group_edit_cancel = new System.Windows.Forms.Button();
            this.btn_group_edit_save = new System.Windows.Forms.Button();
            this.clb_roles_group_edit = new System.Windows.Forms.CheckedListBox();
            this.clb_users_group_edit = new System.Windows.Forms.CheckedListBox();
            this.tabPage_manage_warehouse = new System.Windows.Forms.TabPage();
            this.tabPage_items = new TabControls.DotNetBarTabControl();
            this.tabPage_Warehouse = new System.Windows.Forms.TabPage();
            this.btn_replenish_item = new System.Windows.Forms.Button();
            this.dtp_item_deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label63 = new System.Windows.Forms.Label();
            this.btn_change_category_vat = new System.Windows.Forms.Button();
            this.btn_change_item_vat = new System.Windows.Forms.Button();
            this.btn_search_items = new System.Windows.Forms.Button();
            this.dtp_history_date = new System.Windows.Forms.DateTimePicker();
            this.chk_use_history_date = new System.Windows.Forms.CheckBox();
            this.tbx_item_search = new System.Windows.Forms.TextBox();
            this.btn_delete_item = new System.Windows.Forms.Button();
            this.dgv_warehouse_items = new System.Windows.Forms.DataGridView();
            this.btn_register_item_cancel = new System.Windows.Forms.Button();
            this.btn_register_item_save = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.cmbx_item_vat = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.cmbx_item_unit = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.cmbx_item_type = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.tbx_item_description = new System.Windows.Forms.TextBox();
            this.tbx_item_supplier = new System.Windows.Forms.TextBox();
            this.tbx_item_price = new System.Windows.Forms.TextBox();
            this.tbx_item_quantity = new System.Windows.Forms.TextBox();
            this.tbx_item_name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label62 = new System.Windows.Forms.Label();
            this.btn_delete_item_type = new System.Windows.Forms.Button();
            this.tbx_item_type_name = new System.Windows.Forms.TextBox();
            this.btn_cancel_item_type = new System.Windows.Forms.Button();
            this.btn_add_item_type = new System.Windows.Forms.Button();
            this.dgv_item_types = new System.Windows.Forms.DataGridView();
            this.tabPage_Item_History = new System.Windows.Forms.TabPage();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.btn_history_close = new System.Windows.Forms.Button();
            this.btn_history_filter = new System.Windows.Forms.Button();
            this.tbx_history_employee = new System.Windows.Forms.TextBox();
            this.dtp_history_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_history_to = new System.Windows.Forms.DateTimePicker();
            this.chk_history_use_dates = new System.Windows.Forms.CheckBox();
            this.dgv_item_history = new System.Windows.Forms.DataGridView();
            this.tabPage_Delivery_Details = new System.Windows.Forms.TabPage();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.tbx_det_itemType = new System.Windows.Forms.TextBox();
            this.tbx_det_description = new System.Windows.Forms.TextBox();
            this.tbx_det_unit = new System.Windows.Forms.TextBox();
            this.btn_det_close = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.tbx_det_employee = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.tbx_det_sysDate = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.tbx_det_deliveryDate = new System.Windows.Forms.TextBox();
            this.tbx_det_vat = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.tbx_det_supplier = new System.Windows.Forms.TextBox();
            this.tbx_det_netPrice = new System.Windows.Forms.TextBox();
            this.tbx_det_quantity = new System.Windows.Forms.TextBox();
            this.tbx_det_itemName = new System.Windows.Forms.TextBox();
            this.tabPage_Vat_Change = new System.Windows.Forms.TabPage();
            this.label66 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.btn_vat_save = new System.Windows.Forms.Button();
            this.btn_vat_cancel = new System.Windows.Forms.Button();
            this.dtp_vat_date = new System.Windows.Forms.DateTimePicker();
            this.cmb_vat_category = new System.Windows.Forms.ComboBox();
            this.cmb_new_vat = new System.Windows.Forms.ComboBox();
            this.tbx_vat_item_name = new System.Windows.Forms.TextBox();
            this.lbl_vat_mode_title = new System.Windows.Forms.Label();
            this.tabPage_manage_sales = new System.Windows.Forms.TabPage();
            this.btn_logout = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbx_admin_password_reset = new System.Windows.Forms.TextBox();
            this.btn_admin_password_reset = new System.Windows.Forms.Button();
            this.lbl_edit_password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sale_basket)).BeginInit();
            this.tabControl_sales.SuspendLayout();
            this.tabPage_register_sale.SuspendLayout();
            this.tabPage_sales_history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales_history)).BeginInit();
            this.tabPage_sale_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sale_details)).BeginInit();
            this.dotNetBarTabControl_main_view.SuspendLayout();
            this.tabPage_my_profile.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users_perms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roles)).BeginInit();
            this.tabPage_edit_roles.SuspendLayout();
            this.tabPage_group_edit.SuspendLayout();
            this.tabPage_manage_warehouse.SuspendLayout();
            this.tabPage_items.SuspendLayout();
            this.tabPage_Warehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_warehouse_items)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item_types)).BeginInit();
            this.tabPage_Item_History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item_history)).BeginInit();
            this.tabPage_Delivery_Details.SuspendLayout();
            this.tabPage_Vat_Change.SuspendLayout();
            this.tabPage_manage_sales.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_sale_basket
            // 
            this.dgv_sale_basket.AllowUserToAddRows = false;
            this.dgv_sale_basket.Location = new System.Drawing.Point(335, 40);
            this.dgv_sale_basket.Name = "dgv_sale_basket";
            this.dgv_sale_basket.ReadOnly = true;
            this.dgv_sale_basket.Size = new System.Drawing.Size(268, 220);
            this.dgv_sale_basket.TabIndex = 12;
            // 
            // btn_add_to_basket
            // 
            this.btn_add_to_basket.Location = new System.Drawing.Point(94, 145);
            this.btn_add_to_basket.Name = "btn_add_to_basket";
            this.btn_add_to_basket.Size = new System.Drawing.Size(205, 23);
            this.btn_add_to_basket.TabIndex = 13;
            this.btn_add_to_basket.Text = "Dodaj towar do koszyka";
            this.btn_add_to_basket.UseVisualStyleBackColor = true;
            this.btn_add_to_basket.Click += new System.EventHandler(this.btn_add_to_basket_Click);
            // 
            // lbl_history_date_from
            // 
            this.lbl_history_date_from.Location = new System.Drawing.Point(22, 11);
            this.lbl_history_date_from.Name = "lbl_history_date_from";
            this.lbl_history_date_from.Size = new System.Drawing.Size(26, 23);
            this.lbl_history_date_from.TabIndex = 4;
            this.lbl_history_date_from.Text = "Od:";
            // 
            // tabControl_sales
            // 
            this.tabControl_sales.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl_sales.Controls.Add(this.tabPage_register_sale);
            this.tabControl_sales.Controls.Add(this.tabPage_sales_history);
            this.tabControl_sales.Controls.Add(this.tabPage_sale_details);
            this.tabControl_sales.ItemSize = new System.Drawing.Size(44, 136);
            this.tabControl_sales.Location = new System.Drawing.Point(0, -4);
            this.tabControl_sales.Multiline = true;
            this.tabControl_sales.Name = "tabControl_sales";
            this.tabControl_sales.SelectedIndex = 0;
            this.tabControl_sales.Size = new System.Drawing.Size(767, 549);
            this.tabControl_sales.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_sales.TabIndex = 12;
            this.tabControl_sales.SelectedIndexChanged += new System.EventHandler(this.tabControl_sales_SelectedIndexChanged);
            // 
            // tabPage_register_sale
            // 
            this.tabPage_register_sale.Controls.Add(this.btn_cancel_sale);
            this.tabPage_register_sale.Controls.Add(this.btn_remove_from_basket);
            this.tabPage_register_sale.Controls.Add(this.label68);
            this.tabPage_register_sale.Controls.Add(this.label67);
            this.tabPage_register_sale.Controls.Add(this.tbx_sale_client_name);
            this.tabPage_register_sale.Controls.Add(this.btn_register_sale);
            this.tabPage_register_sale.Controls.Add(this.label30);
            this.tabPage_register_sale.Controls.Add(this.tbx_sale_quantity);
            this.tabPage_register_sale.Controls.Add(this.cmbx_sale_product);
            this.tabPage_register_sale.Controls.Add(this.label38);
            this.tabPage_register_sale.Controls.Add(this.dtp_sale_date);
            this.tabPage_register_sale.Controls.Add(this.label37);
            this.tabPage_register_sale.Controls.Add(this.tbx_sale_client_address);
            this.tabPage_register_sale.Controls.Add(this.label32);
            this.tabPage_register_sale.Controls.Add(this.label36);
            this.tabPage_register_sale.Controls.Add(this.dgv_sale_basket);
            this.tabPage_register_sale.Controls.Add(this.btn_add_to_basket);
            this.tabPage_register_sale.Location = new System.Drawing.Point(140, 4);
            this.tabPage_register_sale.Name = "tabPage_register_sale";
            this.tabPage_register_sale.Size = new System.Drawing.Size(623, 541);
            this.tabPage_register_sale.TabIndex = 0;
            this.tabPage_register_sale.Text = "Rejestracja sprzedaży";
            this.tabPage_register_sale.UseVisualStyleBackColor = true;
            // 
            // btn_cancel_sale
            // 
            this.btn_cancel_sale.Location = new System.Drawing.Point(528, 500);
            this.btn_cancel_sale.Name = "btn_cancel_sale";
            this.btn_cancel_sale.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_sale.TabIndex = 16;
            this.btn_cancel_sale.Text = "Anuluj";
            this.btn_cancel_sale.UseVisualStyleBackColor = true;
            this.btn_cancel_sale.Click += new System.EventHandler(this.btn_cancel_sale_Click);
            // 
            // btn_remove_from_basket
            // 
            this.btn_remove_from_basket.Location = new System.Drawing.Point(94, 175);
            this.btn_remove_from_basket.Name = "btn_remove_from_basket";
            this.btn_remove_from_basket.Size = new System.Drawing.Size(205, 23);
            this.btn_remove_from_basket.TabIndex = 15;
            this.btn_remove_from_basket.Text = "Usuń towar z koszyka";
            this.btn_remove_from_basket.UseVisualStyleBackColor = true;
            this.btn_remove_from_basket.Click += new System.EventHandler(this.btn_remove_from_basket_Click);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(335, 21);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(41, 13);
            this.label68.TabIndex = 14;
            this.label68.Text = "Koszyk";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(2, 119);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(83, 13);
            this.label67.TabIndex = 11;
            this.label67.Text = "Data sprzedaży:";
            // 
            // tbx_sale_client_name
            // 
            this.tbx_sale_client_name.Location = new System.Drawing.Point(94, 14);
            this.tbx_sale_client_name.Name = "tbx_sale_client_name";
            this.tbx_sale_client_name.Size = new System.Drawing.Size(205, 20);
            this.tbx_sale_client_name.TabIndex = 0;
            // 
            // btn_register_sale
            // 
            this.btn_register_sale.Location = new System.Drawing.Point(16, 500);
            this.btn_register_sale.Name = "btn_register_sale";
            this.btn_register_sale.Size = new System.Drawing.Size(87, 23);
            this.btn_register_sale.TabIndex = 1;
            this.btn_register_sale.Text = "Zapisz";
            this.btn_register_sale.Click += new System.EventHandler(this.btn_register_sale_Click);
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(13, 40);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(75, 23);
            this.label30.TabIndex = 2;
            this.label30.Text = "Adres Klienta:";
            // 
            // tbx_sale_quantity
            // 
            this.tbx_sale_quantity.Location = new System.Drawing.Point(94, 93);
            this.tbx_sale_quantity.Name = "tbx_sale_quantity";
            this.tbx_sale_quantity.Size = new System.Drawing.Size(205, 20);
            this.tbx_sale_quantity.TabIndex = 3;
            // 
            // cmbx_sale_product
            // 
            this.cmbx_sale_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_sale_product.Location = new System.Drawing.Point(94, 66);
            this.cmbx_sale_product.Name = "cmbx_sale_product";
            this.cmbx_sale_product.Size = new System.Drawing.Size(205, 21);
            this.cmbx_sale_product.TabIndex = 4;
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(10, 40);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(75, 23);
            this.label38.TabIndex = 5;
            this.label38.Text = "Adres Klienta:";
            // 
            // dtp_sale_date
            // 
            this.dtp_sale_date.Location = new System.Drawing.Point(94, 119);
            this.dtp_sale_date.Name = "dtp_sale_date";
            this.dtp_sale_date.Size = new System.Drawing.Size(205, 20);
            this.dtp_sale_date.TabIndex = 6;
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(49, 96);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(36, 23);
            this.label37.TabIndex = 7;
            this.label37.Text = "Ilość:";
            // 
            // tbx_sale_client_address
            // 
            this.tbx_sale_client_address.Location = new System.Drawing.Point(94, 40);
            this.tbx_sale_client_address.Name = "tbx_sale_client_address";
            this.tbx_sale_client_address.Size = new System.Drawing.Size(205, 20);
            this.tbx_sale_client_address.TabIndex = 8;
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(41, 69);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(44, 23);
            this.label32.TabIndex = 9;
            this.label32.Text = "Towar:";
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(10, 14);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(78, 23);
            this.label36.TabIndex = 10;
            this.label36.Text = "Nazwa Klienta:";
            // 
            // tabPage_sales_history
            // 
            this.tabPage_sales_history.Controls.Add(this.chk_sales_history_dates);
            this.tabPage_sales_history.Controls.Add(this.lbl_history_item);
            this.tabPage_sales_history.Controls.Add(this.lbl_history_seller);
            this.tabPage_sales_history.Controls.Add(this.lbl_history_buyer);
            this.tabPage_sales_history.Controls.Add(this.lbl_history_date_to);
            this.tabPage_sales_history.Controls.Add(this.lbl_history_date_from);
            this.tabPage_sales_history.Controls.Add(this.dgv_sales_history);
            this.tabPage_sales_history.Controls.Add(this.btn_search_sales);
            this.tabPage_sales_history.Controls.Add(this.tbx_history_item);
            this.tabPage_sales_history.Controls.Add(this.tbx_history_seller);
            this.tabPage_sales_history.Controls.Add(this.tbx_history_buyer);
            this.tabPage_sales_history.Controls.Add(this.dtp_sales_history_to);
            this.tabPage_sales_history.Controls.Add(this.dtp_sales_history_from);
            this.tabPage_sales_history.Location = new System.Drawing.Point(140, 4);
            this.tabPage_sales_history.Name = "tabPage_sales_history";
            this.tabPage_sales_history.Size = new System.Drawing.Size(623, 541);
            this.tabPage_sales_history.TabIndex = 1;
            this.tabPage_sales_history.Text = "Historia sprzedaży";
            this.tabPage_sales_history.UseVisualStyleBackColor = true;
            // 
            // chk_sales_history_dates
            // 
            this.chk_sales_history_dates.AutoSize = true;
            this.chk_sales_history_dates.Location = new System.Drawing.Point(490, 14);
            this.chk_sales_history_dates.Name = "chk_sales_history_dates";
            this.chk_sales_history_dates.Size = new System.Drawing.Size(118, 17);
            this.chk_sales_history_dates.TabIndex = 12;
            this.chk_sales_history_dates.Text = "Filtrować po dacie?";
            this.chk_sales_history_dates.UseVisualStyleBackColor = true;
            this.chk_sales_history_dates.CheckedChanged += new System.EventHandler(this.chk_sales_history_dates_CheckedChanged);
            // 
            // lbl_history_item
            // 
            this.lbl_history_item.Location = new System.Drawing.Point(369, 61);
            this.lbl_history_item.Name = "lbl_history_item";
            this.lbl_history_item.Size = new System.Drawing.Size(43, 23);
            this.lbl_history_item.TabIndex = 0;
            this.lbl_history_item.Text = "Towar:";
            // 
            // lbl_history_seller
            // 
            this.lbl_history_seller.Location = new System.Drawing.Point(187, 58);
            this.lbl_history_seller.Name = "lbl_history_seller";
            this.lbl_history_seller.Size = new System.Drawing.Size(72, 23);
            this.lbl_history_seller.TabIndex = 1;
            this.lbl_history_seller.Text = "Sprzedawca:";
            // 
            // lbl_history_buyer
            // 
            this.lbl_history_buyer.Location = new System.Drawing.Point(22, 58);
            this.lbl_history_buyer.Name = "lbl_history_buyer";
            this.lbl_history_buyer.Size = new System.Drawing.Size(56, 23);
            this.lbl_history_buyer.TabIndex = 2;
            this.lbl_history_buyer.Text = "Nabywca:";
            // 
            // lbl_history_date_to
            // 
            this.lbl_history_date_to.Location = new System.Drawing.Point(258, 14);
            this.lbl_history_date_to.Name = "lbl_history_date_to";
            this.lbl_history_date_to.Size = new System.Drawing.Size(25, 23);
            this.lbl_history_date_to.TabIndex = 3;
            this.lbl_history_date_to.Text = "Do:";
            // 
            // dgv_sales_history
            // 
            this.dgv_sales_history.AllowUserToAddRows = false;
            this.dgv_sales_history.AllowUserToDeleteRows = false;
            this.dgv_sales_history.AllowUserToResizeRows = false;
            this.dgv_sales_history.Location = new System.Drawing.Point(31, 88);
            this.dgv_sales_history.Name = "dgv_sales_history";
            this.dgv_sales_history.ReadOnly = true;
            this.dgv_sales_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sales_history.Size = new System.Drawing.Size(577, 420);
            this.dgv_sales_history.TabIndex = 5;
            this.dgv_sales_history.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sales_history_CellDoubleClick);
            // 
            // btn_search_sales
            // 
            this.btn_search_sales.Location = new System.Drawing.Point(520, 52);
            this.btn_search_sales.Name = "btn_search_sales";
            this.btn_search_sales.Size = new System.Drawing.Size(100, 30);
            this.btn_search_sales.TabIndex = 6;
            this.btn_search_sales.Text = "Wyszukaj";
            this.btn_search_sales.UseVisualStyleBackColor = true;
            this.btn_search_sales.Click += new System.EventHandler(this.btn_search_sales_Click);
            // 
            // tbx_history_item
            // 
            this.tbx_history_item.Location = new System.Drawing.Point(414, 58);
            this.tbx_history_item.Name = "tbx_history_item";
            this.tbx_history_item.Size = new System.Drawing.Size(100, 20);
            this.tbx_history_item.TabIndex = 7;
            // 
            // tbx_history_seller
            // 
            this.tbx_history_seller.Location = new System.Drawing.Point(261, 58);
            this.tbx_history_seller.Name = "tbx_history_seller";
            this.tbx_history_seller.Size = new System.Drawing.Size(100, 20);
            this.tbx_history_seller.TabIndex = 8;
            // 
            // tbx_history_buyer
            // 
            this.tbx_history_buyer.Location = new System.Drawing.Point(84, 55);
            this.tbx_history_buyer.Name = "tbx_history_buyer";
            this.tbx_history_buyer.Size = new System.Drawing.Size(100, 20);
            this.tbx_history_buyer.TabIndex = 9;
            // 
            // dtp_sales_history_to
            // 
            this.dtp_sales_history_to.Location = new System.Drawing.Point(283, 11);
            this.dtp_sales_history_to.Name = "dtp_sales_history_to";
            this.dtp_sales_history_to.Size = new System.Drawing.Size(200, 20);
            this.dtp_sales_history_to.TabIndex = 10;
            // 
            // dtp_sales_history_from
            // 
            this.dtp_sales_history_from.Location = new System.Drawing.Point(46, 11);
            this.dtp_sales_history_from.Name = "dtp_sales_history_from";
            this.dtp_sales_history_from.Size = new System.Drawing.Size(200, 20);
            this.dtp_sales_history_from.TabIndex = 11;
            // 
            // tabPage_sale_details
            // 
            this.tabPage_sale_details.Controls.Add(this.lbl_detail_seller);
            this.tabPage_sale_details.Controls.Add(this.lbl_detail_date);
            this.tabPage_sale_details.Controls.Add(this.lbl_detail_address);
            this.tabPage_sale_details.Controls.Add(this.lbl_detail_buyer);
            this.tabPage_sale_details.Controls.Add(this.btn_close_details);
            this.tabPage_sale_details.Controls.Add(this.dgv_sale_details);
            this.tabPage_sale_details.Controls.Add(this.tbx_detail_seller);
            this.tabPage_sale_details.Controls.Add(this.tbx_detail_date);
            this.tabPage_sale_details.Controls.Add(this.tbx_detail_address);
            this.tabPage_sale_details.Controls.Add(this.tbx_detail_buyer);
            this.tabPage_sale_details.Location = new System.Drawing.Point(140, 4);
            this.tabPage_sale_details.Name = "tabPage_sale_details";
            this.tabPage_sale_details.Size = new System.Drawing.Size(623, 541);
            this.tabPage_sale_details.TabIndex = 2;
            this.tabPage_sale_details.Text = "Szczegóły sprzedaży";
            this.tabPage_sale_details.UseVisualStyleBackColor = true;
            // 
            // lbl_detail_seller
            // 
            this.lbl_detail_seller.Location = new System.Drawing.Point(184, 416);
            this.lbl_detail_seller.Name = "lbl_detail_seller";
            this.lbl_detail_seller.Size = new System.Drawing.Size(70, 23);
            this.lbl_detail_seller.TabIndex = 0;
            this.lbl_detail_seller.Text = "Sprzedawca:";
            // 
            // lbl_detail_date
            // 
            this.lbl_detail_date.Location = new System.Drawing.Point(216, 379);
            this.lbl_detail_date.Name = "lbl_detail_date";
            this.lbl_detail_date.Size = new System.Drawing.Size(38, 23);
            this.lbl_detail_date.TabIndex = 1;
            this.lbl_detail_date.Text = "Data:";
            // 
            // lbl_detail_address
            // 
            this.lbl_detail_address.Location = new System.Drawing.Point(216, 344);
            this.lbl_detail_address.Name = "lbl_detail_address";
            this.lbl_detail_address.Size = new System.Drawing.Size(38, 23);
            this.lbl_detail_address.TabIndex = 2;
            this.lbl_detail_address.Text = "Adres:";
            // 
            // lbl_detail_buyer
            // 
            this.lbl_detail_buyer.Location = new System.Drawing.Point(198, 315);
            this.lbl_detail_buyer.Name = "lbl_detail_buyer";
            this.lbl_detail_buyer.Size = new System.Drawing.Size(56, 23);
            this.lbl_detail_buyer.TabIndex = 3;
            this.lbl_detail_buyer.Text = "Nabywca:";
            // 
            // btn_close_details
            // 
            this.btn_close_details.Location = new System.Drawing.Point(260, 456);
            this.btn_close_details.Name = "btn_close_details";
            this.btn_close_details.Size = new System.Drawing.Size(100, 30);
            this.btn_close_details.TabIndex = 4;
            this.btn_close_details.Text = "Zamknij";
            this.btn_close_details.UseVisualStyleBackColor = true;
            this.btn_close_details.Click += new System.EventHandler(this.btn_close_details_Click);
            // 
            // dgv_sale_details
            // 
            this.dgv_sale_details.AllowUserToAddRows = false;
            this.dgv_sale_details.AllowUserToDeleteRows = false;
            this.dgv_sale_details.AllowUserToResizeRows = false;
            this.dgv_sale_details.Location = new System.Drawing.Point(12, 12);
            this.dgv_sale_details.Name = "dgv_sale_details";
            this.dgv_sale_details.ReadOnly = true;
            this.dgv_sale_details.Size = new System.Drawing.Size(597, 294);
            this.dgv_sale_details.TabIndex = 5;
            // 
            // tbx_detail_seller
            // 
            this.tbx_detail_seller.Location = new System.Drawing.Point(260, 413);
            this.tbx_detail_seller.Name = "tbx_detail_seller";
            this.tbx_detail_seller.ReadOnly = true;
            this.tbx_detail_seller.Size = new System.Drawing.Size(150, 20);
            this.tbx_detail_seller.TabIndex = 6;
            // 
            // tbx_detail_date
            // 
            this.tbx_detail_date.Location = new System.Drawing.Point(260, 376);
            this.tbx_detail_date.Name = "tbx_detail_date";
            this.tbx_detail_date.ReadOnly = true;
            this.tbx_detail_date.Size = new System.Drawing.Size(150, 20);
            this.tbx_detail_date.TabIndex = 7;
            // 
            // tbx_detail_address
            // 
            this.tbx_detail_address.Location = new System.Drawing.Point(260, 341);
            this.tbx_detail_address.Name = "tbx_detail_address";
            this.tbx_detail_address.ReadOnly = true;
            this.tbx_detail_address.Size = new System.Drawing.Size(150, 20);
            this.tbx_detail_address.TabIndex = 8;
            // 
            // tbx_detail_buyer
            // 
            this.tbx_detail_buyer.Location = new System.Drawing.Point(260, 312);
            this.tbx_detail_buyer.Name = "tbx_detail_buyer";
            this.tbx_detail_buyer.ReadOnly = true;
            this.tbx_detail_buyer.Size = new System.Drawing.Size(150, 20);
            this.tbx_detail_buyer.TabIndex = 9;
            // 
            // dotNetBarTabControl_main_view
            // 
            this.dotNetBarTabControl_main_view.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.dotNetBarTabControl_main_view.Controls.Add(this.tabPage_my_profile);
            this.dotNetBarTabControl_main_view.Controls.Add(this.tabPage_overview);
            this.dotNetBarTabControl_main_view.Controls.Add(this.tabPage_users);
            this.dotNetBarTabControl_main_view.Controls.Add(this.tabPage_roles);
            this.dotNetBarTabControl_main_view.Controls.Add(this.tabPage_manage_warehouse);
            this.dotNetBarTabControl_main_view.Controls.Add(this.tabPage_manage_sales);
            this.dotNetBarTabControl_main_view.ItemSize = new System.Drawing.Size(44, 142);
            this.dotNetBarTabControl_main_view.Location = new System.Drawing.Point(12, 12);
            this.dotNetBarTabControl_main_view.Multiline = true;
            this.dotNetBarTabControl_main_view.Name = "dotNetBarTabControl_main_view";
            this.dotNetBarTabControl_main_view.SelectedIndex = 0;
            this.dotNetBarTabControl_main_view.Size = new System.Drawing.Size(913, 549);
            this.dotNetBarTabControl_main_view.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.dotNetBarTabControl_main_view.TabIndex = 2;
            this.dotNetBarTabControl_main_view.SelectedIndexChanged += new System.EventHandler(this.dotNetBarTabControl_main_view_SelectedIndexChanged);
            // 
            // tabPage_my_profile
            // 
            this.tabPage_my_profile.Controls.Add(this.clb_profile_roles);
            this.tabPage_my_profile.Controls.Add(this.lbl_repeat_password);
            this.tabPage_my_profile.Controls.Add(this.lbl_new_password);
            this.tabPage_my_profile.Controls.Add(this.lbl_old_password);
            this.tabPage_my_profile.Controls.Add(this.btn_change_password);
            this.tabPage_my_profile.Controls.Add(this.tbx_profile_repeat_password);
            this.tabPage_my_profile.Controls.Add(this.tbx_profile_new_password);
            this.tabPage_my_profile.Controls.Add(this.tbx_profile_old_password);
            this.tabPage_my_profile.Controls.Add(this.tbx_profile_email);
            this.tabPage_my_profile.Controls.Add(this.tbx_profile_surname);
            this.tabPage_my_profile.Controls.Add(this.tbx_profile_name);
            this.tabPage_my_profile.Controls.Add(this.tbx_profile_login);
            this.tabPage_my_profile.Controls.Add(this.label31);
            this.tabPage_my_profile.Controls.Add(this.label33);
            this.tabPage_my_profile.Controls.Add(this.label34);
            this.tabPage_my_profile.Controls.Add(this.label35);
            this.tabPage_my_profile.Location = new System.Drawing.Point(146, 4);
            this.tabPage_my_profile.Name = "tabPage_my_profile";
            this.tabPage_my_profile.Size = new System.Drawing.Size(763, 541);
            this.tabPage_my_profile.TabIndex = 3;
            this.tabPage_my_profile.Text = "Mój profil";
            this.tabPage_my_profile.UseVisualStyleBackColor = true;
            // 
            // clb_profile_roles
            // 
            this.clb_profile_roles.FormattingEnabled = true;
            this.clb_profile_roles.Location = new System.Drawing.Point(280, 204);
            this.clb_profile_roles.Name = "clb_profile_roles";
            this.clb_profile_roles.Size = new System.Drawing.Size(259, 94);
            this.clb_profile_roles.TabIndex = 59;
            // 
            // lbl_repeat_password
            // 
            this.lbl_repeat_password.AutoSize = true;
            this.lbl_repeat_password.Location = new System.Drawing.Point(268, 412);
            this.lbl_repeat_password.Name = "lbl_repeat_password";
            this.lbl_repeat_password.Size = new System.Drawing.Size(69, 13);
            this.lbl_repeat_password.TabIndex = 58;
            this.lbl_repeat_password.Text = "ponów hasło";
            // 
            // lbl_new_password
            // 
            this.lbl_new_password.AutoSize = true;
            this.lbl_new_password.Location = new System.Drawing.Point(274, 372);
            this.lbl_new_password.Name = "lbl_new_password";
            this.lbl_new_password.Size = new System.Drawing.Size(63, 13);
            this.lbl_new_password.TabIndex = 57;
            this.lbl_new_password.Text = "nowe hasło";
            // 
            // lbl_old_password
            // 
            this.lbl_old_password.AutoSize = true;
            this.lbl_old_password.Location = new System.Drawing.Point(277, 334);
            this.lbl_old_password.Name = "lbl_old_password";
            this.lbl_old_password.Size = new System.Drawing.Size(60, 13);
            this.lbl_old_password.TabIndex = 56;
            this.lbl_old_password.Text = "stare hasło";
            // 
            // btn_change_password
            // 
            this.btn_change_password.Location = new System.Drawing.Point(344, 448);
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.Size = new System.Drawing.Size(195, 23);
            this.btn_change_password.TabIndex = 55;
            this.btn_change_password.Text = "Zmień hasło";
            this.btn_change_password.UseVisualStyleBackColor = true;
            this.btn_change_password.Click += new System.EventHandler(this.btn_change_password_Click);
            // 
            // tbx_profile_repeat_password
            // 
            this.tbx_profile_repeat_password.Location = new System.Drawing.Point(345, 409);
            this.tbx_profile_repeat_password.Name = "tbx_profile_repeat_password";
            this.tbx_profile_repeat_password.PasswordChar = '*';
            this.tbx_profile_repeat_password.Size = new System.Drawing.Size(194, 20);
            this.tbx_profile_repeat_password.TabIndex = 54;
            // 
            // tbx_profile_new_password
            // 
            this.tbx_profile_new_password.Location = new System.Drawing.Point(344, 369);
            this.tbx_profile_new_password.Name = "tbx_profile_new_password";
            this.tbx_profile_new_password.PasswordChar = '*';
            this.tbx_profile_new_password.Size = new System.Drawing.Size(194, 20);
            this.tbx_profile_new_password.TabIndex = 53;
            // 
            // tbx_profile_old_password
            // 
            this.tbx_profile_old_password.Location = new System.Drawing.Point(344, 331);
            this.tbx_profile_old_password.Name = "tbx_profile_old_password";
            this.tbx_profile_old_password.PasswordChar = '*';
            this.tbx_profile_old_password.Size = new System.Drawing.Size(194, 20);
            this.tbx_profile_old_password.TabIndex = 52;
            // 
            // tbx_profile_email
            // 
            this.tbx_profile_email.Location = new System.Drawing.Point(344, 143);
            this.tbx_profile_email.Name = "tbx_profile_email";
            this.tbx_profile_email.ReadOnly = true;
            this.tbx_profile_email.Size = new System.Drawing.Size(195, 20);
            this.tbx_profile_email.TabIndex = 51;
            // 
            // tbx_profile_surname
            // 
            this.tbx_profile_surname.Location = new System.Drawing.Point(344, 114);
            this.tbx_profile_surname.Name = "tbx_profile_surname";
            this.tbx_profile_surname.ReadOnly = true;
            this.tbx_profile_surname.Size = new System.Drawing.Size(195, 20);
            this.tbx_profile_surname.TabIndex = 50;
            // 
            // tbx_profile_name
            // 
            this.tbx_profile_name.Location = new System.Drawing.Point(344, 81);
            this.tbx_profile_name.Name = "tbx_profile_name";
            this.tbx_profile_name.ReadOnly = true;
            this.tbx_profile_name.Size = new System.Drawing.Size(195, 20);
            this.tbx_profile_name.TabIndex = 49;
            // 
            // tbx_profile_login
            // 
            this.tbx_profile_login.Location = new System.Drawing.Point(344, 48);
            this.tbx_profile_login.Name = "tbx_profile_login";
            this.tbx_profile_login.ReadOnly = true;
            this.tbx_profile_login.Size = new System.Drawing.Size(195, 20);
            this.tbx_profile_login.TabIndex = 48;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(269, 146);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(68, 13);
            this.label31.TabIndex = 47;
            this.label31.Text = "Adres e-mail*";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(280, 117);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(57, 13);
            this.label33.TabIndex = 44;
            this.label33.Text = "Nazwisko*";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(307, 84);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(30, 13);
            this.label34.TabIndex = 41;
            this.label34.Text = "Imię*";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(175, 51);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(162, 13);
            this.label35.TabIndex = 39;
            this.label35.Text = "Identyfikator użytkownika - login*";
            // 
            // tabPage_overview
            // 
            this.tabPage_overview.Controls.Add(this.lbl_search_user);
            this.tabPage_overview.Controls.Add(this.btn_show_forgotten);
            this.tabPage_overview.Controls.Add(this.tbx_search);
            this.tabPage_overview.Controls.Add(this.btn_search);
            this.tabPage_overview.Controls.Add(this.btn_forget);
            this.tabPage_overview.Controls.Add(this.btn_refresh);
            this.tabPage_overview.Controls.Add(this.dvg_user_list);
            this.tabPage_overview.Location = new System.Drawing.Point(146, 4);
            this.tabPage_overview.Name = "tabPage_overview";
            this.tabPage_overview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_overview.Size = new System.Drawing.Size(763, 541);
            this.tabPage_overview.TabIndex = 1;
            this.tabPage_overview.Text = "Przegląd";
            this.tabPage_overview.UseVisualStyleBackColor = true;
            // 
            // lbl_search_user
            // 
            this.lbl_search_user.AutoSize = true;
            this.lbl_search_user.Location = new System.Drawing.Point(131, 53);
            this.lbl_search_user.Name = "lbl_search_user";
            this.lbl_search_user.Size = new System.Drawing.Size(281, 13);
            this.lbl_search_user.TabIndex = 10;
            this.lbl_search_user.Text = "Wyszukaj użytkownika podając imię, nazwisko lub PESEL";
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
            this.tabPage_users.Size = new System.Drawing.Size(763, 541);
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
            this.dotNetBarTabControl_manage_users.Size = new System.Drawing.Size(767, 549);
            this.dotNetBarTabControl_manage_users.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.dotNetBarTabControl_manage_users.TabIndex = 0;
            this.dotNetBarTabControl_manage_users.SelectedIndexChanged += new System.EventHandler(this.dotNetBarTabControl_manage_users_SelectedIndexChanged);
            // 
            // tabPage_add_user
            // 
            this.tabPage_add_user.Controls.Add(this.lbl_role);
            this.tabPage_add_user.Controls.Add(this.clb_add_user_role);
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
            this.tabPage_add_user.Size = new System.Drawing.Size(623, 541);
            this.tabPage_add_user.TabIndex = 0;
            this.tabPage_add_user.Text = "Dodaj użytkownika";
            this.tabPage_add_user.UseVisualStyleBackColor = true;
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
            // clb_add_user_role
            // 
            this.clb_add_user_role.FormattingEnabled = true;
            this.clb_add_user_role.Location = new System.Drawing.Point(310, 93);
            this.clb_add_user_role.Name = "clb_add_user_role";
            this.clb_add_user_role.Size = new System.Drawing.Size(212, 79);
            this.clb_add_user_role.TabIndex = 44;
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
            this.cmbx_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.lbl_birthdate.Location = new System.Drawing.Point(156, 263);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(83, 13);
            this.lbl_birthdate.TabIndex = 29;
            this.lbl_birthdate.Text = "Data urodzenia*\r\n";
            // 
            // dtpckr_birthdate
            // 
            this.dtpckr_birthdate.Location = new System.Drawing.Point(241, 260);
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
            this.grpbx_address.Controls.Add(this.lbl_postal_code);
            this.grpbx_address.Controls.Add(this.msktbx_postal_code);
            this.grpbx_address.Controls.Add(this.lbl_street_number);
            this.grpbx_address.Controls.Add(this.msktbx_locale_number);
            this.grpbx_address.Controls.Add(this.msktbx_street_number);
            this.grpbx_address.Controls.Add(this.msktbx_street);
            this.grpbx_address.Controls.Add(this.msktbx_city);
            this.grpbx_address.Controls.Add(this.lbl_locale_number);
            this.grpbx_address.Controls.Add(this.lbl_street);
            this.grpbx_address.Controls.Add(this.lbl_city);
            this.grpbx_address.Location = new System.Drawing.Point(149, 286);
            this.grpbx_address.Name = "grpbx_address";
            this.grpbx_address.Size = new System.Drawing.Size(292, 175);
            this.grpbx_address.TabIndex = 25;
            this.grpbx_address.TabStop = false;
            this.grpbx_address.Text = "Adres";
            // 
            // lbl_postal_code
            // 
            this.lbl_postal_code.AutoSize = true;
            this.lbl_postal_code.Location = new System.Drawing.Point(13, 48);
            this.lbl_postal_code.Name = "lbl_postal_code";
            this.lbl_postal_code.Size = new System.Drawing.Size(78, 13);
            this.lbl_postal_code.TabIndex = 47;
            this.lbl_postal_code.Text = "Kod pocztowy*";
            // 
            // msktbx_postal_code
            // 
            this.msktbx_postal_code.Location = new System.Drawing.Point(92, 45);
            this.msktbx_postal_code.Mask = "00-999";
            this.msktbx_postal_code.Name = "msktbx_postal_code";
            this.msktbx_postal_code.Size = new System.Drawing.Size(178, 20);
            this.msktbx_postal_code.TabIndex = 46;
            // 
            // lbl_street_number
            // 
            this.lbl_street_number.AutoSize = true;
            this.lbl_street_number.Location = new System.Drawing.Point(13, 119);
            this.lbl_street_number.Name = "lbl_street_number";
            this.lbl_street_number.Size = new System.Drawing.Size(77, 13);
            this.lbl_street_number.TabIndex = 7;
            this.lbl_street_number.Text = "Numer posesji*";
            // 
            // msktbx_locale_number
            // 
            this.msktbx_locale_number.Location = new System.Drawing.Point(92, 149);
            this.msktbx_locale_number.Name = "msktbx_locale_number";
            this.msktbx_locale_number.Size = new System.Drawing.Size(178, 20);
            this.msktbx_locale_number.TabIndex = 6;
            // 
            // msktbx_street_number
            // 
            this.msktbx_street_number.Location = new System.Drawing.Point(92, 116);
            this.msktbx_street_number.Name = "msktbx_street_number";
            this.msktbx_street_number.Size = new System.Drawing.Size(178, 20);
            this.msktbx_street_number.TabIndex = 5;
            // 
            // msktbx_street
            // 
            this.msktbx_street.Location = new System.Drawing.Point(92, 83);
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
            this.lbl_locale_number.Location = new System.Drawing.Point(17, 152);
            this.lbl_locale_number.Name = "lbl_locale_number";
            this.lbl_locale_number.Size = new System.Drawing.Size(69, 13);
            this.lbl_locale_number.TabIndex = 2;
            this.lbl_locale_number.Text = "Numer lokalu";
            // 
            // lbl_street
            // 
            this.lbl_street.AutoSize = true;
            this.lbl_street.Location = new System.Drawing.Point(55, 86);
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
            this.tabPage_edit_user.Controls.Add(this.lbl_edit_password);
            this.tabPage_edit_user.Controls.Add(this.btn_admin_password_reset);
            this.tabPage_edit_user.Controls.Add(this.tbx_admin_password_reset);
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
            this.tabPage_edit_user.Size = new System.Drawing.Size(623, 541);
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
            this.cmbx_select_user_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbx_gender_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.groupBox1.Controls.Add(this.label69);
            this.groupBox1.Controls.Add(this.msktbx_postal_code_edit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.msktbx_locale_number_edit);
            this.groupBox1.Controls.Add(this.msktbx_street_number_edit);
            this.groupBox1.Controls.Add(this.msktbx_street_edit);
            this.groupBox1.Controls.Add(this.msktbx_city_edit);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(192, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 166);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adres";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(12, 48);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(78, 13);
            this.label69.TabIndex = 49;
            this.label69.Text = "Kod pocztowy*";
            // 
            // msktbx_postal_code_edit
            // 
            this.msktbx_postal_code_edit.Location = new System.Drawing.Point(91, 45);
            this.msktbx_postal_code_edit.Mask = "00-999";
            this.msktbx_postal_code_edit.Name = "msktbx_postal_code_edit";
            this.msktbx_postal_code_edit.Size = new System.Drawing.Size(178, 20);
            this.msktbx_postal_code_edit.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Numer posesji*";
            // 
            // msktbx_locale_number_edit
            // 
            this.msktbx_locale_number_edit.Enabled = false;
            this.msktbx_locale_number_edit.Location = new System.Drawing.Point(92, 137);
            this.msktbx_locale_number_edit.Name = "msktbx_locale_number_edit";
            this.msktbx_locale_number_edit.Size = new System.Drawing.Size(178, 20);
            this.msktbx_locale_number_edit.TabIndex = 6;
            // 
            // msktbx_street_number_edit
            // 
            this.msktbx_street_number_edit.Enabled = false;
            this.msktbx_street_number_edit.Location = new System.Drawing.Point(92, 104);
            this.msktbx_street_number_edit.Name = "msktbx_street_number_edit";
            this.msktbx_street_number_edit.Size = new System.Drawing.Size(178, 20);
            this.msktbx_street_number_edit.TabIndex = 5;
            // 
            // msktbx_street_edit
            // 
            this.msktbx_street_edit.Enabled = false;
            this.msktbx_street_edit.Location = new System.Drawing.Point(92, 74);
            this.msktbx_street_edit.Name = "msktbx_street_edit";
            this.msktbx_street_edit.Size = new System.Drawing.Size(178, 20);
            this.msktbx_street_edit.TabIndex = 4;
            // 
            // msktbx_city_edit
            // 
            this.msktbx_city_edit.Enabled = false;
            this.msktbx_city_edit.Location = new System.Drawing.Point(91, 19);
            this.msktbx_city_edit.Name = "msktbx_city_edit";
            this.msktbx_city_edit.Size = new System.Drawing.Size(178, 20);
            this.msktbx_city_edit.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Numer lokalu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ulica";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 22);
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
            this.tabPage_view_user.Size = new System.Drawing.Size(623, 541);
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
            this.cmbx_gender_view.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.tabPage_roles.Size = new System.Drawing.Size(763, 541);
            this.tabPage_roles.TabIndex = 2;
            this.tabPage_roles.Text = "Zarządzaj uprawnieniami";
            this.tabPage_roles.UseVisualStyleBackColor = true;
            // 
            // dotNetBarTabControl_manage_roles
            // 
            this.dotNetBarTabControl_manage_roles.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.dotNetBarTabControl_manage_roles.Controls.Add(this.tabPage_roles_overview);
            this.dotNetBarTabControl_manage_roles.Controls.Add(this.tabPage_edit_roles);
            this.dotNetBarTabControl_manage_roles.Controls.Add(this.tabPage_group_edit);
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
            this.tabPage_roles_overview.Controls.Add(this.dgv_users_perms);
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
            this.cmbx_permissions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_permissions.FormattingEnabled = true;
            this.cmbx_permissions.Location = new System.Drawing.Point(77, 252);
            this.cmbx_permissions.Name = "cmbx_permissions";
            this.cmbx_permissions.Size = new System.Drawing.Size(208, 21);
            this.cmbx_permissions.TabIndex = 3;
            // 
            // dgv_users_perms
            // 
            this.dgv_users_perms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users_perms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users_perms.Location = new System.Drawing.Point(77, 279);
            this.dgv_users_perms.Name = "dgv_users_perms";
            this.dgv_users_perms.ReadOnly = true;
            this.dgv_users_perms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_users_perms.Size = new System.Drawing.Size(438, 201);
            this.dgv_users_perms.TabIndex = 2;
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
            this.cmbx_select_user_role_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_select_user_role_edit.FormattingEnabled = true;
            this.cmbx_select_user_role_edit.Location = new System.Drawing.Point(51, 96);
            this.cmbx_select_user_role_edit.Name = "cmbx_select_user_role_edit";
            this.cmbx_select_user_role_edit.Size = new System.Drawing.Size(493, 21);
            this.cmbx_select_user_role_edit.TabIndex = 0;
            this.cmbx_select_user_role_edit.SelectedIndexChanged += new System.EventHandler(this.cmbx_select_user_role_edit_SelectedIndexChanged);
            // 
            // tabPage_group_edit
            // 
            this.tabPage_group_edit.Controls.Add(this.lbl_roles_group_edit);
            this.tabPage_group_edit.Controls.Add(this.lbl_users_group_edit);
            this.tabPage_group_edit.Controls.Add(this.btn_group_edit_cancel);
            this.tabPage_group_edit.Controls.Add(this.btn_group_edit_save);
            this.tabPage_group_edit.Controls.Add(this.clb_roles_group_edit);
            this.tabPage_group_edit.Controls.Add(this.clb_users_group_edit);
            this.tabPage_group_edit.Location = new System.Drawing.Point(140, 4);
            this.tabPage_group_edit.Name = "tabPage_group_edit";
            this.tabPage_group_edit.Size = new System.Drawing.Size(597, 527);
            this.tabPage_group_edit.TabIndex = 2;
            this.tabPage_group_edit.Text = "Edycja grupowa";
            this.tabPage_group_edit.UseVisualStyleBackColor = true;
            // 
            // lbl_roles_group_edit
            // 
            this.lbl_roles_group_edit.AutoSize = true;
            this.lbl_roles_group_edit.Location = new System.Drawing.Point(311, 51);
            this.lbl_roles_group_edit.Name = "lbl_roles_group_edit";
            this.lbl_roles_group_edit.Size = new System.Drawing.Size(66, 13);
            this.lbl_roles_group_edit.TabIndex = 5;
            this.lbl_roles_group_edit.Text = "Uprawnienia";
            // 
            // lbl_users_group_edit
            // 
            this.lbl_users_group_edit.AutoSize = true;
            this.lbl_users_group_edit.Location = new System.Drawing.Point(20, 51);
            this.lbl_users_group_edit.Name = "lbl_users_group_edit";
            this.lbl_users_group_edit.Size = new System.Drawing.Size(67, 13);
            this.lbl_users_group_edit.TabIndex = 4;
            this.lbl_users_group_edit.Text = "Użytkownicy";
            // 
            // btn_group_edit_cancel
            // 
            this.btn_group_edit_cancel.Location = new System.Drawing.Point(23, 485);
            this.btn_group_edit_cancel.Name = "btn_group_edit_cancel";
            this.btn_group_edit_cancel.Size = new System.Drawing.Size(256, 26);
            this.btn_group_edit_cancel.TabIndex = 3;
            this.btn_group_edit_cancel.Text = "Anuluj";
            this.btn_group_edit_cancel.UseVisualStyleBackColor = true;
            this.btn_group_edit_cancel.Click += new System.EventHandler(this.btn_group_edit_cancel_Click);
            // 
            // btn_group_edit_save
            // 
            this.btn_group_edit_save.Location = new System.Drawing.Point(314, 486);
            this.btn_group_edit_save.Name = "btn_group_edit_save";
            this.btn_group_edit_save.Size = new System.Drawing.Size(256, 26);
            this.btn_group_edit_save.TabIndex = 2;
            this.btn_group_edit_save.Text = "Zapisz";
            this.btn_group_edit_save.UseVisualStyleBackColor = true;
            this.btn_group_edit_save.Click += new System.EventHandler(this.btn_group_edit_save_Click);
            // 
            // clb_roles_group_edit
            // 
            this.clb_roles_group_edit.FormattingEnabled = true;
            this.clb_roles_group_edit.Location = new System.Drawing.Point(314, 85);
            this.clb_roles_group_edit.Name = "clb_roles_group_edit";
            this.clb_roles_group_edit.Size = new System.Drawing.Size(256, 394);
            this.clb_roles_group_edit.TabIndex = 1;
            // 
            // clb_users_group_edit
            // 
            this.clb_users_group_edit.FormattingEnabled = true;
            this.clb_users_group_edit.Location = new System.Drawing.Point(23, 85);
            this.clb_users_group_edit.Name = "clb_users_group_edit";
            this.clb_users_group_edit.Size = new System.Drawing.Size(256, 394);
            this.clb_users_group_edit.TabIndex = 0;
            // 
            // tabPage_manage_warehouse
            // 
            this.tabPage_manage_warehouse.Controls.Add(this.tabPage_items);
            this.tabPage_manage_warehouse.Location = new System.Drawing.Point(146, 4);
            this.tabPage_manage_warehouse.Name = "tabPage_manage_warehouse";
            this.tabPage_manage_warehouse.Size = new System.Drawing.Size(763, 541);
            this.tabPage_manage_warehouse.TabIndex = 4;
            this.tabPage_manage_warehouse.Text = "Zarządzanie magazynem";
            this.tabPage_manage_warehouse.UseVisualStyleBackColor = true;
            // 
            // tabPage_items
            // 
            this.tabPage_items.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabPage_items.Controls.Add(this.tabPage_Warehouse);
            this.tabPage_items.Controls.Add(this.tabPage2);
            this.tabPage_items.Controls.Add(this.tabPage_Item_History);
            this.tabPage_items.Controls.Add(this.tabPage_Delivery_Details);
            this.tabPage_items.Controls.Add(this.tabPage_Vat_Change);
            this.tabPage_items.ItemSize = new System.Drawing.Size(44, 136);
            this.tabPage_items.Location = new System.Drawing.Point(0, 4);
            this.tabPage_items.Multiline = true;
            this.tabPage_items.Name = "tabPage_items";
            this.tabPage_items.SelectedIndex = 0;
            this.tabPage_items.Size = new System.Drawing.Size(760, 537);
            this.tabPage_items.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPage_items.TabIndex = 0;
            this.tabPage_items.Click += new System.EventHandler(this.dotNetBarTabControl_Add_Item_Type_Click);
            // 
            // tabPage_Warehouse
            // 
            this.tabPage_Warehouse.Controls.Add(this.btn_replenish_item);
            this.tabPage_Warehouse.Controls.Add(this.dtp_item_deliveryDate);
            this.tabPage_Warehouse.Controls.Add(this.label63);
            this.tabPage_Warehouse.Controls.Add(this.btn_change_category_vat);
            this.tabPage_Warehouse.Controls.Add(this.btn_change_item_vat);
            this.tabPage_Warehouse.Controls.Add(this.btn_search_items);
            this.tabPage_Warehouse.Controls.Add(this.dtp_history_date);
            this.tabPage_Warehouse.Controls.Add(this.chk_use_history_date);
            this.tabPage_Warehouse.Controls.Add(this.tbx_item_search);
            this.tabPage_Warehouse.Controls.Add(this.btn_delete_item);
            this.tabPage_Warehouse.Controls.Add(this.dgv_warehouse_items);
            this.tabPage_Warehouse.Controls.Add(this.btn_register_item_cancel);
            this.tabPage_Warehouse.Controls.Add(this.btn_register_item_save);
            this.tabPage_Warehouse.Controls.Add(this.label47);
            this.tabPage_Warehouse.Controls.Add(this.cmbx_item_vat);
            this.tabPage_Warehouse.Controls.Add(this.label46);
            this.tabPage_Warehouse.Controls.Add(this.label45);
            this.tabPage_Warehouse.Controls.Add(this.cmbx_item_unit);
            this.tabPage_Warehouse.Controls.Add(this.label44);
            this.tabPage_Warehouse.Controls.Add(this.cmbx_item_type);
            this.tabPage_Warehouse.Controls.Add(this.label43);
            this.tabPage_Warehouse.Controls.Add(this.label42);
            this.tabPage_Warehouse.Controls.Add(this.label41);
            this.tabPage_Warehouse.Controls.Add(this.label40);
            this.tabPage_Warehouse.Controls.Add(this.label39);
            this.tabPage_Warehouse.Controls.Add(this.tbx_item_description);
            this.tabPage_Warehouse.Controls.Add(this.tbx_item_supplier);
            this.tabPage_Warehouse.Controls.Add(this.tbx_item_price);
            this.tabPage_Warehouse.Controls.Add(this.tbx_item_quantity);
            this.tabPage_Warehouse.Controls.Add(this.tbx_item_name);
            this.tabPage_Warehouse.Location = new System.Drawing.Point(140, 4);
            this.tabPage_Warehouse.Name = "tabPage_Warehouse";
            this.tabPage_Warehouse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Warehouse.Size = new System.Drawing.Size(616, 529);
            this.tabPage_Warehouse.TabIndex = 0;
            this.tabPage_Warehouse.Text = "Towary";
            this.tabPage_Warehouse.UseVisualStyleBackColor = true;
            // 
            // btn_replenish_item
            // 
            this.btn_replenish_item.Location = new System.Drawing.Point(383, 234);
            this.btn_replenish_item.Name = "btn_replenish_item";
            this.btn_replenish_item.Size = new System.Drawing.Size(108, 23);
            this.btn_replenish_item.TabIndex = 52;
            this.btn_replenish_item.Text = "Aktualizuj stan";
            this.btn_replenish_item.UseVisualStyleBackColor = true;
            this.btn_replenish_item.Click += new System.EventHandler(this.btn_replenish_item_Click);
            // 
            // dtp_item_deliveryDate
            // 
            this.dtp_item_deliveryDate.Location = new System.Drawing.Point(172, 478);
            this.dtp_item_deliveryDate.Name = "dtp_item_deliveryDate";
            this.dtp_item_deliveryDate.Size = new System.Drawing.Size(356, 20);
            this.dtp_item_deliveryDate.TabIndex = 51;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(88, 478);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(72, 13);
            this.label63.TabIndex = 50;
            this.label63.Text = "Data dostawy";
            // 
            // btn_change_category_vat
            // 
            this.btn_change_category_vat.Location = new System.Drawing.Point(177, 234);
            this.btn_change_category_vat.Name = "btn_change_category_vat";
            this.btn_change_category_vat.Size = new System.Drawing.Size(200, 23);
            this.btn_change_category_vat.TabIndex = 48;
            this.btn_change_category_vat.Text = "Zmień stawkę VAT dla rodzaju towaru";
            this.btn_change_category_vat.UseVisualStyleBackColor = true;
            this.btn_change_category_vat.Click += new System.EventHandler(this.btn_change_category_vat_Click);
            // 
            // btn_change_item_vat
            // 
            this.btn_change_item_vat.Location = new System.Drawing.Point(7, 234);
            this.btn_change_item_vat.Name = "btn_change_item_vat";
            this.btn_change_item_vat.Size = new System.Drawing.Size(164, 23);
            this.btn_change_item_vat.TabIndex = 47;
            this.btn_change_item_vat.Text = "Zmień stawkę VAT dla towaru";
            this.btn_change_item_vat.UseVisualStyleBackColor = true;
            this.btn_change_item_vat.Click += new System.EventHandler(this.btn_change_item_vat_Click);
            // 
            // btn_search_items
            // 
            this.btn_search_items.Location = new System.Drawing.Point(6, 8);
            this.btn_search_items.Name = "btn_search_items";
            this.btn_search_items.Size = new System.Drawing.Size(111, 23);
            this.btn_search_items.TabIndex = 46;
            this.btn_search_items.Text = "Wyszukaj";
            this.btn_search_items.UseVisualStyleBackColor = true;
            this.btn_search_items.Click += new System.EventHandler(this.btn_search_items_Click);
            // 
            // dtp_history_date
            // 
            this.dtp_history_date.Enabled = false;
            this.dtp_history_date.Location = new System.Drawing.Point(409, 10);
            this.dtp_history_date.Name = "dtp_history_date";
            this.dtp_history_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_history_date.TabIndex = 45;
            // 
            // chk_use_history_date
            // 
            this.chk_use_history_date.AutoSize = true;
            this.chk_use_history_date.Location = new System.Drawing.Point(235, 12);
            this.chk_use_history_date.Name = "chk_use_history_date";
            this.chk_use_history_date.Size = new System.Drawing.Size(168, 17);
            this.chk_use_history_date.TabIndex = 44;
            this.chk_use_history_date.Text = "Pokaż stan historyczny z dnia:";
            this.chk_use_history_date.UseVisualStyleBackColor = true;
            this.chk_use_history_date.CheckedChanged += new System.EventHandler(this.chk_use_history_date_CheckedChanged);
            // 
            // tbx_item_search
            // 
            this.tbx_item_search.Location = new System.Drawing.Point(123, 9);
            this.tbx_item_search.Name = "tbx_item_search";
            this.tbx_item_search.Size = new System.Drawing.Size(100, 20);
            this.tbx_item_search.TabIndex = 43;
            // 
            // btn_delete_item
            // 
            this.btn_delete_item.Location = new System.Drawing.Point(497, 234);
            this.btn_delete_item.Name = "btn_delete_item";
            this.btn_delete_item.Size = new System.Drawing.Size(112, 23);
            this.btn_delete_item.TabIndex = 42;
            this.btn_delete_item.Text = "Usuń towar";
            this.btn_delete_item.UseVisualStyleBackColor = true;
            this.btn_delete_item.Click += new System.EventHandler(this.btn_delete_item_Click);
            // 
            // dgv_warehouse_items
            // 
            this.dgv_warehouse_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_warehouse_items.Location = new System.Drawing.Point(6, 39);
            this.dgv_warehouse_items.Name = "dgv_warehouse_items";
            this.dgv_warehouse_items.Size = new System.Drawing.Size(603, 189);
            this.dgv_warehouse_items.TabIndex = 41;
            this.dgv_warehouse_items.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_warehouse_items_CellDoubleClick);
            // 
            // btn_register_item_cancel
            // 
            this.btn_register_item_cancel.Location = new System.Drawing.Point(453, 504);
            this.btn_register_item_cancel.Name = "btn_register_item_cancel";
            this.btn_register_item_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_register_item_cancel.TabIndex = 40;
            this.btn_register_item_cancel.Text = "Anuluj";
            this.btn_register_item_cancel.UseVisualStyleBackColor = true;
            this.btn_register_item_cancel.Click += new System.EventHandler(this.btn_register_item_cancel_Click);
            // 
            // btn_register_item_save
            // 
            this.btn_register_item_save.Location = new System.Drawing.Point(88, 506);
            this.btn_register_item_save.Name = "btn_register_item_save";
            this.btn_register_item_save.Size = new System.Drawing.Size(75, 23);
            this.btn_register_item_save.TabIndex = 39;
            this.btn_register_item_save.Text = "Zapisz";
            this.btn_register_item_save.UseVisualStyleBackColor = true;
            this.btn_register_item_save.Click += new System.EventHandler(this.btn_register_item_save_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(184, 506);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(0, 13);
            this.label47.TabIndex = 38;
            // 
            // cmbx_item_vat
            // 
            this.cmbx_item_vat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_item_vat.FormattingEnabled = true;
            this.cmbx_item_vat.Items.AddRange(new object[] {
            "23",
            "8",
            "5",
            "0",
            "zw"});
            this.cmbx_item_vat.Location = new System.Drawing.Point(172, 399);
            this.cmbx_item_vat.Name = "cmbx_item_vat";
            this.cmbx_item_vat.Size = new System.Drawing.Size(356, 21);
            this.cmbx_item_vat.TabIndex = 36;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(88, 402);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(67, 13);
            this.label46.TabIndex = 35;
            this.label46.Text = "Stawka VAT";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(88, 320);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(83, 13);
            this.label45.TabIndex = 34;
            this.label45.Text = "Jednostka miary";
            // 
            // cmbx_item_unit
            // 
            this.cmbx_item_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_item_unit.FormattingEnabled = true;
            this.cmbx_item_unit.Items.AddRange(new object[] {
            "Sztuki",
            "Kilogramy",
            "Litry",
            "Palety"});
            this.cmbx_item_unit.Location = new System.Drawing.Point(172, 317);
            this.cmbx_item_unit.Name = "cmbx_item_unit";
            this.cmbx_item_unit.Size = new System.Drawing.Size(356, 21);
            this.cmbx_item_unit.TabIndex = 33;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(88, 293);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(75, 13);
            this.label44.TabIndex = 32;
            this.label44.Text = "Rodzaj towaru";
            // 
            // cmbx_item_type
            // 
            this.cmbx_item_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_item_type.FormattingEnabled = true;
            this.cmbx_item_type.Location = new System.Drawing.Point(172, 290);
            this.cmbx_item_type.Name = "cmbx_item_type";
            this.cmbx_item_type.Size = new System.Drawing.Size(356, 21);
            this.cmbx_item_type.TabIndex = 31;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(88, 429);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(63, 13);
            this.label43.TabIndex = 30;
            this.label43.Text = "Opis towaru";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(88, 455);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(55, 13);
            this.label42.TabIndex = 29;
            this.label42.Text = "Dostawca";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(88, 347);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(29, 13);
            this.label41.TabIndex = 28;
            this.label41.Text = "Ilość";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(88, 373);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(59, 13);
            this.label40.TabIndex = 27;
            this.label40.Text = "Cena netto";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(88, 266);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(75, 13);
            this.label39.TabIndex = 26;
            this.label39.Text = "Nazwa towaru";
            // 
            // tbx_item_description
            // 
            this.tbx_item_description.Location = new System.Drawing.Point(172, 426);
            this.tbx_item_description.Name = "tbx_item_description";
            this.tbx_item_description.Size = new System.Drawing.Size(356, 20);
            this.tbx_item_description.TabIndex = 25;
            // 
            // tbx_item_supplier
            // 
            this.tbx_item_supplier.Location = new System.Drawing.Point(172, 452);
            this.tbx_item_supplier.Name = "tbx_item_supplier";
            this.tbx_item_supplier.Size = new System.Drawing.Size(356, 20);
            this.tbx_item_supplier.TabIndex = 24;
            // 
            // tbx_item_price
            // 
            this.tbx_item_price.Location = new System.Drawing.Point(172, 370);
            this.tbx_item_price.Name = "tbx_item_price";
            this.tbx_item_price.Size = new System.Drawing.Size(356, 20);
            this.tbx_item_price.TabIndex = 23;
            // 
            // tbx_item_quantity
            // 
            this.tbx_item_quantity.Location = new System.Drawing.Point(172, 344);
            this.tbx_item_quantity.Name = "tbx_item_quantity";
            this.tbx_item_quantity.Size = new System.Drawing.Size(356, 20);
            this.tbx_item_quantity.TabIndex = 22;
            // 
            // tbx_item_name
            // 
            this.tbx_item_name.Location = new System.Drawing.Point(172, 263);
            this.tbx_item_name.Name = "tbx_item_name";
            this.tbx_item_name.Size = new System.Drawing.Size(356, 20);
            this.tbx_item_name.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label62);
            this.tabPage2.Controls.Add(this.btn_delete_item_type);
            this.tabPage2.Controls.Add(this.tbx_item_type_name);
            this.tabPage2.Controls.Add(this.btn_cancel_item_type);
            this.tabPage2.Controls.Add(this.btn_add_item_type);
            this.tabPage2.Controls.Add(this.dgv_item_types);
            this.tabPage2.Location = new System.Drawing.Point(140, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rodzaje Towarów";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(6, 182);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(129, 13);
            this.label62.TabIndex = 5;
            this.label62.Text = "Dodaj nowy rodzaj towaru";
            // 
            // btn_delete_item_type
            // 
            this.btn_delete_item_type.Location = new System.Drawing.Point(459, 201);
            this.btn_delete_item_type.Name = "btn_delete_item_type";
            this.btn_delete_item_type.Size = new System.Drawing.Size(151, 23);
            this.btn_delete_item_type.TabIndex = 4;
            this.btn_delete_item_type.Text = "Usuń";
            this.btn_delete_item_type.UseVisualStyleBackColor = true;
            this.btn_delete_item_type.Click += new System.EventHandler(this.btn_delete_item_type_Click);
            // 
            // tbx_item_type_name
            // 
            this.tbx_item_type_name.Location = new System.Drawing.Point(6, 201);
            this.tbx_item_type_name.Name = "tbx_item_type_name";
            this.tbx_item_type_name.Size = new System.Drawing.Size(156, 20);
            this.tbx_item_type_name.TabIndex = 3;
            // 
            // btn_cancel_item_type
            // 
            this.btn_cancel_item_type.Location = new System.Drawing.Point(87, 227);
            this.btn_cancel_item_type.Name = "btn_cancel_item_type";
            this.btn_cancel_item_type.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_item_type.TabIndex = 2;
            this.btn_cancel_item_type.Text = "Anuluj";
            this.btn_cancel_item_type.UseVisualStyleBackColor = true;
            this.btn_cancel_item_type.Click += new System.EventHandler(this.btn_cancel_item_type_Click);
            // 
            // btn_add_item_type
            // 
            this.btn_add_item_type.Location = new System.Drawing.Point(6, 227);
            this.btn_add_item_type.Name = "btn_add_item_type";
            this.btn_add_item_type.Size = new System.Drawing.Size(75, 23);
            this.btn_add_item_type.TabIndex = 1;
            this.btn_add_item_type.Text = "Dodaj";
            this.btn_add_item_type.UseVisualStyleBackColor = true;
            this.btn_add_item_type.Click += new System.EventHandler(this.btn_add_item_type_Click);
            // 
            // dgv_item_types
            // 
            this.dgv_item_types.AllowUserToAddRows = false;
            this.dgv_item_types.AllowUserToDeleteRows = false;
            this.dgv_item_types.AllowUserToResizeRows = false;
            this.dgv_item_types.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item_types.Location = new System.Drawing.Point(6, 6);
            this.dgv_item_types.Name = "dgv_item_types";
            this.dgv_item_types.ReadOnly = true;
            this.dgv_item_types.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_item_types.Size = new System.Drawing.Size(604, 149);
            this.dgv_item_types.TabIndex = 0;
            // 
            // tabPage_Item_History
            // 
            this.tabPage_Item_History.Controls.Add(this.label50);
            this.tabPage_Item_History.Controls.Add(this.label49);
            this.tabPage_Item_History.Controls.Add(this.label48);
            this.tabPage_Item_History.Controls.Add(this.btn_history_close);
            this.tabPage_Item_History.Controls.Add(this.btn_history_filter);
            this.tabPage_Item_History.Controls.Add(this.tbx_history_employee);
            this.tabPage_Item_History.Controls.Add(this.dtp_history_from);
            this.tabPage_Item_History.Controls.Add(this.dtp_history_to);
            this.tabPage_Item_History.Controls.Add(this.chk_history_use_dates);
            this.tabPage_Item_History.Controls.Add(this.dgv_item_history);
            this.tabPage_Item_History.Location = new System.Drawing.Point(140, 4);
            this.tabPage_Item_History.Name = "tabPage_Item_History";
            this.tabPage_Item_History.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Item_History.Size = new System.Drawing.Size(616, 529);
            this.tabPage_Item_History.TabIndex = 2;
            this.tabPage_Item_History.Text = "Historia uzupełniania stanów";
            this.tabPage_Item_History.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(248, 252);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(60, 13);
            this.label50.TabIndex = 9;
            this.label50.Text = "Pracownik:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(406, 252);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(24, 13);
            this.label49.TabIndex = 8;
            this.label49.Text = "Do:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(6, 252);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(24, 13);
            this.label48.TabIndex = 7;
            this.label48.Text = "Od:";
            // 
            // btn_history_close
            // 
            this.btn_history_close.Location = new System.Drawing.Point(203, 500);
            this.btn_history_close.Name = "btn_history_close";
            this.btn_history_close.Size = new System.Drawing.Size(204, 23);
            this.btn_history_close.TabIndex = 6;
            this.btn_history_close.Text = "Zamknij historię";
            this.btn_history_close.UseVisualStyleBackColor = true;
            this.btn_history_close.Click += new System.EventHandler(this.btn_history_close_Click);
            // 
            // btn_history_filter
            // 
            this.btn_history_filter.Location = new System.Drawing.Point(260, 321);
            this.btn_history_filter.Name = "btn_history_filter";
            this.btn_history_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_history_filter.TabIndex = 5;
            this.btn_history_filter.Text = "Filtruj";
            this.btn_history_filter.UseVisualStyleBackColor = true;
            this.btn_history_filter.Click += new System.EventHandler(this.btn_history_filter_Click);
            // 
            // tbx_history_employee
            // 
            this.tbx_history_employee.Location = new System.Drawing.Point(251, 272);
            this.tbx_history_employee.Name = "tbx_history_employee";
            this.tbx_history_employee.Size = new System.Drawing.Size(94, 20);
            this.tbx_history_employee.TabIndex = 4;
            // 
            // dtp_history_from
            // 
            this.dtp_history_from.Enabled = false;
            this.dtp_history_from.Location = new System.Drawing.Point(6, 272);
            this.dtp_history_from.Name = "dtp_history_from";
            this.dtp_history_from.Size = new System.Drawing.Size(200, 20);
            this.dtp_history_from.TabIndex = 3;
            // 
            // dtp_history_to
            // 
            this.dtp_history_to.Enabled = false;
            this.dtp_history_to.Location = new System.Drawing.Point(409, 273);
            this.dtp_history_to.Name = "dtp_history_to";
            this.dtp_history_to.Size = new System.Drawing.Size(200, 20);
            this.dtp_history_to.TabIndex = 2;
            // 
            // chk_history_use_dates
            // 
            this.chk_history_use_dates.AutoSize = true;
            this.chk_history_use_dates.Location = new System.Drawing.Point(251, 298);
            this.chk_history_use_dates.Name = "chk_history_use_dates";
            this.chk_history_use_dates.Size = new System.Drawing.Size(94, 17);
            this.chk_history_use_dates.TabIndex = 1;
            this.chk_history_use_dates.Text = "Filtruj po dacie";
            this.chk_history_use_dates.UseVisualStyleBackColor = true;
            this.chk_history_use_dates.CheckedChanged += new System.EventHandler(this.chk_history_use_dates_CheckedChanged);
            // 
            // dgv_item_history
            // 
            this.dgv_item_history.AllowUserToAddRows = false;
            this.dgv_item_history.AllowUserToDeleteRows = false;
            this.dgv_item_history.AllowUserToOrderColumns = true;
            this.dgv_item_history.AllowUserToResizeRows = false;
            this.dgv_item_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item_history.Location = new System.Drawing.Point(6, 6);
            this.dgv_item_history.Name = "dgv_item_history";
            this.dgv_item_history.Size = new System.Drawing.Size(604, 235);
            this.dgv_item_history.TabIndex = 0;
            this.dgv_item_history.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_item_history_CellDoubleClick);
            // 
            // tabPage_Delivery_Details
            // 
            this.tabPage_Delivery_Details.Controls.Add(this.label61);
            this.tabPage_Delivery_Details.Controls.Add(this.label60);
            this.tabPage_Delivery_Details.Controls.Add(this.label59);
            this.tabPage_Delivery_Details.Controls.Add(this.tbx_det_itemType);
            this.tabPage_Delivery_Details.Controls.Add(this.tbx_det_description);
            this.tabPage_Delivery_Details.Controls.Add(this.tbx_det_unit);
            this.tabPage_Delivery_Details.Controls.Add(this.btn_det_close);
            this.tabPage_Delivery_Details.Controls.Add(this.label54);
            this.tabPage_Delivery_Details.Controls.Add(this.tbx_det_employee);
            this.tabPage_Delivery_Details.Controls.Add(this.label53);
            this.tabPage_Delivery_Details.Controls.Add(this.tbx_det_sysDate);
            this.tabPage_Delivery_Details.Controls.Add(this.label52);
            this.tabPage_Delivery_Details.Controls.Add(this.tbx_det_deliveryDate);
            this.tabPage_Delivery_Details.Controls.Add(this.tbx_det_vat);
            this.tabPage_Delivery_Details.Controls.Add(this.label51);
            this.tabPage_Delivery_Details.Controls.Add(this.label55);
            this.tabPage_Delivery_Details.Controls.Add(this.label56);
            this.tabPage_Delivery_Details.Controls.Add(this.label57);
            this.tabPage_Delivery_Details.Controls.Add(this.label58);
            this.tabPage_Delivery_Details.Controls.Add(this.tbx_det_supplier);
            this.tabPage_Delivery_Details.Controls.Add(this.tbx_det_netPrice);
            this.tabPage_Delivery_Details.Controls.Add(this.tbx_det_quantity);
            this.tabPage_Delivery_Details.Controls.Add(this.tbx_det_itemName);
            this.tabPage_Delivery_Details.Location = new System.Drawing.Point(140, 4);
            this.tabPage_Delivery_Details.Name = "tabPage_Delivery_Details";
            this.tabPage_Delivery_Details.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Delivery_Details.Size = new System.Drawing.Size(616, 529);
            this.tabPage_Delivery_Details.TabIndex = 3;
            this.tabPage_Delivery_Details.Text = "Podgląd szczegółów rejestracji";
            this.tabPage_Delivery_Details.UseVisualStyleBackColor = true;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(9, 189);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(83, 13);
            this.label61.TabIndex = 65;
            this.label61.Text = "Jednostka miary";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(9, 215);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(75, 13);
            this.label60.TabIndex = 64;
            this.label60.Text = "Rodzaj towaru";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(9, 241);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(63, 13);
            this.label59.TabIndex = 63;
            this.label59.Text = "Opis towaru";
            // 
            // tbx_det_itemType
            // 
            this.tbx_det_itemType.Location = new System.Drawing.Point(172, 212);
            this.tbx_det_itemType.Name = "tbx_det_itemType";
            this.tbx_det_itemType.ReadOnly = true;
            this.tbx_det_itemType.Size = new System.Drawing.Size(356, 20);
            this.tbx_det_itemType.TabIndex = 62;
            // 
            // tbx_det_description
            // 
            this.tbx_det_description.Location = new System.Drawing.Point(172, 238);
            this.tbx_det_description.Multiline = true;
            this.tbx_det_description.Name = "tbx_det_description";
            this.tbx_det_description.ReadOnly = true;
            this.tbx_det_description.Size = new System.Drawing.Size(356, 20);
            this.tbx_det_description.TabIndex = 61;
            // 
            // tbx_det_unit
            // 
            this.tbx_det_unit.Location = new System.Drawing.Point(172, 186);
            this.tbx_det_unit.Name = "tbx_det_unit";
            this.tbx_det_unit.ReadOnly = true;
            this.tbx_det_unit.Size = new System.Drawing.Size(356, 20);
            this.tbx_det_unit.TabIndex = 60;
            // 
            // btn_det_close
            // 
            this.btn_det_close.Location = new System.Drawing.Point(172, 500);
            this.btn_det_close.Name = "btn_det_close";
            this.btn_det_close.Size = new System.Drawing.Size(238, 23);
            this.btn_det_close.TabIndex = 59;
            this.btn_det_close.Text = "Zamknij";
            this.btn_det_close.UseVisualStyleBackColor = true;
            this.btn_det_close.Click += new System.EventHandler(this.btn_det_close_Click);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(9, 406);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(113, 13);
            this.label54.TabIndex = 58;
            this.label54.Text = "Pracownik rejestrujący";
            // 
            // tbx_det_employee
            // 
            this.tbx_det_employee.Location = new System.Drawing.Point(172, 406);
            this.tbx_det_employee.Name = "tbx_det_employee";
            this.tbx_det_employee.ReadOnly = true;
            this.tbx_det_employee.Size = new System.Drawing.Size(356, 20);
            this.tbx_det_employee.TabIndex = 57;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(9, 383);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(157, 13);
            this.label53.TabIndex = 56;
            this.label53.Text = "Data wprowadzenia do systemu";
            // 
            // tbx_det_sysDate
            // 
            this.tbx_det_sysDate.Location = new System.Drawing.Point(172, 380);
            this.tbx_det_sysDate.Name = "tbx_det_sysDate";
            this.tbx_det_sysDate.ReadOnly = true;
            this.tbx_det_sysDate.Size = new System.Drawing.Size(356, 20);
            this.tbx_det_sysDate.TabIndex = 55;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(9, 357);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(72, 13);
            this.label52.TabIndex = 54;
            this.label52.Text = "Data dostawy";
            // 
            // tbx_det_deliveryDate
            // 
            this.tbx_det_deliveryDate.Location = new System.Drawing.Point(172, 354);
            this.tbx_det_deliveryDate.Name = "tbx_det_deliveryDate";
            this.tbx_det_deliveryDate.ReadOnly = true;
            this.tbx_det_deliveryDate.Size = new System.Drawing.Size(356, 20);
            this.tbx_det_deliveryDate.TabIndex = 53;
            // 
            // tbx_det_vat
            // 
            this.tbx_det_vat.Location = new System.Drawing.Point(172, 296);
            this.tbx_det_vat.Name = "tbx_det_vat";
            this.tbx_det_vat.ReadOnly = true;
            this.tbx_det_vat.Size = new System.Drawing.Size(356, 20);
            this.tbx_det_vat.TabIndex = 52;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(9, 299);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(67, 13);
            this.label51.TabIndex = 51;
            this.label51.Text = "Stawka VAT";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(9, 328);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(55, 13);
            this.label55.TabIndex = 45;
            this.label55.Text = "Dostawca";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(9, 163);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(29, 13);
            this.label56.TabIndex = 44;
            this.label56.Text = "Ilość";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(9, 270);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(59, 13);
            this.label57.TabIndex = 43;
            this.label57.Text = "Cena netto";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(9, 134);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(75, 13);
            this.label58.TabIndex = 42;
            this.label58.Text = "Nazwa towaru";
            // 
            // tbx_det_supplier
            // 
            this.tbx_det_supplier.Location = new System.Drawing.Point(172, 325);
            this.tbx_det_supplier.Name = "tbx_det_supplier";
            this.tbx_det_supplier.ReadOnly = true;
            this.tbx_det_supplier.Size = new System.Drawing.Size(356, 20);
            this.tbx_det_supplier.TabIndex = 40;
            // 
            // tbx_det_netPrice
            // 
            this.tbx_det_netPrice.Location = new System.Drawing.Point(172, 267);
            this.tbx_det_netPrice.Name = "tbx_det_netPrice";
            this.tbx_det_netPrice.ReadOnly = true;
            this.tbx_det_netPrice.Size = new System.Drawing.Size(356, 20);
            this.tbx_det_netPrice.TabIndex = 39;
            // 
            // tbx_det_quantity
            // 
            this.tbx_det_quantity.Location = new System.Drawing.Point(172, 160);
            this.tbx_det_quantity.Name = "tbx_det_quantity";
            this.tbx_det_quantity.ReadOnly = true;
            this.tbx_det_quantity.Size = new System.Drawing.Size(356, 20);
            this.tbx_det_quantity.TabIndex = 38;
            // 
            // tbx_det_itemName
            // 
            this.tbx_det_itemName.Location = new System.Drawing.Point(172, 134);
            this.tbx_det_itemName.Name = "tbx_det_itemName";
            this.tbx_det_itemName.ReadOnly = true;
            this.tbx_det_itemName.Size = new System.Drawing.Size(356, 20);
            this.tbx_det_itemName.TabIndex = 37;
            // 
            // tabPage_Vat_Change
            // 
            this.tabPage_Vat_Change.Controls.Add(this.label66);
            this.tabPage_Vat_Change.Controls.Add(this.label65);
            this.tabPage_Vat_Change.Controls.Add(this.label64);
            this.tabPage_Vat_Change.Controls.Add(this.btn_vat_save);
            this.tabPage_Vat_Change.Controls.Add(this.btn_vat_cancel);
            this.tabPage_Vat_Change.Controls.Add(this.dtp_vat_date);
            this.tabPage_Vat_Change.Controls.Add(this.cmb_vat_category);
            this.tabPage_Vat_Change.Controls.Add(this.cmb_new_vat);
            this.tabPage_Vat_Change.Controls.Add(this.tbx_vat_item_name);
            this.tabPage_Vat_Change.Controls.Add(this.lbl_vat_mode_title);
            this.tabPage_Vat_Change.Location = new System.Drawing.Point(140, 4);
            this.tabPage_Vat_Change.Name = "tabPage_Vat_Change";
            this.tabPage_Vat_Change.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Vat_Change.Size = new System.Drawing.Size(616, 529);
            this.tabPage_Vat_Change.TabIndex = 4;
            this.tabPage_Vat_Change.Text = "Zmiana stawki VAT";
            this.tabPage_Vat_Change.UseVisualStyleBackColor = true;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(3, 294);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(75, 13);
            this.label66.TabIndex = 10;
            this.label66.Text = "Rodzaj towaru";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(3, 350);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(58, 13);
            this.label65.TabIndex = 9;
            this.label65.Text = "Nowy VAT";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(3, 401);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(165, 13);
            this.label64.TabIndex = 8;
            this.label64.Text = "Data rozpoczęcia obowiązywania";
            // 
            // btn_vat_save
            // 
            this.btn_vat_save.Location = new System.Drawing.Point(6, 500);
            this.btn_vat_save.Name = "btn_vat_save";
            this.btn_vat_save.Size = new System.Drawing.Size(189, 23);
            this.btn_vat_save.TabIndex = 7;
            this.btn_vat_save.Text = "Zapisz";
            this.btn_vat_save.UseVisualStyleBackColor = true;
            this.btn_vat_save.Click += new System.EventHandler(this.btn_vat_save_Click);
            // 
            // btn_vat_cancel
            // 
            this.btn_vat_cancel.Location = new System.Drawing.Point(201, 500);
            this.btn_vat_cancel.Name = "btn_vat_cancel";
            this.btn_vat_cancel.Size = new System.Drawing.Size(189, 23);
            this.btn_vat_cancel.TabIndex = 6;
            this.btn_vat_cancel.Text = "Anuluj";
            this.btn_vat_cancel.UseVisualStyleBackColor = true;
            this.btn_vat_cancel.Click += new System.EventHandler(this.btn_vat_cancel_Click);
            // 
            // dtp_vat_date
            // 
            this.dtp_vat_date.Location = new System.Drawing.Point(6, 417);
            this.dtp_vat_date.Name = "dtp_vat_date";
            this.dtp_vat_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_vat_date.TabIndex = 4;
            // 
            // cmb_vat_category
            // 
            this.cmb_vat_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_vat_category.FormattingEnabled = true;
            this.cmb_vat_category.Location = new System.Drawing.Point(6, 310);
            this.cmb_vat_category.Name = "cmb_vat_category";
            this.cmb_vat_category.Size = new System.Drawing.Size(121, 21);
            this.cmb_vat_category.TabIndex = 3;
            // 
            // cmb_new_vat
            // 
            this.cmb_new_vat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_new_vat.FormattingEnabled = true;
            this.cmb_new_vat.Items.AddRange(new object[] {
            "0",
            "5",
            "8",
            "23"});
            this.cmb_new_vat.Location = new System.Drawing.Point(6, 366);
            this.cmb_new_vat.Name = "cmb_new_vat";
            this.cmb_new_vat.Size = new System.Drawing.Size(121, 21);
            this.cmb_new_vat.TabIndex = 2;
            // 
            // tbx_vat_item_name
            // 
            this.tbx_vat_item_name.Location = new System.Drawing.Point(6, 256);
            this.tbx_vat_item_name.Name = "tbx_vat_item_name";
            this.tbx_vat_item_name.ReadOnly = true;
            this.tbx_vat_item_name.Size = new System.Drawing.Size(100, 20);
            this.tbx_vat_item_name.TabIndex = 1;
            // 
            // lbl_vat_mode_title
            // 
            this.lbl_vat_mode_title.AutoSize = true;
            this.lbl_vat_mode_title.Location = new System.Drawing.Point(3, 240);
            this.lbl_vat_mode_title.Name = "lbl_vat_mode_title";
            this.lbl_vat_mode_title.Size = new System.Drawing.Size(41, 13);
            this.lbl_vat_mode_title.TabIndex = 0;
            this.lbl_vat_mode_title.Text = "label63";
            // 
            // tabPage_manage_sales
            // 
            this.tabPage_manage_sales.Controls.Add(this.tabControl_sales);
            this.tabPage_manage_sales.Location = new System.Drawing.Point(146, 4);
            this.tabPage_manage_sales.Name = "tabPage_manage_sales";
            this.tabPage_manage_sales.Size = new System.Drawing.Size(763, 541);
            this.tabPage_manage_sales.TabIndex = 5;
            this.tabPage_manage_sales.Text = "Zarządzanie sprzedażą";
            this.tabPage_manage_sales.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(12, 567);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(146, 27);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "Wyloguj";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbx_admin_password_reset
            // 
            this.tbx_admin_password_reset.Location = new System.Drawing.Point(25, 144);
            this.tbx_admin_password_reset.Name = "tbx_admin_password_reset";
            this.tbx_admin_password_reset.PasswordChar = '*';
            this.tbx_admin_password_reset.Size = new System.Drawing.Size(155, 20);
            this.tbx_admin_password_reset.TabIndex = 63;
            // 
            // btn_admin_password_reset
            // 
            this.btn_admin_password_reset.Location = new System.Drawing.Point(25, 171);
            this.btn_admin_password_reset.Name = "btn_admin_password_reset";
            this.btn_admin_password_reset.Size = new System.Drawing.Size(155, 23);
            this.btn_admin_password_reset.TabIndex = 64;
            this.btn_admin_password_reset.Text = "Zmień hasło";
            this.btn_admin_password_reset.UseVisualStyleBackColor = true;
            this.btn_admin_password_reset.Click += new System.EventHandler(this.btn_admin_password_reset_Click);
            // 
            // lbl_edit_password
            // 
            this.lbl_edit_password.AutoSize = true;
            this.lbl_edit_password.Location = new System.Drawing.Point(22, 128);
            this.lbl_edit_password.Name = "lbl_edit_password";
            this.lbl_edit_password.Size = new System.Drawing.Size(36, 13);
            this.lbl_edit_password.TabIndex = 65;
            this.lbl_edit_password.Text = "Hasło";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(968, 606);
            this.Controls.Add(this.dotNetBarTabControl_main_view);
            this.Controls.Add(this.btn_logout);
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System magazynowy";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sale_basket)).EndInit();
            this.tabControl_sales.ResumeLayout(false);
            this.tabPage_register_sale.ResumeLayout(false);
            this.tabPage_register_sale.PerformLayout();
            this.tabPage_sales_history.ResumeLayout(false);
            this.tabPage_sales_history.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales_history)).EndInit();
            this.tabPage_sale_details.ResumeLayout(false);
            this.tabPage_sale_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sale_details)).EndInit();
            this.dotNetBarTabControl_main_view.ResumeLayout(false);
            this.tabPage_my_profile.ResumeLayout(false);
            this.tabPage_my_profile.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users_perms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_roles)).EndInit();
            this.tabPage_edit_roles.ResumeLayout(false);
            this.tabPage_edit_roles.PerformLayout();
            this.tabPage_group_edit.ResumeLayout(false);
            this.tabPage_group_edit.PerformLayout();
            this.tabPage_manage_warehouse.ResumeLayout(false);
            this.tabPage_items.ResumeLayout(false);
            this.tabPage_Warehouse.ResumeLayout(false);
            this.tabPage_Warehouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_warehouse_items)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item_types)).EndInit();
            this.tabPage_Item_History.ResumeLayout(false);
            this.tabPage_Item_History.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item_history)).EndInit();
            this.tabPage_Delivery_Details.ResumeLayout(false);
            this.tabPage_Delivery_Details.PerformLayout();
            this.tabPage_Vat_Change.ResumeLayout(false);
            this.tabPage_Vat_Change.PerformLayout();
            this.tabPage_manage_sales.ResumeLayout(false);
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
        private TabPage tabPage_roles;
        private TabControls.DotNetBarTabControl dotNetBarTabControl_manage_roles;
        private TabPage tabPage_roles_overview;
        private TabPage tabPage_edit_roles;
        private DataGridView dgv_roles;
        private Label lbl_choose_user;
        private ComboBox cmbx_select_user_role_edit;
        private Button btn_save_role_changes;
        private Label lbl_roles;
        private CheckedListBox clb_roles;
        private Button btn_cancel_role;
        private DataGridView dgv_users_perms;
        private Button btn_filter_perms;
        private ComboBox cmbx_permissions;
        private CheckedListBox clb_add_user_role;
        private Label lbl_role;
        private TabPage tabPage_group_edit;
        private Button btn_group_edit_save;
        private CheckedListBox clb_roles_group_edit;
        private CheckedListBox clb_users_group_edit;
        private Button btn_group_edit_cancel;
        private Button btn_logout;
        private TabPage tabPage_my_profile;
        private TextBox tbx_profile_email;
        private TextBox tbx_profile_surname;
        private TextBox tbx_profile_name;
        private TextBox tbx_profile_login;
        private Label label31;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label lbl_repeat_password;
        private Label lbl_new_password;
        private Label lbl_old_password;
        private Button btn_change_password;
        private TextBox tbx_profile_repeat_password;
        private TextBox tbx_profile_new_password;
        private TextBox tbx_profile_old_password;
        private Label lbl_users_group_edit;
        private Label lbl_roles_group_edit;
        private TabPage tabPage_manage_warehouse;
        private TabPage tabPage_manage_sales;
        private CheckedListBox clb_profile_roles;
        private Button btn_register_sale;
        private DateTimePicker dtp_sale_date;
        private ComboBox cmbx_sale_product;
        private TextBox tbx_sale_quantity;
        private TextBox tbx_sale_client_address;
        private TextBox tbx_sale_client_name;
        private Label label38;
        private Label label37;
        private Label label36;
        private Label label32;
        private Label label30;
        private TabControls.DotNetBarTabControl tabPage_items;
        private TabPage tabPage_Warehouse;
        private Button btn_register_item_cancel;
        private Button btn_register_item_save;
        private Label label47;
        private ComboBox cmbx_item_vat;
        private Label label46;
        private Label label45;
        private ComboBox cmbx_item_unit;
        private Label label44;
        private ComboBox cmbx_item_type;
        private Label label43;
        private Label label42;
        private Label label41;
        private Label label40;
        private Label label39;
        private TextBox tbx_item_description;
        private TextBox tbx_item_supplier;
        private TextBox tbx_item_price;
        private TextBox tbx_item_quantity;
        private TextBox tbx_item_name;
        private TabPage tabPage2;
        private TextBox tbx_item_type_name;
        private Button btn_cancel_item_type;
        private Button btn_add_item_type;
        private DataGridView dgv_item_types;
        private Button btn_delete_item_type;
        private DataGridView dgv_warehouse_items;
        private Button btn_delete_item;
        private CheckBox chk_use_history_date;
        private TextBox tbx_item_search;
        private Button btn_search_items;
        private DateTimePicker dtp_history_date;
        private TabPage tabPage_Item_History;
        private Button btn_history_close;
        private Button btn_history_filter;
        private TextBox tbx_history_employee;
        private DateTimePicker dtp_history_from;
        private DateTimePicker dtp_history_to;
        private CheckBox chk_history_use_dates;
        private DataGridView dgv_item_history;
        private Label label50;
        private Label label49;
        private Label label48;
        private TabPage tabPage_Delivery_Details;
        private Label label51;
        private Label label55;
        private Label label56;
        private Label label57;
        private Label label58;
        private TextBox tbx_det_supplier;
        private TextBox tbx_det_netPrice;
        private TextBox tbx_det_quantity;
        private TextBox tbx_det_itemName;
        private TextBox tbx_det_vat;
        private Label label54;
        private TextBox tbx_det_employee;
        private Label label53;
        private TextBox tbx_det_sysDate;
        private Label label52;
        private TextBox tbx_det_deliveryDate;
        private Button btn_det_close;
        private Label label61;
        private Label label60;
        private Label label59;
        private TextBox tbx_det_itemType;
        private TextBox tbx_det_description;
        private TextBox tbx_det_unit;
        private Label label62;
        private Button btn_change_category_vat;
        private Button btn_change_item_vat;
        private TabPage tabPage_Vat_Change;
        private Button btn_vat_save;
        private Button btn_vat_cancel;
        private DateTimePicker dtp_vat_date;
        private ComboBox cmb_vat_category;
        private ComboBox cmb_new_vat;
        private TextBox tbx_vat_item_name;
        private Label lbl_vat_mode_title;
        private Label label64;
        private Label label65;
        private Label label66;
        private Label lbl_search_user;
        private Button btn_replenish_item;
        private DateTimePicker dtp_item_deliveryDate;
        private Label label63;
        private TabControls.DotNetBarTabControl tabControl_sales;
        private System.Windows.Forms.TabPage tabPage_register_sale;
        private System.Windows.Forms.TabPage tabPage_sales_history;
        private System.Windows.Forms.TabPage tabPage_sale_details;
        private System.Windows.Forms.DataGridView dgv_sales_history;
        private System.Windows.Forms.Button btn_search_sales;
        private System.Windows.Forms.TextBox tbx_history_item;
        private System.Windows.Forms.TextBox tbx_history_seller;
        private System.Windows.Forms.TextBox tbx_history_buyer;
        private System.Windows.Forms.DateTimePicker dtp_sales_history_to;
        private System.Windows.Forms.DateTimePicker dtp_sales_history_from;
        private System.Windows.Forms.Label lbl_history_date_from;
        private System.Windows.Forms.Label lbl_history_date_to;
        private System.Windows.Forms.Label lbl_history_buyer;
        private System.Windows.Forms.Label lbl_history_seller;
        private System.Windows.Forms.Label lbl_history_item;
        private System.Windows.Forms.DataGridView dgv_sale_details;
        private System.Windows.Forms.TextBox tbx_detail_seller;
        private System.Windows.Forms.TextBox tbx_detail_date;
        private System.Windows.Forms.TextBox tbx_detail_address;
        private System.Windows.Forms.TextBox tbx_detail_buyer;
        private System.Windows.Forms.Button btn_close_details;
        private System.Windows.Forms.Label lbl_detail_buyer;
        private System.Windows.Forms.Label lbl_detail_address;
        private System.Windows.Forms.Label lbl_detail_date;
        private System.Windows.Forms.Label lbl_detail_seller;
        private ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgv_sale_basket;
        private System.Windows.Forms.Button btn_add_to_basket;
        private Label label67;
        private Label label68;
        private Button btn_remove_from_basket;
        private Button btn_cancel_sale;
        private CheckBox chk_sales_history_dates;
        private Label lbl_postal_code;
        private MaskedTextBox msktbx_postal_code;
        private Label label69;
        private MaskedTextBox msktbx_postal_code_edit;
        private Button btn_admin_password_reset;
        private TextBox tbx_admin_password_reset;
        private Label lbl_edit_password;
    }
}