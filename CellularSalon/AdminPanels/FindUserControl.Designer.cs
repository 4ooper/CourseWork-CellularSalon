namespace CellularSalon.AdminPanels
{
    partial class FindUserControl
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
            this.findNameBox = new System.Windows.Forms.ComboBox();
            this.findemailBox = new System.Windows.Forms.ComboBox();
            this.findButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // findNameBox
            // 
            this.findNameBox.FormattingEnabled = true;
            this.findNameBox.Location = new System.Drawing.Point(4, 4);
            this.findNameBox.Name = "findNameBox";
            this.findNameBox.Size = new System.Drawing.Size(191, 21);
            this.findNameBox.TabIndex = 0;
            this.findNameBox.SelectedIndexChanged += new System.EventHandler(this.findNameBox_SelectedIndexChanged);
            // 
            // findemailBox
            // 
            this.findemailBox.FormattingEnabled = true;
            this.findemailBox.Location = new System.Drawing.Point(4, 31);
            this.findemailBox.Name = "findemailBox";
            this.findemailBox.Size = new System.Drawing.Size(191, 21);
            this.findemailBox.TabIndex = 1;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(4, 59);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(191, 53);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(202, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 485);
            this.panel1.TabIndex = 3;
            // 
            // FindUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.findemailBox);
            this.Controls.Add(this.findNameBox);
            this.Name = "FindUserControl";
            this.Size = new System.Drawing.Size(764, 492);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox findNameBox;
        private System.Windows.Forms.ComboBox findemailBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Panel panel1;
    }
}
