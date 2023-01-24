namespace WinFormsApp1
{
    partial class TextForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SelectButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SelectionPanel = new System.Windows.Forms.Panel();
            this.SortButton2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SortButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.IdComboBox = new System.Windows.Forms.ComboBox();
            this.SortType = new System.Windows.Forms.ComboBox();
            this.SortingPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GridPanel.SuspendLayout();
            this.SortingPanel.SuspendLayout();
            this.SuspendLayout();
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
            // SelectionPanel
            // 
            this.SelectionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectionPanel.AutoSize = true;
            this.SelectionPanel.Controls.Add(this.SortingPanel);
            this.SelectionPanel.Controls.Add(this.label2);
            this.SelectionPanel.Controls.Add(this.SortButton2);
            this.SelectionPanel.Controls.Add(this.textBox1);
            this.SelectionPanel.Controls.Add(this.OkButton);
            this.SelectionPanel.Controls.Add(this.SelectButton);
            this.SelectionPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SelectionPanel.Location = new System.Drawing.Point(500, 325);
            this.SelectionPanel.Name = "SelectionPanel";
            this.SelectionPanel.Size = new System.Drawing.Size(446, 80);
            this.SelectionPanel.TabIndex = 3;
            // 
            // SortButton2
            // 
            this.SortButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton2.Location = new System.Drawing.Point(231, 40);
            this.SortButton2.Name = "SortButton2";
            this.SortButton2.Size = new System.Drawing.Size(94, 29);
            this.SortButton2.TabIndex = 3;
            this.SortButton2.Text = "Sorting";
            this.SortButton2.UseVisualStyleBackColor = true;
            this.SortButton2.Visible = false;
            this.SortButton2.Click += new System.EventHandler(this.SortButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(937, 322);
            this.dataGridView1.TabIndex = 4;
            // 
            // GridPanel
            // 
            this.GridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPanel.Controls.Add(this.dataGridView1);
            this.GridPanel.Location = new System.Drawing.Point(0, 0);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(937, 322);
            this.GridPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sort data by:";
            // 
            // SortButton
            // 
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton.Location = new System.Drawing.Point(275, 5);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(94, 29);
            this.SortButton.TabIndex = 2;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(396, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 29);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // IdComboBox
            // 
            this.IdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdComboBox.Location = new System.Drawing.Point(12, 39);
            this.IdComboBox.Name = "IdComboBox";
            this.IdComboBox.Size = new System.Drawing.Size(238, 28);
            this.IdComboBox.TabIndex = 4;
            // 
            // SortType
            // 
            this.SortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortType.FormattingEnabled = true;
            this.SortType.Location = new System.Drawing.Point(275, 39);
            this.SortType.Name = "SortType";
            this.SortType.Size = new System.Drawing.Size(142, 28);
            this.SortType.TabIndex = 5;
            // 
            // SortingPanel
            // 
            this.SortingPanel.AutoSize = true;
            this.SortingPanel.Controls.Add(this.SortType);
            this.SortingPanel.Controls.Add(this.IdComboBox);
            this.SortingPanel.Controls.Add(this.CloseButton);
            this.SortingPanel.Controls.Add(this.SortButton);
            this.SortingPanel.Controls.Add(this.label1);
            this.SortingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortingPanel.Location = new System.Drawing.Point(0, 0);
            this.SortingPanel.Name = "SortingPanel";
            this.SortingPanel.Size = new System.Drawing.Size(446, 80);
            this.SortingPanel.TabIndex = 3;
            this.SortingPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path :";
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(937, 406);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.SelectionPanel);
            this.MinimumSize = new System.Drawing.Size(452, 453);
            this.Name = "TextForm";
            this.Text = "TextForm";
            this.SelectionPanel.ResumeLayout(false);
            this.SelectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GridPanel.ResumeLayout(false);
            this.SortingPanel.ResumeLayout(false);
            this.SortingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SelectButton;
        private TextBox textBox1;
        private Button OkButton;
        private Panel SelectionPanel;
        private DataGridView dataGridView1;
        private Panel GridPanel;
        private Button SortButton2;
        private Label label1;
        private Button SortButton;
        private Button CloseButton;
        private ComboBox IdComboBox;
        private ComboBox SortType;
        private Panel SortingPanel;
        private Label label2;
    }
}