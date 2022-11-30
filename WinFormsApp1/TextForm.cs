using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TextForm : Form
    {
        string? FileName ;

        public TextForm()
        {

            InitializeComponent();
            
        }

        
        private void SelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new()
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                RestoreDirectory = true,
                CheckFileExists = true, 
                CheckPathExists = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                FileName = openFileDialog1.FileName;
            }

        }
        private void ReadData()
        {
            try
            {
                StreamReader Reader = new(FileName);
                string element = Reader.ReadLine();
                element = element.Trim();
                string delimiters = " "+'\t';
                string[] Header = element.Split(delimiters.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (string header in Header)
                {
                    dataGridView1.Columns.Add(header, header);
                    IdComboBox.Items.Add(header);
                }
                string[]TopBase=new string[Regex.Matches(element, @"\b\w+\b").Count];
                while (!Reader.EndOfStream)
                {
                    element = Reader.ReadLine();
                    element.Trim();
                    TopBase = element.Split(delimiters.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (TopBase.Length == 0) continue;else
                    dataGridView1.Rows.Add(TopBase);
                }
                ShowSort();
                Reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void ClearDataGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }
        private void ShowSort()
        {
            SortType.Items.Clear();
            SortType.Items.Add("ASC");
            SortType.Items.Add("DESC");
            SortingPanel.Visible = true;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(textBox1.Text))
            {
                ClearDataGrid();
                FileName = textBox1.Text;
                ReadData();

            }
            else MessageBox.Show("File dont exists\nPlease select .txt file");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            SortingPanel.Visible = false;
        }
    }
}
