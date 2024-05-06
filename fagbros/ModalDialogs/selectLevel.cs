using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace fagbros.ModalDialogs
{
    public partial class selectLevel : Form
    {
        public selectLevel()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void selectLevel_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {

            formLevel1 lvl1 = new formLevel1(); // form Level 1
            lvl1.Show();
            this.Close();
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {

        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {

        }
    }
}
