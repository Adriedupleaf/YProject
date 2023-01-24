namespace YProject.BackEnd
{
    internal class ControlsLayout
    {
        public static void initSort(ComboBox SortType)
        {
            SortType.Items.Add("ASC");
            SortType.Items.Add("DESC");
            SortType.SelectedIndex = 0;
        }
        public static void ClearPrevData(DataGridView Grid, ComboBox IdComboBox)
        {
            if (Grid.Rows.Count == 0 && Grid.Columns.Count == 0)
            {
                Grid.Columns.Clear();
                Grid.Rows.Clear();
                Grid.Refresh();
            }

            IdComboBox.Items.Clear();

        }
        public static void ShowSort(ComboBox IdComboBox, Panel SortingPanel)
        {
            IdComboBox.SelectedIndex = 0;
            SortingPanel.Visible = true;
        }
    }
}
