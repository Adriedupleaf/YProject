using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YProject.BackEnd
{
    internal class Functions
    {
        public static string[] gridTransform(DataGridView Grid, int cellIndex)
        {
            string[] data = new string[Grid.Rows.Count];
            for (int i = 0; i < Grid.Rows.Count ; i++)
            {
                if (Grid.Rows[i].Cells[cellIndex].Value != null)
                    data[i] = Grid.Rows[i].Cells[cellIndex].Value.ToString().Trim();
                else data[i] = "";
            }
            return data;
        }
        
        public void SortingAsc(string[] array, int start, int end, DataGridView Grid)
        {

            int i = start;
            int k = end;
            if (end - start >= 1)
            {
                string pivot = array[start];
                while (k > i)
                {
                    while (array[i].CompareTo(pivot) <= 0 && i <= end && k > i)
                        i++;
                    while (array[k].CompareTo(pivot) > 0 && k >= start && k >= i)
                        k--;
                    if (k > i)
                        swap(array, i, k, Grid);
                }
                swap(array, start, k, Grid);
                SortingAsc(array, start, k - 1, Grid);
                SortingAsc(array, k + 1, end, Grid);
            }
            else { return; }

           
        }
        public void SortingDesc(string[] array, int start, int end, DataGridView Grid)
        {

            int i = start;
            int k = end;
            if (end - start >= 1)
            {
                string pivot = array[start];
                while (k > i)
                {
                    while (array[i].CompareTo(pivot) <= 0 && i <= end && k > i)
                        i++;
                    while (array[k].CompareTo(pivot) > 0 && k >= start && k >= i)
                        k--;
                    if (k > i)
                        swap(array, i, k, Grid);
                }
                swap(array, start, k, Grid);
                SortingDesc(array, start, k - 1, Grid);
                SortingDesc(array, k + 1, end, Grid);
            }
            else { return; }

           
        }
        private static void SwapRows(DataGridView grid, int row1, int row2)
        {
            if (row1 != row2 && row1 >= 0 && row2 >= 0 && row1 < grid.RowCount && row2 < grid.RowCount)
            {
                var rows = grid.Rows.Cast<DataGridViewRow>().ToArray();
                var temp = rows[row1];
                rows[row1] = rows[row2];
                rows[row2] = temp;
                grid.Rows.Clear();
                grid.Rows.AddRange(rows);
            }
        }
        public static void swap(string[] array, int index1, int index2, DataGridView Grid)
        {
            
            (array[index2], array[index1]) = (array[index1], array[index2]);
            SwapRows(Grid, index1, index2);
        }
    }
}
