namespace fagbros.ModalDialogs
{
    partial class openedChest
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
            this.lblShowGetRandomCoins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblShowGetRandomCoins
            // 
            this.lblShowGetRandomCoins.AutoSize = true;
            this.lblShowGetRandomCoins.BackColor = System.Drawing.Color.Transparent;
            this.lblShowGetRandomCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblShowGetRandomCoins.Location = new System.Drawing.Point(174, 280);
            this.lblShowGetRandomCoins.Name = "lblShowGetRandomCoins";
            this.lblShowGetRandomCoins.Size = new System.Drawing.Size(34, 18);
            this.lblShowGetRandomCoins.TabIndex = 0;
            this.lblShowGetRandomCoins.Text = "X []";
            // 
            // openedChest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fagbros.Properties.Resources.Chest_Opened_GUI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.lblShowGetRandomCoins);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "openedChest";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "openedChest";
            this.Load += new System.EventHandler(this.openedChest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowGetRandomCoins;
    }
}