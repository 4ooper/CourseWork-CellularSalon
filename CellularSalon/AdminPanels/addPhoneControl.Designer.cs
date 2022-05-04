namespace CellularSalon.AdminPanels
{
    partial class addPhoneControl
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.screenBox = new System.Windows.Forms.TextBox();
            this.cpuBox = new System.Windows.Forms.TextBox();
            this.memoryBox = new System.Windows.Forms.TextBox();
            this.cameraBox = new System.Windows.Forms.TextBox();
            this.batteryBox = new System.Windows.Forms.TextBox();
            this.previewFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.choosePreviewButton = new System.Windows.Forms.Button();
            this.choosePhotoButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.simBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(74, 10);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(272, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.inputTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Модель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Цена:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Экран:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Процессор:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Память:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Сим-карта:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 254);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Камера:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 282);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(75, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Батарея:";
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(107, 42);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(239, 20);
            this.countBox.TabIndex = 12;
            this.countBox.TextChanged += new System.EventHandler(this.inputTextChanged);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(59, 70);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(287, 20);
            this.priceBox.TabIndex = 13;
            this.priceBox.TextChanged += new System.EventHandler(this.inputTextChanged);
            // 
            // screenBox
            // 
            this.screenBox.Location = new System.Drawing.Point(66, 131);
            this.screenBox.Name = "screenBox";
            this.screenBox.Size = new System.Drawing.Size(280, 20);
            this.screenBox.TabIndex = 16;
            this.screenBox.TextChanged += new System.EventHandler(this.inputTextChanged);
            // 
            // cpuBox
            // 
            this.cpuBox.Location = new System.Drawing.Point(97, 163);
            this.cpuBox.Name = "cpuBox";
            this.cpuBox.Size = new System.Drawing.Size(249, 20);
            this.cpuBox.TabIndex = 17;
            this.cpuBox.TextChanged += new System.EventHandler(this.inputTextChanged);
            // 
            // memoryBox
            // 
            this.memoryBox.Location = new System.Drawing.Point(81, 191);
            this.memoryBox.Name = "memoryBox";
            this.memoryBox.Size = new System.Drawing.Size(265, 20);
            this.memoryBox.TabIndex = 18;
            this.memoryBox.TextChanged += new System.EventHandler(this.inputTextChanged);
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(81, 254);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(265, 20);
            this.cameraBox.TabIndex = 20;
            this.cameraBox.TextChanged += new System.EventHandler(this.inputTextChanged);
            // 
            // batteryBox
            // 
            this.batteryBox.Location = new System.Drawing.Point(84, 282);
            this.batteryBox.Name = "batteryBox";
            this.batteryBox.Size = new System.Drawing.Size(262, 20);
            this.batteryBox.TabIndex = 21;
            this.batteryBox.TextChanged += new System.EventHandler(this.inputTextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 312);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 22;
            this.label12.Text = "Превью:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(3, 342);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(56, 19);
            this.label13.TabIndex = 23;
            this.label13.Text = "Фото:";
            // 
            // choosePreviewButton
            // 
            this.choosePreviewButton.Location = new System.Drawing.Point(76, 312);
            this.choosePreviewButton.Name = "choosePreviewButton";
            this.choosePreviewButton.Size = new System.Drawing.Size(270, 23);
            this.choosePreviewButton.TabIndex = 24;
            this.choosePreviewButton.Text = "Выбрать";
            this.choosePreviewButton.UseVisualStyleBackColor = true;
            this.choosePreviewButton.Click += new System.EventHandler(this.choosePreviewButton_Click);
            // 
            // choosePhotoButton
            // 
            this.choosePhotoButton.Location = new System.Drawing.Point(65, 342);
            this.choosePhotoButton.Name = "choosePhotoButton";
            this.choosePhotoButton.Size = new System.Drawing.Size(281, 23);
            this.choosePhotoButton.TabIndex = 25;
            this.choosePhotoButton.Text = "Выбрать";
            this.choosePhotoButton.UseVisualStyleBackColor = true;
            this.choosePhotoButton.Click += new System.EventHandler(this.choosePhotoButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(7, 380);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(339, 50);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(51, 98);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(295, 21);
            this.typeBox.TabIndex = 27;
            // 
            // simBox
            // 
            this.simBox.FormattingEnabled = true;
            this.simBox.Location = new System.Drawing.Point(104, 224);
            this.simBox.Name = "simBox";
            this.simBox.Size = new System.Drawing.Size(242, 21);
            this.simBox.TabIndex = 28;
            // 
            // addPhoneControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.choosePhotoButton);
            this.Controls.Add(this.choosePreviewButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.batteryBox);
            this.Controls.Add(this.cameraBox);
            this.Controls.Add(this.memoryBox);
            this.Controls.Add(this.cpuBox);
            this.Controls.Add(this.screenBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "addPhoneControl";
            this.Size = new System.Drawing.Size(354, 438);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox screenBox;
        private System.Windows.Forms.TextBox cpuBox;
        private System.Windows.Forms.TextBox memoryBox;
        private System.Windows.Forms.TextBox cameraBox;
        private System.Windows.Forms.TextBox batteryBox;
        private System.Windows.Forms.OpenFileDialog previewFileDialog;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button choosePreviewButton;
        private System.Windows.Forms.Button choosePhotoButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.ComboBox simBox;
    }
}
