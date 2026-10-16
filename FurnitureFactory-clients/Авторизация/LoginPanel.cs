using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using FurnitureFactory_clients;

namespace BeautySalon.Авторизация
{
    public partial class LoginPanel: UserControl
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        //Вход в аккаунт
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(FurnitureFactory_clients.Properties.Settings.Default.Connection))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT ID_Пользователь
                        FROM Пользователи
                        WHERE Логин = @Логин AND Пароль = @Пароль";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Логин", InputLogin.Text.Trim());
                    command.Parameters.AddWithValue("@Пароль", InputPassword.Text.Trim());

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int userId = Convert.ToInt32(result);

                        Control parent = Parent;
                        parent.Controls.Clear();
                        parent.Controls.Add(new UserPanel(userId));
                    }
                    else
                        MessageBox.Show("Неверный логин или пароль.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка входа: " + ex.Message);
                }
            }
        }

        //Переадресация на регистрацию
        private void LinkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control parent = Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new RegisterPanel());
        }
    }
}
