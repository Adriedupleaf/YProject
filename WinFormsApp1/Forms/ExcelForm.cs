using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ExcelForm : Form
    {
        public ExcelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new()
            {
                InitialDirectory = @"C:\",
                Title = "Browse Excel Files",
                DefaultExt = "xlsx",
                Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true
            };
        }
    }
}
