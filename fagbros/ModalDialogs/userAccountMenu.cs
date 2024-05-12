using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fagbros.ModalDialogs
{
    public partial class userAccountMenu : Form
    {
        // Define the directory path where you want to create a folder
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data/user.json");

        public userAccountMenu()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            LoadUsers();
        }

        // fungsi untuk membaca user (load user)
        public void LoadUsers()
        {
            string json = File.ReadAllText(filePath);
            // Parse the JSON string into a JObject
            var jsonObject = JObject.Parse(json);
            string valueusername = jsonObject["username"].ToString();

            lblUsername.Text = valueusername;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Define the message and caption for the MessageBox
            string message = "You can Log out. But if you Log out, all levels that have been played will be lost. Are you sure?";
            string caption = "Confirmation Log out";

            // Show the MessageBox with the OK and No buttons
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            // Check the result of the MessageBox
            if (result == DialogResult.Yes)
            {
                // Content to write to the file
                string content = "{  }";

                // Write the content to the file, overwriting it if it already exists
                File.WriteAllText(filePath, content);

                // Restart the application
                Application.Restart();
                // Close the current instance of the application
                Environment.Exit(0);
            }
        }
    }
}
