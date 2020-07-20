using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;
using System.Windows.Forms;

namespace BudgetMinecraft
{
    public abstract class Block
    {

        public Block(string meltedItem,string droppedItem, string typeOfBlock)
        {
            MeltedItem = meltedItem;
            TypeOfBlock = typeOfBlock;
            DroppedItem = droppedItem;
        }
         
        

        public string MeltedItem { get; set; }
        public string DroppedItem { get; set; }
        public string TypeOfBlock { get; set; }

        public virtual void Break(List<string> mainInventory, List<string> chestInventory)
        {
            if (mainInventory.Contains("pickaxe") || chestInventory.Contains("pickaxe"))
            {
                if (mainInventory.Contains(TypeOfBlock))
                {
                    mainInventory.Remove(TypeOfBlock); //then we remove it from the inventory
                    MessageBox.Show(" result: " + TypeOfBlock + " was broked");

                }
                else
                {
                    if (chestInventory.Contains(TypeOfBlock)) //if not, we check in the chest
                    {
                        chestInventory.Remove(TypeOfBlock); //then we remove it from the inventory
                        MessageBox.Show(" result: " + TypeOfBlock + " was broked");
                    }
                }
            }
            else
            { 
                MessageBox.Show("there is no pickaxe to break !"); }
            } 

        public  virtual void Store(List<string> mainInventory, List<string> chestInventory)
        {
            if (mainInventory.Contains(TypeOfBlock)) //first we check if we have the item we want to store
            {
                chestInventory.Add(TypeOfBlock); //then you add it in the chest
                mainInventory.Remove(TypeOfBlock); //and remove it from the inventory
                MessageBox.Show( "result is: " + TypeOfBlock + " is stored in the chest");
            }
            else
            {
                MessageBox.Show("There is no " + TypeOfBlock + " to be  stored");
            }
        }

        public  void Pick(List<string> mainInventory) // when we the command word is pick
        {
            mainInventory.Add(TypeOfBlock); //we add the item into the inventory 
            MessageBox.Show( " result: " + TypeOfBlock + " was picked");
        }

        public  void Throw(List<string> mainInventory, List<string> chestInventory)
        {
            //we check if we have the item we want to throw in any inventory
            if (mainInventory.Contains(TypeOfBlock))
            {
                mainInventory.Remove(TypeOfBlock);
                MessageBox.Show( " result: " + TypeOfBlock + " was thrown");
            }
            else
            {
                if (chestInventory.Contains(TypeOfBlock)) //if not, we check in the chest
                {
                    chestInventory.Remove(TypeOfBlock);//then we remove it from the chest
                    MessageBox.Show(" result: " + TypeOfBlock + " was thrown");
                }
                else
                {
                    MessageBox.Show(" result: There is no" + TypeOfBlock + " to be thrown");
                }
            }
        }
        public virtual void Melt(List<string> mainInventory, List<string> chestInventory)
        {
            MessageBox.Show( "result: " + TypeOfBlock + " can't be melted");
        }

       

        protected int Count(List<string> list, string searchedItem)
        {
            //functuon for counting the number of times a seachedItem is found in a list
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToString() == searchedItem)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
