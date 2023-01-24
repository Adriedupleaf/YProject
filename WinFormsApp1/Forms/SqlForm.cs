using YProject.BackEnd;

namespace WinFormsApp1
{
    public partial class SqlForm : Form
    {
        readonly DataReaderSql DataReaderSql = new();
        readonly ControlsLayout ControlsLayout = new();
        readonly Functions sortare = new();
        public SqlForm()
        {
            InitializeComponent();
            ControlsLayout.initSort(SortType);
        }

        private void SqlForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataReaderSql.GetDataSources(connectionsComboBox);
                connectionsComboBox.SelectedIndex = 0;
            }
            catch (Exception ex) { Console.WriteLine(ex); }


        }



        private void ConnectionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbSelectorComboBox.Items.Clear();
            DataReaderSql.GetDatabases(connectionsComboBox, dbSelectorComboBox);
            dbSelectorComboBox.Visible = true;
            dbSelectorComboBox.SelectedIndex = 0;

        }

        private void DbSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(dbSelectorComboBox.SelectedItem.ToString());
            //Console.WriteLine(connectionsComboBox.SelectedItem.ToString());
            DataReaderSql.GetDataTables(connectionsComboBox, dbSelectorComboBox, dbTableComboBox);
            dbTableComboBox.Visible = true;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ControlsLayout.ClearPrevData(dataGridView1, IdComboBox);
            if (connectionsComboBox.SelectedItem != null && dbSelectorComboBox.SelectedItem != null && dbTableComboBox.SelectedItem != null)
            {
                if (DataReaderSql.ReadData("Data Source=" + connectionsComboBox.SelectedItem.ToString() + ";Database=" + dbSelectorComboBox.SelectedItem.ToString() + "; Integrated Security=true;Encrypt=False", dataGridView1, dbTableComboBox.SelectedItem.ToString(), IdComboBox))
                {
                    ControlsLayout.ShowSort(IdComboBox, SortingPanel);
                    SortButton2.Visible = true;
                }
            }
            else MessageBox.Show("Do not use empty fields!");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            SortingPanel.Visible = false;
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

        private void SortButton2_Click(object sender, EventArgs e)
        {
            SortingPanel.Visible = true;
        }
    }
}
