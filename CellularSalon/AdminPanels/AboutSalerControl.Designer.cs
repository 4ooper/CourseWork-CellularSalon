namespace CellularSalon.AdminPanels
{
    partial class AboutSalerControl
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.countOfSalePhonesLabel = new System.Windows.Forms.Label();
            this.priceOfSaleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.nameLabel.Location = new System.Drawing.Point(253, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(84, 31);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "label1";
            // 
            // countOfSalePhonesLabel
            // 
            this.countOfSalePhonesLabel.AutoSize = true;
            this.countOfSalePhonesLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOfSalePhonesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.countOfSalePhonesLabel.Location = new System.Drawing.Point(3, 109);
            this.countOfSalePhonesLabel.Name = "countOfSalePhonesLabel";
            this.countOfSalePhonesLabel.Size = new System.Drawing.Size(61, 23);
            this.countOfSalePhonesLabel.TabIndex = 2;
            this.countOfSalePhonesLabel.Text = "label3";
            // 
            // priceOfSaleLabel
            // 
            this.priceOfSaleLabel.AutoSize = true;
            this.priceOfSaleLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceOfSaleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.priceOfSaleLabel.Location = new System.Drawing.Point(3, 155);
            this.priceOfSaleLabel.Name = "priceOfSaleLabel";
            this.priceOfSaleLabel.Size = new System.Drawing.Size(61, 23);
            this.priceOfSaleLabel.TabIndex = 3;
            this.priceOfSaleLabel.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Проданные телефоны: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // AboutSalerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.priceOfSaleLabel);
            this.Controls.Add(this.countOfSalePhonesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Name = "AboutSalerControl";
            this.Size = new System.Drawing.Size(593, 485);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label countOfSalePhonesLabel;
        private System.Windows.Forms.Label priceOfSaleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
