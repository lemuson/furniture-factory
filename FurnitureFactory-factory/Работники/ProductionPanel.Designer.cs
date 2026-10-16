namespace FurnitureFactory_factory.Работники
{
    partial class ProductionPanel
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
            this.ProductionProductsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SupplyProductInfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ProductionProductInfoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.InputProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonCancelOrder = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAcceptProducton = new Guna.UI2.WinForms.Guna2Button();
            this.ProductionProductPanel = new System.Windows.Forms.Panel();
            this.TableOrders = new System.Windows.Forms.DataGridView();
            this.ProductionProductsLayout.SuspendLayout();
            this.SupplyProductInfoLayout.SuspendLayout();
            this.ProductionProductInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputProductImage)).BeginInit();
            this.ButtonsLayout.SuspendLayout();
            this.ProductionProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductionProductsLayout
            // 
            this.ProductionProductsLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ProductionProductsLayout.ColumnCount = 2;
            this.ProductionProductsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.ProductionProductsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProductionProductsLayout.Controls.Add(this.SupplyProductInfoLayout, 0, 0);
            this.ProductionProductsLayout.Controls.Add(this.ProductionProductPanel, 1, 0);
            this.ProductionProductsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductionProductsLayout.Location = new System.Drawing.Point(0, 0);
            this.ProductionProductsLayout.Name = "ProductionProductsLayout";
            this.ProductionProductsLayout.Padding = new System.Windows.Forms.Padding(2);
            this.ProductionProductsLayout.RowCount = 1;
            this.ProductionProductsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProductionProductsLayout.Size = new System.Drawing.Size(900, 500);
            this.ProductionProductsLayout.TabIndex = 5;
            // 
            // SupplyProductInfoLayout
            // 
            this.SupplyProductInfoLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.SupplyProductInfoLayout.ColumnCount = 1;
            this.SupplyProductInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SupplyProductInfoLayout.Controls.Add(this.ProductionProductInfoPanel, 0, 0);
            this.SupplyProductInfoLayout.Controls.Add(this.ButtonsLayout, 0, 1);
            this.SupplyProductInfoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplyProductInfoLayout.Location = new System.Drawing.Point(6, 6);
            this.SupplyProductInfoLayout.Name = "SupplyProductInfoLayout";
            this.SupplyProductInfoLayout.RowCount = 2;
            this.SupplyProductInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SupplyProductInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SupplyProductInfoLayout.Size = new System.Drawing.Size(414, 488);
            this.SupplyProductInfoLayout.TabIndex = 1;
            // 
            // ProductionProductInfoPanel
            // 
            this.ProductionProductInfoPanel.Controls.Add(this.InputProductImage);
            this.ProductionProductInfoPanel.Controls.Add(this.label1);
            this.ProductionProductInfoPanel.Controls.Add(this.InputProductName);
            this.ProductionProductInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductionProductInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.ProductionProductInfoPanel.Name = "ProductionProductInfoPanel";
            this.ProductionProductInfoPanel.Size = new System.Drawing.Size(408, 432);
            this.ProductionProductInfoPanel.TabIndex = 3;
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
            this.InputProductName.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputProductName.Location = new System.Drawing.Point(170, 38);
            this.InputProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputProductName.Name = "InputProductName";
            this.InputProductName.PasswordChar = '\0';
            this.InputProductName.PlaceholderText = "";
            this.InputProductName.ReadOnly = true;
            this.InputProductName.SelectedText = "";
            this.InputProductName.Size = new System.Drawing.Size(234, 47);
            this.InputProductName.TabIndex = 1;
            // 
            // ButtonsLayout
            // 
            this.ButtonsLayout.ColumnCount = 2;
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayout.Controls.Add(this.ButtonCancelOrder, 1, 0);
            this.ButtonsLayout.Controls.Add(this.ButtonAcceptProducton, 0, 0);
            this.ButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsLayout.Location = new System.Drawing.Point(3, 441);
            this.ButtonsLayout.Name = "ButtonsLayout";
            this.ButtonsLayout.RowCount = 1;
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayout.Size = new System.Drawing.Size(408, 44);
            this.ButtonsLayout.TabIndex = 4;
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
            this.ButtonCancelOrder.TabIndex = 6;
            this.ButtonCancelOrder.Text = "Отменить";
            this.ButtonCancelOrder.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonAcceptProducton
            // 
            this.ButtonAcceptProducton.BorderRadius = 5;
            this.ButtonAcceptProducton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAcceptProducton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAcceptProducton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAcceptProducton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAcceptProducton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAcceptProducton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.ButtonAcceptProducton.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ButtonAcceptProducton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonAcceptProducton.Location = new System.Drawing.Point(3, 3);
            this.ButtonAcceptProducton.Name = "ButtonAcceptProducton";
            this.ButtonAcceptProducton.Size = new System.Drawing.Size(198, 38);
            this.ButtonAcceptProducton.TabIndex = 5;
            this.ButtonAcceptProducton.Text = "Произвести";
            this.ButtonAcceptProducton.Click += new System.EventHandler(this.ButtonAcceptProducton_Click);
            // 
            // ProductionProductPanel
            // 
            this.ProductionProductPanel.AutoScroll = true;
            this.ProductionProductPanel.Controls.Add(this.TableOrders);
            this.ProductionProductPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductionProductPanel.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ProductionProductPanel.Location = new System.Drawing.Point(427, 6);
            this.ProductionProductPanel.Name = "ProductionProductPanel";
            this.ProductionProductPanel.Size = new System.Drawing.Size(467, 488);
            this.ProductionProductPanel.TabIndex = 2;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableOrders.ColumnHeadersHeight = 35;
            this.TableOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 12F);
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
            this.TableOrders.TabIndex = 4;
            this.TableOrders.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableOrders_RowEnter);
            this.TableOrders.DoubleClick += new System.EventHandler(this.ProductionPanel_Load);
            // 
            // ProductionPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.ProductionProductsLayout);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Name = "ProductionPanel";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.ProductionPanel_Load);
            this.ProductionProductsLayout.ResumeLayout(false);
            this.SupplyProductInfoLayout.ResumeLayout(false);
            this.ProductionProductInfoPanel.ResumeLayout(false);
            this.ProductionProductInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputProductImage)).EndInit();
            this.ButtonsLayout.ResumeLayout(false);
            this.ProductionProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ProductionProductsLayout;
        private System.Windows.Forms.TableLayoutPanel SupplyProductInfoLayout;
        private Guna.UI2.WinForms.Guna2Panel ProductionProductInfoPanel;
        private Guna.UI2.WinForms.Guna2PictureBox InputProductImage;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox InputProductName;
        private System.Windows.Forms.Panel ProductionProductPanel;
        private System.Windows.Forms.TableLayoutPanel ButtonsLayout;
        private Guna.UI2.WinForms.Guna2Button ButtonAcceptProducton;
        private System.Windows.Forms.DataGridView TableOrders;
        private Guna.UI2.WinForms.Guna2Button ButtonCancelOrder;
    }
}
