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
            this.usersBox.Location = new System.Drawing.Point(4, 4);
            this.usersBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usersBox.Name = "usersBox";
            this.usersBox.Size = new System.Drawing.Size(205, 24);
            this.usersBox.TabIndex = 0;
            // 
            // phonesBox
            // 
            this.phonesBox.FormattingEnabled = true;
            this.phonesBox.Location = new System.Drawing.Point(804, 4);
            this.phonesBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phonesBox.Name = "phonesBox";
            this.phonesBox.Size = new System.Drawing.Size(205, 24);
            this.phonesBox.TabIndex = 1;
            // 
            // saleButton
            // 
            this.saleButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saleButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saleButton.Location = new System.Drawing.Point(361, 4);
            this.saleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(289, 82);
            this.saleButton.TabIndex = 2;
            this.saleButton.Text = "Продать";
            this.saleButton.UseVisualStyleBackColor = false;
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // SaleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.saleButton);
            this.Controls.Add(this.phonesBox);
            this.Controls.Add(this.usersBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SaleControl";
            this.Size = new System.Drawing.Size(1019, 606);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox usersBox;
        private System.Windows.Forms.ComboBox phonesBox;
        private System.Windows.Forms.Button saleButton;
    }
}
