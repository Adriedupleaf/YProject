﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Functions
    {
        public String[] gridTransform(DataGridView Grid,int cellIndex)
        {
            String []data = new String[Grid.Rows.Count];
            for (int i = 0; i < Grid.Rows.Count-1; i++)
            {
                if (Grid.Rows[i].Cells[cellIndex].Value != null)
                    data[i] = Grid.Rows[i].Cells[cellIndex].Value.ToString().Trim();
                else data[i] = "";
            }
            Grid.Sort(Grid.Columns[cellIndex], ListSortDirection.Ascending);
            return data;
        }
        public String[] A;
        public void sorting(String []array, int start, int end, DataGridView Grid)
        {
            
            int i = start;
            int k = end;
            if (end - start >= 1)
            {
                String pivot = array[start];
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
                sorting(array, start, k - 1, Grid);
                sorting(array, k + 1, end, Grid);
            }
            else { return; }
            
            A = array;
        }
        public void swap(String []array, int index1, int index2, DataGridView Grid)
        {
           
            String temp2 = array[index1];
            array[index1] = array[index2];
            array[index2] = temp2;
        }
    }
}
