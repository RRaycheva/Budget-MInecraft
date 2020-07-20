using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetMinecraft
{[Serializable]
    class Grass : Block
    {
        public Grass()
           : base(null, "stone", "grass")
        {

        }

        private string name = Sign.nickname;

        public override void Break(List<string> mainInventory, List<string> chestInventory)
        {
            if (mainInventory.Contains("pickaxe") || chestInventory.Contains("pickaxe"))
            {
                if (mainInventory.Contains(TypeOfBlock))
                {
                    mainInventory.Remove(TypeOfBlock);//then we remove it from the inventory
                    mainInventory.Add(DroppedItem);
                    MessageBox.Show(name + ", result is: " + TypeOfBlock + " was broken");
                }
                else
                {
                    if (chestInventory.Contains(TypeOfBlock)) //if not, we check in the chest
                    {
                        chestInventory.Remove(TypeOfBlock);//then we remove it from the inventory
                        chestInventory.Add(DroppedItem);
                        MessageBox.Show(name + ", result is: " + TypeOfBlock + " was broken");
                    }
                    else
                    {
                        MessageBox.Show(name + ", result is: There is no " + TypeOfBlock + " to be broken");
                    }
                }
            }
            else
            {
                MessageBox.Show("there is no pickaxe to break the item !");
            }
       

        }

      

    }
}
