using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net;

namespace FurnitureFactory_factory.Работники
{
    public partial class SupplyPanel: UserControl
    {
        private int Product_ID = -1;
        public SupplyPanel()
        {
            InitializeComponent();
        }

        //Получение товаров из БД (активных)
        private void SupplyPanel_Load(object sender, EventArgs e)
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
        private void TableOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Product_ID = (int)TableProducts.Rows[e.RowIndex].Cells[0].Value;
            IS_UPDATE = false;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT [Название], [Описание], [Изображение], [Стоимость], [Наличие] FROM [Товары] WHERE [ID_Товар] = @ID_Товар";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_Товар", Product_ID);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        InputProductName.Text = reader["Название"].ToString();
                        InputProductDescription.Text = reader["Описание"].ToString();
                        InputProductPrice.Text = reader["Стоимость"].ToString();
                        InputProductIs.Checked = !(bool)reader["Наличие"];

                        byte[] imageBytes = (byte[])reader["Изображение"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                            InputProductImage.Image = Image.FromStream(ms);

                        IS_UPDATE = true;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных товара: " + ex.Message);
                }
            }
        }

        //Имитация заказа материалов
        bool IS_UPDATE = false;
        private void ButtonGetMaterials_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Материалы доставлены");


            if (Product_ID != -1 && IS_UPDATE)
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand command;
                        string query = @"
                                 UPDATE [Товары]
                                 SET [Наличие] = @Наличие
                                 WHERE [ID_Товар] = @ID_Товар";
                        command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@Наличие", true);
                        command.Parameters.AddWithValue("@ID_Товар", Product_ID);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при обновлении товара: " + ex.Message);
                    }
                }
            }
            IS_UPDATE = false;
            InputProductIs.Checked = false;
        }

        private void UpdateIs()
        {
            if (Product_ID != -1 && IS_UPDATE)
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand command;
                        string query = @"
                                 UPDATE [Товары]
                                 SET [Наличие] = @Наличие
                                 WHERE [ID_Товар] = @ID_Товар";
                        command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@Наличие", !InputProductIs.Checked);
                        command.Parameters.AddWithValue("@ID_Товар", Product_ID);
                        command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при обновлении товара: " + ex.Message);
                    }
                    IS_UPDATE = false;
                }
            }
        }

        private void InputProductIs_CheckedChanged(object sender, EventArgs e)
        {
            ButtonGetMaterials.Enabled = InputProductIs.Checked;
            UpdateIs();
        }
    }
}
