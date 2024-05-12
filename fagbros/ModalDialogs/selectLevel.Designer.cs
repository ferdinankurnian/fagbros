namespace fagbros.ModalDialogs
{
    partial class selectLevel
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
            this.bgSelectLevel = new System.Windows.Forms.Panel();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.lblSelectLevel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.bgSelectLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgSelectLevel
            // 
            this.bgSelectLevel.BackgroundImage = global::fagbros.Properties.Resources.Save_Games;
            this.bgSelectLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bgSelectLevel.Controls.Add(this.btnLevel3);
            this.bgSelectLevel.Controls.Add(this.btnLevel2);
            this.bgSelectLevel.Controls.Add(this.btnLevel1);
            this.bgSelectLevel.Controls.Add(this.lblSelectLevel);
            this.bgSelectLevel.Controls.Add(this.btnClose);
            this.bgSelectLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgSelectLevel.Location = new System.Drawing.Point(0, 0);
            this.bgSelectLevel.Name = "bgSelectLevel";
            this.bgSelectLevel.Size = new System.Drawing.Size(365, 450);
            this.bgSelectLevel.TabIndex = 0;
            // 
            // btnLevel3
            // 
            this.btnLevel3.BackgroundImage = global::fagbros.Properties.Resources.Locked_ButtonLevel_3;
            this.btnLevel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLevel3.Enabled = false;
            this.btnLevel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLevel3.Location = new System.Drawing.Point(58, 348);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(247, 63);
            this.btnLevel3.TabIndex = 2;
            this.btnLevel3.UseVisualStyleBackColor = true;
            this.btnLevel3.Click += new System.EventHandler(this.btnLevel3_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.BackgroundImage = global::fagbros.Properties.Resources.Locked_ButtonLevel_2;
            this.btnLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLevel2.Enabled = false;
            this.btnLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLevel2.Location = new System.Drawing.Point(58, 225);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(247, 63);
            this.btnLevel2.TabIndex = 2;
            this.btnLevel2.UseVisualStyleBackColor = true;
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel2_Click);
            // 
            // btnLevel1
            // 
            this.btnLevel1.BackgroundImage = global::fagbros.Properties.Resources.ButtonLevel_1;
            this.btnLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLevel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLevel1.Location = new System.Drawing.Point(58, 101);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(247, 63);
            this.btnLevel1.TabIndex = 2;
            this.btnLevel1.UseVisualStyleBackColor = true;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // lblSelectLevel
            // 
            this.lblSelectLevel.AutoSize = true;
            this.lblSelectLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectLevel.Font = new System.Drawing.Font("Maiandra GD", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(24)))), ((int)(((byte)(20)))));
            this.lblSelectLevel.Location = new System.Drawing.Point(112, 14);
            this.lblSelectLevel.Name = "lblSelectLevel";
            this.lblSelectLevel.Size = new System.Drawing.Size(133, 26);
            this.lblSelectLevel.TabIndex = 1;
            this.lblSelectLevel.Text = "Select Level";
            this.lblSelectLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::fagbros.Properties.Resources.Close_Icon;
            this.btnClose.Location = new System.Drawing.Point(319, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // selectLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.bgSelectLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selectLevel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "selectLevel";
            this.Load += new System.EventHandler(this.selectLevel_Load);
            this.bgSelectLevel.ResumeLayout(false);
            this.bgSelectLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bgSelectLevel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSelectLevel;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnLevel3;
        private System.Windows.Forms.Button btnLevel2;
    }
}