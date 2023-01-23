using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YProject.BackEnd;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class ExcelForm : Form
    {
        readonly DataReaderExcel dataReader = new();
        readonly ControlsLayout controlsLayout = new();
        readonly Functions sortare = new();
        public ExcelForm()
        {
            InitializeComponent();
        }


        private void SelectButton_Click(object sender, EventArgs e)
        {
            dataReader.FileSearchOpen(textBox1);
            if (File.Exists(textBox1.Text)) {
                DataReaderExcel.GetSheetNames(textBox1.Text, sheetComboBox);}
            else MessageBox.Show("File dont exists\nPlease select .xlxs file");

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text))
            {
                //controlsLayout.ClearPrevData(dataGridView1, sheetComboBox);
                
                if (dataReader.ReadData(dataGridView1, textBox1.Text, sheetComboBox.Text))
                {
                    Console.WriteLine("OK");
                }
                //    ControlsLayout.ShowSort(IdComboBox, SortingPanel);
                //SortButton2.Visible = true;
            }
            else MessageBox.Show("File dont exists\nPlease select .xlsx file");
        }
    }
}
