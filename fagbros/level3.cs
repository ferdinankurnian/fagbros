using fagbros.ModalDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fagbros
{
    public partial class formLevel3 : Form
    {
        // initialisasi variabel
        bool goleft = false; // boolean untuk kontrol player ke kiri
        bool goright = false; // boolean untuk kontrol player ke kanan
        bool jumping = false; // boolean untuk cek jika player melompat
        int jumpSpeed = 24; // integer untuk set kecepatan lompat
        int force = 5; // force dari lompat
        int totalCoin = 0; // default total koin di set ke 0
        int score = 0; // default total score di set ke 0
        int playSpeed = 24; // integer untuk set kecepatan player
        int heart = 5; // integer untuk total heart

        public formLevel3()
        {
            InitializeComponent();
        }

        private void gameTimer(object sender, EventArgs e)
        {
            // linking the jumpspeed integer with the player picture boxes to location
            player.Top += jumpSpeed;

            // refresh the player picture box consistently
            player.Refresh();

            // load total heart ke label
            getTotalHeart();

            getTotalCoin();

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
                jumpSpeed = -24;
                force -= 1;
            }
            else
            {
                // else change the jump speed to 12
                jumpSpeed = 24;
            }

            // if go left is true and players left is greater than 100 pixels
            // only then move player towards left of the 
            if (goleft && player.Left > 8)
            {
                player.Left -= playSpeed;
            }
            // by doing the if statement above, the player picture will stop on the forms left
            // if go right Boolean is true
            // player left plus players width plus 100 is less than the forms width
            // then we move the player towards the right by adding to the players left
            if (goright && player.Left + (player.Width + 5) < this.ClientSize.Width)
            {
                player.Left += playSpeed;
            }

            // below if the for loop thats checking for all of the controls in this form
            foreach (Control x in this.Controls)
            {
                // jika x adalah terrain
                if (x is PictureBox && x.Tag == "terrain")
                {
                    // then we are checking if the player is colliding with the terrain
                    // and jumping is set to false
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        if (player.Top < x.Top)
                        {
                            // then we do the following
                            force = 8; // set the force to 8
                            player.Top = x.Top - player.Height + 1; // also we place the player on top of the picture box
                            jumpSpeed = 0; // set the jump speed to 0
                        }
                        else if (goleft && player.Left < x.Right)
                        {
                            player.Left = x.Right - player.Width + 18;
                            player.Left += playSpeed;
                        }
                        else if (goright && player.Left + player.Width > x.Left)
                        {
                            player.Left -= playSpeed;
                        }
                        else if (player.Top < x.Top + x.Height)
                        {
                            player.Top = x.Top + x.Height + 20;
                            jumpSpeed -= playSpeed;
                        }

                        if (goleft || goright)
                        {
                            SoundPlayer walkSound = new SoundPlayer("steps.wav");
                            walkSound.Play();
                        }
                    }
                }

                // jika x adalah lava
                if (x is PictureBox && x.Tag == "lava")
                {
                    // jika player collide dengan lava
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (player.Top < x.Top)
                        {
                            showDiedDialog(); // tampikan dialog
                        }
                    }
                }

                // jika x adalah coin
                if (x is PictureBox && x.Tag == "coin")
                {
                    // jika player collide dengan coin
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x); // sembunyikan koin yang sudah collide
                        totalCoin++; // tambahkan 1 koin ke variabel coin

                        SoundPlayer coinSound = new SoundPlayer("coin_get.wav");
                        coinSound.Play();
                    }
                }

                // jika x adalah chest
                if (x is PictureBox && x.Tag == "chest")
                {
                    // jika player collide dengan chest
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Tag = "openedchest";
                        Random rndCoinChest = new Random(); // buat object random
                        int randomCoinGot = rndCoinChest.Next(1, 6); // range coin dari 1 sampai 5
                        x.BackgroundImage = Properties.Resources.opened_chest; // replace gambar menjadi chest terbuka
                        totalCoin += randomCoinGot; // tambahkan beberapa koin ke variabel coin

                        SoundPlayer chestSound = new SoundPlayer("tadareward.wav");
                        chestSound.Play();
                    }
                }
            }

            // jika player sudah berada di finish
            if (player.Bounds.IntersectsWith(door.Bounds))
            {
                // stop the timer
                mainGameTimer.Stop();

                // Inside Form1 button click event
                string inputValue = totalCoin.ToString();
                using (levelComplete3 lvlComplete = new levelComplete3(inputValue))
                {
                    if (lvlComplete.ShowDialog() == DialogResult.OK)
                    {
                        mainMenu MainMenu = new mainMenu(); // form Level 1
                        MainMenu.Show();
                        this.Hide();
                    }
                }
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
                SoundPlayer jumpSound = new SoundPlayer("jump.wav");
                jumpSound.Play();
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

        // fungsi untuk menampilkan dialog saat player mati
        public void showDiedDialog()
        {
            if (heart > 1)
            {
                mainGameTimer.Stop(); // stop the timer
                heart -= 1;
                MessageBox.Show("You Died!!!"); // show the message box
                restartGame();
                getTotalHeart();
            }
            else if (heart == 1)
            {
                mainGameTimer.Stop(); // stop timer nya
                MessageBox.Show("Game Over, Mulai dari awal lagi?"); // munculkan message box
                heart += 4;
                restartTotalGame(); // restart gamenya
                getTotalHeart(); // tampilkan total heartnya
            }
        }

        // fungsi untuk meletakkan total heart ke label
        public void getTotalHeart()
        {
            lblheart.Text = "X " + heart.ToString();
        }

        // fungsi untuk meletakkan total coin ke label
        public void getTotalCoin()
        {
            lblcoin.Text = "X " + totalCoin.ToString();
        }

        // fungsi untuk restart game
        public void restartGame()
        {
            mainGameTimer.Start();
            player.Location = new Point(130, 254);
        }

        // fungsi untuk restart total game
        public void restartTotalGame()
        {
            formLevel3 frmres = new formLevel3();
            frmres.Show();
            this.Hide();
        }

        private void closeToMainMenu(object sender, FormClosedEventArgs e)
        {
            mainMenu maMenu = new mainMenu(); // Instantiate a Form3 object.
            maMenu.Show(); // Show Form3 and
        }

        private void formLevel3_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void formLevel3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to leave this level?", "Exit Level", MessageBoxButtons.YesNo);
            // Check the result of the MessageBox
            if (result == DialogResult.Yes)
            {
                mainMenu maMenu = new mainMenu(); // Instantiate a Form3 object.
                maMenu.Show(); // Show Form3 and
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
