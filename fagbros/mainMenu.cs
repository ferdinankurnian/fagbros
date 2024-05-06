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

namespace fagbros
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }
        public class User
        {
            public string Username { get; set; }
            public string HasLevel1 { get; set; }
            public string HasLevel2 { get; set; }
            public string HasLevel3 { get; set; }
        }

        private void closeGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            selectLevel modalSelectLevel = new selectLevel(); // Aktifkan Modal Select Level
            modalSelectLevel.ShowDialog(); // Tampilkam modal Select Level
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

        public static class UserManager
        {
            private static readonly string usersFilePath = "D:\\Projects\\fagbros\\fagbros\\Data\\user.json";

            public static List<User> LoadUsers()
            {
                if (File.Exists(usersFilePath))
                {
                    var json = File.ReadAllText(usersFilePath);
                    return JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
                }
                return new List<User>();
            }

            public static void SaveUser(User user)
            {
                var users = LoadUsers();
                users.Add(user);
                var json = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(usersFilePath, json);
            }

            public static bool AuthenticateUser(string username)
            {
                var users = LoadUsers();
                return users.Any(u => u.Username == username);
            }
        }

        private void btnLogInUser_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUserLogIn.Text;

            if (UserManager.AuthenticateUser(inputUsername))
            {
                greetingBox.BackgroundImage = Properties.Resources.Greet;
            }
            else
            {
                var newUser = new User
                {
                    Username = inputUsername
                };
                UserManager.SaveUser(newUser); 
            }
        }
    }
}
