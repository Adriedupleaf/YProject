using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YProject.BackEnd
{
    internal interface IReader
    {
        bool ReadData(DataGridView Grid, System.Windows.Forms.ComboBox IdComboBox);
    }
}
