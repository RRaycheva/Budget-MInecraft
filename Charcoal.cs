using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetMinecraft
{
    [Serializable]
    class Charcoal : Block
    {
        public Charcoal() : base("stone", null , "charcoal")
        {

        }

        private string name = Sign.nickname;
        public override void Melt(List<string> mainInventory, List<string> chestInventory)
        {

            if (MeltedItem != null)
            {
                if (mainInventory.Contains("furnace") || chestInventory.Contains("furnace"))
                {

                    if (Count(mainInventory, TypeOfBlock) >= 2)
                    {
                        mainInventory.Add(MeltedItem); //then we add the transformed item to the inventory
                        mainInventory.Remove(TypeOfBlock); //we remove
                        mainInventory.Remove(TypeOfBlock); //the two items we have melted
                        MessageBox.Show(" result: " + TypeOfBlock + " was melted");
                    }
                    else
                    {
                        if (Count(chestInventory, TypeOfBlock) >= 2)
                        {
                            chestInventory.Add(MeltedItem); //then we add the transformed item to the inventory
                            chestInventory.Remove(TypeOfBlock); //we remove
                            chestInventory.Remove(TypeOfBlock); //the two items we have melted
                            MessageBox.Show(" result: " + TypeOfBlock + " was melted");
                        }
                        else
                        {
                            MessageBox.Show(" result: There is not enough " + TypeOfBlock + " to be melted");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("There is no furnace to melt the blocks");
                }
            }
        }



    }
}
