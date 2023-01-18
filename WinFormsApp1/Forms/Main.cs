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
            ExcelForm Excel = new()
            {
                TopLevel = false,
                ControlBox = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(Excel);
            Excel.Show();

        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            TextForm Text = new()
            {
                TopLevel = false,
                ControlBox = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(Text);
            Text.Show();
        }

        private void SqlButton_Click(object sender, EventArgs e)
        {

            SqlForm SQL = new()
            {
                TopLevel = false,
                ControlBox = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(SQL);
            SQL.Show();

        }
    }
}