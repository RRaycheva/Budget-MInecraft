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
    public partial class Action : Form
    {
        public Action()
        {
            InitializeComponent();
        }

        public string resultAction;

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(radioButtonBreak.Checked)
            {
                resultAction = "break";
                this.Close();
            }
            else if (radioButtonThrow.Checked)
            {
                resultAction = "throw";
                this.Close();
            }
            else if (radioButtonStore.Checked)
            {
                resultAction = "store";
                this.Close();
            }
            else if (radioButtonPick.Checked)
            {
                resultAction = "pick";
                this.Close();
            }
            else if (radioButtonMelt.Checked)
            {
                resultAction = "melt";
                this.Close();
            }
            else if(radioButtonBreak.Checked==false && radioButtonMelt.Checked == false && radioButtonThrow.Checked == false && radioButtonPick.Checked == false && radioButtonStore.Checked == false)
            {
                MessageBox.Show("Please, chose an action to continue!");
            }
        }

        private void Action_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonMelt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonBreak_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
