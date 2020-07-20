using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml.Schema;


namespace BudgetMinecraft
{
    public partial class Inventory : Form
    {
        public Inventory() { }
        
        public Inventory(List<string>mainList,List<string>chestList)
        {
            InitializeComponent();
            
            var mItem = from s in mainList // sorting mainInventory using LINQ
                        orderby s.Length descending
                        select s;

            var chItem = from s in chestList // sorting chestInventoryusing LINQ
                         orderby s.Length descending
                         select s;

            foreach (string listItem in mItem)
            {
                listBoxMain.Items.Add(listItem);
            }

            foreach (string listItem in chItem)
            {
                listBoxChest.Items.Add(listItem);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var binFormater = new BinaryFormatter();

            using (var fileStream = new FileStream("E:\\ту- 2ри семсетър\\Minecraft_main.txt", FileMode.Create, FileAccess.ReadWrite))
                binFormater.Serialize(fileStream, Game.mainInventory);
  
            using (var fileStream = new FileStream("E:\\ту- 2ри семсетър\\Minecraft_chest.txt", FileMode.Create, FileAccess.ReadWrite))
                binFormater.Serialize(fileStream, Game.chestInventory);
        }

        private void listBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBoxChest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
