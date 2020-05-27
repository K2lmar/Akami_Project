namespace Akami_Project
{
    partial class FormOrder
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
            this.labelIdClient = new System.Windows.Forms.Label();
            this.labelIdProduct = new System.Windows.Forms.Label();
            this.labelAddress_Delivery = new System.Windows.Forms.Label();
            this.labelDelivery_method = new System.Windows.Forms.Label();
            this.labelPayment_method = new System.Windows.Forms.Label();
            this.comboBoxIdClient = new System.Windows.Forms.ComboBox();
            this.comboBoxIdProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxDelivery_method = new System.Windows.Forms.ComboBox();
            this.comboBoxPayment_method = new System.Windows.Forms.ComboBox();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxAddress_Delivery = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Salmon;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(463, 265);
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
            this.buttonEdit.Location = new System.Drawing.Point(558, 265);
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
            this.buttonDel.Location = new System.Drawing.Point(656, 265);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(80, 38);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelIdClient
            // 
            this.labelIdClient.AutoSize = true;
            this.labelIdClient.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelIdClient.Location = new System.Drawing.Point(9, 52);
            this.labelIdClient.Name = "labelIdClient";
            this.labelIdClient.Size = new System.Drawing.Size(56, 15);
            this.labelIdClient.TabIndex = 3;
            this.labelIdClient.Text = "Клиент";
            // 
            // labelIdProduct
            // 
            this.labelIdProduct.AutoSize = true;
            this.labelIdProduct.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelIdProduct.Location = new System.Drawing.Point(9, 94);
            this.labelIdProduct.Name = "labelIdProduct";
            this.labelIdProduct.Size = new System.Drawing.Size(47, 15);
            this.labelIdProduct.TabIndex = 4;
            this.labelIdProduct.Text = "Товар";
            // 
            // labelAddress_Delivery
            // 
            this.labelAddress_Delivery.AutoSize = true;
            this.labelAddress_Delivery.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelAddress_Delivery.Location = new System.Drawing.Point(9, 136);
            this.labelAddress_Delivery.Name = "labelAddress_Delivery";
            this.labelAddress_Delivery.Size = new System.Drawing.Size(111, 15);
            this.labelAddress_Delivery.TabIndex = 5;
            this.labelAddress_Delivery.Text = "Адрес доставки";
            // 
            // labelDelivery_method
            // 
            this.labelDelivery_method.AutoSize = true;
            this.labelDelivery_method.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelDelivery_method.Location = new System.Drawing.Point(9, 177);
            this.labelDelivery_method.Name = "labelDelivery_method";
            this.labelDelivery_method.Size = new System.Drawing.Size(120, 15);
            this.labelDelivery_method.TabIndex = 6;
            this.labelDelivery_method.Text = "Способ доставки";
            // 
            // labelPayment_method
            // 
            this.labelPayment_method.AutoSize = true;
            this.labelPayment_method.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelPayment_method.Location = new System.Drawing.Point(9, 219);
            this.labelPayment_method.Name = "labelPayment_method";
            this.labelPayment_method.Size = new System.Drawing.Size(108, 15);
            this.labelPayment_method.TabIndex = 7;
            this.labelPayment_method.Text = "Способ оплаты";
            // 
            // comboBoxIdClient
            // 
            this.comboBoxIdClient.FormattingEnabled = true;
            this.comboBoxIdClient.Location = new System.Drawing.Point(12, 70);
            this.comboBoxIdClient.Name = "comboBoxIdClient";
            this.comboBoxIdClient.Size = new System.Drawing.Size(189, 21);
            this.comboBoxIdClient.TabIndex = 8;
            // 
            // comboBoxIdProduct
            // 
            this.comboBoxIdProduct.FormattingEnabled = true;
            this.comboBoxIdProduct.Location = new System.Drawing.Point(12, 112);
            this.comboBoxIdProduct.Name = "comboBoxIdProduct";
            this.comboBoxIdProduct.Size = new System.Drawing.Size(189, 21);
            this.comboBoxIdProduct.TabIndex = 9;
            // 
            // comboBoxDelivery_method
            // 
            this.comboBoxDelivery_method.FormattingEnabled = true;
            this.comboBoxDelivery_method.Items.AddRange(new object[] {
            "Доставка курьером",
            "Доставка экспресс службой",
            "Самовывоз"});
            this.comboBoxDelivery_method.Location = new System.Drawing.Point(12, 195);
            this.comboBoxDelivery_method.Name = "comboBoxDelivery_method";
            this.comboBoxDelivery_method.Size = new System.Drawing.Size(189, 21);
            this.comboBoxDelivery_method.TabIndex = 10;
            // 
            // comboBoxPayment_method
            // 
            this.comboBoxPayment_method.FormattingEnabled = true;
            this.comboBoxPayment_method.Items.AddRange(new object[] {
            "Наличными",
            "СберБанк Онлайн",
            "Visa/Mastercard"});
            this.comboBoxPayment_method.Location = new System.Drawing.Point(12, 237);
            this.comboBoxPayment_method.Name = "comboBoxPayment_method";
            this.comboBoxPayment_method.Size = new System.Drawing.Size(189, 21);
            this.comboBoxPayment_method.TabIndex = 11;
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.GridLines = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(210, 0);
            this.listViewOrder.MultiSelect = false;
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(526, 259);
            this.listViewOrder.TabIndex = 12;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrder.SelectedIndexChanged += new System.EventHandler(this.listViewOrder_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО клиента";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            this.columnHeader3.Width = 42;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Товар";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Адрес доставки";
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Способ доставки";
            this.columnHeader6.Width = 102;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Способ оплаты";
            this.columnHeader7.Width = 96;
            // 
            // textBoxAddress_Delivery
            // 
            this.textBoxAddress_Delivery.Location = new System.Drawing.Point(12, 154);
            this.textBoxAddress_Delivery.Name = "textBoxAddress_Delivery";
            this.textBoxAddress_Delivery.Size = new System.Drawing.Size(189, 20);
            this.textBoxAddress_Delivery.TabIndex = 14;
            // 
            // Logo
            // 
            this.Logo.Image = global::Akami_Project.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(1, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(203, 50);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 13;
            this.Logo.TabStop = false;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(745, 311);
            this.Controls.Add(this.textBoxAddress_Delivery);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.comboBoxPayment_method);
            this.Controls.Add(this.comboBoxDelivery_method);
            this.Controls.Add(this.comboBoxIdProduct);
            this.Controls.Add(this.comboBoxIdClient);
            this.Controls.Add(this.labelPayment_method);
            this.Controls.Add(this.labelDelivery_method);
            this.Controls.Add(this.labelAddress_Delivery);
            this.Controls.Add(this.labelIdProduct);
            this.Controls.Add(this.labelIdClient);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelIdClient;
        private System.Windows.Forms.Label labelIdProduct;
        private System.Windows.Forms.Label labelAddress_Delivery;
        private System.Windows.Forms.Label labelDelivery_method;
        private System.Windows.Forms.Label labelPayment_method;
        private System.Windows.Forms.ComboBox comboBoxIdClient;
        private System.Windows.Forms.ComboBox comboBoxIdProduct;
        private System.Windows.Forms.ComboBox comboBoxDelivery_method;
        private System.Windows.Forms.ComboBox comboBoxPayment_method;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox textBoxAddress_Delivery;
    }
}