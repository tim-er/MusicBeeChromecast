﻿namespace MusicBeePlugin
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.serverPortSelect = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.libraryPathButton = new System.Windows.Forms.Button();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.closeText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serverPortSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Web Server Port";
            // 
            // serverPortSelect
            // 
            this.serverPortSelect.Location = new System.Drawing.Point(113, 38);
            this.serverPortSelect.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.serverPortSelect.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
            this.serverPortSelect.Name = "serverPortSelect";
            this.serverPortSelect.Size = new System.Drawing.Size(59, 20);
            this.serverPortSelect.TabIndex = 2;
            this.serverPortSelect.Value = new decimal(new int[] {
            23614,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Musicbee Library Directory";
            // 
            // libraryPathButton
            // 
            this.libraryPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libraryPathButton.Location = new System.Drawing.Point(159, 64);
            this.libraryPathButton.Name = "libraryPathButton";
            this.libraryPathButton.Size = new System.Drawing.Size(75, 23);
            this.libraryPathButton.TabIndex = 4;
            this.libraryPathButton.Text = "Browse";
            this.libraryPathButton.UseVisualStyleBackColor = true;
            this.libraryPathButton.Click += new System.EventHandler(this.libraryPathButton_Click);
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(21, 93);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(43, 13);
            this.directoryLabel.TabIndex = 5;
            this.directoryLabel.Text = "Not Set";
            // 
            // closeText
            // 
            this.closeText.AutoSize = true;
            this.closeText.Location = new System.Drawing.Point(204, 128);
            this.closeText.Name = "closeText";
            this.closeText.Size = new System.Drawing.Size(33, 13);
            this.closeText.TabIndex = 6;
            this.closeText.Text = "Close";
            this.closeText.Click += new System.EventHandler(this.closeText_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Plugin Settings";
            // 
            // saveText
            // 
            this.saveText.AutoSize = true;
            this.saveText.Location = new System.Drawing.Point(12, 128);
            this.saveText.Name = "saveText";
            this.saveText.Size = new System.Drawing.Size(32, 13);
            this.saveText.TabIndex = 8;
            this.saveText.Text = "Save";
            this.saveText.Click += new System.EventHandler(this.saveText_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 150);
            this.Controls.Add(this.saveText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closeText);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.libraryPathButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverPortSelect);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.serverPortSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown serverPortSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button libraryPathButton;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Label closeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label saveText;
    }
}