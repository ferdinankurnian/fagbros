namespace fagbros.ModalDialogs
{
    partial class levelComplete3
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
            this.goMainMenu = new System.Windows.Forms.Button();
            this.lblShowCoins = new System.Windows.Forms.Label();
            this.lblShowScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goMainMenu
            // 
            this.goMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.goMainMenu.BackgroundImage = global::fagbros.Properties.Resources.Exit;
            this.goMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goMainMenu.Location = new System.Drawing.Point(125, 252);
            this.goMainMenu.Name = "goMainMenu";
            this.goMainMenu.Size = new System.Drawing.Size(110, 60);
            this.goMainMenu.TabIndex = 4;
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
            this.lblShowCoins.Location = new System.Drawing.Point(193, 199);
            this.lblShowCoins.Name = "lblShowCoins";
            this.lblShowCoins.Size = new System.Drawing.Size(35, 18);
            this.lblShowCoins.TabIndex = 2;
            this.lblShowCoins.Text = "100";
            // 
            // lblShowScore
            // 
            this.lblShowScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowScore.AutoSize = true;
            this.lblShowScore.BackColor = System.Drawing.Color.Transparent;
            this.lblShowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowScore.Location = new System.Drawing.Point(221, 157);
            this.lblShowScore.Name = "lblShowScore";
            this.lblShowScore.Size = new System.Drawing.Size(35, 18);
            this.lblShowScore.TabIndex = 3;
            this.lblShowScore.Text = "100";
            // 
            // levelComplete3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fagbros.Properties.Resources.Completed_Level_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(342, 342);
            this.Controls.Add(this.goMainMenu);
            this.Controls.Add(this.lblShowCoins);
            this.Controls.Add(this.lblShowScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "levelComplete3";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "levelComplete3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goMainMenu;
        private System.Windows.Forms.Label lblShowCoins;
        private System.Windows.Forms.Label lblShowScore;
    }
}