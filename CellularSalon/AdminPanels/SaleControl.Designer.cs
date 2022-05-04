namespace CellularSalon.AdminPanels
{
    partial class SaleControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.usersBox = new System.Windows.Forms.ComboBox();
            this.phonesBox = new System.Windows.Forms.ComboBox();
            this.saleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersBox
            // 
            this.usersBox.FormattingEnabled = true;
            this.usersBox.Location = new System.Drawing.Point(3, 3);
            this.usersBox.Name = "usersBox";
            this.usersBox.Size = new System.Drawing.Size(155, 21);
            this.usersBox.TabIndex = 0;
            // 
            // phonesBox
            // 
            this.phonesBox.FormattingEnabled = true;
            this.phonesBox.Location = new System.Drawing.Point(603, 3);
            this.phonesBox.Name = "phonesBox";
            this.phonesBox.Size = new System.Drawing.Size(155, 21);
            this.phonesBox.TabIndex = 1;
            // 
            // saleButton
            // 
            this.saleButton.Location = new System.Drawing.Point(272, 35);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(217, 67);
            this.saleButton.TabIndex = 2;
            this.saleButton.Text = "Продать";
            this.saleButton.UseVisualStyleBackColor = true;
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // SaleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saleButton);
            this.Controls.Add(this.phonesBox);
            this.Controls.Add(this.usersBox);
            this.Name = "SaleControl";
            this.Size = new System.Drawing.Size(764, 492);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox usersBox;
        private System.Windows.Forms.ComboBox phonesBox;
        private System.Windows.Forms.Button saleButton;
    }
}
