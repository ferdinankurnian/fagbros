using fagbros.ModalDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace fagbros
{
    public partial class formLevel1 : Form
    {
        bool goleft = false; // boolean untuk kontrol player ke kiri
        bool goright = false; // boolean untuk kontrol player ke kanan
        bool jumping = false; // boolean untuk cek jika player melompat
        int jumpSpeed = 10; // integer untuk set kecepatan lompat
        int force = 8; // force of the jump in an integer
        int score = 0; // default score integer set to 0
        int playSpeed = 18; //this integer will set players speed to 18
        int backLeft = 8; // this integer will set the background moving speed to 8

        public formLevel1()
        {
            InitializeComponent();
            mainMenu masmenu = new mainMenu();
            masmenu.Hide();
        }

        private void OnFrameChangedHandler(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void formLevel1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            // linking the jumpspeed integer with the player picture boxes to location
            player.Top += jumpSpeed;
            // refresh the player picture box consistently
            player.Refresh();
            // if jumping is true and force is less than 0
            // then change jumping to false
            if (jumping && force < 0)
            {
                jumping = false;
            }
            // if jumping is true
            // then change jump speed to -12 
            // reduce force by 1
            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                // else change the jump speed to 12
                jumpSpeed = 12;
            }
            // if go left is true and players left is greater than 100 pixels
            // only then move player towards left of the 
            if (goleft && player.Left > 2)
            {
                player.Left -= playSpeed;
            }
            // by doing the if statement above, the player picture will stop on the forms left
            // if go right Boolean is true
            // player left plus players width plus 100 is less than the forms width
            // then we move the player towards the right by adding to the players left
            if (goright && player.Left + (player.Width + 100) < this.ClientSize.Width)
            {
                player.Left += playSpeed;
            }

            // below if the for loop thats checking for all of the controls in this form
            foreach (Control x in this.Controls)
            {
                // is X is a picture box and it has a tag of terrain
                if (x is PictureBox && x.Tag == "terrain")
                {
                    // then we are checking if the player is colliding with the terrain
                    // and jumping is set to false
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        // then we do the following
                        force = 8; // set the force to 8
                        player.Top = x.Top - player.Height + 10; // also we place the player on top of the picture box
                        jumpSpeed = 0; // set the jump speed to 0
                    }
                }
                // if the picture box found has a tag of coin
                if (x is PictureBox && x.Tag == "coin")
                {
                    // now if the player collides with the coin picture box
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x); // then we are going to remove the coin image
                        score++; // add 1 to the score
                    }
                }
            }
            // if the player collides with the door and has key boolean is true
            if (player.Bounds.IntersectsWith(door.Bounds))
            {
                // then we change the image of the door to open
                // and we stop the timer
                gameTimer.Stop();

                levelComplete lvlComplete = new levelComplete(); // Instantiate a Form3 object.
                lvlComplete.Show(); // Show Form3 and
            }
            // this is where the player dies
            // if the player goes below the forms height then we will end the game
            if (player.Top + player.Height > this.ClientSize.Height + 60)
            {
                gameTimer.Stop(); // stop the timer
                MessageBox.Show("You Died!!!"); // show the message box
                restartGame();
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //if the player pressed the left key AND the player is inside the panel
            // then we set the car left boolean to true
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            // if player pressed the right key and the player left plus player width is less then the panel1 width          

            if (e.KeyCode == Keys.Right)
            {
                // then we set the player right to true
                goright = true;
            }
            //if the player pressed the space key and jumping boolean is false

            if (e.KeyCode == Keys.Up && !jumping)
            {
                // then we set jumping to true
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            // if the LEFT key is up we set the car left to false
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            // if the RIGHT key is up we set the car right to false
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            //when the keys are released we check if jumping is true
            // if so we need to set it back to false so the player can jump again
            if (jumping)
            {
                jumping = false;
            }
        }

        public void restartGame()
        {
            gameTimer.Start();
            player.Location = new Point(130, 254);
        }

        private void closeToMainMenu(object sender, FormClosedEventArgs e)
        {
            mainMenu maMenu = new mainMenu(); // Instantiate a Form3 object.
            maMenu.Show(); // Show Form3 and
        }
    }
}
