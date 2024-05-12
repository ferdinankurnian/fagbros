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
            this.label1 = new System.Windows.Forms.Label();
            this.nextLevel = new System.Windows.Forms.Button();
            this.goMainMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "100";
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
            this.goMainMenu.TabIndex = 1;
            this.goMainMenu.UseVisualStyleBackColor = false;
            this.goMainMenu.Click += new System.EventHandler(this.goMainMenu_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "100";
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "levelComplete1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "levelComplete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nextLevel;
        private System.Windows.Forms.Button goMainMenu;
        private System.Windows.Forms.Label label2;
    }
}