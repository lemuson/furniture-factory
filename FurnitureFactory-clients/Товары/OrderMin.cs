using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureFactory_clients.Товары
{
    public partial class OrderMin: UserControl
    {
        public int Product_ID = -1;
        public double Price = 0;
        public OrderMin(int id, string name, string price, Image image)
        {
            InitializeComponent();

            Product_ID = id;
            Price = Convert.ToDouble(price);

            InputProductName.Text = name;
            InputProductPrice.Text = price + " Р";
            InputProductImage.Image = image;
        }


        private void Element_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
