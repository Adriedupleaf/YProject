using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YProject.BackEnd
{
    internal class DataReaderExcel
    {
        public string? FileName;
        public bool ReadData(DataGridView dataGrid, string excelFileName, string sheetName)
        {

            try
            {
                    using (ExcelPackage xlPackage = new(new FileInfo(excelFileName)))
                    {    
                        ExcelWorksheet worksheet = xlPackage.Workbook.Worksheets[sheetName];
                        ExcelCellAddress startCell = worksheet.Dimension.Start;
                        ExcelCellAddress endCell = worksheet.Dimension.End;

                        for (Int32 row = startCell.Row; row <= endCell.Row; row++)
                        {  
                            dataGrid.Rows.Add();
                            for (int col = startCell.Column; col <= endCell.Column; col++)
                            {
                                var excelCell = worksheet.Workbook.Worksheets.First().Cells[row, col];
                                var gridViewCell = dataGrid.Rows[row - 1].Cells[col - 1];
                                gridViewCell.Value = excelCell.Value;
                            }
                        }
                    

                }
                return true;

            }
            catch(Exception ex) { Console.WriteLine(ex); return false; }
            
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
        public static void GetSheetNames(string path, ComboBox sheetComboBox)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using ExcelPackage xlPackage = new(new FileInfo(path));
            List<string> sheets = xlPackage.Workbook.Worksheets.Select(x => x.Name).ToList();
            foreach (string s in sheets)
                sheetComboBox.Items.Add(s);
        }
}
}
