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
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace fagbros.ModalDialogs
{
    public partial class selectLevel : Form
    {
        public string getLevel { get; set; }
        public selectLevel()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            LoadLevels();
        }

        // fungsi untuk membaca user (load user)
        public void LoadLevels()
        {
            // Define the directory path where you want to create a folder
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data/user.json");

            string json = File.ReadAllText(filePath);

            // Parse the JSON string into a JObject
            var jsonObject = JObject.Parse(json);

            // Retrieve the value associated with the "username" key
            string hasLevel2 = jsonObject["haslevel2"].ToString();
            string hasLevel3 = jsonObject["haslevel3"].ToString();

            if(hasLevel2 == "true")
            {
                btnLevel2.BackgroundImage = Properties.Resources.ButtonLevel_2;
                btnLevel2.Enabled = true;
            }
            else
            {
                btnLevel2.BackgroundImage = Properties.Resources.Locked_ButtonLevel_2;
                btnLevel2.Enabled = false;
            }


            if (hasLevel3 == "true")
            {
                btnLevel3.BackgroundImage = Properties.Resources.ButtonLevel_3;
                btnLevel3.Enabled = true;
            }
            else
            {
                btnLevel3.BackgroundImage = Properties.Resources.Locked_ButtonLevel_3;
                btnLevel3.Enabled = false;
            }
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
            getLevel = "lvl1";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            getLevel = "lvl2";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            getLevel = "lvl3";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
