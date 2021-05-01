﻿
namespace E_HealthCare.PresentationLayer
{
    partial class BloodRequestPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodRequestPanel));
            this.bloodComboBox = new System.Windows.Forms.ComboBox();
            this.selectBlood = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.donorDataGridView = new System.Windows.Forms.DataGridView();
            this.donorList = new System.Windows.Forms.Label();
            this.requestButton = new System.Windows.Forms.Button();
            this.currentDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.donateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bloodComboBox
            // 
            this.bloodComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodComboBox.ForeColor = System.Drawing.Color.Red;
            this.bloodComboBox.FormattingEnabled = true;
            this.bloodComboBox.Items.AddRange(new object[] {
            "AB+",
            "AB-",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.bloodComboBox.Location = new System.Drawing.Point(16, 52);
            this.bloodComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.bloodComboBox.Name = "bloodComboBox";
            this.bloodComboBox.Size = new System.Drawing.Size(353, 34);
            this.bloodComboBox.TabIndex = 0;
            // 
            // selectBlood
            // 
            this.selectBlood.AutoSize = true;
            this.selectBlood.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBlood.ForeColor = System.Drawing.Color.DarkRed;
            this.selectBlood.Location = new System.Drawing.Point(9, 15);
            this.selectBlood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectBlood.Name = "selectBlood";
            this.selectBlood.Size = new System.Drawing.Size(262, 34);
            this.selectBlood.TabIndex = 1;
            this.selectBlood.Text = "Select Blood Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(663, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(743, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // donorDataGridView
            // 
            this.donorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donorDataGridView.Location = new System.Drawing.Point(861, 317);
            this.donorDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.donorDataGridView.Name = "donorDataGridView";
            this.donorDataGridView.RowHeadersWidth = 51;
            this.donorDataGridView.Size = new System.Drawing.Size(329, 154);
            this.donorDataGridView.TabIndex = 3;
            this.donorDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.donorDataGridView_CellClick);
            // 
            // donorList
            // 
            this.donorList.AutoSize = true;
            this.donorList.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorList.ForeColor = System.Drawing.Color.DarkGreen;
            this.donorList.Location = new System.Drawing.Point(979, 246);
            this.donorList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.donorList.Name = "donorList";
            this.donorList.Size = new System.Drawing.Size(87, 31);
            this.donorList.TabIndex = 4;
            this.donorList.Text = "Donor";
            // 
            // requestButton
            // 
            this.requestButton.Location = new System.Drawing.Point(131, 189);
            this.requestButton.Margin = new System.Windows.Forms.Padding(4);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(123, 37);
            this.requestButton.TabIndex = 5;
            this.requestButton.Text = "Request";
            this.requestButton.UseVisualStyleBackColor = true;
            this.requestButton.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // currentDataGridView
            // 
            this.currentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentDataGridView.Location = new System.Drawing.Point(16, 281);
            this.currentDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.currentDataGridView.Name = "currentDataGridView";
            this.currentDataGridView.RowHeadersWidth = 51;
            this.currentDataGridView.Size = new System.Drawing.Size(639, 291);
            this.currentDataGridView.TabIndex = 6;
            this.currentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.currentDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(232, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current Requests";
            // 
            // donateButton
            // 
            this.donateButton.Location = new System.Drawing.Point(282, 580);
            this.donateButton.Margin = new System.Windows.Forms.Padding(4);
            this.donateButton.Name = "donateButton";
            this.donateButton.Size = new System.Drawing.Size(123, 37);
            this.donateButton.TabIndex = 8;
            this.donateButton.Text = "Donate";
            this.donateButton.UseVisualStyleBackColor = true;
            this.donateButton.Click += new System.EventHandler(this.donateButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1212, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(189, 108);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(154, 22);
            this.locationTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(54, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(189, 146);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(154, 22);
            this.phoneTextBox.TabIndex = 13;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1256, 606);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(123, 37);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(509, 101);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(46, 17);
            this.idLabel.TabIndex = 15;
            this.idLabel.Text = "label4";
            // 
            // BloodRequestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 676);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.donateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentDataGridView);
            this.Controls.Add(this.requestButton);
            this.Controls.Add(this.donorList);
            this.Controls.Add(this.donorDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selectBlood);
            this.Controls.Add(this.bloodComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BloodRequestPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood_Request";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Blood_Request_FormClosing);
            this.Load += new System.EventHandler(this.BloodRequestPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bloodComboBox;
        private System.Windows.Forms.Label selectBlood;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView donorDataGridView;
        private System.Windows.Forms.Label donorList;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.DataGridView currentDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button donateButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label idLabel;
    }
}