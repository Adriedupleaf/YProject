using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YProject.BackEnd
{
    internal class DataReaderSql : IReader
    {
        bool IReader.ReadData(DataGridView Grid, ComboBox IdComboBox)
        {
            throw new NotImplementedException();
        }
        public void getDataSources(ComboBox connectionsComboBox)
        {
            string ServerName = Environment.MachineName;
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
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
        public void getDatabases(ComboBox connectionsComboBox,ComboBox dbSelectorComboBox)
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
        public void getDataTables(ComboBox connectionsComboBox, ComboBox dbSelectorComboBox, ComboBox dbTableComboBox)
        {
            
            using (SqlConnection con = new SqlConnection("Data Source=" + connectionsComboBox.SelectedItem.ToString() + ";Database=" + dbSelectorComboBox.SelectedItem.ToString() + "; Integrated Security=true;Encrypt=False"))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", con))
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
