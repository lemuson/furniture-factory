using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace FurnitureFactory_factory.Работники
{
    public partial class ProductionPanel: UserControl
    {
        private int Order_ID = -1;
        public ProductionPanel()
        {
            InitializeComponent();
        }

        //Загрузка данных из бд (заявки со статусом "Отправлен на производство")
        private void ProductionPanel_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
            {
                try
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(@"
                            SELECT 
                                Заказы.ID_Заказ AS [ID],
                                Заказы.Дата,
                                Товары.Название AS Товар,
                                Пользователи.Имя AS Пользователь,
                                Заказы.Сумма
                            FROM 
                                Заказы
                            JOIN 
                                Товары ON Заказы.ID_Товар = Товары.ID_Товар
                            JOIN 
                                Пользователи ON Заказы.ID_Пользователь = Пользователи.ID_Пользователь
                            WHERE
                            	[СтатусЗаказа] = 'Отправлен на производство'
                        ", connection);
                    adapter.Fill(dataTable);

                    TableOrders.DataSource = dataTable;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                connection.Close();
            }
        }

        //Выбор заказа
        private void TableOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Order_ID = (int)TableOrders.Rows[e.RowIndex].Cells[0].Value;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
            {
                try
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            Товары.Изображение,
                            Товары.Название
                        FROM
				        	Заказы
                        JOIN 
				        	Товары ON Заказы.ID_Товар = Товары.ID_Товар
                        WHERE
				        	Заказы.ID_Заказ = @ID_Заказ";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_Заказ", Order_ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                byte[] imageData = (byte[])reader["Изображение"];
                                using (var ms = new MemoryStream(imageData))
                                    InputProductImage.Image = Image.FromStream(ms);
                            }
                            else
                                InputProductImage.Image = null;

                            InputProductName.Text = reader["Название"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки данных заказа: " + ex.Message);
                }
            }
        }

        //Имитация производства (статус заявки "Передан в доставку")
        private void ButtonAcceptProducton_Click(object sender, EventArgs e)
        {
            if (Order_ID != -1)
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE [Заказы] SET [СтатусЗаказа] = @Статус WHERE [ID_Заказ] = @ID_Заказ";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Статус", "Передан в доставку");
                        command.Parameters.AddWithValue("@ID_Заказ", Order_ID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Заказ передан в доставку.");

                        InputProductImage.Image = null;
                        InputProductName.Text = "";

                        Order_ID = -1;
                        ProductionPanel_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при принятии заказа: " + ex.Message);
                    }
                }
            }
        }

        //Отмена на этапе производства
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (Order_ID != -1)
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE [Заказы] SET [СтатусЗаказа] = @Статус WHERE [ID_Заказ] = @ID_Заказ";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Статус", "Отклонен на этапе производства");
                        command.Parameters.AddWithValue("@ID_Заказ", Order_ID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Заказ отклонён.");
                        InputProductImage.Image = null;
                        InputProductName.Text = "";

                        Order_ID = -1;
                        ProductionPanel_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при отклонении заказа: " + ex.Message);
                    }
                }
            }
        }
    }
}
