namespace fagbros
{
    partial class formLevel1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLevel1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.door = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.grass1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimer);
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.door.Location = new System.Drawing.Point(760, 119);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(95, 108);
            this.door.TabIndex = 3;
            this.door.TabStop = false;
            this.door.Tag = "door";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.Control;
            this.player.Image = global::fagbros.Properties.Resources.Character11;
            this.player.Location = new System.Drawing.Point(185, 246);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(38, 69);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // grass1
            // 
            this.grass1.BackColor = System.Drawing.Color.Transparent;
            this.grass1.BackgroundImage = global::fagbros.Properties.Resources.grass;
            this.grass1.Location = new System.Drawing.Point(0, 321);
            this.grass1.Name = "grass1";
            this.grass1.Size = new System.Drawing.Size(387, 50);
            this.grass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass1.TabIndex = 1;
            this.grass1.TabStop = false;
            this.grass1.Tag = "terrain";
            // 
            // formLevel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fagbros.Properties.Resources.Background_1;
            this.ClientSize = new System.Drawing.Size(1344, 661);
            this.Controls.Add(this.door);
            this.Controls.Add(this.player);
            this.Controls.Add(this.grass1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formLevel1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAG Bros - Level 1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeToMainMenu);
            this.Load += new System.EventHandler(this.formLevel1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox grass1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox door;
    }
}

