using YProject.BackEnd;

namespace WinFormsApp1
{
    public partial class ExcelForm : Form
    {
        readonly DataReaderExcel dataReader = new();
        readonly Functions sortare = new();
        public ExcelForm()
        {
            InitializeComponent();
            ControlsLayout.initSort(SortType);
        }


        private void SelectButton_Click(object sender, EventArgs e)
        {
            ControlsLayout.ClearPrevData(dataGridView1, sheetComboBox);
            dataReader.FileSearchOpen(textBox1);
            if (File.Exists(textBox1.Text))
            {
                dataReader.GetSheetNames(textBox1.Text, sheetComboBox);
            }
            else MessageBox.Show("File dont exists\nPlease select .xlxs file");

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text))
            {

                if (dataReader.ReadData(dataGridView1, textBox1.Text, sheetComboBox.Text, IdComboBox))
                {
                    ControlsLayout.ShowSort(IdComboBox, SortingPanel);
                    Console.WriteLine("OK");
                    SortButton2.Visible = true;
                }

            }
            else MessageBox.Show("File dont exists\nPlease select .xlsx file");
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (SortType.SelectedIndex == 0)
            {

                sortare.SortingAsc(Functions.gridTransform(dataGridView1, IdComboBox.SelectedIndex), 0, dataGridView1.Rows.Count - 1, dataGridView1);
            }
            else
            {
                sortare.SortingDesc(Functions.gridTransform(dataGridView1, IdComboBox.SelectedIndex), 0, dataGridView1.Rows.Count - 1, dataGridView1);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            SortingPanel.Visible = false;
        }
    }
}
