using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fagbros.ModalDialogs
{
    public partial class levelComplete1 : Form
    {
        public levelComplete1(string inputValue)
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            lblShowCoins.Text = inputValue;
            lblShowScore.Text = inputValue;
        }
          
        private void goMainMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void nextLevel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void levelComplete1_Load(object sender, EventArgs e)
        {

        }
    }
}
