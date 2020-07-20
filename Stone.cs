using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetMinecraft
{[Serializable]
    class Stone:Block
    {
        public Stone() : base(null,"grass", "stone")
        {

        }

        private string name = Sign.nickname;

        public override void Break(List<string> mainInventory, List<string> chestInventory)
        {
            if (mainInventory.Contains("pickaxe") || chestInventory.Contains("pickaxe"))
            {
                if (mainInventory.Contains(TypeOfBlock)) //check in which inventory exactly 
                {
                    mainInventory.Remove(TypeOfBlock);// we remove the item from the inventory
                    mainInventory.Add(DroppedItem); //and we add the dropped item
                    MessageBox.Show(name + ", result is: " + TypeOfBlock + " was broken");
                }
                else
                {
                    if (chestInventory.Contains(TypeOfBlock))
                    {
                        chestInventory.Remove(TypeOfBlock);// we remove the item from the inventory
                        chestInventory.Add(DroppedItem); //and we add the dropped item
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
