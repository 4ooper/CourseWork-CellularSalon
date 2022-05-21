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
            this.findNameBox.Location = new System.Drawing.Point(5, 5);
            this.findNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.findNameBox.Name = "findNameBox";
            this.findNameBox.Size = new System.Drawing.Size(253, 24);
            this.findNameBox.TabIndex = 0;
            this.findNameBox.SelectedIndexChanged += new System.EventHandler(this.findNameBox_SelectedIndexChanged);
            // 
            // findemailBox
            // 
            this.findemailBox.FormattingEnabled = true;
            this.findemailBox.Location = new System.Drawing.Point(5, 38);
            this.findemailBox.Margin = new System.Windows.Forms.Padding(4);
            this.findemailBox.Name = "findemailBox";
            this.findemailBox.Size = new System.Drawing.Size(253, 24);
            this.findemailBox.TabIndex = 1;
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(116)))));
            this.findButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.findButton.Location = new System.Drawing.Point(5, 73);
            this.findButton.Margin = new System.Windows.Forms.Padding(4);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(255, 65);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.panel1.Location = new System.Drawing.Point(269, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 597);
            this.panel1.TabIndex = 3;
            // 
            // FindUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.findemailBox);
            this.Controls.Add(this.findNameBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FindUserControl";
            this.Size = new System.Drawing.Size(1019, 606);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox findNameBox;
        private System.Windows.Forms.ComboBox findemailBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Panel panel1;
    }
}
