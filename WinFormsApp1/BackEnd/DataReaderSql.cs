using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using System.Data;

namespace YProject.BackEnd
{
    internal class DataReaderSql
    {
        public static bool ReadData(string connectionString, DataGridView dataGrid, string tb, ComboBox IdComboBox)
        {
            try
            {
                var c = new SqlConnection(connectionString);
                var dataAdapter = new SqlDataAdapter("SELECT * FROM " + tb, c);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                foreach (var item in ds.Tables[0].Columns)
                    IdComboBox.Items.Add(item);
                //dataGrid.DataSource = ds.Tables[0];
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {

                    dataGrid.Columns.Add(dc.ColumnName, dc.ColumnName);

                }
                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    dataGrid.Rows.Add(dr.ItemArray);

                }
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
        public static void GetDataSources(ComboBox connectionsComboBox)
        {
            string ServerName = Environment.MachineName;
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                using (RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false))
                {
                    if (instanceKey != null)
                    {
                        foreach (var instanceName in instanceKey.GetValueNames())
                        {
                            connectionsComboBox.Items.Add(ServerName);
                            Console.WriteLine(ServerName + '\\' + instanceName);
                        }
                    }
                }
            }
        }
        public static void GetDatabases(ComboBox connectionsComboBox, ComboBox dbSelectorComboBox)
        {
            using (var con = new SqlConnection("Data Source=" + connectionsComboBox.SelectedItem.ToString() + "; Integrated Security=true;Encrypt=False"))
            {
                con.Open();
                DataTable databases = con.GetSchema("Databases");
                foreach (DataRow database in databases.Rows)
                {
                    String databaseName = database.Field<string>("database_name");
                    dbSelectorComboBox.Items.Add(databaseName);
                }
            }
        }
        public static void GetDataTables(ComboBox connectionsComboBox, ComboBox dbSelectorComboBox, ComboBox dbTableComboBox)
        {

            using (SqlConnection con = new("Data Source=" + connectionsComboBox.SelectedItem.ToString() + ";Database=" + dbSelectorComboBox.SelectedItem.ToString() + "; Integrated Security=true;Encrypt=False"))
            {
                con.Open();
                using (SqlCommand com = new("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", con))
                {
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        dbTableComboBox.Items.Clear();
                        while (reader.Read())
                        {
                            Console.WriteLine(reader[0]);
                            dbTableComboBox.Items.Add((string)reader["TABLE_NAME"]);
                        }
                    }
                }
            }

        }
    }
}
