using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureFactory_clients.Товары
{
    public partial class OrderMax: Form
    {
        private int ID = -1;
        public OrderMax(int id)
        {
            InitializeComponent();

            ID = id;
        }

        private void OrderMax_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Connection))
            {
                try
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            [Название],
                            [Описание],
                            [Стоимость],
                            [Изображение]
                        FROM
				        	[Товары]
                        WHERE
				        	[ID_Товар] = @ID_Товар";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_Товар", ID);

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
                            InputProductDescription.Text = reader["Описание"].ToString();
                            InputProductPrice.Text = reader["Стоимость"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки данных заказа: " + ex.Message);
                }
            }
        }

        private void ButtonAddOrder_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
