namespace BeautySalon.Авторизация
{
    partial class RegisterPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.LinkToLogin = new System.Windows.Forms.LinkLabel();
            this.ButtonRegister = new Guna.UI2.WinForms.Guna2TileButton();
            this.InputPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.InputLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.InputAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.InputPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.InputName = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(345, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Есть аккаунт?";
            // 
            // LinkToLogin
            // 
            this.LinkToLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.LinkToLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LinkToLogin.AutoSize = true;
            this.LinkToLogin.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.LinkToLogin.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.LinkToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.LinkToLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.LinkToLogin.Location = new System.Drawing.Point(484, 445);
            this.LinkToLogin.Name = "LinkToLogin";
            this.LinkToLogin.Size = new System.Drawing.Size(65, 26);
            this.LinkToLogin.TabIndex = 10;
            this.LinkToLogin.TabStop = true;
            this.LinkToLogin.Text = "Войти";
            this.LinkToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkToLogin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.LinkToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToLogin_LinkClicked);
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonRegister.BorderRadius = 10;
            this.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.ButtonRegister.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.ButtonRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.ButtonRegister.Location = new System.Drawing.Point(275, 385);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(350, 47);
            this.ButtonRegister.TabIndex = 9;
            this.ButtonRegister.Text = "Зарегистрироваться";
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
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
            this.InputPassword.Location = new System.Drawing.Point(239, 311);
            this.InputPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '●';
            this.InputPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(180)))), ((int)(((byte)(187)))));
            this.InputPassword.PlaceholderText = "Пароль";
            this.InputPassword.SelectedText = "";
            this.InputPassword.Size = new System.Drawing.Size(422, 58);
            this.InputPassword.TabIndex = 8;
            this.InputPassword.UseSystemPasswordChar = true;
            this.InputPassword.WordWrap = false;
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
            this.InputLogin.Location = new System.Drawing.Point(239, 243);
            this.InputLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputLogin.Name = "InputLogin";
            this.InputLogin.PasswordChar = '\0';
            this.InputLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(180)))), ((int)(((byte)(187)))));
            this.InputLogin.PlaceholderText = "Имя пользователя";
            this.InputLogin.SelectedText = "";
            this.InputLogin.Size = new System.Drawing.Size(422, 58);
            this.InputLogin.TabIndex = 7;
            this.InputLogin.WordWrap = false;
            // 
            // InputAddress
            // 
            this.InputAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputAddress.BorderRadius = 5;
            this.InputAddress.BorderThickness = 2;
            this.InputAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputAddress.DefaultText = "";
            this.InputAddress.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.InputAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputAddress.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.InputAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.InputAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.InputAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            this.InputAddress.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.InputAddress.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputAddress.ForeColor = System.Drawing.Color.Black;
            this.InputAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            this.InputAddress.HoverState.ForeColor = System.Drawing.Color.Black;
            this.InputAddress.Location = new System.Drawing.Point(239, 175);
            this.InputAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputAddress.Name = "InputAddress";
            this.InputAddress.PasswordChar = '\0';
            this.InputAddress.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(180)))), ((int)(((byte)(187)))));
            this.InputAddress.PlaceholderText = "Адрес";
            this.InputAddress.SelectedText = "";
            this.InputAddress.Size = new System.Drawing.Size(422, 58);
            this.InputAddress.TabIndex = 13;
            this.InputAddress.WordWrap = false;
            // 
            // InputPhone
            // 
            this.InputPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputPhone.BorderRadius = 5;
            this.InputPhone.BorderThickness = 2;
            this.InputPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputPhone.DefaultText = "";
            this.InputPhone.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.InputPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputPhone.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.InputPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.InputPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.InputPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            this.InputPhone.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.InputPhone.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputPhone.ForeColor = System.Drawing.Color.Black;
            this.InputPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            this.InputPhone.HoverState.ForeColor = System.Drawing.Color.Black;
            this.InputPhone.Location = new System.Drawing.Point(239, 107);
            this.InputPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputPhone.Name = "InputPhone";
            this.InputPhone.PasswordChar = '\0';
            this.InputPhone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(180)))), ((int)(((byte)(187)))));
            this.InputPhone.PlaceholderText = "Телефон";
            this.InputPhone.SelectedText = "";
            this.InputPhone.Size = new System.Drawing.Size(422, 58);
            this.InputPhone.TabIndex = 12;
            this.InputPhone.WordWrap = false;
            // 
            // InputName
            // 
            this.InputName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputName.BorderRadius = 5;
            this.InputName.BorderThickness = 2;
            this.InputName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputName.DefaultText = "";
            this.InputName.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.InputName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputName.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.InputName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.InputName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.InputName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            this.InputName.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.InputName.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.InputName.ForeColor = System.Drawing.Color.Black;
            this.InputName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            this.InputName.HoverState.ForeColor = System.Drawing.Color.Black;
            this.InputName.Location = new System.Drawing.Point(239, 39);
            this.InputName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputName.Name = "InputName";
            this.InputName.PasswordChar = '\0';
            this.InputName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(180)))), ((int)(((byte)(187)))));
            this.InputName.PlaceholderText = "Имя";
            this.InputName.SelectedText = "";
            this.InputName.Size = new System.Drawing.Size(422, 58);
            this.InputName.TabIndex = 14;
            this.InputName.WordWrap = false;
            // 
            // RegisterPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.InputAddress);
            this.Controls.Add(this.InputPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LinkToLogin);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputLogin);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterPanel";
            this.Size = new System.Drawing.Size(900, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkToLogin;
        private Guna.UI2.WinForms.Guna2TileButton ButtonRegister;
        private Guna.UI2.WinForms.Guna2TextBox InputPassword;
        private Guna.UI2.WinForms.Guna2TextBox InputLogin;
        private Guna.UI2.WinForms.Guna2TextBox InputAddress;
        private Guna.UI2.WinForms.Guna2TextBox InputPhone;
        private Guna.UI2.WinForms.Guna2TextBox InputName;
    }
}
