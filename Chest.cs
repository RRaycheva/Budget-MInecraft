using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetMinecraft
{[Serializable]
    class Chest:Block
    {
        public Chest() : base(null, null, "chest")
        {
           
        }

        private string name = Sign.nickname;       

       
        public override void Store(List<string> mainInventory, List<string> chestInventory)
        {
            MessageBox.Show(name + ", chest can't be stored in chest");
        }
    }
}
