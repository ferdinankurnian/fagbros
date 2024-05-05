using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fagbros
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void openLevel1_Click(object sender, EventArgs e)
        {
            formLevel1 flvl1 = new formLevel1(); // Instantiate a Form3 object.
            flvl1.Show(); // Show Form3 and
            this.Hide(); // hide the Form2 instance.
        }

        private void closeGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
