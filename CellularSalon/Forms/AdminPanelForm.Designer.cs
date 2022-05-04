namespace CellularSalon.Forms
{
    partial class adminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPanelForm));
            this.authGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userPosition = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.addPhoneButton = new System.Windows.Forms.Button();
            this.editPhoneButton = new System.Windows.Forms.Button();
            this.salerButton = new System.Windows.Forms.Button();
            this.showSalesButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.canChangeUserData = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.saleButton = new System.Windows.Forms.Button();
            this.listOfPHonesButton = new System.Windows.Forms.Button();
            this.aboutSalerButton = new System.Windows.Forms.Button();
            this.authGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // authGroupBox
            // 
            this.authGroupBox.Controls.Add(this.pictureBox1);
            this.authGroupBox.Controls.Add(this.userPosition);
            this.authGroupBox.Controls.Add(this.userName);
            this.authGroupBox.Location = new System.Drawing.Point(782, 12);
            this.authGroupBox.Name = "authGroupBox";
            this.authGroupBox.Size = new System.Drawing.Size(248, 81);
            this.authGroupBox.TabIndex = 5;
            this.authGroupBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // userPosition
            // 
            this.userPosition.AutoSize = true;
            this.userPosition.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPosition.Location = new System.Drawing.Point(72, 47);
            this.userPosition.Name = "userPosition";
            this.userPosition.Size = new System.Drawing.Size(73, 15);
            this.userPosition.TabIndex = 3;
            this.userPosition.Text = "%position%";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.Location = new System.Drawing.Point(72, 19);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(57, 15);
            this.userName.TabIndex = 2;
            this.userName.Text = "%name%";
            // 
            // addPhoneButton
            // 
            this.addPhoneButton.Location = new System.Drawing.Point(782, 99);
            this.addPhoneButton.Name = "addPhoneButton";
            this.addPhoneButton.Size = new System.Drawing.Size(114, 45);
            this.addPhoneButton.TabIndex = 0;
            this.addPhoneButton.Text = "Добавить товар";
            this.addPhoneButton.UseVisualStyleBackColor = true;
            this.addPhoneButton.Click += new System.EventHandler(this.addPhoneButton_Click);
            // 
            // editPhoneButton
            // 
            this.editPhoneButton.Location = new System.Drawing.Point(916, 99);
            this.editPhoneButton.Name = "editPhoneButton";
            this.editPhoneButton.Size = new System.Drawing.Size(114, 45);
            this.editPhoneButton.TabIndex = 7;
            this.editPhoneButton.Text = "Изменить товар";
            this.editPhoneButton.UseVisualStyleBackColor = true;
            this.editPhoneButton.Click += new System.EventHandler(this.deletePhoneButton_Click);
            // 
            // salerButton
            // 
            this.salerButton.Location = new System.Drawing.Point(782, 299);
            this.salerButton.Name = "salerButton";
            this.salerButton.Size = new System.Drawing.Size(248, 43);
            this.salerButton.TabIndex = 8;
            this.salerButton.Text = "Просмотреть данные о продавцах";
            this.salerButton.UseVisualStyleBackColor = true;
            this.salerButton.Click += new System.EventHandler(this.salerButton_Click);
            // 
            // showSalesButton
            // 
            this.showSalesButton.Location = new System.Drawing.Point(782, 397);
            this.showSalesButton.Name = "showSalesButton";
            this.showSalesButton.Size = new System.Drawing.Size(248, 43);
            this.showSalesButton.TabIndex = 9;
            this.showSalesButton.Text = "Просмотреть продажи";
            this.showSalesButton.UseVisualStyleBackColor = true;
            this.showSalesButton.Click += new System.EventHandler(this.showSalesButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(916, 201);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(114, 43);
            this.orderButton.TabIndex = 10;
            this.orderButton.Text = "Список заказов";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // canChangeUserData
            // 
            this.canChangeUserData.Location = new System.Drawing.Point(782, 201);
            this.canChangeUserData.Name = "canChangeUserData";
            this.canChangeUserData.Size = new System.Drawing.Size(114, 43);
            this.canChangeUserData.TabIndex = 11;
            this.canChangeUserData.Text = "Изменить пользователя";
            this.canChangeUserData.UseVisualStyleBackColor = true;
            this.canChangeUserData.Click += new System.EventHandler(this.button3_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(764, 492);
            this.mainPanel.TabIndex = 12;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(782, 446);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(248, 43);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "На главную";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saleButton
            // 
            this.saleButton.Location = new System.Drawing.Point(782, 348);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(248, 43);
            this.saleButton.TabIndex = 14;
            this.saleButton.Text = "Провести продажу";
            this.saleButton.UseVisualStyleBackColor = true;
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // listOfPHonesButton
            // 
            this.listOfPHonesButton.Location = new System.Drawing.Point(782, 150);
            this.listOfPHonesButton.Name = "listOfPHonesButton";
            this.listOfPHonesButton.Size = new System.Drawing.Size(248, 45);
            this.listOfPHonesButton.TabIndex = 15;
            this.listOfPHonesButton.Text = "Список товаров";
            this.listOfPHonesButton.UseVisualStyleBackColor = true;
            this.listOfPHonesButton.Click += new System.EventHandler(this.listOfPhonesButton_Click);
            // 
            // aboutSalerButton
            // 
            this.aboutSalerButton.Location = new System.Drawing.Point(782, 250);
            this.aboutSalerButton.Name = "aboutSalerButton";
            this.aboutSalerButton.Size = new System.Drawing.Size(248, 43);
            this.aboutSalerButton.TabIndex = 16;
            this.aboutSalerButton.Text = "Просмотреть данные о продажах";
            this.aboutSalerButton.UseVisualStyleBackColor = true;
            this.aboutSalerButton.Click += new System.EventHandler(this.aboutSalerButton_Click);
            // 
            // adminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 512);
            this.Controls.Add(this.aboutSalerButton);
            this.Controls.Add(this.listOfPHonesButton);
            this.Controls.Add(this.showSalesButton);
            this.Controls.Add(this.saleButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.canChangeUserData);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.authGroupBox);
            this.Controls.Add(this.salerButton);
            this.Controls.Add(this.addPhoneButton);
            this.Controls.Add(this.editPhoneButton);
            this.Name = "adminPanelForm";
            this.Text = "AdminPanelForm";
            this.authGroupBox.ResumeLayout(false);
            this.authGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox authGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userPosition;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button addPhoneButton;
        private System.Windows.Forms.Button editPhoneButton;
        private System.Windows.Forms.Button salerButton;
        private System.Windows.Forms.Button showSalesButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button canChangeUserData;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saleButton;
        private System.Windows.Forms.Button listOfPHonesButton;
        private System.Windows.Forms.Button aboutSalerButton;
    }
}