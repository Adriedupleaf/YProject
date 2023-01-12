using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YProject.BackEnd
{
    internal class ControlsLayout
    {
        /*rivate void ShowSort()
        {
            SortType.Items.Clear();
            IdComboBox.SelectedIndex = 0;
            SortType.Items.Add("ASC");
            SortType.Items.Add("DESC");
            SortType.SelectedIndex = 0;
            SortingPanel.Visible = true;
        }
        */
        public void ClearPrevData(DataGridView Grid, System.Windows.Forms.ComboBox IdComboBox)
        {
            Grid.Columns.Clear();
            IdComboBox.Items.Clear();
            Grid.Rows.Clear();
            Grid.Refresh();

        }
        public void ShowSort(System.Windows.Forms.ComboBox IdComboBox, Panel SortingPanel)
        {
            IdComboBox.SelectedIndex = 0;
            SortingPanel.Visible = true;
        }
    }
}
