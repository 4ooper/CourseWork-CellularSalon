namespace CellularSalon.AdminPanels
{
    partial class FindPhoneControl
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
            this.namesBox = new System.Windows.Forms.ComboBox();
            this.findButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // namesBox
            // 
            this.namesBox.FormattingEnabled = true;
            this.namesBox.Location = new System.Drawing.Point(4, 4);
            this.namesBox.Name = "namesBox";
            this.namesBox.Size = new System.Drawing.Size(166, 21);
            this.namesBox.TabIndex = 0;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(4, 31);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(166, 43);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(177, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 485);
            this.panel1.TabIndex = 2;
            // 
            // FindPhoneControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.namesBox);
            this.Name = "FindPhoneControl";
            this.Size = new System.Drawing.Size(764, 492);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox namesBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Panel panel1;
    }
}
