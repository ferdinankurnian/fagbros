namespace fagbros.ModalDialogs
{
    partial class levelComplete2
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
            this.nextLevel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goMainMenu
            // 
            this.goMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.goMainMenu.BackgroundImage = global::fagbros.Properties.Resources.Exit;
            this.goMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goMainMenu.Location = new System.Drawing.Point(33, 254);
            this.goMainMenu.Name = "goMainMenu";
            this.goMainMenu.Size = new System.Drawing.Size(110, 60);
            this.goMainMenu.TabIndex = 4;
            this.goMainMenu.UseVisualStyleBackColor = false;
            // 
            // nextLevel
            // 
            this.nextLevel.BackColor = System.Drawing.Color.Transparent;
            this.nextLevel.BackgroundImage = global::fagbros.Properties.Resources.Next;
            this.nextLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextLevel.Location = new System.Drawing.Point(150, 254);
            this.nextLevel.Name = "nextLevel";
            this.nextLevel.Size = new System.Drawing.Size(158, 60);
            this.nextLevel.TabIndex = 5;
            this.nextLevel.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "100";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "100";
            // 
            // levelComplete2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fagbros.Properties.Resources.Completed_Level_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(342, 342);
            this.Controls.Add(this.goMainMenu);
            this.Controls.Add(this.nextLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "levelComplete2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "levelComplete2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goMainMenu;
        private System.Windows.Forms.Button nextLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}