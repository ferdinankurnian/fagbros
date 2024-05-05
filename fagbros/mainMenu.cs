using fagbros.ModalDialogs;
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

        private string usersFilePath = "Data/users.json"; // Path to the JSON file

        public class User
        {
            public string Username { get; set; }
        }

        private List<User> users = new List<User>();

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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            selectLevel modalSelectLevel = new selectLevel(); // Aktifkan Modal Select Level
            modalSelectLevel.Show(); // Tampilkam modal Select Level
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogInUser_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUserLogIn.Text;

            var user = users.FirstOrDefault(u => u.Username == inputUsername);

            if (user != null)
            {
                MessageBox.Show("Welcome!");
            }
            else
            {
                
            }
        }
    }
}
