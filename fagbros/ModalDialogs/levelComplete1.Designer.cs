namespace fagbros.ModalDialogs
{
    partial class levelComplete1
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
            this.lblShowScore = new System.Windows.Forms.Label();
            this.nextLevel = new System.Windows.Forms.Button();
            this.goMainMenu = new System.Windows.Forms.Button();
            this.lblShowCoins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblShowScore
            // 
            this.lblShowScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowScore.AutoSize = true;
            this.lblShowScore.BackColor = System.Drawing.Color.Transparent;
            this.lblShowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowScore.Location = new System.Drawing.Point(218, 157);
            this.lblShowScore.Name = "lblShowScore";
            this.lblShowScore.Size = new System.Drawing.Size(35, 18);
            this.lblShowScore.TabIndex = 0;
            this.lblShowScore.Text = "100";
            // 
            // nextLevel
            // 
            this.nextLevel.BackColor = System.Drawing.Color.Transparent;
            this.nextLevel.BackgroundImage = global::fagbros.Properties.Resources.Next;
            this.nextLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextLevel.Location = new System.Drawing.Point(149, 254);
            this.nextLevel.Name = "nextLevel";
            this.nextLevel.Size = new System.Drawing.Size(158, 60);
            this.nextLevel.TabIndex = 1;
            this.nextLevel.UseVisualStyleBackColor = false;
            this.nextLevel.Click += new System.EventHandler(this.nextLevel_Click);
            // 
            // goMainMenu
            // 
            this.goMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.goMainMenu.BackgroundImage = global::fagbros.Properties.Resources.Exit;
            this.goMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goMainMenu.Location = new System.Drawing.Point(32, 254);
            this.goMainMenu.Name = "goMainMenu";
            this.goMainMenu.Size = new System.Drawing.Size(110, 60);
            this.goMainMenu.TabIndex = 2;
            this.goMainMenu.UseVisualStyleBackColor = false;
            this.goMainMenu.Click += new System.EventHandler(this.goMainMenu_Click);
            // 
            // lblShowCoins
            // 
            this.lblShowCoins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowCoins.AutoSize = true;
            this.lblShowCoins.BackColor = System.Drawing.Color.Transparent;
            this.lblShowCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCoins.Location = new System.Drawing.Point(190, 199);
            this.lblShowCoins.Name = "lblShowCoins";
            this.lblShowCoins.Size = new System.Drawing.Size(35, 18);
            this.lblShowCoins.TabIndex = 0;
            this.lblShowCoins.Text = "100";
            // 
            // levelComplete1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fagbros.Properties.Resources.Completed_Level_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(342, 342);
            this.Controls.Add(this.goMainMenu);
            this.Controls.Add(this.nextLevel);
            this.Controls.Add(this.lblShowCoins);
            this.Controls.Add(this.lblShowScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "levelComplete1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "levelComplete";
            this.Load += new System.EventHandler(this.levelComplete1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowScore;
        private System.Windows.Forms.Button nextLevel;
        private System.Windows.Forms.Button goMainMenu;
        private System.Windows.Forms.Label lblShowCoins;
    }
}