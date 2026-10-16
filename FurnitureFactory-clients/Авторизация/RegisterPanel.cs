using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BeautySalon.Авторизация
{
    public partial class RegisterPanel: UserControl
    {
        public RegisterPanel()
        {
            InitializeComponent();
        }

        //Регистрация
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(FurnitureFactory_clients.Properties.Settings.Default.Connection))
            {
                try
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Пользователи (Логин, Пароль, Адрес, Телефон, Имя)
                        VALUES (@Логин, @Пароль, @Адрес, @Телефон, @Имя)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Логин", InputLogin.Text.Trim());
                    command.Parameters.AddWithValue("@Пароль", InputPassword.Text.Trim());
                    command.Parameters.AddWithValue("@Адрес", InputAddress.Text.Trim());
                    command.Parameters.AddWithValue("@Телефон", InputPhone.Text.Trim());
                    command.Parameters.AddWithValue("@Имя", InputName.Text.Trim());

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Регистрация прошла успешно.");

                        Control parent = Parent;
                        parent.Controls.Clear();
                        parent.Controls.Add(new LoginPanel());
                    }
                    else
                        MessageBox.Show("Ошибка при регистрации.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка регистрации: " + ex.Message);
                }
            }
        }

        //Переадресация на вход
        private void LinkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control parent = Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new LoginPanel());
        }
    }
}
