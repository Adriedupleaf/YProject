namespace YProject.BackEnd
{
    internal class ControlsLayout
    {
        public void initSort(ComboBox SortType)
        {
            SortType.Items.Add("ASC");
            SortType.Items.Add("DESC");
            SortType.SelectedIndex = 0;
        }
        public void ClearPrevData(DataGridView Grid, ComboBox IdComboBox)
        {
            Grid.Columns.Clear();
            IdComboBox.Items.Clear();
            Grid.Rows.Clear();
            Grid.Refresh();

        }
        public void ShowSort(ComboBox IdComboBox, Panel SortingPanel)
        {
            IdComboBox.SelectedIndex = 0;
            SortingPanel.Visible = true;
        }
    }
}
