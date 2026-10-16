using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using FurnitureFactory_clients.Товары;
using BeautySalon.Авторизация;

namespace FurnitureFactory_clients
{
    public partial class UserPanel: UserControl
    {
        private int User_ID = -1;
        public UserPanel(int userId)
        {
            InitializeComponent();

            User_ID = userId;
        }

        //Загрузка данных о профиле
        private void ProfilePage_Enter(object sender, EventArgs e)
        {
            if (User_ID != -1)
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
                {
                    //Загрузка данных профиля
                    try
                    {
                        connection.Open();

                        string query = @"
                            SELECT 
                                [Имя],
                                [Телефон],
                                [Адрес],
                                [Логин],
                                [Пароль]
                            FROM
				            	Пользователи
                            WHERE
				            	ID_Пользователь = @ID_Пользователь";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Пользователь", User_ID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                InputUserName.Text = reader["Имя"].ToString();
                                InputUserPhone.Text = reader["Телефон"].ToString();
                                InputUserAddress.Text = reader["Адрес"].ToString();
                                InputUserLogin.Text = reader["Логин"].ToString();
                                InputUserPassword.Text = reader["Пароль"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка загрузки данных заказа: " + ex.Message);
                    }
                    connection.Close();

                    //Загрузка истории заказов
                    try
                    {
                        connection.Open();
                        DataTable dataTable = new DataTable();

                        string query = @"
                            SELECT 
                                Заказы.ID_Заказ AS [ID],
                                Заказы.Дата,
                                Товары.Название AS Товар,
                                Заказы.Сумма,
                                Заказы.СтатусЗаказа AS Статус
                            FROM 
                                Заказы
                            JOIN 
                                Товары ON Заказы.ID_Товар = Товары.ID_Товар
                            JOIN 
                                Пользователи ON Заказы.ID_Пользователь = Пользователи.ID_Пользователь
                            WHERE
                                Пользователи.ID_Пользователь = @ID_Пользователь";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Пользователь", User_ID);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        TableOrders.DataSource = dataTable;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Не удалось загрузить данные: " + exception.Message);
                    }
                    connection.Close();
                }
            }
        }

        //Обновить таблицу
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            ProfilePage_Enter(sender, e);
        }

        //Изменить профиль
        private void ButtonEditProfile_Click(object sender, EventArgs e)
        {
            if (User_ID != -1)
            {
                InputUserName.Enabled = !InputUserName.Enabled;
                InputUserAddress.Enabled = !InputUserAddress.Enabled;
                InputUserPhone.Enabled = !InputUserPhone.Enabled;
                InputUserLogin.Enabled = !InputUserLogin.Enabled;
                InputUserPassword.Enabled = !InputUserPassword.Enabled;

                if (ButtonEditProfile.Text == "Изменить")
                {
                    ButtonEditProfile.Text = "Сохранить";
                }
                else
                {
                    ButtonEditProfile.Text = "Изменить";

                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
                    {
                        try
                        {
                            connection.Open();

                            string query = @"
                                UPDATE [Пользователи]
                                SET [Логин] = @Логин,
                                    [Пароль] = @Пароль,
                                    [Телефон] = @Телефон,
                                    [Имя] = @Имя,
                                    [Адрес] = @Адрес
                                WHERE [ID_Пользователь] = @ID_Пользователь";
                            SqlCommand sqlCommand = new SqlCommand(query, connection);

                            sqlCommand.Parameters.AddWithValue("@Логин", InputUserLogin.Text);
                            sqlCommand.Parameters.AddWithValue("@Пароль", InputUserPassword.Text);
                            sqlCommand.Parameters.AddWithValue("@Телефон", InputUserPhone.Text);
                            sqlCommand.Parameters.AddWithValue("@Имя", InputUserName.Text);
                            sqlCommand.Parameters.AddWithValue("@Адрес", InputUserAddress.Text);
                            sqlCommand.Parameters.AddWithValue("@ID_Пользователь", User_ID);

                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Данные работника успешно обновлены!");

                            ProfilePage_Enter(sender, e);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show("Ошибка при обновлении данных работника: " + exception.Message);
                        }
                        connection.Close();
                    }
                }
            }
        }

        //Выйти из профиля
        private void Buttonlogout_Click(object sender, EventArgs e)
        {
            User_ID = -1;

            Control parent = Parent;
            parent.Controls.Remove(this);
            parent.Controls.Add(new LoginPanel());
        }

        //Загрузка данных о товарах
        private void ProductsPage_Enter(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT
                            [ID_Товар] AS [ID],
                            [Название],
                            [Стоимость],
                            [Описание],
                            [Изображение]
                        FROM
                            [Товары]
                        WHERE
                            [Активность] = 1 AND [Наличие] = 1";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    ProductsLayout.Controls.Clear();
                    while (reader.Read())
                    {
                        int id = (int)reader["ID"];
                        string name = reader["Название"].ToString();
                        string price = reader["Стоимость"].ToString();
                        string description = reader["Описание"].ToString();

                        byte[] imageBytes = (byte[])reader["Изображение"];
                        Image image;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                            image = Image.FromStream(ms);

                        ProductsLayout.Controls.Add(new OrderMin(id, name, price, image));
                    }

                    reader.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                connection.Close();
            }

        }

        //Выбор товара (открытие формы)
        private void ProductCard_Click(object sender, EventArgs e)
        {
            OrderMin order = sender as OrderMin;
            int ID = order.Product_ID;
            double price = order.Price;

            if (User_ID != -1)
            {
                if (new OrderMax(ID).ShowDialog() == DialogResult.OK)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
                    {
                        try
                        {
                            connection.Open();
                            string query = @"
                            INSERT INTO Заказы ([Дата], [ID_Пользователь], [ID_Товар], [Сумма], [СтатусЗаказа])
                            VALUES (GETDATE(), @ID_Пользователь, @ID_Товар, @Сумма, N'Ожидает подтверждения')";

                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@ID_Пользователь", User_ID);
                            command.Parameters.AddWithValue("@ID_Товар", ID);
                            command.Parameters.AddWithValue("@Сумма", price);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Заказ успешно создан!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при создании заказа: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void ProductsLayout_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is OrderMin)
            {
                e.Control.Click += ProductCard_Click;
            }
        }

        //Первая загрузка
        private void UserPanel_Load(object sender, EventArgs e)
        {
            ProfilePage_Enter(sender, e);
        }
    }
}
