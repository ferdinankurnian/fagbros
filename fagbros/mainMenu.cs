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
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Media;

namespace fagbros
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
            LoadUsers();

            SoundPlayer backSound = new SoundPlayer("resources/backsound.wav");
            backSound.Play();
        }

        // fungsi untuk membuka list level
        private void btnPlay_Click(object sender, EventArgs e)
        {
            using (selectLevel modalSelectLevel = new selectLevel())
            {
                if (modalSelectLevel.ShowDialog() == DialogResult.OK)
                {
                    // Retrieve the data from the dialog form
                    string selectedLevel = modalSelectLevel.getLevel;

                    if(selectedLevel == "lvl1")
                    {
                        formLevel1 lvl1 = new formLevel1(); // form Level 1
                        lvl1.Show();
                        this.Hide();
                    }
                    else if (selectedLevel == "lvl2")
                    {
                        formLevel2 lvl2 = new formLevel2(); // form Level 1
                        lvl2.Show();
                        this.Hide();
                    }
                    else if (selectedLevel == "lvl3")
                    {
                        formLevel3 lvl3 = new formLevel3(); // form Level 1
                        lvl3.Show();
                        this.Hide();
                    }
                }
            }
        }

        // fungsi untuk exit game dari quit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        // fungsi untuk membuka settings
        private void btnSettings_Click(object sender, EventArgs e)
        {
            settings modalSettings = new settings(); // Aktifkan Modal Select Level
            modalSettings.Show(); // Tampilkam modal Select Level
        }

        // fungsi untuk membaca user (load user)
        public void LoadUsers()
        {
            // Define the directory path where you want to create a folder
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Data");

            // Check if the directory already exists
            if (!Directory.Exists(directoryPath))
            {
                // Create the directory if it does not exist
                Directory.CreateDirectory(directoryPath);
            }

            // Define the file path within the directory
            string filePath = Path.Combine(directoryPath, "user.json");

            // Check if the file already exists
            if (!File.Exists(filePath))
            {
                // Create the file and close it after writing
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("{  }");
                }

                using (welcome welcomelogin = new welcome())
                {
                    if (welcomelogin.ShowDialog() == DialogResult.OK)
                    {
                        // Retrieve the data from the dialog form
                        string usernameadded = welcomelogin.usernameRegistered;

                        lblUsernameMainMenu.Text = usernameadded;
                    }
                }
            }
            else
            {
                string json = File.ReadAllText(filePath);

                // Parse the JSON string into a JObject
                var jsonObject = JObject.Parse(json);

                // Check if the "username" key exists
                if (jsonObject.ContainsKey("username"))
                {
                    // Retrieve the value associated with the "username" key
                    string valueusername = jsonObject["username"].ToString();

                    lblUsernameMainMenu.Text = valueusername;
                }
                else
                {
                    using (welcome welcomelogin = new welcome())
                    {
                        if (welcomelogin.ShowDialog() == DialogResult.OK)
                        {
                            // Retrieve the data from the dialog form
                            string usernameadded = welcomelogin.usernameRegistered;

                            lblUsernameMainMenu.Text = usernameadded;
                        }
                    }
                }
            }

        }

        private void userAccount_Click(object sender, EventArgs e)
        {
            showAccountMenu();
        }

        private void lblUsernameMainMenu_Click(object sender, EventArgs e)
        {
            showAccountMenu();
        }

        public void showAccountMenu()
        {
            userAccountMenu accountmenu = new userAccountMenu();
            accountmenu.ShowDialog();
        }

        // fungsi untuk exit game dari close form
        private void closeGame(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
