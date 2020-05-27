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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            ShowProvider();
            ShowProduct();
        }
        void ShowProvider()
        {
            comboBoxIdProviders.Items.Clear();
            foreach (ProvidersSet providerSet in Program.wftDb.ProvidersSet)
            {
                string[] item = { providerSet.Id.ToString() + ".", providerSet.Firm_Name,  providerSet.Address_Firm,
                                  providerSet.Phone, providerSet.License_number };
                comboBoxIdProviders.Items.Add(string.Join("", item));
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 1)
            {
                ProductsSet productSet = listViewProduct.SelectedItems[0].Tag as ProductsSet;
                productSet.Product_Name = textBoxProduct_Name.Text;
                productSet.Category_products = comboBoxCategory_products.Text;
                productSet.IdProviders = Convert.ToInt32(comboBoxIdProviders.SelectedItem.ToString().Split('.')[0]);
                productSet.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.wftDb.SaveChanges();
                ShowProduct();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxProduct_Name.Text != "" && comboBoxCategory_products.Text != null && comboBoxIdProviders.SelectedItem != null && textBoxPrice.Text != "")
            { 
               ProductsSet productSet = new ProductsSet();
               productSet.Product_Name = textBoxProduct_Name.Text;
               productSet.Category_products = comboBoxCategory_products.Text;
               productSet.IdProviders = Convert.ToInt32(comboBoxIdProviders.SelectedItem.ToString().Split('.')[0]);
               productSet.Price = Convert.ToInt64(textBoxPrice.Text);
               Program.wftDb.ProductsSet.Add(productSet);
               Program.wftDb.SaveChanges();
               ShowProduct();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowProduct()
        {
            listViewProduct.Items.Clear();
            foreach (ProductsSet productSet in Program.wftDb.ProductsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    productSet.Id.ToString() + "",
                    productSet.Product_Name.ToString(),
                    productSet.Category_products.ToString(),
                    productSet.IdProviders.ToString(),
                    productSet.ProvidersSet.Firm_Name+" "+productSet.ProvidersSet.Address_Firm+" "+productSet.ProvidersSet.Phone+" "+productSet.ProvidersSet.License_number,
                    productSet.Price.ToString()
                });
                item.Tag = productSet;
                listViewProduct.Items.Add(item);
            }
        }
        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 1)
            {
                ProductsSet productSet = listViewProduct.SelectedItems[0].Tag as ProductsSet;
                textBoxProduct_Name.Text = productSet.Product_Name.ToString();
                comboBoxCategory_products.Text = productSet.Category_products.ToString();
                comboBoxIdProviders.SelectedIndex = comboBoxIdProviders.FindString(productSet.IdProviders.ToString());
                textBoxPrice.Text = productSet.Price.ToString();
            }
            else
            {
                textBoxProduct_Name.Text = "";
                comboBoxCategory_products.Text = null;
                comboBoxIdProviders.SelectedItem = null;
                textBoxPrice.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProduct.SelectedItems.Count == 1)
                {
                    ProductsSet productSet = listViewProduct.SelectedItems[0].Tag as ProductsSet;
                    Program.wftDb.ProductsSet.Remove(productSet);
                    Program.wftDb.SaveChanges();
                    ShowProduct();
                }
                textBoxProduct_Name.Text = "";
                comboBoxCategory_products.Text = null;
                comboBoxIdProviders.SelectedItem = null;
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
