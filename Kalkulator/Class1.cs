using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace Kalkulator
{
    public class Customer : DataGrid
    {
        public string Days { get; set; }
        public string SUM { get; set; }
        public string Proc { get; set; }
        public string Result { get; set; }


    }
}
