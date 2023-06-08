using App_ALLCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App2
{
    internal class CmdListItemData
    {
/*        public CmdListItemData(DataBase dataBase)
        {
            Text = "cccc";
        }*/
        public String Text { get; set; }
        public ICommand Command { get; set; }
    }

}
