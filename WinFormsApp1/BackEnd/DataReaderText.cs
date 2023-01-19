using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace YProject.BackEnd
{
    internal class DataReaderText : IReader
    {
        public string? FileName;

        public bool ReadData(DataGridView Grid, ComboBox IdComboBox)
        {
            try
            {
                using StreamReader Reader = new(FileName);
                string? element = Reader?.ReadLine();
                element = element?.Trim();
                string delimiters = "\t" + ' ';
                string[] Header = element.Split(delimiters.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (string header in Header)
                {
                    Grid.Columns.Add(header, header);
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
                        Grid.Rows.Add(TopBase);
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        public void FileSearchOpen(TextBox Path)
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
                Path.Text = openFileDialog1.FileName;
                FileName = openFileDialog1.FileName;
            }
        }
        

    }
}
