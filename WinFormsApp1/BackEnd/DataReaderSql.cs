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
                        connectionsComboBox.Items.Add(instanceName);
                        Console.WriteLine(ServerName + "\\" + instanceName);
                    }
                }
            }
        }
        public void getDatabases(ComboBox connectionsComboBox,ComboBox dbSelectorComboBox)
        {
            using (var con = new SqlConnection("Data Source=" + connectionsComboBox.SelectedText + "; Integrated Security=true;Encrypt=False"))
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
        public void getDataTables(ComboBox connectionsComboBox,ComboBox dbTableComboBox)
        {
            using (var con = new SqlConnection("Data Source=" + connectionsComboBox.SelectedText + "; Integrated Security=true;Encrypt=False"))
            {
                con.Open();
                DataTable t = con.GetSchema("Tables");
                foreach (DataRow tab in t.Rows)
                    dbTableComboBox.Items.Add(tab[2].ToString());
            }
        }
    }
}
