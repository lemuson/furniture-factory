namespace FurnitureFactory_factory
{
    partial class OrderCard
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
            this.OrderInfo = new System.Windows.Forms.TableLayoutPanel();
            this.OrderCompany = new System.Windows.Forms.Label();
            this.OrderDate = new System.Windows.Forms.Label();
            this.OrderImage = new System.Windows.Forms.PictureBox();
            this.OrderLayout.SuspendLayout();
            this.OrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderImage)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderLayout
            // 
            this.OrderLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.OrderLayout.ColumnCount = 2;
            this.OrderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.OrderLayout.Controls.Add(this.OrderInfo, 0, 0);
            this.OrderLayout.Controls.Add(this.OrderImage, 1, 0);
            this.OrderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderLayout.Location = new System.Drawing.Point(0, 0);
            this.OrderLayout.Name = "OrderLayout";
            this.OrderLayout.RowCount = 1;
            this.OrderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderLayout.Size = new System.Drawing.Size(596, 110);
            this.OrderLayout.TabIndex = 0;
            // 
            // OrderInfo
            // 
            this.OrderInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.OrderInfo.ColumnCount = 1;
            this.OrderInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.66443F));
            this.OrderInfo.Controls.Add(this.OrderCompany, 0, 1);
            this.OrderInfo.Controls.Add(this.OrderDate, 0, 0);
            this.OrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderInfo.Location = new System.Drawing.Point(5, 5);
            this.OrderInfo.Name = "OrderInfo";
            this.OrderInfo.RowCount = 2;
            this.OrderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.72727F));
            this.OrderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.27273F));
            this.OrderInfo.Size = new System.Drawing.Size(484, 100);
            this.OrderInfo.TabIndex = 1;
            // 
            // OrderCompany
            // 
            this.OrderCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderCompany.Font = new System.Drawing.Font("Tektur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.OrderCompany.Location = new System.Drawing.Point(4, 33);
            this.OrderCompany.Name = "OrderCompany";
            this.OrderCompany.Size = new System.Drawing.Size(476, 66);
            this.OrderCompany.TabIndex = 2;
            this.OrderCompany.Text = "Название товара";
            this.OrderCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderDate
            // 
            this.OrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDate.Font = new System.Drawing.Font("Tektur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.OrderDate.Location = new System.Drawing.Point(4, 1);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(476, 31);
            this.OrderDate.TabIndex = 0;
            this.OrderDate.Text = "Дата";
            this.OrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderImage
            // 
            this.OrderImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderImage.Location = new System.Drawing.Point(497, 5);
            this.OrderImage.Name = "OrderImage";
            this.OrderImage.Size = new System.Drawing.Size(94, 100);
            this.OrderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OrderImage.TabIndex = 2;
            this.OrderImage.TabStop = false;
            // 
            // OrderCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.OrderLayout);
            this.Name = "OrderCard";
            this.Size = new System.Drawing.Size(596, 110);
            this.OrderLayout.ResumeLayout(false);
            this.OrderInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel OrderLayout;
        private System.Windows.Forms.TableLayoutPanel OrderInfo;
        private System.Windows.Forms.Label OrderCompany;
        private System.Windows.Forms.Label OrderDate;
        private System.Windows.Forms.PictureBox OrderImage;
    }
}
