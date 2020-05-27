namespace Akami_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenProviders = new System.Windows.Forms.Button();
            this.buttonOpenProducts = new System.Windows.Forms.Button();
            this.buttonOpenOrders = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.Color.Salmon;
            this.buttonOpenClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenClients.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenClients.Location = new System.Drawing.Point(11, 119);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(290, 45);
            this.buttonOpenClients.TabIndex = 0;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenProviders
            // 
            this.buttonOpenProviders.BackColor = System.Drawing.Color.Salmon;
            this.buttonOpenProviders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenProviders.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonOpenProviders.Location = new System.Drawing.Point(11, 170);
            this.buttonOpenProviders.Name = "buttonOpenProviders";
            this.buttonOpenProviders.Size = new System.Drawing.Size(290, 45);
            this.buttonOpenProviders.TabIndex = 1;
            this.buttonOpenProviders.Text = "Поставщики";
            this.buttonOpenProviders.UseVisualStyleBackColor = false;
            this.buttonOpenProviders.Click += new System.EventHandler(this.buttonOpenProviders_Click);
            // 
            // buttonOpenProducts
            // 
            this.buttonOpenProducts.BackColor = System.Drawing.Color.Salmon;
            this.buttonOpenProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenProducts.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonOpenProducts.Location = new System.Drawing.Point(11, 221);
            this.buttonOpenProducts.Name = "buttonOpenProducts";
            this.buttonOpenProducts.Size = new System.Drawing.Size(290, 45);
            this.buttonOpenProducts.TabIndex = 2;
            this.buttonOpenProducts.Text = "Товары";
            this.buttonOpenProducts.UseVisualStyleBackColor = false;
            this.buttonOpenProducts.Click += new System.EventHandler(this.buttonOpenProducts_Click);
            // 
            // buttonOpenOrders
            // 
            this.buttonOpenOrders.BackColor = System.Drawing.Color.Salmon;
            this.buttonOpenOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenOrders.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonOpenOrders.Location = new System.Drawing.Point(11, 272);
            this.buttonOpenOrders.Name = "buttonOpenOrders";
            this.buttonOpenOrders.Size = new System.Drawing.Size(290, 45);
            this.buttonOpenOrders.TabIndex = 3;
            this.buttonOpenOrders.Text = "Заказы";
            this.buttonOpenOrders.UseVisualStyleBackColor = false;
            this.buttonOpenOrders.Click += new System.EventHandler(this.buttonOpenOrders_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Akami_Project.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(-1, 31);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(314, 81);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 4;
            this.Logo.TabStop = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(13, 12);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(44, 13);
            this.labelHello.TabIndex = 5;
            this.labelHello.Text = "Привет";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(314, 326);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.buttonOpenOrders);
            this.Controls.Add(this.buttonOpenProducts);
            this.Controls.Add(this.buttonOpenProviders);
            this.Controls.Add(this.buttonOpenClients);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenProviders;
        private System.Windows.Forms.Button buttonOpenProducts;
        private System.Windows.Forms.Button buttonOpenOrders;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label labelHello;
    }
}

