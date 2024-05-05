namespace fagbros
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.openLevel1 = new System.Windows.Forms.Button();
            this.openLevel2 = new System.Windows.Forms.Button();
            this.openLevel3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openLevel1
            // 
            this.openLevel1.Location = new System.Drawing.Point(308, 132);
            this.openLevel1.Name = "openLevel1";
            this.openLevel1.Size = new System.Drawing.Size(75, 23);
            this.openLevel1.TabIndex = 0;
            this.openLevel1.Text = "Level 1";
            this.openLevel1.UseVisualStyleBackColor = true;
            this.openLevel1.Click += new System.EventHandler(this.openLevel1_Click);
            // 
            // openLevel2
            // 
            this.openLevel2.Location = new System.Drawing.Point(118, 225);
            this.openLevel2.Name = "openLevel2";
            this.openLevel2.Size = new System.Drawing.Size(75, 23);
            this.openLevel2.TabIndex = 0;
            this.openLevel2.Text = "Level 2";
            this.openLevel2.UseVisualStyleBackColor = true;
            // 
            // openLevel3
            // 
            this.openLevel3.Location = new System.Drawing.Point(440, 205);
            this.openLevel3.Name = "openLevel3";
            this.openLevel3.Size = new System.Drawing.Size(75, 23);
            this.openLevel3.TabIndex = 0;
            this.openLevel3.Text = "Level 3";
            this.openLevel3.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 482);
            this.Controls.Add(this.openLevel3);
            this.Controls.Add(this.openLevel2);
            this.Controls.Add(this.openLevel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainMenu";
            this.Text = "FAG Bros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeGame);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openLevel1;
        private System.Windows.Forms.Button openLevel2;
        private System.Windows.Forms.Button openLevel3;
    }
}