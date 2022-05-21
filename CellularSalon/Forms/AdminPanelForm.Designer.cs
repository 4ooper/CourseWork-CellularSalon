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
            this.stockReportsButton = new System.Windows.Forms.Button();
            this.addPhoneCountButton = new System.Windows.Forms.Button();
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
            this.pictureBox1.Size = new System.Drawing.Size(45, 52);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // userPosition
            // 
            this.userPosition.AutoSize = true;
            this.userPosition.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.userPosition.Location = new System.Drawing.Point(57, 46);
            this.userPosition.Name = "userPosition";
            this.userPosition.Size = new System.Drawing.Size(112, 25);
            this.userPosition.TabIndex = 3;
            this.userPosition.Text = "%position%";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.userName.Location = new System.Drawing.Point(57, 19);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(91, 25);
            this.userName.TabIndex = 2;
            this.userName.Text = "%name%";
            // 
            // addPhoneButton
            // 
            this.addPhoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.addPhoneButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPhoneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.addPhoneButton.Location = new System.Drawing.Point(782, 99);
            this.addPhoneButton.Name = "addPhoneButton";
            this.addPhoneButton.Size = new System.Drawing.Size(114, 44);
            this.addPhoneButton.TabIndex = 0;
            this.addPhoneButton.Text = "Добавить товар";
            this.addPhoneButton.UseVisualStyleBackColor = false;
            this.addPhoneButton.Click += new System.EventHandler(this.addPhoneButton_Click);
            // 
            // editPhoneButton
            // 
            this.editPhoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.editPhoneButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editPhoneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.editPhoneButton.Location = new System.Drawing.Point(916, 98);
            this.editPhoneButton.Name = "editPhoneButton";
            this.editPhoneButton.Size = new System.Drawing.Size(114, 45);
            this.editPhoneButton.TabIndex = 7;
            this.editPhoneButton.Text = "Изменить товар";
            this.editPhoneButton.UseVisualStyleBackColor = false;
            this.editPhoneButton.Click += new System.EventHandler(this.deletePhoneButton_Click);
            // 
            // salerButton
            // 
            this.salerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.salerButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.salerButton.Location = new System.Drawing.Point(782, 306);
            this.salerButton.Name = "salerButton";
            this.salerButton.Size = new System.Drawing.Size(248, 43);
            this.salerButton.TabIndex = 8;
            this.salerButton.Text = "Просмотреть данные о продавцах";
            this.salerButton.UseVisualStyleBackColor = false;
            this.salerButton.Click += new System.EventHandler(this.salerButton_Click);
            // 
            // showSalesButton
            // 
            this.showSalesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.showSalesButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showSalesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.showSalesButton.Location = new System.Drawing.Point(916, 247);
            this.showSalesButton.Name = "showSalesButton";
            this.showSalesButton.Size = new System.Drawing.Size(114, 53);
            this.showSalesButton.TabIndex = 9;
            this.showSalesButton.Text = "Просмотреть продажи";
            this.showSalesButton.UseVisualStyleBackColor = false;
            this.showSalesButton.Click += new System.EventHandler(this.showSalesButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.orderButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.orderButton.Location = new System.Drawing.Point(782, 198);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(114, 43);
            this.orderButton.TabIndex = 10;
            this.orderButton.Text = "Список заказов";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // canChangeUserData
            // 
            this.canChangeUserData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.canChangeUserData.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canChangeUserData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.canChangeUserData.Location = new System.Drawing.Point(916, 149);
            this.canChangeUserData.Name = "canChangeUserData";
            this.canChangeUserData.Size = new System.Drawing.Size(114, 43);
            this.canChangeUserData.TabIndex = 11;
            this.canChangeUserData.Text = "Изменить пользователя";
            this.canChangeUserData.UseVisualStyleBackColor = false;
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
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.backButton.Location = new System.Drawing.Point(782, 453);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(248, 46);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "На главную";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saleButton
            // 
            this.saleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.saleButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.saleButton.Location = new System.Drawing.Point(782, 247);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(114, 53);
            this.saleButton.TabIndex = 14;
            this.saleButton.Text = "Расходная операция";
            this.saleButton.UseVisualStyleBackColor = false;
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // listOfPHonesButton
            // 
            this.listOfPHonesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.listOfPHonesButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOfPHonesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.listOfPHonesButton.Location = new System.Drawing.Point(782, 147);
            this.listOfPHonesButton.Name = "listOfPHonesButton";
            this.listOfPHonesButton.Size = new System.Drawing.Size(114, 45);
            this.listOfPHonesButton.TabIndex = 15;
            this.listOfPHonesButton.Text = "Список товаров";
            this.listOfPHonesButton.UseVisualStyleBackColor = false;
            this.listOfPHonesButton.Click += new System.EventHandler(this.listOfPhonesButton_Click);
            // 
            // aboutSalerButton
            // 
            this.aboutSalerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.aboutSalerButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutSalerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.aboutSalerButton.Location = new System.Drawing.Point(916, 198);
            this.aboutSalerButton.Name = "aboutSalerButton";
            this.aboutSalerButton.Size = new System.Drawing.Size(114, 43);
            this.aboutSalerButton.TabIndex = 16;
            this.aboutSalerButton.Text = "Данные о продажах";
            this.aboutSalerButton.UseVisualStyleBackColor = false;
            this.aboutSalerButton.Click += new System.EventHandler(this.aboutSalerButton_Click);
            // 
            // stockReportsButton
            // 
            this.stockReportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.stockReportsButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stockReportsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.stockReportsButton.Location = new System.Drawing.Point(782, 404);
            this.stockReportsButton.Name = "stockReportsButton";
            this.stockReportsButton.Size = new System.Drawing.Size(248, 43);
            this.stockReportsButton.TabIndex = 17;
            this.stockReportsButton.Text = "Приходно-расходные операции";
            this.stockReportsButton.UseVisualStyleBackColor = false;
            this.stockReportsButton.Click += new System.EventHandler(this.stockReportsButton_Click);
            // 
            // addPhoneCountButton
            // 
            this.addPhoneCountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.addPhoneCountButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPhoneCountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.addPhoneCountButton.Location = new System.Drawing.Point(782, 355);
            this.addPhoneCountButton.Name = "addPhoneCountButton";
            this.addPhoneCountButton.Size = new System.Drawing.Size(248, 43);
            this.addPhoneCountButton.TabIndex = 18;
            this.addPhoneCountButton.Text = "Приходная операция";
            this.addPhoneCountButton.UseVisualStyleBackColor = false;
            this.addPhoneCountButton.Click += new System.EventHandler(this.addPhoneCountButton_Click);
            // 
            // adminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1042, 512);
            this.Controls.Add(this.addPhoneCountButton);
            this.Controls.Add(this.stockReportsButton);
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
        private System.Windows.Forms.Button stockReportsButton;
        private System.Windows.Forms.Button addPhoneCountButton;
    }
}