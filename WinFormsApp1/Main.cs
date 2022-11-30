using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Main : Form
    {
        

        public Main()
        {
            InitializeComponent();
            
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            ExcelForm Excel=new ExcelForm();
            Excel.TopLevel = false;
            Excel.ControlBox = false;
            Excel.AutoScroll = true;
            Excel.FormBorderStyle = FormBorderStyle.None;
            Excel.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(Excel);
            Excel.Show();

        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            TextForm Text = new TextForm();
            Text.TopLevel = false;
            Text.ControlBox = false;
            Text.AutoScroll = true;
            Text.FormBorderStyle = FormBorderStyle.None;
            Text.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(Text);
            Text.Show();
        }

        private void SqlButton_Click(object sender, EventArgs e)
        {
            
            SqlForm SQL = new SqlForm();
            SQL.TopLevel = false;
            SQL.ControlBox = false;
            SQL.AutoScroll = true;
            SQL.FormBorderStyle= FormBorderStyle.None;
            SQL.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(SQL);
            SQL.Show();
            
        }
    }
}