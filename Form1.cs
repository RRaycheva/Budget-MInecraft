using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetMinecraft
{
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
        }

        public static string nickname;

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            nickname = textBoxName.Text;

            if (nickname == "" || nickname == null)
            {
                MessageBox.Show("Please, type your nickname!");
            }
            else
            {
                Game game = new Game();
                if (game.ShowDialog() == DialogResult.OK)
                {
                   
                }
            }
        }

        
        private void textBoxNickname_KeyDown(object sender, KeyEventArgs e)
        {
            nickname = textBoxName.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if (nickname == "" || nickname == null)
                {
                    MessageBox.Show("Please, type your nickname!");
                }
                else
                {
                    Game game = new Game();
                    if (game.ShowDialog() == DialogResult.OK)
                    {

                    }
                }

            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Description of game \n creator");
        }

        private void Sign_Load(object sender, EventArgs e)
        {

        }
    }

}

