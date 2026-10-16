using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using FurnitureFactory_factory.Работники;

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
            using (SqlConnection connection = new SqlConnection(FurnitureFactory_factory.Properties.Settings.Default.Connection))
            {
                try
                {
                    connection.Open();
                    string query = @"
                         SELECT Роли.Название
                         FROM Работники
                         JOIN Роли ON Работники.ID_Роль = Роли.ID_Роль
                         WHERE Работники.Логин = @Логин AND Работники.Пароль = @Пароль";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Логин", InputLogin.Text.Trim());
                    command.Parameters.AddWithValue("@Пароль", InputPassword.Text.Trim());

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();
                        Control parent = Parent;
                        parent.Controls.Clear();

                        switch (role)
                        {
                            case "Администратор":
                                {
                                    parent.Controls.Add(new AdminPanel());
                                    break;
                                }
                            case "Диспетчер":
                                {
                                    parent.Controls.Add(new DispatcherPanel());
                                    break;
                                }
                            case "Логист":
                                {
                                    parent.Controls.Add(new SenderPanel());
                                    break;
                                }
                            case "Рабочий":
                                {
                                    parent.Controls.Add(new ProductionPanel());
                                    break;
                                }
                            case "Менеджер по закупкам":
                                {
                                    parent.Controls.Add(new SupplyPanel());
                                    break;
                                }
                        }
                    }
                    else
                        MessageBox.Show("Неверный логин или пароль.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при получении роли: " + ex.Message);
                }
            }
        }
    }
}
