using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akami_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "provider") buttonOpenProviders.Enabled = false;
            labelHello.Text = "Добро пожаловать, " + FormAuthorization.users.login;
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenProviders_Click(object sender, EventArgs e)
        {
            Form formProvider = new FormProvider();
            formProvider.Show();
        }

        private void buttonOpenProducts_Click(object sender, EventArgs e)
        {
            Form formProduct = new FormProduct();
            formProduct.Show();
        }

        private void buttonOpenOrders_Click(object sender, EventArgs e)
        {
            Form formOrder = new FormOrder();
            formOrder.Show();
        }
    }
}
