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
    public partial class levelComplete : Form
    {
        public levelComplete()
        {
            InitializeComponent();
        }

        private void goMainMenu_Click(object sender, EventArgs e)
        {
            // mainMenu maMenu = new mainMenu(); // Instantiate a Form3 object.
            formLevel1 flvle1 = new formLevel1(); // Instantiate a Form3 object.
            flvle1.Close(); // Show Form3 and
            // maMenu.Show(); // Show Form3 and
            // this.Close();
        }
    }
}
