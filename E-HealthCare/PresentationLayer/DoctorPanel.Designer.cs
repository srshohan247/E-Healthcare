﻿
namespace E_HealthCare.PresentationLayer
{
    partial class DoctorPanel
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
            this.appoinmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.appoinmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.doneButton = new System.Windows.Forms.Button();
            this.oldNewTriggerButton = new System.Windows.Forms.Button();
            this.appoinmentPanelButton = new System.Windows.Forms.Button();
            this.MedicinePanelButton = new System.Windows.Forms.Button();
            this.profilePanelButton = new System.Windows.Forms.Button();
            this.appoinmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appoinmentsGroupBox
            // 
            this.appoinmentsGroupBox.Controls.Add(this.oldNewTriggerButton);
            this.appoinmentsGroupBox.Controls.Add(this.doneButton);
            this.appoinmentsGroupBox.Controls.Add(this.appoinmentsDataGridView);
            this.appoinmentsGroupBox.Location = new System.Drawing.Point(205, 12);
            this.appoinmentsGroupBox.Name = "appoinmentsGroupBox";
            this.appoinmentsGroupBox.Size = new System.Drawing.Size(369, 247);
            this.appoinmentsGroupBox.TabIndex = 0;
            this.appoinmentsGroupBox.TabStop = false;
            this.appoinmentsGroupBox.Text = "Appoinments";
            // 
            // appoinmentsDataGridView
            // 
            this.appoinmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appoinmentsDataGridView.Location = new System.Drawing.Point(6, 19);
            this.appoinmentsDataGridView.Name = "appoinmentsDataGridView";
            this.appoinmentsDataGridView.Size = new System.Drawing.Size(357, 193);
            this.appoinmentsDataGridView.TabIndex = 0;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(288, 218);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 1;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            // 
            // oldNewTriggerButton
            // 
            this.oldNewTriggerButton.Location = new System.Drawing.Point(6, 218);
            this.oldNewTriggerButton.Name = "oldNewTriggerButton";
            this.oldNewTriggerButton.Size = new System.Drawing.Size(75, 23);
            this.oldNewTriggerButton.TabIndex = 2;
            this.oldNewTriggerButton.Text = "Old";
            this.oldNewTriggerButton.UseVisualStyleBackColor = true;
            // 
            // appoinmentPanelButton
            // 
            this.appoinmentPanelButton.Location = new System.Drawing.Point(12, 12);
            this.appoinmentPanelButton.Name = "appoinmentPanelButton";
            this.appoinmentPanelButton.Size = new System.Drawing.Size(81, 104);
            this.appoinmentPanelButton.TabIndex = 3;
            this.appoinmentPanelButton.Text = "Appoinments";
            this.appoinmentPanelButton.UseVisualStyleBackColor = true;
            // 
            // MedicinePanelButton
            // 
            this.MedicinePanelButton.Location = new System.Drawing.Point(12, 120);
            this.MedicinePanelButton.Name = "MedicinePanelButton";
            this.MedicinePanelButton.Size = new System.Drawing.Size(81, 104);
            this.MedicinePanelButton.TabIndex = 4;
            this.MedicinePanelButton.Text = "Medicine";
            this.MedicinePanelButton.UseVisualStyleBackColor = true;
            // 
            // profilePanelButton
            // 
            this.profilePanelButton.Location = new System.Drawing.Point(12, 230);
            this.profilePanelButton.Name = "profilePanelButton";
            this.profilePanelButton.Size = new System.Drawing.Size(81, 104);
            this.profilePanelButton.TabIndex = 5;
            this.profilePanelButton.Text = "Profile";
            this.profilePanelButton.UseVisualStyleBackColor = true;
            // 
            // DoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 346);
            this.Controls.Add(this.profilePanelButton);
            this.Controls.Add(this.MedicinePanelButton);
            this.Controls.Add(this.appoinmentPanelButton);
            this.Controls.Add(this.appoinmentsGroupBox);
            this.Name = "DoctorPanel";
            this.Text = "DoctorPanel";
            this.Load += new System.EventHandler(this.DoctorPanel_Load);
            this.appoinmentsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox appoinmentsGroupBox;
        private System.Windows.Forms.Button oldNewTriggerButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.DataGridView appoinmentsDataGridView;
        private System.Windows.Forms.Button appoinmentPanelButton;
        private System.Windows.Forms.Button MedicinePanelButton;
        private System.Windows.Forms.Button profilePanelButton;
    }
}