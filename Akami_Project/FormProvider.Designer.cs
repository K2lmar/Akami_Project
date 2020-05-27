namespace Akami_Project
{
    partial class FormProvider
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
            this.Logo = new System.Windows.Forms.PictureBox();
            this.labelFirm_Name = new System.Windows.Forms.Label();
            this.labelAddress_Firm = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLicense_number = new System.Windows.Forms.Label();
            this.textBoxFirm_Name = new System.Windows.Forms.TextBox();
            this.textBoxAddress_Firm = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxLicense_number = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewProvider = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::Akami_Project.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(0, 1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(201, 50);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // labelFirm_Name
            // 
            this.labelFirm_Name.AutoSize = true;
            this.labelFirm_Name.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelFirm_Name.Location = new System.Drawing.Point(9, 52);
            this.labelFirm_Name.Name = "labelFirm_Name";
            this.labelFirm_Name.Size = new System.Drawing.Size(158, 15);
            this.labelFirm_Name.TabIndex = 1;
            this.labelFirm_Name.Text = "Наименование фирмы";
            // 
            // labelAddress_Firm
            // 
            this.labelAddress_Firm.AutoSize = true;
            this.labelAddress_Firm.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelAddress_Firm.Location = new System.Drawing.Point(9, 93);
            this.labelAddress_Firm.Name = "labelAddress_Firm";
            this.labelAddress_Firm.Size = new System.Drawing.Size(97, 15);
            this.labelAddress_Firm.TabIndex = 2;
            this.labelAddress_Firm.Text = "Адрес фирмы";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelPhone.Location = new System.Drawing.Point(9, 134);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(67, 15);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Телефон";
            // 
            // labelLicense_number
            // 
            this.labelLicense_number.AutoSize = true;
            this.labelLicense_number.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelLicense_number.Location = new System.Drawing.Point(9, 175);
            this.labelLicense_number.Name = "labelLicense_number";
            this.labelLicense_number.Size = new System.Drawing.Size(117, 15);
            this.labelLicense_number.TabIndex = 4;
            this.labelLicense_number.Text = "Номер лицензии";
            // 
            // textBoxFirm_Name
            // 
            this.textBoxFirm_Name.Location = new System.Drawing.Point(12, 70);
            this.textBoxFirm_Name.Name = "textBoxFirm_Name";
            this.textBoxFirm_Name.Size = new System.Drawing.Size(189, 20);
            this.textBoxFirm_Name.TabIndex = 5;
            // 
            // textBoxAddress_Firm
            // 
            this.textBoxAddress_Firm.Location = new System.Drawing.Point(12, 111);
            this.textBoxAddress_Firm.Name = "textBoxAddress_Firm";
            this.textBoxAddress_Firm.Size = new System.Drawing.Size(189, 20);
            this.textBoxAddress_Firm.TabIndex = 6;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(12, 152);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(189, 20);
            this.textBoxPhone.TabIndex = 7;
            // 
            // textBoxLicense_number
            // 
            this.textBoxLicense_number.Location = new System.Drawing.Point(12, 193);
            this.textBoxLicense_number.Name = "textBoxLicense_number";
            this.textBoxLicense_number.Size = new System.Drawing.Size(189, 20);
            this.textBoxLicense_number.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Salmon;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(456, 219);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 38);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Salmon;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.Location = new System.Drawing.Point(551, 219);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 38);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Salmon;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonDel.Location = new System.Drawing.Point(646, 219);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(80, 38);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewProvider
            // 
            this.listViewProvider.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listViewProvider.FullRowSelect = true;
            this.listViewProvider.GridLines = true;
            this.listViewProvider.HideSelection = false;
            this.listViewProvider.Location = new System.Drawing.Point(210, 1);
            this.listViewProvider.MultiSelect = false;
            this.listViewProvider.Name = "listViewProvider";
            this.listViewProvider.Size = new System.Drawing.Size(516, 212);
            this.listViewProvider.TabIndex = 12;
            this.listViewProvider.UseCompatibleStateImageBehavior = false;
            this.listViewProvider.View = System.Windows.Forms.View.Details;
            this.listViewProvider.SelectedIndexChanged += new System.EventHandler(this.listViewProvider_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 57;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Наименование фирмы";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Адрес фирмы";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Телефон";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Номер лицензии";
            this.columnHeader5.Width = 107;
            // 
            // FormProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(731, 266);
            this.Controls.Add(this.listViewProvider);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxLicense_number);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress_Firm);
            this.Controls.Add(this.textBoxFirm_Name);
            this.Controls.Add(this.labelLicense_number);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress_Firm);
            this.Controls.Add(this.labelFirm_Name);
            this.Controls.Add(this.Logo);
            this.Name = "FormProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставщики";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label labelFirm_Name;
        private System.Windows.Forms.Label labelAddress_Firm;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLicense_number;
        private System.Windows.Forms.TextBox textBoxFirm_Name;
        private System.Windows.Forms.TextBox textBoxAddress_Firm;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxLicense_number;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewProvider;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}