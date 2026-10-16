namespace FurnitureFactory_factory.Работники
{
    partial class DispatcherPanel
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
            this.DispatherLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OrderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonCancelOrder = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAcceptOrder = new Guna.UI2.WinForms.Guna2Button();
            this.OrderInfoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.InputUserPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InputUserAdress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.InputProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.DispatcerOrdersPanel = new System.Windows.Forms.Panel();
            this.TableOrders = new System.Windows.Forms.DataGridView();
            this.DispatherLayout.SuspendLayout();
            this.OrderPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.OrderInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputProductImage)).BeginInit();
            this.DispatcerOrdersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // DispatherLayout
            // 
            this.DispatherLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.DispatherLayout.ColumnCount = 2;
            this.DispatherLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.DispatherLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DispatherLayout.Controls.Add(this.OrderPanel, 0, 0);
            this.DispatherLayout.Controls.Add(this.DispatcerOrdersPanel, 1, 0);
            this.DispatherLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DispatherLayout.Location = new System.Drawing.Point(0, 0);
            this.DispatherLayout.Name = "DispatherLayout";
            this.DispatherLayout.Padding = new System.Windows.Forms.Padding(2);
            this.DispatherLayout.RowCount = 1;
            this.DispatherLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DispatherLayout.Size = new System.Drawing.Size(900, 500);
            this.DispatherLayout.TabIndex = 2;
            // 
            // OrderPanel
            // 
            this.OrderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.OrderPanel.ColumnCount = 1;
            this.OrderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.OrderPanel.Controls.Add(this.OrderInfoPanel, 0, 0);
            this.OrderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderPanel.Location = new System.Drawing.Point(6, 6);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.RowCount = 2;
            this.OrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.OrderPanel.Size = new System.Drawing.Size(414, 488);
            this.OrderPanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ButtonCancelOrder, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonAcceptOrder, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 441);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(408, 44);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ButtonCancelOrder
            // 
            this.ButtonCancelOrder.BorderRadius = 5;
            this.ButtonCancelOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCancelOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCancelOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonCancelOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonCancelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCancelOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.ButtonCancelOrder.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ButtonCancelOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonCancelOrder.Location = new System.Drawing.Point(207, 3);
            this.ButtonCancelOrder.Name = "ButtonCancelOrder";
            this.ButtonCancelOrder.Size = new System.Drawing.Size(198, 38);
            this.ButtonCancelOrder.TabIndex = 2;
            this.ButtonCancelOrder.Text = "Отклонить";
            this.ButtonCancelOrder.Click += new System.EventHandler(this.ButtonCancelOrder_Click);
            // 
            // ButtonAcceptOrder
            // 
            this.ButtonAcceptOrder.BorderRadius = 5;
            this.ButtonAcceptOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAcceptOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAcceptOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAcceptOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAcceptOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAcceptOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.ButtonAcceptOrder.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ButtonAcceptOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonAcceptOrder.Location = new System.Drawing.Point(3, 3);
            this.ButtonAcceptOrder.Name = "ButtonAcceptOrder";
            this.ButtonAcceptOrder.Size = new System.Drawing.Size(198, 38);
            this.ButtonAcceptOrder.TabIndex = 0;
            this.ButtonAcceptOrder.Text = "Принять";
            this.ButtonAcceptOrder.Click += new System.EventHandler(this.ButtonAcceptOrder_Click);
            // 
            // OrderInfoPanel
            // 
            this.OrderInfoPanel.Controls.Add(this.label5);
            this.OrderInfoPanel.Controls.Add(this.InputUserPhone);
            this.OrderInfoPanel.Controls.Add(this.label4);
            this.OrderInfoPanel.Controls.Add(this.InputUserAdress);
            this.OrderInfoPanel.Controls.Add(this.label3);
            this.OrderInfoPanel.Controls.Add(this.InputUserName);
            this.OrderInfoPanel.Controls.Add(this.InputProductImage);
            this.OrderInfoPanel.Controls.Add(this.label1);
            this.OrderInfoPanel.Controls.Add(this.InputProductName);
            this.OrderInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.OrderInfoPanel.Name = "OrderInfoPanel";
            this.OrderInfoPanel.Size = new System.Drawing.Size(408, 432);
            this.OrderInfoPanel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label5.Location = new System.Drawing.Point(1, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "Телефон заказчика";
            // 
            // InputUserPhone
            // 
            this.InputUserPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputUserPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserPhone.BorderRadius = 10;
            this.InputUserPhone.BorderThickness = 2;
            this.InputUserPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputUserPhone.DefaultText = "";
            this.InputUserPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserPhone.Enabled = false;
            this.InputUserPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputUserPhone.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputUserPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputUserPhone.Location = new System.Drawing.Point(4, 367);
            this.InputUserPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputUserPhone.Name = "InputUserPhone";
            this.InputUserPhone.PasswordChar = '\0';
            this.InputUserPhone.PlaceholderText = "";
            this.InputUserPhone.SelectedText = "";
            this.InputUserPhone.Size = new System.Drawing.Size(402, 47);
            this.InputUserPhone.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label4.Location = new System.Drawing.Point(0, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Адрес заказчика";
            // 
            // InputUserAdress
            // 
            this.InputUserAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputUserAdress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserAdress.BorderRadius = 10;
            this.InputUserAdress.BorderThickness = 2;
            this.InputUserAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputUserAdress.DefaultText = "";
            this.InputUserAdress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserAdress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserAdress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserAdress.Enabled = false;
            this.InputUserAdress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserAdress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputUserAdress.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputUserAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserAdress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputUserAdress.Location = new System.Drawing.Point(3, 286);
            this.InputUserAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputUserAdress.Name = "InputUserAdress";
            this.InputUserAdress.PasswordChar = '\0';
            this.InputUserAdress.PlaceholderText = "";
            this.InputUserAdress.SelectedText = "";
            this.InputUserAdress.Size = new System.Drawing.Size(402, 47);
            this.InputUserAdress.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label3.Location = new System.Drawing.Point(-1, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Имя заказчика";
            // 
            // InputUserName
            // 
            this.InputUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserName.BorderRadius = 10;
            this.InputUserName.BorderThickness = 2;
            this.InputUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputUserName.DefaultText = "";
            this.InputUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserName.Enabled = false;
            this.InputUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserName.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserName.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserName.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserName.Location = new System.Drawing.Point(3, 206);
            this.InputUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputUserName.Name = "InputUserName";
            this.InputUserName.PasswordChar = '\0';
            this.InputUserName.PlaceholderText = "";
            this.InputUserName.SelectedText = "";
            this.InputUserName.Size = new System.Drawing.Size(402, 47);
            this.InputUserName.TabIndex = 10;
            // 
            // InputProductImage
            // 
            this.InputProductImage.BorderRadius = 15;
            this.InputProductImage.Enabled = false;
            this.InputProductImage.ImageRotate = 0F;
            this.InputProductImage.Location = new System.Drawing.Point(0, 3);
            this.InputProductImage.Name = "InputProductImage";
            this.InputProductImage.Size = new System.Drawing.Size(160, 160);
            this.InputProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InputProductImage.TabIndex = 9;
            this.InputProductImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(162, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название товара";
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
            this.InputProductName.Location = new System.Drawing.Point(166, 35);
            this.InputProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputProductName.Name = "InputProductName";
            this.InputProductName.PasswordChar = '\0';
            this.InputProductName.PlaceholderText = "";
            this.InputProductName.SelectedText = "";
            this.InputProductName.Size = new System.Drawing.Size(234, 47);
            this.InputProductName.TabIndex = 7;
            // 
            // DispatcerOrdersPanel
            // 
            this.DispatcerOrdersPanel.AutoScroll = true;
            this.DispatcerOrdersPanel.Controls.Add(this.TableOrders);
            this.DispatcerOrdersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DispatcerOrdersPanel.Font = new System.Drawing.Font("Tektur", 12F);
            this.DispatcerOrdersPanel.Location = new System.Drawing.Point(427, 6);
            this.DispatcerOrdersPanel.Name = "DispatcerOrdersPanel";
            this.DispatcerOrdersPanel.Size = new System.Drawing.Size(467, 488);
            this.DispatcerOrdersPanel.TabIndex = 2;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tektur", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableOrders.ColumnHeadersHeight = 35;
            this.TableOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tektur", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableOrders.EnableHeadersVisualStyles = false;
            this.TableOrders.GridColor = System.Drawing.Color.DimGray;
            this.TableOrders.Location = new System.Drawing.Point(0, 0);
            this.TableOrders.MultiSelect = false;
            this.TableOrders.Name = "TableOrders";
            this.TableOrders.ReadOnly = true;
            this.TableOrders.RowHeadersVisible = false;
            this.TableOrders.RowHeadersWidth = 51;
            this.TableOrders.RowTemplate.Height = 30;
            this.TableOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableOrders.Size = new System.Drawing.Size(467, 488);
            this.TableOrders.TabIndex = 3;
            this.TableOrders.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableOrders_RowEnter);
            this.TableOrders.DoubleClick += new System.EventHandler(this.DispatcherPanel_Load);
            // 
            // DispatcherPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.DispatherLayout);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DispatcherPanel";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.DispatcherPanel_Load);
            this.DispatherLayout.ResumeLayout(false);
            this.OrderPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.OrderInfoPanel.ResumeLayout(false);
            this.OrderInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputProductImage)).EndInit();
            this.DispatcerOrdersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel DispatherLayout;
        private System.Windows.Forms.TableLayoutPanel OrderPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button ButtonCancelOrder;
        private Guna.UI2.WinForms.Guna2Button ButtonAcceptOrder;
        private Guna.UI2.WinForms.Guna2Panel OrderInfoPanel;
        private System.Windows.Forms.Panel DispatcerOrdersPanel;
        private System.Windows.Forms.DataGridView TableOrders;
        private Guna.UI2.WinForms.Guna2PictureBox InputProductImage;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox InputProductName;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox InputUserPhone;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox InputUserAdress;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox InputUserName;
    }
}
