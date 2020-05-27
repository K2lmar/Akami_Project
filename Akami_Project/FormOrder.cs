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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
            ShowClient();
            ShowProduct();
            ShowOrder();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }
        void ShowClient()
        {
            comboBoxIdClient.Items.Clear();
            foreach (ClientsSet clientSet in Program.wftDb.ClientsSet)
            {
                string[] item = {clientSet.Id.ToString() + ".", clientSet.LastName, clientSet.FirstName,
                                 clientSet.MiddleName, clientSet.Email };
                comboBoxIdClient.Items.Add(string.Join("", item));
            }
        }
        void ShowProduct()
        {
           comboBoxIdProduct.Items.Clear();
           foreach (ProductsSet productSet in Program.wftDb.ProductsSet)
           {
              string[] item = {productSet.Id.ToString() + ".",
                  productSet.Product_Name,
                  productSet.Category_products,
                  productSet.IdProviders.ToString() + ".",
                  productSet.Price.ToString() };
              comboBoxIdProduct.Items.Add(string.Join("", item));
           }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxIdClient.SelectedItem != null && comboBoxIdProduct.SelectedItem != null && textBoxAddress_Delivery.Text != "" && comboBoxDelivery_method.Text != null && comboBoxPayment_method.Text != null)
            {
                OrdersSet orderSet = new OrdersSet();
                orderSet.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                orderSet.IdProduct = Convert.ToInt32(comboBoxIdProduct.SelectedItem.ToString().Split('.')[0]);
                orderSet.Address_Delivery = textBoxAddress_Delivery.Text;
                orderSet.Delivery_method = comboBoxDelivery_method.Text;
                orderSet.Payment_method = comboBoxPayment_method.Text;
                Program.wftDb.OrdersSet.Add(orderSet);
                Program.wftDb.SaveChanges();
                ShowOrder();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowOrder()
        {
            listViewOrder.Items.Clear();
            foreach (OrdersSet orderSet in Program.wftDb.OrdersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    orderSet.IdClient.ToString(),
                    orderSet.ClientsSet.LastName+" "+orderSet.ClientsSet.FirstName+" "+orderSet.ClientsSet.MiddleName, 
                    orderSet.IdProduct.ToString() + ".",
                    orderSet.ProductsSet.Product_Name.ToString(),
                    orderSet.Address_Delivery.ToString(),
                    orderSet.Delivery_method.ToString(),
                    orderSet.Payment_method.ToString()
                });
                item.Tag = orderSet;
                listViewOrder.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count == 1)
            {
                OrdersSet orderSet = listViewOrder.SelectedItems[0].Tag as OrdersSet;
                orderSet.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                orderSet.IdProduct = Convert.ToInt32(comboBoxIdProduct.SelectedItem.ToString().Split('.')[0]);
                orderSet.Address_Delivery = textBoxAddress_Delivery.Text;
                orderSet.Delivery_method = comboBoxDelivery_method.Text;
                orderSet.Payment_method = comboBoxPayment_method.Text;
                Program.wftDb.SaveChanges();
                ShowOrder();
            }
        }

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count == 1)
            {
                OrdersSet orderSet = listViewOrder.SelectedItems[0].Tag as OrdersSet;
                comboBoxIdClient.SelectedIndex = comboBoxIdClient.FindString(orderSet.IdClient.ToString());
                comboBoxIdProduct.SelectedIndex = comboBoxIdProduct.FindString(orderSet.IdProduct.ToString());
                textBoxAddress_Delivery.Text = orderSet.Address_Delivery.ToString();
                comboBoxDelivery_method.Text = orderSet.Delivery_method.ToString();
                comboBoxPayment_method.Text = orderSet.Payment_method.ToString();
            }
            else
            {
                comboBoxIdClient.SelectedItem = null;
                comboBoxIdProduct.SelectedItem = null;
                textBoxAddress_Delivery.Text = "";
                comboBoxDelivery_method.Text = null;
                comboBoxPayment_method.Text = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrder.SelectedItems.Count == 1)
                {
                    OrdersSet orderSet = listViewOrder.SelectedItems[0].Tag as OrdersSet;
                    Program.wftDb.OrdersSet.Remove(orderSet);
                    Program.wftDb.SaveChanges();
                    ShowOrder();
                }
                comboBoxIdClient.SelectedItem = null;
                comboBoxIdProduct.SelectedItem = null;
                textBoxAddress_Delivery.Text = "";
                comboBoxDelivery_method.Text = null;
                comboBoxPayment_method.Text = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
