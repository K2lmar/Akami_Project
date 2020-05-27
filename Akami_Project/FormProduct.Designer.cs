namespace Akami_Project
{
    partial class FormProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelProduct_Name = new System.Windows.Forms.Label();
            this.labelCategory_products = new System.Windows.Forms.Label();
            this.labelIdProviders = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxProduct_Name = new System.Windows.Forms.TextBox();
            this.comboBoxIdProviders = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory_products = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Salmon;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(445, 221);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 38);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Salmon;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.Location = new System.Drawing.Point(542, 221);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 38);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Salmon;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonDel.Location = new System.Drawing.Point(639, 221);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(80, 38);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelProduct_Name
            // 
            this.labelProduct_Name.AutoSize = true;
            this.labelProduct_Name.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelProduct_Name.Location = new System.Drawing.Point(10, 54);
            this.labelProduct_Name.Name = "labelProduct_Name";
            this.labelProduct_Name.Size = new System.Drawing.Size(123, 15);
            this.labelProduct_Name.TabIndex = 3;
            this.labelProduct_Name.Text = "Название товара";
            // 
            // labelCategory_products
            // 
            this.labelCategory_products.AutoSize = true;
            this.labelCategory_products.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelCategory_products.Location = new System.Drawing.Point(10, 93);
            this.labelCategory_products.Name = "labelCategory_products";
            this.labelCategory_products.Size = new System.Drawing.Size(129, 15);
            this.labelCategory_products.TabIndex = 4;
            this.labelCategory_products.Text = "Категория товара";
            // 
            // labelIdProviders
            // 
            this.labelIdProviders.AutoSize = true;
            this.labelIdProviders.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelIdProviders.Location = new System.Drawing.Point(10, 135);
            this.labelIdProviders.Name = "labelIdProviders";
            this.labelIdProviders.Size = new System.Drawing.Size(81, 15);
            this.labelIdProviders.TabIndex = 5;
            this.labelIdProviders.Text = "Поставщик";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelPrice.Location = new System.Drawing.Point(10, 177);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 15);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Цена";
            // 
            // listViewProduct
            // 
            this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listViewProduct.FullRowSelect = true;
            this.listViewProduct.GridLines = true;
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(208, 1);
            this.listViewProduct.MultiSelect = false;
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(511, 214);
            this.listViewProduct.TabIndex = 7;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.View = System.Windows.Forms.View.Details;
            this.listViewProduct.SelectedIndexChanged += new System.EventHandler(this.listViewProduct_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название товара";
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Категория товара";
            this.columnHeader3.Width = 114;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            this.columnHeader7.Width = 63;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Поставщик";
            this.columnHeader8.Width = 87;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Цена";
            this.columnHeader9.Width = 68;
            // 
            // Logo
            // 
            this.Logo.Image = global::Akami_Project.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(1, 1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 50);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(13, 195);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(189, 20);
            this.textBoxPrice.TabIndex = 9;
            // 
            // textBoxProduct_Name
            // 
            this.textBoxProduct_Name.Location = new System.Drawing.Point(13, 70);
            this.textBoxProduct_Name.Name = "textBoxProduct_Name";
            this.textBoxProduct_Name.Size = new System.Drawing.Size(189, 20);
            this.textBoxProduct_Name.TabIndex = 10;
            // 
            // comboBoxIdProviders
            // 
            this.comboBoxIdProviders.FormattingEnabled = true;
            this.comboBoxIdProviders.Location = new System.Drawing.Point(13, 153);
            this.comboBoxIdProviders.Name = "comboBoxIdProviders";
            this.comboBoxIdProviders.Size = new System.Drawing.Size(189, 21);
            this.comboBoxIdProviders.TabIndex = 11;
            // 
            // comboBoxCategory_products
            // 
            this.comboBoxCategory_products.FormattingEnabled = true;
            this.comboBoxCategory_products.Items.AddRange(new object[] {
            "Дакимакуры",
            "Аксессуары",
            "Бижутерия",
            "Канцелярия",
            "Мягкие игрушки",
            "Фигурки",
            "Печатная продукция",
            "Сумки, рюкзаки"});
            this.comboBoxCategory_products.Location = new System.Drawing.Point(13, 111);
            this.comboBoxCategory_products.Name = "comboBoxCategory_products";
            this.comboBoxCategory_products.Size = new System.Drawing.Size(189, 21);
            this.comboBoxCategory_products.TabIndex = 12;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(724, 266);
            this.Controls.Add(this.comboBoxCategory_products);
            this.Controls.Add(this.comboBoxIdProviders);
            this.Controls.Add(this.textBoxProduct_Name);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.listViewProduct);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelIdProviders);
            this.Controls.Add(this.labelCategory_products);
            this.Controls.Add(this.labelProduct_Name);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelProduct_Name;
        private System.Windows.Forms.Label labelCategory_products;
        private System.Windows.Forms.Label labelIdProviders;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxProduct_Name;
        private System.Windows.Forms.ComboBox comboBoxIdProviders;
        private System.Windows.Forms.ComboBox comboBoxCategory_products;
    }
}