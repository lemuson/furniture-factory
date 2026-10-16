namespace FurnitureFactory_clients.Товары
{
    partial class OrderMin
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
            this.OrderLayout = new System.Windows.Forms.TableLayoutPanel();
            this.InputProductPrice = new System.Windows.Forms.Label();
            this.InputProductName = new System.Windows.Forms.Label();
            this.InputProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.OrderLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderLayout
            // 
            this.OrderLayout.ColumnCount = 1;
            this.OrderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderLayout.Controls.Add(this.InputProductPrice, 0, 2);
            this.OrderLayout.Controls.Add(this.InputProductName, 0, 1);
            this.OrderLayout.Controls.Add(this.InputProductImage, 0, 0);
            this.OrderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderLayout.Location = new System.Drawing.Point(0, 0);
            this.OrderLayout.Name = "OrderLayout";
            this.OrderLayout.RowCount = 3;
            this.OrderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.OrderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.OrderLayout.Size = new System.Drawing.Size(202, 252);
            this.OrderLayout.TabIndex = 0;
            // 
            // InputProductPrice
            // 
            this.InputProductPrice.AutoSize = true;
            this.InputProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputProductPrice.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.InputProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InputProductPrice.Location = new System.Drawing.Point(3, 227);
            this.InputProductPrice.Name = "InputProductPrice";
            this.InputProductPrice.Size = new System.Drawing.Size(196, 25);
            this.InputProductPrice.TabIndex = 4;
            this.InputProductPrice.Text = "Стоимость";
            this.InputProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InputProductPrice.Click += new System.EventHandler(this.Element_Click);
            // 
            // InputProductName
            // 
            this.InputProductName.AutoSize = true;
            this.InputProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.InputProductName.Location = new System.Drawing.Point(3, 202);
            this.InputProductName.Name = "InputProductName";
            this.InputProductName.Size = new System.Drawing.Size(196, 25);
            this.InputProductName.TabIndex = 3;
            this.InputProductName.Text = "Имя";
            this.InputProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InputProductName.Click += new System.EventHandler(this.Element_Click);
            // 
            // InputProductImage
            // 
            this.InputProductImage.BorderRadius = 25;
            this.InputProductImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputProductImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.InputProductImage.ImageRotate = 0F;
            this.InputProductImage.Location = new System.Drawing.Point(3, 3);
            this.InputProductImage.Name = "InputProductImage";
            this.InputProductImage.Size = new System.Drawing.Size(196, 196);
            this.InputProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InputProductImage.TabIndex = 0;
            this.InputProductImage.TabStop = false;
            this.InputProductImage.Click += new System.EventHandler(this.Element_Click);
            // 
            // OrderMin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.OrderLayout);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderMin";
            this.Size = new System.Drawing.Size(202, 252);
            this.OrderLayout.ResumeLayout(false);
            this.OrderLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel OrderLayout;
        private Guna.UI2.WinForms.Guna2PictureBox InputProductImage;
        private System.Windows.Forms.Label InputProductName;
        private System.Windows.Forms.Label InputProductPrice;
    }
}
