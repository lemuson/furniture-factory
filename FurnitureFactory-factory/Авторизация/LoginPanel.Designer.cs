namespace BeautySalon.Авторизация
{
    partial class LoginPanel
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
            this.InputLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.InputPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonLogin = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // InputLogin
            // 
            this.InputLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputLogin.BorderRadius = 5;
            this.InputLogin.BorderThickness = 2;
            this.InputLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputLogin.DefaultText = "";
            this.InputLogin.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.InputLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputLogin.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.InputLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.InputLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.InputLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            this.InputLogin.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.InputLogin.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputLogin.ForeColor = System.Drawing.Color.Black;
            this.InputLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            this.InputLogin.HoverState.ForeColor = System.Drawing.Color.Black;
            this.InputLogin.Location = new System.Drawing.Point(239, 120);
            this.InputLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputLogin.Name = "InputLogin";
            this.InputLogin.PasswordChar = '\0';
            this.InputLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(180)))), ((int)(((byte)(187)))));
            this.InputLogin.PlaceholderText = "Имя пользователя";
            this.InputLogin.SelectedText = "";
            this.InputLogin.Size = new System.Drawing.Size(422, 58);
            this.InputLogin.TabIndex = 0;
            this.InputLogin.WordWrap = false;
            // 
            // InputPassword
            // 
            this.InputPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputPassword.BorderRadius = 5;
            this.InputPassword.BorderThickness = 2;
            this.InputPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputPassword.DefaultText = "";
            this.InputPassword.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.InputPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputPassword.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.InputPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.InputPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.InputPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            this.InputPassword.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.InputPassword.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputPassword.ForeColor = System.Drawing.Color.Black;
            this.InputPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            this.InputPassword.HoverState.ForeColor = System.Drawing.Color.Black;
            this.InputPassword.Location = new System.Drawing.Point(239, 188);
            this.InputPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '●';
            this.InputPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(180)))), ((int)(((byte)(187)))));
            this.InputPassword.PlaceholderText = "Пароль";
            this.InputPassword.SelectedText = "";
            this.InputPassword.Size = new System.Drawing.Size(422, 58);
            this.InputPassword.TabIndex = 1;
            this.InputPassword.UseSystemPasswordChar = true;
            this.InputPassword.WordWrap = false;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonLogin.BorderRadius = 10;
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.ButtonLogin.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.ButtonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonLogin.Location = new System.Drawing.Point(275, 262);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(350, 47);
            this.ButtonLogin.TabIndex = 2;
            this.ButtonLogin.Text = "Войти";
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // LoginPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputLogin);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(900, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox InputLogin;
        private Guna.UI2.WinForms.Guna2TextBox InputPassword;
        private Guna.UI2.WinForms.Guna2TileButton ButtonLogin;
    }
}
