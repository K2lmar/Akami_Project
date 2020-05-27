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
    public partial class FormProvider : Form
    {
        public FormProvider()
        {
            InitializeComponent();
            ShowProvider();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProvidersSet providerSet = new ProvidersSet();
            providerSet.Firm_Name = textBoxFirm_Name.Text;
            providerSet.Address_Firm = textBoxAddress_Firm.Text;
            providerSet.Phone = textBoxPhone.Text;
            providerSet.License_number = textBoxLicense_number.Text;
            Program.wftDb.ProvidersSet.Add(providerSet);
            Program.wftDb.SaveChanges();
            ShowProvider();
        }
        void ShowProvider()
        {
            listViewProvider.Items.Clear();
            foreach (ProvidersSet providerSet in Program.wftDb.ProvidersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                  providerSet.Id.ToString(), providerSet.Firm_Name,  providerSet.Address_Firm,
                  providerSet.Phone, providerSet.License_number
                });
                item.Tag = providerSet;
                listViewProvider.Items.Add(item);
            }
            listViewProvider.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewProvider.SelectedItems.Count == 1)
            {
                ProvidersSet providerSet = listViewProvider.SelectedItems[0].Tag as ProvidersSet;
                providerSet.Firm_Name = textBoxFirm_Name.Text;
                providerSet.Address_Firm = textBoxAddress_Firm.Text;
                providerSet.Phone = textBoxPhone.Text;
                providerSet.License_number = textBoxLicense_number.Text;
                Program.wftDb.SaveChanges();
                ShowProvider();
            }
        }

        private void listViewProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProvider.SelectedItems.Count == 1)
            {
                ProvidersSet providerSet = listViewProvider.SelectedItems[0].Tag as ProvidersSet;
                textBoxFirm_Name.Text = providerSet.Firm_Name;
                textBoxAddress_Firm.Text = providerSet.Address_Firm;
                textBoxPhone.Text = providerSet.Phone;
                textBoxLicense_number.Text = providerSet.License_number;
            }
            else
            {
                textBoxFirm_Name.Text = "";
                textBoxAddress_Firm.Text = "";
                textBoxPhone.Text = "";
                textBoxLicense_number.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProvider.SelectedItems.Count == 1)
                {
                    ProvidersSet providerSet = listViewProvider.SelectedItems[0].Tag as ProvidersSet;
                    Program.wftDb.ProvidersSet.Remove(providerSet);
                    Program.wftDb.SaveChanges();
                    ShowProvider();
                }
                textBoxFirm_Name.Text = "";
                textBoxAddress_Firm.Text = "";
                textBoxPhone.Text = "";
                textBoxLicense_number.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
