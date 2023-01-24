namespace WinFormsApp1
{
    partial class SqlForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SelectionPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dbTableComboBox = new System.Windows.Forms.ComboBox();
            this.dbSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.connectionsComboBox = new System.Windows.Forms.ComboBox();
            this.SortButton2 = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.SortingPanel = new System.Windows.Forms.Panel();
            this.SortType = new System.Windows.Forms.ComboBox();
            this.IdComboBox = new System.Windows.Forms.ComboBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectionPanel.SuspendLayout();
            this.SortingPanel.SuspendLayout();
            this.GridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectionPanel
            // 
            this.SelectionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectionPanel.AutoSize = true;
            this.SelectionPanel.Controls.Add(this.SortingPanel);
            this.SelectionPanel.Controls.Add(this.label4);
            this.SelectionPanel.Controls.Add(this.label3);
            this.SelectionPanel.Controls.Add(this.label2);
            this.SelectionPanel.Controls.Add(this.dbTableComboBox);
            this.SelectionPanel.Controls.Add(this.dbSelectorComboBox);
            this.SelectionPanel.Controls.Add(this.connectionsComboBox);
            this.SelectionPanel.Controls.Add(this.SortButton2);
            this.SelectionPanel.Controls.Add(this.OkButton);
            this.SelectionPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SelectionPanel.Location = new System.Drawing.Point(540, 294);
            this.SelectionPanel.Name = "SelectionPanel";
            this.SelectionPanel.Size = new System.Drawing.Size(472, 111);
            this.SelectionPanel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Table :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Database :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Server :";
            // 
            // dbTableComboBox
            // 
            this.dbTableComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbTableComboBox.FormattingEnabled = true;
            this.dbTableComboBox.Location = new System.Drawing.Point(94, 72);
            this.dbTableComboBox.Name = "dbTableComboBox";
            this.dbTableComboBox.Size = new System.Drawing.Size(257, 28);
            this.dbTableComboBox.TabIndex = 6;
            this.dbTableComboBox.Visible = false;
            // 
            // dbSelectorComboBox
            // 
            this.dbSelectorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbSelectorComboBox.FormattingEnabled = true;
            this.dbSelectorComboBox.Location = new System.Drawing.Point(94, 38);
            this.dbSelectorComboBox.Name = "dbSelectorComboBox";
            this.dbSelectorComboBox.Size = new System.Drawing.Size(257, 28);
            this.dbSelectorComboBox.TabIndex = 5;
            this.dbSelectorComboBox.Visible = false;
            this.dbSelectorComboBox.SelectedIndexChanged += new System.EventHandler(this.DbSelectorComboBox_SelectedIndexChanged);
            // 
            // connectionsComboBox
            // 
            this.connectionsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectionsComboBox.FormattingEnabled = true;
            this.connectionsComboBox.Location = new System.Drawing.Point(94, 5);
            this.connectionsComboBox.Name = "connectionsComboBox";
            this.connectionsComboBox.Size = new System.Drawing.Size(257, 28);
            this.connectionsComboBox.TabIndex = 4;
            this.connectionsComboBox.SelectedIndexChanged += new System.EventHandler(this.ConnectionsComboBox_SelectedIndexChanged);
            // 
            // SortButton2
            // 
            this.SortButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton2.Location = new System.Drawing.Point(363, 36);
            this.SortButton2.Name = "SortButton2";
            this.SortButton2.Size = new System.Drawing.Size(94, 29);
            this.SortButton2.TabIndex = 3;
            this.SortButton2.Text = "Sorting";
            this.SortButton2.UseVisualStyleBackColor = true;
            this.SortButton2.Visible = false;
            this.SortButton2.Click += new System.EventHandler(this.SortButton2_Click);
            // 
            // OkButton
            // 
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Location = new System.Drawing.Point(363, 72);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 29);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
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
            this.SortingPanel.Size = new System.Drawing.Size(472, 111);
            this.SortingPanel.TabIndex = 3;
            this.SortingPanel.Visible = false;
            // 
            // SortType
            // 
            this.SortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortType.FormattingEnabled = true;
            this.SortType.Location = new System.Drawing.Point(315, 39);
            this.SortType.Name = "SortType";
            this.SortType.Size = new System.Drawing.Size(142, 28);
            this.SortType.TabIndex = 5;
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
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(430, 5);
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
            this.SortButton.Location = new System.Drawing.Point(315, 5);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(94, 29);
            this.SortButton.TabIndex = 2;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
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
            // GridPanel
            // 
            this.GridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPanel.Controls.Add(this.dataGridView1);
            this.GridPanel.Location = new System.Drawing.Point(0, 0);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(1024, 294);
            this.GridPanel.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 294);
            this.dataGridView1.TabIndex = 4;
            // 
            // SqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1024, 406);
            this.Controls.Add(this.SelectionPanel);
            this.Controls.Add(this.GridPanel);
            this.MinimumSize = new System.Drawing.Size(452, 453);
            this.Name = "SqlForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SqlForm_Load);
            this.SelectionPanel.ResumeLayout(false);
            this.SelectionPanel.PerformLayout();
            this.SortingPanel.ResumeLayout(false);
            this.SortingPanel.PerformLayout();
            this.GridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel SelectionPanel;
        private Button SortButton2;
        private Button OkButton;
        private Panel GridPanel;
        private DataGridView dataGridView1;
        private ComboBox connectionsComboBox;
        private ComboBox dbSelectorComboBox;
        private ComboBox dbTableComboBox;
        private Label label3;
        private Label label2;
        private Label label4;
        private Panel SortingPanel;
        private ComboBox SortType;
        private ComboBox IdComboBox;
        private Button CloseButton;
        private Button SortButton;
        private Label label1;
    }
}