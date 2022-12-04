﻿namespace WinFormsApp1
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SqlButton = new System.Windows.Forms.Button();
            this.TextButton = new System.Windows.Forms.Button();
            this.ExcelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select DB type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.splitContainer1.Panel1.Controls.Add(this.SqlButton);
            this.splitContainer1.Panel1.Controls.Add(this.TextButton);
            this.splitContainer1.Panel1.Controls.Add(this.ExcelButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Size = new System.Drawing.Size(682, 453);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // SqlButton
            // 
            this.SqlButton.AutoSize = true;
            this.SqlButton.BackColor = System.Drawing.Color.Khaki;
            this.SqlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SqlButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SqlButton.FlatAppearance.BorderSize = 0;
            this.SqlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SqlButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SqlButton.Location = new System.Drawing.Point(0, 121);
            this.SqlButton.Margin = new System.Windows.Forms.Padding(0);
            this.SqlButton.Name = "SqlButton";
            this.SqlButton.Size = new System.Drawing.Size(209, 40);
            this.SqlButton.TabIndex = 4;
            this.SqlButton.Text = "SQL";
            this.SqlButton.UseVisualStyleBackColor = false;
            this.SqlButton.Click += new System.EventHandler(this.SqlButton_Click);
            // 
            // TextButton
            // 
            this.TextButton.AutoSize = true;
            this.TextButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.TextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TextButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextButton.FlatAppearance.BorderSize = 0;
            this.TextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextButton.Location = new System.Drawing.Point(0, 83);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(209, 38);
            this.TextButton.TabIndex = 3;
            this.TextButton.Text = "Text";
            this.TextButton.UseVisualStyleBackColor = false;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // ExcelButton
            // 
            this.ExcelButton.AutoSize = true;
            this.ExcelButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExcelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExcelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExcelButton.FlatAppearance.BorderSize = 0;
            this.ExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcelButton.Location = new System.Drawing.Point(0, 43);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(209, 40);
            this.ExcelButton.TabIndex = 2;
            this.ExcelButton.Text = "Excel";
            this.ExcelButton.UseVisualStyleBackColor = false;
            this.ExcelButton.Click += new System.EventHandler(this.ExcelButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Main";
            this.Text = "Sorting Algorithm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private SplitContainer splitContainer1;
        private Button ExcelButton;
        private Button SqlButton;
        private Button TextButton;
    }
}