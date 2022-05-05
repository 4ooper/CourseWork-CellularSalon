﻿namespace CellularSalon.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.userPosition = new System.Windows.Forms.Label();
            this.authGroupBox = new System.Windows.Forms.GroupBox();
            this.adminPanelButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.authGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Учёт продаж салона сотовой связи на Windows Form";
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
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.Location = new System.Drawing.Point(60, 19);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(50, 14);
            this.userName.TabIndex = 2;
            this.userName.Text = "%name%";
            // 
            // userPosition
            // 
            this.userPosition.AutoSize = true;
            this.userPosition.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPosition.Location = new System.Drawing.Point(60, 52);
            this.userPosition.Name = "userPosition";
            this.userPosition.Size = new System.Drawing.Size(73, 15);
            this.userPosition.TabIndex = 3;
            this.userPosition.Text = "%position%";
            // 
            // authGroupBox
            // 
            this.authGroupBox.Controls.Add(this.adminPanelButton);
            this.authGroupBox.Controls.Add(this.logOutButton);
            this.authGroupBox.Controls.Add(this.pictureBox1);
            this.authGroupBox.Controls.Add(this.userPosition);
            this.authGroupBox.Controls.Add(this.userName);
            this.authGroupBox.Location = new System.Drawing.Point(601, 38);
            this.authGroupBox.Name = "authGroupBox";
            this.authGroupBox.Size = new System.Drawing.Size(248, 81);
            this.authGroupBox.TabIndex = 4;
            this.authGroupBox.TabStop = false;
            // 
            // adminPanelButton
            // 
            this.adminPanelButton.Location = new System.Drawing.Point(152, 43);
            this.adminPanelButton.Name = "adminPanelButton";
            this.adminPanelButton.Size = new System.Drawing.Size(89, 23);
            this.adminPanelButton.TabIndex = 5;
            this.adminPanelButton.Text = "Админ-панель";
            this.adminPanelButton.UseVisualStyleBackColor = true;
            this.adminPanelButton.Click += new System.EventHandler(this.AdminPanelButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(187, 15);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(55, 23);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Выйти";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Location = new System.Drawing.Point(13, 38);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(570, 457);
            this.mainPanel.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(590, 430);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(259, 64);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Завершить работу";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 507);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.authGroupBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.authGroupBox.ResumeLayout(false);
            this.authGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label userPosition;
        private System.Windows.Forms.GroupBox authGroupBox;
        private System.Windows.Forms.Button adminPanelButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button closeButton;
    }
}