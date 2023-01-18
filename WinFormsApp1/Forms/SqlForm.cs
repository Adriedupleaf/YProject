using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using System.Data;
using System.Drawing;
using YProject.BackEnd;

namespace WinFormsApp1
{
    public partial class SqlForm : Form
    {
        DataReaderSql DataReaderSql = new();
        ControlsLayout ControlsLayout = new();
        Functions sortare = new();
        public SqlForm()
        {
            InitializeComponent();
        }

        private void SqlForm_Load(object sender, EventArgs e)
        {
            DataReaderSql.getDataSources(connectionsComboBox);
            connectionsComboBox.SelectedIndex = 0;
        }
        


        private void ConnectionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbSelectorComboBox.Items.Clear();
            DataReaderSql.getDatabases(connectionsComboBox, dbSelectorComboBox);
            dbSelectorComboBox.Visible = true;
            dbSelectorComboBox.SelectedIndex = 0;
            dbTableComboBox.Visible=true;
        }

        private void DbSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbTableComboBox.Items.Clear();
            DataReaderSql.getDataTables(connectionsComboBox,dbTableComboBox);
            
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

        }
    }
}
