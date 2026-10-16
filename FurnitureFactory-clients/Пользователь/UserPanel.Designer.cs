namespace FurnitureFactory_clients
{
    partial class UserPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserPages = new Guna.UI2.WinForms.Guna2TabControl();
            this.ProfilePage = new System.Windows.Forms.TabPage();
            this.UserProfileLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UserProfileInfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UserProfileInfoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.InputUserPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InputUserPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputUserLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputUserAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Buttonlogout = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonEditProfile = new Guna.UI2.WinForms.Guna2Button();
            this.UserProfileOrdersLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.TableOrders = new System.Windows.Forms.DataGridView();
            this.ProductsPage = new System.Windows.Forms.TabPage();
            this.ProductsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.UserPages.SuspendLayout();
            this.ProfilePage.SuspendLayout();
            this.UserProfileLayout.SuspendLayout();
            this.UserProfileInfoLayout.SuspendLayout();
            this.UserProfileInfoPanel.SuspendLayout();
            this.ButtonsLayout.SuspendLayout();
            this.UserProfileOrdersLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrders)).BeginInit();
            this.ProductsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserPages
            // 
            this.UserPages.Controls.Add(this.ProfilePage);
            this.UserPages.Controls.Add(this.ProductsPage);
            this.UserPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserPages.ItemSize = new System.Drawing.Size(180, 40);
            this.UserPages.Location = new System.Drawing.Point(0, 0);
            this.UserPages.Name = "UserPages";
            this.UserPages.SelectedIndex = 0;
            this.UserPages.Size = new System.Drawing.Size(900, 500);
            this.UserPages.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.UserPages.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.UserPages.TabButtonHoverState.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.UserPages.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.UserPages.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.UserPages.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.UserPages.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.UserPages.TabButtonIdleState.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.UserPages.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.UserPages.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.UserPages.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.UserPages.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.UserPages.TabButtonSelectedState.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.UserPages.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.UserPages.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.UserPages.TabButtonSize = new System.Drawing.Size(180, 40);
            this.UserPages.TabIndex = 0;
            this.UserPages.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.UserPages.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // ProfilePage
            // 
            this.ProfilePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ProfilePage.Controls.Add(this.UserProfileLayout);
            this.ProfilePage.Location = new System.Drawing.Point(4, 44);
            this.ProfilePage.Name = "ProfilePage";
            this.ProfilePage.Padding = new System.Windows.Forms.Padding(3);
            this.ProfilePage.Size = new System.Drawing.Size(892, 452);
            this.ProfilePage.TabIndex = 0;
            this.ProfilePage.Text = "Профиль";
            this.ProfilePage.Enter += new System.EventHandler(this.ProfilePage_Enter);
            // 
            // UserProfileLayout
            // 
            this.UserProfileLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.UserProfileLayout.ColumnCount = 2;
            this.UserProfileLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.UserProfileLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserProfileLayout.Controls.Add(this.UserProfileInfoLayout, 0, 0);
            this.UserProfileLayout.Controls.Add(this.UserProfileOrdersLayout, 1, 0);
            this.UserProfileLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserProfileLayout.Location = new System.Drawing.Point(3, 3);
            this.UserProfileLayout.Name = "UserProfileLayout";
            this.UserProfileLayout.Padding = new System.Windows.Forms.Padding(2);
            this.UserProfileLayout.RowCount = 1;
            this.UserProfileLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserProfileLayout.Size = new System.Drawing.Size(886, 446);
            this.UserProfileLayout.TabIndex = 6;
            // 
            // UserProfileInfoLayout
            // 
            this.UserProfileInfoLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.UserProfileInfoLayout.ColumnCount = 1;
            this.UserProfileInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserProfileInfoLayout.Controls.Add(this.UserProfileInfoPanel, 0, 0);
            this.UserProfileInfoLayout.Controls.Add(this.ButtonsLayout, 0, 1);
            this.UserProfileInfoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserProfileInfoLayout.Location = new System.Drawing.Point(6, 6);
            this.UserProfileInfoLayout.Name = "UserProfileInfoLayout";
            this.UserProfileInfoLayout.RowCount = 2;
            this.UserProfileInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserProfileInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.UserProfileInfoLayout.Size = new System.Drawing.Size(414, 434);
            this.UserProfileInfoLayout.TabIndex = 1;
            // 
            // UserProfileInfoPanel
            // 
            this.UserProfileInfoPanel.Controls.Add(this.label5);
            this.UserProfileInfoPanel.Controls.Add(this.InputUserPhone);
            this.UserProfileInfoPanel.Controls.Add(this.label4);
            this.UserProfileInfoPanel.Controls.Add(this.InputUserPassword);
            this.UserProfileInfoPanel.Controls.Add(this.label3);
            this.UserProfileInfoPanel.Controls.Add(this.InputUserLogin);
            this.UserProfileInfoPanel.Controls.Add(this.label2);
            this.UserProfileInfoPanel.Controls.Add(this.InputUserAddress);
            this.UserProfileInfoPanel.Controls.Add(this.label1);
            this.UserProfileInfoPanel.Controls.Add(this.InputUserName);
            this.UserProfileInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserProfileInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.UserProfileInfoPanel.Name = "UserProfileInfoPanel";
            this.UserProfileInfoPanel.Size = new System.Drawing.Size(408, 378);
            this.UserProfileInfoPanel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label5.Location = new System.Drawing.Point(3, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Телефон";
            // 
            // InputUserPhone
            // 
            this.InputUserPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputUserPhone.BorderRadius = 10;
            this.InputUserPhone.BorderThickness = 2;
            this.InputUserPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputUserPhone.DefaultText = "";
            this.InputUserPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserPhone.Enabled = false;
            this.InputUserPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserPhone.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.InputUserPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserPhone.Location = new System.Drawing.Point(99, 135);
            this.InputUserPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputUserPhone.Name = "InputUserPhone";
            this.InputUserPhone.PasswordChar = '\0';
            this.InputUserPhone.PlaceholderText = "";
            this.InputUserPhone.ReadOnly = true;
            this.InputUserPhone.SelectedText = "";
            this.InputUserPhone.Size = new System.Drawing.Size(305, 47);
            this.InputUserPhone.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label4.Location = new System.Drawing.Point(7, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пароль";
            // 
            // InputUserPassword
            // 
            this.InputUserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputUserPassword.BorderRadius = 10;
            this.InputUserPassword.BorderThickness = 2;
            this.InputUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputUserPassword.DefaultText = "";
            this.InputUserPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserPassword.Enabled = false;
            this.InputUserPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserPassword.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.InputUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserPassword.Location = new System.Drawing.Point(99, 257);
            this.InputUserPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputUserPassword.Name = "InputUserPassword";
            this.InputUserPassword.PasswordChar = '●';
            this.InputUserPassword.PlaceholderText = "";
            this.InputUserPassword.ReadOnly = true;
            this.InputUserPassword.SelectedText = "";
            this.InputUserPassword.Size = new System.Drawing.Size(303, 47);
            this.InputUserPassword.TabIndex = 7;
            this.InputUserPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label3.Location = new System.Drawing.Point(7, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Логин";
            // 
            // InputUserLogin
            // 
            this.InputUserLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputUserLogin.BorderRadius = 10;
            this.InputUserLogin.BorderThickness = 2;
            this.InputUserLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputUserLogin.DefaultText = "";
            this.InputUserLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserLogin.Enabled = false;
            this.InputUserLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserLogin.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.InputUserLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserLogin.Location = new System.Drawing.Point(99, 196);
            this.InputUserLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputUserLogin.Name = "InputUserLogin";
            this.InputUserLogin.PasswordChar = '\0';
            this.InputUserLogin.PlaceholderText = "";
            this.InputUserLogin.ReadOnly = true;
            this.InputUserLogin.SelectedText = "";
            this.InputUserLogin.Size = new System.Drawing.Size(305, 47);
            this.InputUserLogin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Адрес";
            // 
            // InputUserAddress
            // 
            this.InputUserAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputUserAddress.BorderRadius = 10;
            this.InputUserAddress.BorderThickness = 2;
            this.InputUserAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputUserAddress.DefaultText = "";
            this.InputUserAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserAddress.Enabled = false;
            this.InputUserAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserAddress.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.InputUserAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserAddress.Location = new System.Drawing.Point(101, 74);
            this.InputUserAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputUserAddress.Name = "InputUserAddress";
            this.InputUserAddress.PasswordChar = '\0';
            this.InputUserAddress.PlaceholderText = "";
            this.InputUserAddress.ReadOnly = true;
            this.InputUserAddress.SelectedText = "";
            this.InputUserAddress.Size = new System.Drawing.Size(304, 47);
            this.InputUserAddress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // InputUserName
            // 
            this.InputUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputUserName.BorderRadius = 10;
            this.InputUserName.BorderThickness = 2;
            this.InputUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputUserName.DefaultText = "";
            this.InputUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserName.Enabled = false;
            this.InputUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserName.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.InputUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserName.Location = new System.Drawing.Point(100, 13);
            this.InputUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputUserName.Name = "InputUserName";
            this.InputUserName.PasswordChar = '\0';
            this.InputUserName.PlaceholderText = "";
            this.InputUserName.ReadOnly = true;
            this.InputUserName.SelectedText = "";
            this.InputUserName.Size = new System.Drawing.Size(304, 47);
            this.InputUserName.TabIndex = 1;
            // 
            // ButtonsLayout
            // 
            this.ButtonsLayout.ColumnCount = 2;
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayout.Controls.Add(this.Buttonlogout, 1, 0);
            this.ButtonsLayout.Controls.Add(this.ButtonEditProfile, 0, 0);
            this.ButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsLayout.Location = new System.Drawing.Point(3, 387);
            this.ButtonsLayout.Name = "ButtonsLayout";
            this.ButtonsLayout.RowCount = 1;
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayout.Size = new System.Drawing.Size(408, 44);
            this.ButtonsLayout.TabIndex = 4;
            // 
            // Buttonlogout
            // 
            this.Buttonlogout.BorderRadius = 5;
            this.Buttonlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Buttonlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Buttonlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Buttonlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Buttonlogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Buttonlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.Buttonlogout.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Buttonlogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.Buttonlogout.Location = new System.Drawing.Point(207, 3);
            this.Buttonlogout.Name = "Buttonlogout";
            this.Buttonlogout.Size = new System.Drawing.Size(198, 38);
            this.Buttonlogout.TabIndex = 6;
            this.Buttonlogout.Text = "Выйти";
            this.Buttonlogout.Click += new System.EventHandler(this.Buttonlogout_Click);
            // 
            // ButtonEditProfile
            // 
            this.ButtonEditProfile.BorderRadius = 5;
            this.ButtonEditProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEditProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEditProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonEditProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonEditProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEditProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.ButtonEditProfile.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ButtonEditProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonEditProfile.Location = new System.Drawing.Point(3, 3);
            this.ButtonEditProfile.Name = "ButtonEditProfile";
            this.ButtonEditProfile.Size = new System.Drawing.Size(198, 38);
            this.ButtonEditProfile.TabIndex = 5;
            this.ButtonEditProfile.Text = "Изменить";
            this.ButtonEditProfile.Click += new System.EventHandler(this.ButtonEditProfile_Click);
            // 
            // UserProfileOrdersLayout
            // 
            this.UserProfileOrdersLayout.ColumnCount = 1;
            this.UserProfileOrdersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserProfileOrdersLayout.Controls.Add(this.ButtonUpdate, 0, 1);
            this.UserProfileOrdersLayout.Controls.Add(this.TableOrders, 0, 0);
            this.UserProfileOrdersLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserProfileOrdersLayout.Location = new System.Drawing.Point(427, 6);
            this.UserProfileOrdersLayout.Name = "UserProfileOrdersLayout";
            this.UserProfileOrdersLayout.RowCount = 2;
            this.UserProfileOrdersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserProfileOrdersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.UserProfileOrdersLayout.Size = new System.Drawing.Size(453, 434);
            this.UserProfileOrdersLayout.TabIndex = 2;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BorderRadius = 5;
            this.ButtonUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.ButtonUpdate.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ButtonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonUpdate.Location = new System.Drawing.Point(3, 387);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(447, 44);
            this.ButtonUpdate.TabIndex = 6;
            this.ButtonUpdate.Text = "Обновить";
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // TableOrders
            // 
            this.TableOrders.AllowUserToAddRows = false;
            this.TableOrders.AllowUserToDeleteRows = false;
            this.TableOrders.AllowUserToResizeRows = false;
            this.TableOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.TableOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.TableOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TableOrders.ColumnHeadersHeight = 35;
            this.TableOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableOrders.DefaultCellStyle = dataGridViewCellStyle4;
            this.TableOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableOrders.EnableHeadersVisualStyles = false;
            this.TableOrders.GridColor = System.Drawing.Color.DimGray;
            this.TableOrders.Location = new System.Drawing.Point(3, 3);
            this.TableOrders.MultiSelect = false;
            this.TableOrders.Name = "TableOrders";
            this.TableOrders.ReadOnly = true;
            this.TableOrders.RowHeadersVisible = false;
            this.TableOrders.RowHeadersWidth = 51;
            this.TableOrders.RowTemplate.Height = 30;
            this.TableOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableOrders.Size = new System.Drawing.Size(447, 378);
            this.TableOrders.TabIndex = 5;
            // 
            // ProductsPage
            // 
            this.ProductsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ProductsPage.Controls.Add(this.ProductsLayout);
            this.ProductsPage.Location = new System.Drawing.Point(4, 44);
            this.ProductsPage.Name = "ProductsPage";
            this.ProductsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsPage.Size = new System.Drawing.Size(892, 452);
            this.ProductsPage.TabIndex = 1;
            this.ProductsPage.Text = "Сделать заказ";
            this.ProductsPage.Enter += new System.EventHandler(this.ProductsPage_Enter);
            // 
            // ProductsLayout
            // 
            this.ProductsLayout.AutoScroll = true;
            this.ProductsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsLayout.Location = new System.Drawing.Point(3, 3);
            this.ProductsLayout.Name = "ProductsLayout";
            this.ProductsLayout.Size = new System.Drawing.Size(886, 446);
            this.ProductsLayout.TabIndex = 0;
            this.ProductsLayout.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ProductsLayout_ControlAdded);
            this.ProductsLayout.DoubleClick += new System.EventHandler(this.ProductsPage_Enter);
            // 
            // UserPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.UserPages);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Name = "UserPanel";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.UserPages.ResumeLayout(false);
            this.ProfilePage.ResumeLayout(false);
            this.UserProfileLayout.ResumeLayout(false);
            this.UserProfileInfoLayout.ResumeLayout(false);
            this.UserProfileInfoPanel.ResumeLayout(false);
            this.UserProfileInfoPanel.PerformLayout();
            this.ButtonsLayout.ResumeLayout(false);
            this.UserProfileOrdersLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableOrders)).EndInit();
            this.ProductsPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl UserPages;
        private System.Windows.Forms.TabPage ProfilePage;
        private System.Windows.Forms.TabPage ProductsPage;
        private System.Windows.Forms.TableLayoutPanel UserProfileLayout;
        private System.Windows.Forms.TableLayoutPanel UserProfileInfoLayout;
        private Guna.UI2.WinForms.Guna2Panel UserProfileInfoPanel;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox InputUserPassword;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox InputUserLogin;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox InputUserAddress;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox InputUserName;
        private System.Windows.Forms.TableLayoutPanel ButtonsLayout;
        private Guna.UI2.WinForms.Guna2Button Buttonlogout;
        private Guna.UI2.WinForms.Guna2Button ButtonEditProfile;
        private System.Windows.Forms.TableLayoutPanel UserProfileOrdersLayout;
        private Guna.UI2.WinForms.Guna2Button ButtonUpdate;
        private System.Windows.Forms.DataGridView TableOrders;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox InputUserPhone;
        private System.Windows.Forms.FlowLayoutPanel ProductsLayout;
    }
}
