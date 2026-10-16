using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using BeautySalon.Авторизация;

namespace FurnitureFactory_factory.Работники
{
    public partial class AdminPanel: UserControl
    {
        private int Product_ID = -1;
        private int Employee_ID = -1;
        public AdminPanel()
        {
            InitializeComponent();
        }

        //Первая загрузка
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            AdminProductsPage_Enter(sender, e);
        }

        //------------------------------------ТОВАРЫ------------------------------------
        //Загрузка данных из БД (товары)
        private void AdminProductsPage_Enter(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
            {
                try
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(@"
                        SELECT
					    	[ID_Товар] AS [ID],
					    	[Название],
                            [Стоимость]
                        FROM
                            [Товары]
                        WHERE
                            [Активность] = 1
                        ", connection);
                    adapter.Fill(dataTable);

                    TableProducts.DataSource = dataTable;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                connection.Close();
            }
        }

        //Выбор товара
        private void TableProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Product_ID = (int)TableProducts.Rows[e.RowIndex].Cells[0].Value;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT [Название], [Описание], [Изображение], [Стоимость] FROM [Товары] WHERE [ID_Товар] = @ID_Товар";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_Товар", Product_ID);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        InputProductName.Text = reader["Название"].ToString();
                        InputProductDescription.Text = reader["Описание"].ToString();
                        InputProductPrice.Text = reader["Стоимость"].ToString();

                        byte[] imageBytes = (byte[])reader["Изображение"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                            InputProductImage.Image = Image.FromStream(ms);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных товара: " + ex.Message);
                }
            }
        }

        //Загрузка изображения (окно выбора изображения)
        private void InputProductImage_Click(object sender, EventArgs e)
        {
            if (ImageSelector.ShowDialog() == DialogResult.OK)
            {
                InputProductImage.Image = Image.FromFile(ImageSelector.FileName);
                InputProductImage.Text = ImageSelector.FileName;
            }
        }

        //Добавить товар
        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            InputProductName.Enabled = !InputProductName.Enabled;
            InputProductPrice.Enabled = !InputProductPrice.Enabled;
            InputProductDescription.Enabled = !InputProductDescription.Enabled;
            InputProductImage.Enabled = !InputProductImage.Enabled;

            if (ButtonAddProduct.Text == "Создать")
            {
                ButtonAddProduct.Text = "Сохранить";

                InputProductName.Text = "";
                InputProductPrice.Text = "";
                InputProductDescription.Text = "";
                InputProductImage.Image = null;
                InputProductImage.Text = "";
            }
            else
            {
                ButtonAddProduct.Text = "Создать";

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
                {
                    try
                    {
                        connection.Open();

                        string query = @"
                            INSERT INTO [Товары]
                                ([Название], [Описание], [Изображение], [Стоимость], [Наличие], [Активность]) 
                            VALUES
                                (@Название, @Описание, @Изображение, @Стоимость, @Наличие, @Активность)";
                        SqlCommand command = new SqlCommand(query, connection);

                        byte[] imageData;
                        using (FileStream fs = new FileStream(InputProductImage.Text, FileMode.Open, FileAccess.Read))
                            using (BinaryReader br = new BinaryReader(fs))
                                imageData = br.ReadBytes((int)fs.Length);                        

                        command.Parameters.AddWithValue("@Название", InputProductName.Text);
                        command.Parameters.AddWithValue("@Описание", InputProductDescription.Text);
                        command.Parameters.AddWithValue("@Изображение", imageData);
                        command.Parameters.AddWithValue("@Стоимость", Convert.ToDecimal(InputProductPrice.Text));
                        command.Parameters.AddWithValue("@Наличие", false);
                        command.Parameters.AddWithValue("@Активность", true);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Товар успешно добавлен!");

                        AdminProductsPage_Enter(sender, e);
                        InputProductImage.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при добавлении товара: " + ex.Message);
                    }
                }

            }
        }

        //Изменить товар
        private void ButtonEditProduct_Click(object sender, EventArgs e)
        {
            if (Product_ID != -1)
            {
                InputProductName.Enabled = !InputProductName.Enabled;
                InputProductPrice.Enabled = !InputProductPrice.Enabled;
                InputProductDescription.Enabled = !InputProductDescription.Enabled;
                InputProductImage.Enabled = !InputProductImage.Enabled;

                if (ButtonEditProduct.Text == "Изменить")
                {
                    ButtonEditProduct.Text = "Сохранить";
                }
                else
                {
                    ButtonEditProduct.Text = "Изменить";

                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
                    {
                        try
                        {
                            connection.Open();

                            SqlCommand command;
                            string query;

                            if (!string.IsNullOrWhiteSpace(InputProductImage.Text) && File.Exists(InputProductImage.Text))
                            {
                                query = @"
                                     UPDATE [Товары]
                                     SET [Название] = @Название,
                                         [Описание] = @Описание,
                                         [Изображение] = @Изображение,
                                         [Стоимость] = @Стоимость
                                     WHERE [ID_Товар] = @ID_Товар";

                                command = new SqlCommand(query, connection);

                                byte[] imageData;
                                using (FileStream fs = new FileStream(InputProductImage.Text, FileMode.Open, FileAccess.Read))
                                using (BinaryReader br = new BinaryReader(fs))
                                {
                                    imageData = br.ReadBytes((int)fs.Length);
                                }

                                command.Parameters.AddWithValue("@Изображение", imageData);
                            }
                            else
                            {
                                query = @"
                                     UPDATE [Товары]
                                     SET [Название] = @Название,
                                         [Описание] = @Описание,
                                         [Стоимость] = @Стоимость
                                     WHERE [ID_Товар] = @ID_Товар";

                                command = new SqlCommand(query, connection);
                            }

                            command.Parameters.AddWithValue("@Название", InputProductName.Text);
                            command.Parameters.AddWithValue("@Описание", InputProductDescription.Text);
                            command.Parameters.AddWithValue("@Стоимость", Convert.ToDecimal(InputProductPrice.Text));
                            command.Parameters.AddWithValue("@ID_Товар", Product_ID);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Товар успешно обновлён!");

                            AdminProductsPage_Enter(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при обновлении товара: " + ex.Message);
                        }
                    }

                }
            }
        }

        //Удалить товар
        private void ButtonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (Product_ID != -1)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить товар?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
                    {
                        try
                        {
                            connection.Open();

                            string query = "UPDATE [Товары] SET [Активность] = 0 WHERE [ID_Товар] = @ID_Товар";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@ID_Товар", Product_ID);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Товар успешно удалён (деактивирован).");

                            InputProductName.Text = "";
                            InputProductPrice.Text = "";
                            InputProductDescription.Text = "";
                            InputProductImage.Image = null;
                            InputProductImage.Text = "";

                            Product_ID = -1;
                            AdminProductsPage_Enter(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при удалении товара: " + ex.Message);
                        }
                    }
                }
            }
        }




        //------------------------------------РАБОТНИКИ------------------------------------
        //Загрузка данных из БД (работники и роли)
        private void AdminEmployeesPage_Enter(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
            {
                try
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(@"
                        SELECT
                            Работники.ID_Работник AS [ID],
                            Работники.Имя,
                            Роли.Название AS [Должность]
                        FROM
                            Работники
                        JOIN
                            Роли ON Работники.ID_Роль = Роли.ID_Роль
                    ", connection);
                    adapter.Fill(dataTable);

                    TableEmployees.DataSource = dataTable;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                connection.Close();


                //Загрузка данных о ролях
                try
                {
                    connection.Open();

                    List<KeyValuePair<int, string>> clients = new List<KeyValuePair<int, string>>();
                    string query = "SELECT [ID_Роль], [Название] FROM [Роли]";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        int clientID = reader.GetInt32(0);
                        string clientName = reader.GetString(1);

                        clients.Add(new KeyValuePair<int, string>(clientID, $"{clientName}"));
                    }
                    reader.Close();

                    InputEmployeeRole.DataSource = clients;
                    InputEmployeeRole.ValueMember = "Key";
                    InputEmployeeRole.DisplayMember = "Value";
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                connection.Close();
            }
        }

        //Выбор работника
        private void TableEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Employee_ID = (int)TableEmployees.Rows[e.RowIndex].Cells[0].Value;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT [Логин], [Пароль], [Имя], [ID_Роль] FROM [Работники] WHERE [ID_Работник] = @ID_Работник";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_Работник", Employee_ID);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        InputEmployeeLogin.Text = reader["Логин"].ToString();
                        InputEmployeePassword.Text = reader["Пароль"].ToString();
                        InputEmployeeName.Text = reader["Имя"].ToString();

                        int roleId = Convert.ToInt32(reader["ID_Роль"]);

                        foreach (KeyValuePair<int, string> item in InputEmployeeRole.Items)
                        {
                            if (item.Key == roleId)
                            {
                                InputEmployeeRole.SelectedItem = item;
                                break;
                            }
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных работника: " + ex.Message);
                }
            }
        }


        //Добавить работника
        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            InputEmployeeName.Enabled = !InputEmployeeName.Enabled;
            InputEmployeeLogin.Enabled = !InputEmployeeLogin.Enabled;
            InputEmployeePassword.Enabled = !InputEmployeePassword.Enabled;
            InputEmployeeRole.Enabled = !InputEmployeeRole.Enabled;

            if (ButtonAddEmployee.Text == "Создать")
            {
                ButtonAddEmployee.Text = "Сохранить";

                InputEmployeeLogin.Text = "";
                InputEmployeePassword.Text = "";
                InputEmployeeRole.Text = "";
                InputEmployeeName.Text = "";
            }
            else
            {
                ButtonAddEmployee.Text = "Создать";

                //Сохранение
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
                {
                    try
                    {
                        connection.Open();

                        string query = @"
                                INSERT INTO [Работники]
                                    ([Логин], [Пароль], [Имя], [ID_Роль])
                                VALUES
                                    (@Логин, @Пароль, @Имя, @ID_Роль)";
                        SqlCommand sqlCommand = new SqlCommand(query, connection);

                        sqlCommand.Parameters.AddWithValue("@Логин", InputEmployeeLogin.Text);
                        sqlCommand.Parameters.AddWithValue("@Пароль", InputEmployeePassword.Text);
                        sqlCommand.Parameters.AddWithValue("@Имя", InputEmployeeName.Text);
                        sqlCommand.Parameters.AddWithValue("@ID_Роль", ((KeyValuePair<int, string>)InputEmployeeRole.SelectedItem).Key);

                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Работник успешно добавлен!");

                        AdminEmployeesPage_Enter(sender, e);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Ошибка при добавлении работника: " + exception.Message);
                    }
                    connection.Close();
                }
            }
        }

        //Изменить работника
        private void ButtonEditEmployee_Click(object sender, EventArgs e)
        {
            if (Employee_ID != -1)
            {
                TableEmployees.Enabled = !TableEmployees.Enabled;
                InputEmployeeName.Enabled = !InputEmployeeName.Enabled;
                InputEmployeeLogin.Enabled = !InputEmployeeLogin.Enabled;
                InputEmployeePassword.Enabled = !InputEmployeePassword.Enabled;
                InputEmployeeRole.Enabled = !InputEmployeeRole.Enabled;

                if (ButtonEditEmployee.Text == "Изменить")
                {
                    ButtonEditEmployee.Text = "Сохранить";
                }
                else
                {
                    ButtonEditEmployee.Text = "Изменить";

                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
                    {
                        try
                        {
                            connection.Open();

                            string query = "UPDATE [Работники] SET [Логин] = @Логин, [Пароль] = @Пароль, [Имя] = @Имя, [ID_Роль] = @ID_Роль WHERE [ID_Работник] = @ID_Работник";
                            SqlCommand sqlCommand = new SqlCommand(query, connection);

                            sqlCommand.Parameters.AddWithValue("@Логин", InputEmployeeLogin.Text);
                            sqlCommand.Parameters.AddWithValue("@Пароль", InputEmployeePassword.Text);
                            sqlCommand.Parameters.AddWithValue("@Имя", InputEmployeeName.Text);
                            sqlCommand.Parameters.AddWithValue("@ID_Роль", ((KeyValuePair<int, string>)InputEmployeeRole.SelectedItem).Key);
                            sqlCommand.Parameters.AddWithValue("@ID_Работник", Employee_ID);
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Данные работника успешно обновлены!");

                            AdminEmployeesPage_Enter(sender, e);
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

        //Удалить работника
        private void ButtonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (Employee_ID != -1)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить работника?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
                    {
                        try
                        {
                            connection.Open();

                            string query = "DELETE FROM [Работники] WHERE [ID_Работник] = @ID_Работник";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@ID_Работник", Employee_ID);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Работник успешно удалён.");

                            InputEmployeeName.Text = "";
                            InputEmployeeLogin.Text = "";
                            InputEmployeePassword.Text = "";
                            InputEmployeeRole.SelectedIndex = -1;

                            Employee_ID = -1;
                            AdminEmployeesPage_Enter(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при удалении работника: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
