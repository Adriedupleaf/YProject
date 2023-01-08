using System.ComponentModel;
using System.Text.RegularExpressions;
using YProject.BackEnd;

namespace WinFormsApp1
{
    public partial class TextForm : Form
    {
        string? FileName;

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
                using (StreamReader Reader = new(FileName))
                {
                    string? element = Reader?.ReadLine();
                    element = element?.Trim();
                    string delimiters = " " + '\t';
                    string[] Header = element.Split(delimiters.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    foreach (string header in Header)
                    {
                        dataGridView1.Columns.Add(header, header);
                        IdComboBox.Items.Add(header);
                    }
                    string[] TopBase = new string[Regex.Matches(element, @"\b\w+\b").Count];
                    while (!Reader.EndOfStream)
                    {
                        element = Reader.ReadLine();
                        _ = element.Trim();

                        TopBase = element.Split(delimiters.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        if (TopBase.Length == 0) continue;
                        else
                            dataGridView1.Rows.Add(TopBase);
                    }
                    ShowSort();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void ReadData(String[] Array)
        {
            foreach (String str in Array)
            {
                dataGridView1.Rows.Add(str);

            }


        }
        private void ClearPrevData(bool control)
        {
            if (control)
            {
                dataGridView1.Columns.Clear();
                IdComboBox.Items.Clear();
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

        }
        private void ShowSort()
        {
            SortType.Items.Clear();
            IdComboBox.SelectedIndex = 0;
            SortType.Items.Add("ASC");
            SortType.Items.Add("DESC");
            SortType.SelectedIndex = 0;
            SortingPanel.Visible = true;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            if (File.Exists(textBox1.Text))
            {
                ClearPrevData(true);
                FileName = textBox1.Text;
                ReadData();
                SortButton2.Visible = true;
            }
            else MessageBox.Show("File dont exists\nPlease select .txt file");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            SortingPanel.Visible = false;
        }

        private void SortButton2_Click(object sender, EventArgs e)
        {
            SortingPanel.Visible = true;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            Functions sortare = new();
            if (SortType.SelectedIndex == 0)
            {
                
                sortare.SortingAsc(Functions.gridTransform(dataGridView1, IdComboBox.SelectedIndex), 0, dataGridView1.Rows.Count - 1, dataGridView1);
            }
            else {
                sortare.SortingDesc(Functions.gridTransform(dataGridView1, IdComboBox.SelectedIndex), 0, dataGridView1.Rows.Count - 1, dataGridView1);
                }
        }
    }
}
