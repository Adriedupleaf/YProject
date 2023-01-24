using YProject.BackEnd;

namespace WinFormsApp1
{
    public partial class TextForm : Form
    {
        readonly DataReaderText DataReader = new();
        readonly ControlsLayout ControlsLayout = new();
        readonly Functions sortare = new();
        public TextForm()
        {

            InitializeComponent();
            ControlsLayout.initSort(SortType);

        }


        private void SelectButton_Click(object sender, EventArgs e)
        {
            DataReader.FileSearchOpen(textBox1);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            if (File.Exists(textBox1.Text))
            {
                ControlsLayout.ClearPrevData(dataGridView1, IdComboBox);
                if (DataReader.ReadData(dataGridView1, IdComboBox))
                    ControlsLayout.ShowSort(IdComboBox, SortingPanel);
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
            if (SortType.SelectedIndex == 0)
            {

                sortare.SortingAsc(Functions.gridTransform(dataGridView1, IdComboBox.SelectedIndex), 0, dataGridView1.Rows.Count - 1, dataGridView1);
            }
            else
            {
                sortare.SortingDesc(Functions.gridTransform(dataGridView1, IdComboBox.SelectedIndex), 0, dataGridView1.Rows.Count - 1, dataGridView1);
            }
        }
    }
}
