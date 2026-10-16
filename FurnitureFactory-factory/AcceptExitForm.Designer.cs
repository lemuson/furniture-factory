namespace FurnitureFactory_factory
{
    partial class AcceptExitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonLogout = new Guna.UI2.WinForms.Guna2TileButton();
            this.ButtonExit = new Guna.UI2.WinForms.Guna2TileButton();
            this.ButtonsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы уверены, что хотите выйти?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonsContainer
            // 
            this.ButtonsContainer.ColumnCount = 2;
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsContainer.Controls.Add(this.ButtonExit, 1, 0);
            this.ButtonsContainer.Controls.Add(this.ButtonLogout, 0, 0);
            this.ButtonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsContainer.Location = new System.Drawing.Point(0, 60);
            this.ButtonsContainer.Name = "ButtonsContainer";
            this.ButtonsContainer.RowCount = 1;
            this.ButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsContainer.Size = new System.Drawing.Size(546, 67);
            this.ButtonsContainer.TabIndex = 1;
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonLogout.BorderRadius = 10;
            this.ButtonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.ButtonLogout.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ButtonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonLogout.Location = new System.Drawing.Point(3, 10);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(267, 47);
            this.ButtonLogout.TabIndex = 3;
            this.ButtonLogout.Text = "Выйти из учетной записи";
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonExit.BorderRadius = 10;
            this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.ButtonExit.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonExit.Location = new System.Drawing.Point(276, 10);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(267, 47);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Выйти из программы";
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // AcceptExitForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(546, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonsContainer);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AcceptExitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ButtonsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel ButtonsContainer;
        private Guna.UI2.WinForms.Guna2TileButton ButtonExit;
        private Guna.UI2.WinForms.Guna2TileButton ButtonLogout;
    }
}