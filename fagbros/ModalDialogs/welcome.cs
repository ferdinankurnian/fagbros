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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fagbros.ModalDialogs
{
    public partial class welcome : Form
    {
        private string _usersFilePath = "Data/user.json";
        private Dictionary<string, string> _users;
        public string usernameRegistered { get; set; }

        public welcome()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            LoadUsersw();
        }

        // fungsi untuk membaca user (load user)
        public void LoadUsersw()
        {
            // Define the directory path where you want to create a folder
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data/user.json");

            string json = File.ReadAllText(filePath);

            _users = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }

        // fungsi untuk save user
        public void SaveUsers()
        {
            string json = JsonConvert.SerializeObject(_users);
            File.WriteAllText(_usersFilePath, json);
        }

        public void RegistUser()
        {
            string username = txtUsername.Text;

            if (!_users.ContainsKey("username") && !string.IsNullOrEmpty(username))
            {
                _users.Add("username", username);
                _users.Add("haslevel2", "false");
                _users.Add("haslevel3", "false");
                SaveUsers();
                usernameRegistered = username;
                MessageBox.Show("Username added! Now you can play!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            RegistUser();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegistUser();
            }
        }
    }
}
