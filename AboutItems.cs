using System;
using System.Windows.Forms;
using System.Xml;


namespace BudgetMinecraft.Properties
{
    public partial class About_Items : Form
    {
        public About_Items()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (searchInput != null )
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("XMLFile1.xml");

                foreach (XmlNode node in doc.DocumentElement)
                {
                    string name = node.Attributes[0].InnerText;
                    if (name == searchInput.Text)
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            searchResults.Items.Add(child.InnerText);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input  ;) ");
                searchInput.Text = string.Empty;
                searchInput.Focus();
            }
        }

        private void Clear_Buttom_Click(object sender, EventArgs e)
        {
            searchResults.Items.Clear();
            searchInput.Text = string.Empty;
        }

        private void About_Items_Load(object sender, EventArgs e)
        {

        }
    }
          
}
