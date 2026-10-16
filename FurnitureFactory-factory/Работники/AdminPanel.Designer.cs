namespace FurnitureFactory_factory.Работники
{
    partial class AdminPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AdminPages = new Guna.UI2.WinForms.Guna2TabControl();
            this.AdminProductsPage = new System.Windows.Forms.TabPage();
            this.AdminProductsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AdminProductInfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonDeleteProduct = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonEditProduct = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.AdminProductInfoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.InputProductDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.InputProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputProductPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.AdminProductPanel = new System.Windows.Forms.Panel();
            this.TableProducts = new System.Windows.Forms.DataGridView();
            this.AdminEmployeesPage = new System.Windows.Forms.TabPage();
            this.AdminEmployeesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AdminEmployeeInfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonDeleteEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonEditEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAddEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.AdminEmployeeInfoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.InputEmployeeRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InputEmployeePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InputEmployeeLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputEmployeeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.AdminEmployeesPanel = new System.Windows.Forms.Panel();
            this.TableEmployees = new System.Windows.Forms.DataGridView();
            this.ImageSelector = new System.Windows.Forms.OpenFileDialog();
            this.AdminPages.SuspendLayout();
            this.AdminProductsPage.SuspendLayout();
            this.AdminProductsLayout.SuspendLayout();
            this.AdminProductInfoLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.AdminProductInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputProductImage)).BeginInit();
            this.AdminProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableProducts)).BeginInit();
            this.AdminEmployeesPage.SuspendLayout();
            this.AdminEmployeesLayout.SuspendLayout();
            this.AdminEmployeeInfoLayout.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.AdminEmployeeInfoPanel.SuspendLayout();
            this.AdminEmployeesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminPages
            // 
            this.AdminPages.Controls.Add(this.AdminProductsPage);
            this.AdminPages.Controls.Add(this.AdminEmployeesPage);
            this.AdminPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPages.ItemSize = new System.Drawing.Size(180, 40);
            this.AdminPages.Location = new System.Drawing.Point(0, 0);
            this.AdminPages.Name = "AdminPages";
            this.AdminPages.SelectedIndex = 0;
            this.AdminPages.Size = new System.Drawing.Size(900, 500);
            this.AdminPages.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.AdminPages.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.AdminPages.TabButtonHoverState.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.AdminPages.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.AdminPages.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.AdminPages.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.AdminPages.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.AdminPages.TabButtonIdleState.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.AdminPages.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.AdminPages.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.AdminPages.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.AdminPages.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.AdminPages.TabButtonSelectedState.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminPages.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.AdminPages.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.AdminPages.TabButtonSize = new System.Drawing.Size(180, 40);
            this.AdminPages.TabIndex = 0;
            this.AdminPages.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.AdminPages.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // AdminProductsPage
            // 
            this.AdminProductsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.AdminProductsPage.Controls.Add(this.AdminProductsLayout);
            this.AdminProductsPage.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.AdminProductsPage.Location = new System.Drawing.Point(4, 44);
            this.AdminProductsPage.Name = "AdminProductsPage";
            this.AdminProductsPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdminProductsPage.Size = new System.Drawing.Size(892, 452);
            this.AdminProductsPage.TabIndex = 0;
            this.AdminProductsPage.Text = "Товары";
            this.AdminProductsPage.Enter += new System.EventHandler(this.AdminProductsPage_Enter);
            // 
            // AdminProductsLayout
            // 
            this.AdminProductsLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.AdminProductsLayout.ColumnCount = 2;
            this.AdminProductsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.AdminProductsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AdminProductsLayout.Controls.Add(this.AdminProductInfoLayout, 0, 0);
            this.AdminProductsLayout.Controls.Add(this.AdminProductPanel, 1, 0);
            this.AdminProductsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminProductsLayout.Location = new System.Drawing.Point(3, 3);
            this.AdminProductsLayout.Name = "AdminProductsLayout";
            this.AdminProductsLayout.Padding = new System.Windows.Forms.Padding(2);
            this.AdminProductsLayout.RowCount = 1;
            this.AdminProductsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AdminProductsLayout.Size = new System.Drawing.Size(886, 446);
            this.AdminProductsLayout.TabIndex = 3;
            // 
            // AdminProductInfoLayout
            // 
            this.AdminProductInfoLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.AdminProductInfoLayout.ColumnCount = 1;
            this.AdminProductInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AdminProductInfoLayout.Controls.Add(this.ButtonDeleteProduct, 0, 2);
            this.AdminProductInfoLayout.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.AdminProductInfoLayout.Controls.Add(this.AdminProductInfoPanel, 0, 0);
            this.AdminProductInfoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminProductInfoLayout.Location = new System.Drawing.Point(6, 6);
            this.AdminProductInfoLayout.Name = "AdminProductInfoLayout";
            this.AdminProductInfoLayout.RowCount = 3;
            this.AdminProductInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AdminProductInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.AdminProductInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.AdminProductInfoLayout.Size = new System.Drawing.Size(414, 434);
            this.AdminProductInfoLayout.TabIndex = 1;
            // 
            // ButtonDeleteProduct
            // 
            this.ButtonDeleteProduct.BorderRadius = 5;
            this.ButtonDeleteProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDeleteProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDeleteProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDeleteProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonDeleteProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDeleteProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.ButtonDeleteProduct.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ButtonDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonDeleteProduct.Location = new System.Drawing.Point(3, 387);
            this.ButtonDeleteProduct.Name = "ButtonDeleteProduct";
            this.ButtonDeleteProduct.Size = new System.Drawing.Size(408, 44);
            this.ButtonDeleteProduct.TabIndex = 4;
            this.ButtonDeleteProduct.Text = "Удалить";
            this.ButtonDeleteProduct.Click += new System.EventHandler(this.ButtonDeleteProduct_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ButtonEditProduct, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonAddProduct, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 337);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(408, 44);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ButtonEditProduct
            // 
            this.ButtonEditProduct.BorderRadius = 5;
            this.ButtonEditProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEditProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEditProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonEditProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonEditProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEditProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.ButtonEditProduct.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ButtonEditProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonEditProduct.Location = new System.Drawing.Point(207, 3);
            this.ButtonEditProduct.Name = "ButtonEditProduct";
            this.ButtonEditProduct.Size = new System.Drawing.Size(198, 38);
            this.ButtonEditProduct.TabIndex = 2;
            this.ButtonEditProduct.Text = "Изменить";
            this.ButtonEditProduct.Click += new System.EventHandler(this.ButtonEditProduct_Click);
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.BorderRadius = 5;
            this.ButtonAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.ButtonAddProduct.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ButtonAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonAddProduct.Location = new System.Drawing.Point(3, 3);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(198, 38);
            this.ButtonAddProduct.TabIndex = 0;
            this.ButtonAddProduct.Text = "Создать";
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // AdminProductInfoPanel
            // 
            this.AdminProductInfoPanel.Controls.Add(this.InputProductDescription);
            this.AdminProductInfoPanel.Controls.Add(this.InputProductImage);
            this.AdminProductInfoPanel.Controls.Add(this.label2);
            this.AdminProductInfoPanel.Controls.Add(this.InputProductPrice);
            this.AdminProductInfoPanel.Controls.Add(this.label1);
            this.AdminProductInfoPanel.Controls.Add(this.InputProductName);
            this.AdminProductInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminProductInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.AdminProductInfoPanel.Name = "AdminProductInfoPanel";
            this.AdminProductInfoPanel.Size = new System.Drawing.Size(408, 328);
            this.AdminProductInfoPanel.TabIndex = 3;
            // 
            // InputProductDescription
            // 
            this.InputProductDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputProductDescription.BorderRadius = 10;
            this.InputProductDescription.BorderThickness = 2;
            this.InputProductDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputProductDescription.DefaultText = "";
            this.InputProductDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputProductDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputProductDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputProductDescription.Enabled = false;
            this.InputProductDescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputProductDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputProductDescription.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputProductDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputProductDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputProductDescription.Location = new System.Drawing.Point(8, 177);
            this.InputProductDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputProductDescription.Multiline = true;
            this.InputProductDescription.Name = "InputProductDescription";
            this.InputProductDescription.PasswordChar = '\0';
            this.InputProductDescription.PlaceholderText = "";
            this.InputProductDescription.SelectedText = "";
            this.InputProductDescription.Size = new System.Drawing.Size(400, 146);
            this.InputProductDescription.TabIndex = 6;
            // 
            // InputProductImage
            // 
            this.InputProductImage.BorderRadius = 15;
            this.InputProductImage.Enabled = false;
            this.InputProductImage.ImageRotate = 0F;
            this.InputProductImage.Location = new System.Drawing.Point(4, 6);
            this.InputProductImage.Name = "InputProductImage";
            this.InputProductImage.Size = new System.Drawing.Size(160, 160);
            this.InputProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InputProductImage.TabIndex = 5;
            this.InputProductImage.TabStop = false;
            this.InputProductImage.Click += new System.EventHandler(this.InputProductImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label2.Location = new System.Drawing.Point(166, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена";
            // 
            // InputProductPrice
            // 
            this.InputProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputProductPrice.BorderRadius = 10;
            this.InputProductPrice.BorderThickness = 2;
            this.InputProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputProductPrice.DefaultText = "";
            this.InputProductPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputProductPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputProductPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputProductPrice.Enabled = false;
            this.InputProductPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputProductPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputProductPrice.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputProductPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputProductPrice.Location = new System.Drawing.Point(170, 120);
            this.InputProductPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputProductPrice.Name = "InputProductPrice";
            this.InputProductPrice.PasswordChar = '\0';
            this.InputProductPrice.PlaceholderText = "";
            this.InputProductPrice.SelectedText = "";
            this.InputProductPrice.Size = new System.Drawing.Size(234, 47);
            this.InputProductPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(166, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // InputProductName
            // 
            this.InputProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputProductName.BorderRadius = 10;
            this.InputProductName.BorderThickness = 2;
            this.InputProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputProductName.DefaultText = "";
            this.InputProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputProductName.Enabled = false;
            this.InputProductName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputProductName.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputProductName.Location = new System.Drawing.Point(170, 38);
            this.InputProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputProductName.Name = "InputProductName";
            this.InputProductName.PasswordChar = '\0';
            this.InputProductName.PlaceholderText = "";
            this.InputProductName.SelectedText = "";
            this.InputProductName.Size = new System.Drawing.Size(234, 47);
            this.InputProductName.TabIndex = 1;
            // 
            // AdminProductPanel
            // 
            this.AdminProductPanel.AutoScroll = true;
            this.AdminProductPanel.Controls.Add(this.TableProducts);
            this.AdminProductPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminProductPanel.Font = new System.Drawing.Font("Tektur", 12F);
            this.AdminProductPanel.Location = new System.Drawing.Point(427, 6);
            this.AdminProductPanel.Name = "AdminProductPanel";
            this.AdminProductPanel.Size = new System.Drawing.Size(453, 434);
            this.AdminProductPanel.TabIndex = 2;
            // 
            // TableProducts
            // 
            this.TableProducts.AllowUserToAddRows = false;
            this.TableProducts.AllowUserToDeleteRows = false;
            this.TableProducts.AllowUserToResizeRows = false;
            this.TableProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.TableProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.TableProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tektur", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableProducts.ColumnHeadersHeight = 35;
            this.TableProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tektur", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableProducts.EnableHeadersVisualStyles = false;
            this.TableProducts.GridColor = System.Drawing.Color.DimGray;
            this.TableProducts.Location = new System.Drawing.Point(0, 0);
            this.TableProducts.MultiSelect = false;
            this.TableProducts.Name = "TableProducts";
            this.TableProducts.ReadOnly = true;
            this.TableProducts.RowHeadersVisible = false;
            this.TableProducts.RowHeadersWidth = 51;
            this.TableProducts.RowTemplate.Height = 30;
            this.TableProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableProducts.Size = new System.Drawing.Size(453, 434);
            this.TableProducts.TabIndex = 2;
            this.TableProducts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableProducts_RowEnter);
            // 
            // AdminEmployeesPage
            // 
            this.AdminEmployeesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.AdminEmployeesPage.Controls.Add(this.AdminEmployeesLayout);
            this.AdminEmployeesPage.Location = new System.Drawing.Point(4, 44);
            this.AdminEmployeesPage.Name = "AdminEmployeesPage";
            this.AdminEmployeesPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdminEmployeesPage.Size = new System.Drawing.Size(892, 452);
            this.AdminEmployeesPage.TabIndex = 1;
            this.AdminEmployeesPage.Text = "Работники";
            this.AdminEmployeesPage.Enter += new System.EventHandler(this.AdminEmployeesPage_Enter);
            // 
            // AdminEmployeesLayout
            // 
            this.AdminEmployeesLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.AdminEmployeesLayout.ColumnCount = 2;
            this.AdminEmployeesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.AdminEmployeesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AdminEmployeesLayout.Controls.Add(this.AdminEmployeeInfoLayout, 0, 0);
            this.AdminEmployeesLayout.Controls.Add(this.AdminEmployeesPanel, 1, 0);
            this.AdminEmployeesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminEmployeesLayout.Location = new System.Drawing.Point(3, 3);
            this.AdminEmployeesLayout.Name = "AdminEmployeesLayout";
            this.AdminEmployeesLayout.Padding = new System.Windows.Forms.Padding(2);
            this.AdminEmployeesLayout.RowCount = 1;
            this.AdminEmployeesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AdminEmployeesLayout.Size = new System.Drawing.Size(886, 446);
            this.AdminEmployeesLayout.TabIndex = 4;
            // 
            // AdminEmployeeInfoLayout
            // 
            this.AdminEmployeeInfoLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.AdminEmployeeInfoLayout.ColumnCount = 1;
            this.AdminEmployeeInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AdminEmployeeInfoLayout.Controls.Add(this.ButtonDeleteEmployee, 0, 2);
            this.AdminEmployeeInfoLayout.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.AdminEmployeeInfoLayout.Controls.Add(this.AdminEmployeeInfoPanel, 0, 0);
            this.AdminEmployeeInfoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminEmployeeInfoLayout.Location = new System.Drawing.Point(6, 6);
            this.AdminEmployeeInfoLayout.Name = "AdminEmployeeInfoLayout";
            this.AdminEmployeeInfoLayout.RowCount = 3;
            this.AdminEmployeeInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AdminEmployeeInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.AdminEmployeeInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.AdminEmployeeInfoLayout.Size = new System.Drawing.Size(414, 434);
            this.AdminEmployeeInfoLayout.TabIndex = 1;
            // 
            // ButtonDeleteEmployee
            // 
            this.ButtonDeleteEmployee.BorderRadius = 5;
            this.ButtonDeleteEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDeleteEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDeleteEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDeleteEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonDeleteEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDeleteEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.ButtonDeleteEmployee.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ButtonDeleteEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonDeleteEmployee.Location = new System.Drawing.Point(3, 387);
            this.ButtonDeleteEmployee.Name = "ButtonDeleteEmployee";
            this.ButtonDeleteEmployee.Size = new System.Drawing.Size(408, 44);
            this.ButtonDeleteEmployee.TabIndex = 4;
            this.ButtonDeleteEmployee.Text = "Удалить";
            this.ButtonDeleteEmployee.Click += new System.EventHandler(this.ButtonDeleteEmployee_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.ButtonEditEmployee, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.ButtonAddEmployee, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 337);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(408, 44);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // ButtonEditEmployee
            // 
            this.ButtonEditEmployee.BorderRadius = 5;
            this.ButtonEditEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEditEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEditEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonEditEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonEditEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEditEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.ButtonEditEmployee.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ButtonEditEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonEditEmployee.Location = new System.Drawing.Point(207, 3);
            this.ButtonEditEmployee.Name = "ButtonEditEmployee";
            this.ButtonEditEmployee.Size = new System.Drawing.Size(198, 38);
            this.ButtonEditEmployee.TabIndex = 2;
            this.ButtonEditEmployee.Text = "Изменить";
            this.ButtonEditEmployee.Click += new System.EventHandler(this.ButtonEditEmployee_Click);
            // 
            // ButtonAddEmployee
            // 
            this.ButtonAddEmployee.BorderRadius = 5;
            this.ButtonAddEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAddEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAddEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAddEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.ButtonAddEmployee.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ButtonAddEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonAddEmployee.Location = new System.Drawing.Point(3, 3);
            this.ButtonAddEmployee.Name = "ButtonAddEmployee";
            this.ButtonAddEmployee.Size = new System.Drawing.Size(198, 38);
            this.ButtonAddEmployee.TabIndex = 0;
            this.ButtonAddEmployee.Text = "Создать";
            this.ButtonAddEmployee.Click += new System.EventHandler(this.ButtonAddEmployee_Click);
            // 
            // AdminEmployeeInfoPanel
            // 
            this.AdminEmployeeInfoPanel.Controls.Add(this.InputEmployeeRole);
            this.AdminEmployeeInfoPanel.Controls.Add(this.label6);
            this.AdminEmployeeInfoPanel.Controls.Add(this.label5);
            this.AdminEmployeeInfoPanel.Controls.Add(this.InputEmployeePassword);
            this.AdminEmployeeInfoPanel.Controls.Add(this.label4);
            this.AdminEmployeeInfoPanel.Controls.Add(this.InputEmployeeLogin);
            this.AdminEmployeeInfoPanel.Controls.Add(this.label3);
            this.AdminEmployeeInfoPanel.Controls.Add(this.InputEmployeeName);
            this.AdminEmployeeInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminEmployeeInfoPanel.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.AdminEmployeeInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.AdminEmployeeInfoPanel.Name = "AdminEmployeeInfoPanel";
            this.AdminEmployeeInfoPanel.Size = new System.Drawing.Size(408, 328);
            this.AdminEmployeeInfoPanel.TabIndex = 3;
            // 
            // InputEmployeeRole
            // 
            this.InputEmployeeRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputEmployeeRole.BackColor = System.Drawing.Color.Transparent;
            this.InputEmployeeRole.BorderRadius = 10;
            this.InputEmployeeRole.BorderThickness = 2;
            this.InputEmployeeRole.DisabledState.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputEmployeeRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.InputEmployeeRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputEmployeeRole.Enabled = false;
            this.InputEmployeeRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputEmployeeRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputEmployeeRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputEmployeeRole.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputEmployeeRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.InputEmployeeRole.HoverState.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputEmployeeRole.ItemHeight = 30;
            this.InputEmployeeRole.ItemsAppearance.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputEmployeeRole.ItemsAppearance.SelectedFont = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputEmployeeRole.Location = new System.Drawing.Point(6, 276);
            this.InputEmployeeRole.MaxDropDownItems = 3;
            this.InputEmployeeRole.Name = "InputEmployeeRole";
            this.InputEmployeeRole.Size = new System.Drawing.Size(402, 36);
            this.InputEmployeeRole.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label6.Location = new System.Drawing.Point(2, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Роль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label5.Location = new System.Drawing.Point(1, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Пароль";
            // 
            // InputEmployeePassword
            // 
            this.InputEmployeePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputEmployeePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeePassword.BorderRadius = 10;
            this.InputEmployeePassword.BorderThickness = 2;
            this.InputEmployeePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputEmployeePassword.DefaultText = "";
            this.InputEmployeePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputEmployeePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeePassword.Enabled = false;
            this.InputEmployeePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputEmployeePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputEmployeePassword.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputEmployeePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputEmployeePassword.Location = new System.Drawing.Point(4, 196);
            this.InputEmployeePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputEmployeePassword.Name = "InputEmployeePassword";
            this.InputEmployeePassword.PasswordChar = '●';
            this.InputEmployeePassword.PlaceholderText = "";
            this.InputEmployeePassword.SelectedText = "";
            this.InputEmployeePassword.Size = new System.Drawing.Size(402, 47);
            this.InputEmployeePassword.TabIndex = 7;
            this.InputEmployeePassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label4.Location = new System.Drawing.Point(0, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Логин";
            // 
            // InputEmployeeLogin
            // 
            this.InputEmployeeLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputEmployeeLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeeLogin.BorderRadius = 10;
            this.InputEmployeeLogin.BorderThickness = 2;
            this.InputEmployeeLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputEmployeeLogin.DefaultText = "";
            this.InputEmployeeLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeeLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputEmployeeLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeeLogin.Enabled = false;
            this.InputEmployeeLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputEmployeeLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputEmployeeLogin.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputEmployeeLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeeLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputEmployeeLogin.Location = new System.Drawing.Point(3, 115);
            this.InputEmployeeLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputEmployeeLogin.Name = "InputEmployeeLogin";
            this.InputEmployeeLogin.PasswordChar = '\0';
            this.InputEmployeeLogin.PlaceholderText = "";
            this.InputEmployeeLogin.SelectedText = "";
            this.InputEmployeeLogin.Size = new System.Drawing.Size(402, 47);
            this.InputEmployeeLogin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label3.Location = new System.Drawing.Point(-1, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя";
            // 
            // InputEmployeeName
            // 
            this.InputEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputEmployeeName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeeName.BorderRadius = 10;
            this.InputEmployeeName.BorderThickness = 2;
            this.InputEmployeeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputEmployeeName.DefaultText = "";
            this.InputEmployeeName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputEmployeeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeeName.Enabled = false;
            this.InputEmployeeName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputEmployeeName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeeName.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeeName.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeeName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeeName.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputEmployeeName.Location = new System.Drawing.Point(3, 35);
            this.InputEmployeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputEmployeeName.Name = "InputEmployeeName";
            this.InputEmployeeName.PasswordChar = '\0';
            this.InputEmployeeName.PlaceholderText = "";
            this.InputEmployeeName.SelectedText = "";
            this.InputEmployeeName.Size = new System.Drawing.Size(402, 47);
            this.InputEmployeeName.TabIndex = 3;
            // 
            // AdminEmployeesPanel
            // 
            this.AdminEmployeesPanel.AutoScroll = true;
            this.AdminEmployeesPanel.Controls.Add(this.TableEmployees);
            this.AdminEmployeesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminEmployeesPanel.Font = new System.Drawing.Font("Tektur", 12F);
            this.AdminEmployeesPanel.Location = new System.Drawing.Point(427, 6);
            this.AdminEmployeesPanel.Name = "AdminEmployeesPanel";
            this.AdminEmployeesPanel.Size = new System.Drawing.Size(453, 434);
            this.AdminEmployeesPanel.TabIndex = 2;
            // 
            // TableEmployees
            // 
            this.TableEmployees.AllowUserToAddRows = false;
            this.TableEmployees.AllowUserToDeleteRows = false;
            this.TableEmployees.AllowUserToResizeRows = false;
            this.TableEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.TableEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.TableEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tektur", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TableEmployees.ColumnHeadersHeight = 35;
            this.TableEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tektur", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableEmployees.DefaultCellStyle = dataGridViewCellStyle4;
            this.TableEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableEmployees.EnableHeadersVisualStyles = false;
            this.TableEmployees.GridColor = System.Drawing.Color.DimGray;
            this.TableEmployees.Location = new System.Drawing.Point(0, 0);
            this.TableEmployees.MultiSelect = false;
            this.TableEmployees.Name = "TableEmployees";
            this.TableEmployees.ReadOnly = true;
            this.TableEmployees.RowHeadersVisible = false;
            this.TableEmployees.RowHeadersWidth = 51;
            this.TableEmployees.RowTemplate.Height = 30;
            this.TableEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableEmployees.Size = new System.Drawing.Size(453, 434);
            this.TableEmployees.TabIndex = 1;
            this.TableEmployees.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableEmployees_RowEnter);
            // 
            // ImageSelector
            // 
            this.ImageSelector.Filter = "PNG изображения (*.png)|*.png";
            // 
            // AdminPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.AdminPages);
            this.Font = new System.Drawing.Font("Tektur", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminPanel";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.AdminPages.ResumeLayout(false);
            this.AdminProductsPage.ResumeLayout(false);
            this.AdminProductsLayout.ResumeLayout(false);
            this.AdminProductInfoLayout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.AdminProductInfoPanel.ResumeLayout(false);
            this.AdminProductInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputProductImage)).EndInit();
            this.AdminProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableProducts)).EndInit();
            this.AdminEmployeesPage.ResumeLayout(false);
            this.AdminEmployeesLayout.ResumeLayout(false);
            this.AdminEmployeeInfoLayout.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.AdminEmployeeInfoPanel.ResumeLayout(false);
            this.AdminEmployeeInfoPanel.PerformLayout();
            this.AdminEmployeesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl AdminPages;
        private System.Windows.Forms.TabPage AdminProductsPage;
        private System.Windows.Forms.TabPage AdminEmployeesPage;
        private System.Windows.Forms.TableLayoutPanel AdminProductsLayout;
        private System.Windows.Forms.TableLayoutPanel AdminProductInfoLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button ButtonEditProduct;
        private Guna.UI2.WinForms.Guna2Button ButtonAddProduct;
        private Guna.UI2.WinForms.Guna2Panel AdminProductInfoPanel;
        private System.Windows.Forms.Panel AdminProductPanel;
        private Guna.UI2.WinForms.Guna2Button ButtonDeleteProduct;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox InputProductName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox InputProductPrice;
        private Guna.UI2.WinForms.Guna2PictureBox InputProductImage;
        private Guna.UI2.WinForms.Guna2TextBox InputProductDescription;
        private System.Windows.Forms.TableLayoutPanel AdminEmployeesLayout;
        private System.Windows.Forms.TableLayoutPanel AdminEmployeeInfoLayout;
        private Guna.UI2.WinForms.Guna2Button ButtonDeleteEmployee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2Button ButtonEditEmployee;
        private Guna.UI2.WinForms.Guna2Button ButtonAddEmployee;
        private Guna.UI2.WinForms.Guna2Panel AdminEmployeeInfoPanel;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox InputEmployeeLogin;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox InputEmployeeName;
        private System.Windows.Forms.Panel AdminEmployeesPanel;
        private Guna.UI2.WinForms.Guna2ComboBox InputEmployeeRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox InputEmployeePassword;
        private System.Windows.Forms.DataGridView TableEmployees;
        private System.Windows.Forms.DataGridView TableProducts;
        private System.Windows.Forms.OpenFileDialog ImageSelector;
    }
}
