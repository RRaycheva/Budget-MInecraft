using BudgetMinecraft.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace BudgetMinecraft
{
    public partial class Game : Form
    {
        public static List<string> mainInventory = new List<string>();
        public static List<string> chestInventory = new List<string>();

        private const string BREAK = "break";
        private const string MELT = "melt";
        private const string PICK = "pick";
        private const string THROW = "throw";
        private const string STORE = "store";

        public Game()
        {
            InitializeComponent();
            labelName.Text = Sign.nickname;

            mainInventory.Add(charcoal.TypeOfBlock);
            mainInventory.Add(grass.TypeOfBlock);
            mainInventory.Add(furnace.TypeOfBlock);
            mainInventory.Add(stone.TypeOfBlock);
            mainInventory.Add(wood.TypeOfBlock);
            mainInventory.Add(pickaxe.TypeOfBlock);
            mainInventory.Add(chest.TypeOfBlock);
        }

        Action actionForm = new Action();

        Block wood = new Wood();
        Block stone = new Stone();
        Block pickaxe = new Pickaxe();
        Block grass = new Grass();
        Block furnace = new Furnace();
        Block chest = new Chest();
        Block charcoal = new Charcoal();

        public string action;
        public string picName;
        

        private void pictureBoxInventories_MouseClick(object sender, MouseEventArgs e)
        {
            Inventory inventory = new Inventory(mainInventory,chestInventory);
            if (inventory.ShowDialog() == DialogResult.OK)
            {

            }
        }



        private void pictureBoxCharcoal_Click(object sender, EventArgs e)
        {
            if (actionForm.ShowDialog() == DialogResult.OK)
            {

            }

            action = actionForm.resultAction.ToLower();
          
            switch (action)
            {
                case BREAK:                  
                     charcoal.Break(mainInventory, chestInventory); 
                     break;
                case MELT:
                    charcoal.Melt(mainInventory, chestInventory);
                    break;
                case PICK:
                    charcoal.Pick(mainInventory);
                    break;
                case THROW:
                    charcoal.Throw(mainInventory, chestInventory);
                    break;
                case STORE:
                    charcoal.Store(mainInventory, chestInventory);
                    break;
            }
        }

        private void pictureBoxStone_Click(object sender, EventArgs e)
        {
            if (actionForm.ShowDialog() == DialogResult.OK)
            {

            }

            action = actionForm.resultAction;
          

            switch (action)
            {
                case BREAK:
                    stone.Break(mainInventory, chestInventory);
                    break;
                case MELT:
                    stone.Melt(mainInventory, chestInventory);
                    break;
                case PICK:
                    stone.Pick(mainInventory);
                    break;
                case THROW:
                    stone.Throw(mainInventory, chestInventory);
                    break;
                case STORE:
                    stone.Store(mainInventory, chestInventory);
                    break;
            }
        }

        private void pictureBoxFurnace_Click(object sender, EventArgs e)
        {
            if (actionForm.ShowDialog() == DialogResult.OK)
            {

            }

            action = actionForm.resultAction;
           
            switch (action)
            {
                case BREAK:
                    furnace.Break(mainInventory, chestInventory);
                    break;
                case MELT:
                    furnace.Melt(mainInventory, chestInventory);
                    break;
                case PICK:
                    furnace.Pick(mainInventory);
                    break;
                case THROW:
                    furnace.Throw(mainInventory, chestInventory);
                    break;
                case STORE:
                    furnace.Store(mainInventory, chestInventory);
                    break;
            }
        }

        private void pictureBoxWood_Click(object sender, EventArgs e)
        {
            actionForm.ShowDialog();

            action = actionForm.resultAction;
           

            switch (action)
            {
                case BREAK:
                    wood.Break(mainInventory, chestInventory);
                    break;
                case MELT:
                    wood.Melt(mainInventory, chestInventory);
                    break;
                case PICK:
                    wood.Pick(mainInventory);
                    break;
                case THROW:
                    wood.Throw(mainInventory, chestInventory);
                    break;
                case STORE:
                    wood.Store(mainInventory, chestInventory);
                    break;
            }
        }

        private void pictureBoxChest_Click(object sender, EventArgs e)
        {
            if (actionForm.ShowDialog() == DialogResult.OK)
            {

            }

            action = actionForm.resultAction;
          
            switch (action)
            {
                case BREAK:
                    chest.Break(mainInventory, chestInventory);
                    break;
                case MELT:
                    chest.Melt(mainInventory, chestInventory);
                    break;
                case PICK:
                    chest.Pick(mainInventory);
                    break;
                case THROW:
                    chest.Throw(mainInventory, chestInventory);
                    break;
                case STORE:
                    chest.Store(mainInventory, chestInventory);
                    break;
            }
        }

        private void pictureBoxPickaxe_Click(object sender, EventArgs e)
        {
            if (actionForm.ShowDialog() == DialogResult.OK)
            {

            }

            action = actionForm.resultAction;
          

            switch (action)
            {
                case BREAK:
                    pickaxe.Break(mainInventory, chestInventory);
                    break;
                case MELT:
                    pickaxe.Melt(mainInventory, chestInventory);
                    break;
                case PICK:
                    pickaxe.Pick(mainInventory);
                    break;
                case THROW:
                    pickaxe.Throw(mainInventory, chestInventory);
                    break;
                case STORE:
                    pickaxe.Store(mainInventory, chestInventory);
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (actionForm.ShowDialog() == DialogResult.OK)
            {

            }

            action = actionForm.resultAction;
          

            switch (action)
            {
                case BREAK:
                    grass.Break(mainInventory, chestInventory);
                    break;
                case MELT:
                    grass.Melt(mainInventory, chestInventory);
                    break;
                case PICK:
                    grass.Pick(mainInventory);
                    break;
                case THROW:
                    grass.Throw(mainInventory, chestInventory);
                    break;
                case STORE:
                    grass.Store(mainInventory, chestInventory);
                    break;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void validationEventHandeler(object sender, ValidationEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("", @"C:\Users\Rumi\Desktop\BudgetMinecraft\XMLSchema1.xsd");

            XDocument doc = XDocument.Load(@"C:\Users\Rumi\Desktop\BudgetMinecraft\XMLFile1.xml");
            bool validationError = false;
            doc.Validate
                 (schema, (s, p) =>
                 {
                     MessageBox.Show(p.Message);
                     validationError = true;
                 });

            if (validationError)
            {
                MessageBox.Show("Validation faild");
            }
            else
            {
                MessageBox.Show("Validation succeeded");
            }
        }

        private void pictureBoxInventories_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            About_Items items = new About_Items();
            if (items.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}

