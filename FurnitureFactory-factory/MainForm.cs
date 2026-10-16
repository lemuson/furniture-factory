using System;
using System.Windows.Forms;
using BeautySalon.Авторизация;

namespace FurnitureFactory_factory
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainContainer.Controls.Add(new LoginPanel());
        }

        private void MainContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.Dock = DockStyle.Fill;
        }

        //Выход
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = new AcceptExitForm().ShowDialog();

            if (result == DialogResult.Yes)
            {
                MainContainer.Controls.Clear();
                MainContainer.Controls.Add(new LoginPanel());
                e.Cancel = true;
            }
            else if (result == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
