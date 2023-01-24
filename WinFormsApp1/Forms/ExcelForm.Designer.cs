namespace WinFormsApp1
{
    partial class ExcelForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SortingPanel = new System.Windows.Forms.Panel();
            this.SortType = new System.Windows.Forms.ComboBox();
            this.IdComboBox = new System.Windows.Forms.ComboBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SortButton2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sheetComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.SortingPanel.SuspendLayout();
            this.GridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.SortingPanel);
            this.panel1.Controls.Add(this.SortButton2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sheetComboBox);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.OkButton);
            this.panel1.Controls.Add(this.SelectButton);
            this.panel1.Location = new System.Drawing.Point(94, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 86);
            this.panel1.TabIndex = 4;
            // 
            // SortingPanel
            // 
            this.SortingPanel.AutoSize = true;
            this.SortingPanel.Controls.Add(this.SortType);
            this.SortingPanel.Controls.Add(this.IdComboBox);
            this.SortingPanel.Controls.Add(this.CloseButton);
            this.SortingPanel.Controls.Add(this.SortButton);
            this.SortingPanel.Controls.Add(this.label3);
            this.SortingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortingPanel.Location = new System.Drawing.Point(0, 0);
            this.SortingPanel.Name = "SortingPanel";
            this.SortingPanel.Size = new System.Drawing.Size(462, 86);
            this.SortingPanel.TabIndex = 6;
            this.SortingPanel.Visible = false;
            // 
            // SortType
            // 
            this.SortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortType.FormattingEnabled = true;
            this.SortType.Location = new System.Drawing.Point(275, 46);
            this.SortType.Name = "SortType";
            this.SortType.Size = new System.Drawing.Size(142, 28);
            this.SortType.TabIndex = 5;
            // 
            // IdComboBox
            // 
            this.IdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdComboBox.Location = new System.Drawing.Point(12, 46);
            this.IdComboBox.Name = "IdComboBox";
            this.IdComboBox.Size = new System.Drawing.Size(238, 28);
            this.IdComboBox.TabIndex = 4;
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(430, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 29);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton.Location = new System.Drawing.Point(323, 12);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(94, 29);
            this.SortButton.TabIndex = 2;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sort data by:";
            // 
            // SortButton2
            // 
            this.SortButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton2.Location = new System.Drawing.Point(231, 40);
            this.SortButton2.Name = "SortButton2";
            this.SortButton2.Size = new System.Drawing.Size(94, 29);
            this.SortButton2.TabIndex = 6;
            this.SortButton2.Text = "Sorting";
            this.SortButton2.UseVisualStyleBackColor = true;
            this.SortButton2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sheet :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path :";
            // 
            // sheetComboBox
            // 
            this.sheetComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sheetComboBox.FormattingEnabled = true;
            this.sheetComboBox.Location = new System.Drawing.Point(75, 41);
            this.sheetComboBox.Name = "sheetComboBox";
            this.sheetComboBox.Size = new System.Drawing.Size(150, 28);
            this.sheetComboBox.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 27);
            this.textBox1.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Location = new System.Drawing.Point(331, 40);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 29);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.Location = new System.Drawing.Point(331, 5);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(94, 29);
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // GridPanel
            // 
            this.GridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPanel.Controls.Add(this.dataGridView1);
            this.GridPanel.Location = new System.Drawing.Point(0, 0);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(556, 322);
            this.GridPanel.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(556, 322);
            this.dataGridView1.TabIndex = 4;
            // 
            // ExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(556, 406);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(452, 453);
            this.Name = "ExcelForm";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SortingPanel.ResumeLayout(false);
            this.SortingPanel.PerformLayout();
            this.GridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button OkButton;
        private Button SelectButton;
        private ComboBox sheetComboBox;
        private Panel GridPanel;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Panel SortingPanel;
        private ComboBox SortType;
        private ComboBox IdComboBox;
        private Button CloseButton;
        private Button SortButton;
        private Label label3;
        private Button SortButton2;
    }
}