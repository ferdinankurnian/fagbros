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
    public partial class openedChest : Form
    {
        public openedChest(string inputValue)
        {
            InitializeComponent();
            lblShowGetRandomCoins.Text = "X " + inputValue;
        }

        async private void openedChest_Load(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            this.Close();
        }
    }
}

