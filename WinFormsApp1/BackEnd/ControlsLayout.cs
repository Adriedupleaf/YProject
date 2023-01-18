namespace YProject.BackEnd
{
    internal class ControlsLayout
    {

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
