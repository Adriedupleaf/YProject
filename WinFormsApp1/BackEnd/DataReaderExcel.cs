using OfficeOpenXml;
using System.Data;

namespace YProject.BackEnd
{
    internal class DataReaderExcel
    {
        public string? FileName;
        public bool ReadData(DataGridView dataGrid, string excelFileName, string sheetName, ComboBox idComboBox)
        {

            try
            {
                using (ExcelPackage xlPackage = new(new FileInfo(excelFileName)))
                {
                    DataTable dt = new DataTable();
                    ExcelWorksheet worksheet = xlPackage.Workbook.Worksheets[sheetName];
                    if (worksheet.Dimension == null)
                        throw (new Exception("Nu sunt date"));
                    List<string> columnNames = new List<string>();
                    int currentColumn = 1;
                    foreach (var cell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                    {
                        string columnName = cell.Text.Trim();
                        if (cell.Start.Column != currentColumn)
                        {
                            columnNames.Add("Header_" + currentColumn);
                            dt.Columns.Add("Header_" + currentColumn);
                            currentColumn++;
                        }
                        columnNames.Add(columnName);
                        int occurrences = columnNames.Count(x => x.Equals(columnName));
                        if (occurrences > 1)
                        {
                            columnName = columnName + "_" + occurrences;
                        }
                        dt.Columns.Add(columnName);
                        currentColumn++;
                    }
                    for (int i = 2; i <= worksheet.Dimension.End.Row; i++)
                    {
                        var row = worksheet.Cells[i, 1, i, worksheet.Dimension.End.Column];
                        DataRow newRow = dt.NewRow();
                        foreach (var cell in row)
                        {
                            newRow[cell.Start.Column - 1] = cell.Text;
                        }

                        dt.Rows.Add(newRow);
                        
                    }
                    foreach (DataColumn col in dt.Columns)
                        dataGrid.Columns.Add(col.ColumnName, col.ColumnName);
                    foreach (DataRow row in dt.Rows)
                        dataGrid.Rows.Add(row.ItemArray);
                    idComboBox.DataSource = columnNames;
                }

                return true;

            }
            catch (Exception ex) { Console.WriteLine(ex); return false; }

        }
        public void FileSearchOpen(TextBox Path)
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Path.Text = openFileDialog1.FileName;
                FileName = openFileDialog1.FileName;
            }
        }
        public void GetSheetNames(string path, ComboBox sheetComboBox)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using ExcelPackage xlPackage = new(new FileInfo(path));
            List<string> sheets = xlPackage.Workbook.Worksheets.Select(x => x.Name).ToList();
            foreach (string s in sheets)
                sheetComboBox.Items.Add(s);
        }
    }
}
