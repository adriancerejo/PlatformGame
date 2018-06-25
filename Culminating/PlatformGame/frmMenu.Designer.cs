namespace PlatformGame
{
    partial class frmMenu
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
            this.lnkHelp = new System.Windows.Forms.LinkLabel();
            this.lnkLevel2 = new System.Windows.Forms.LinkLabel();
            this.lnkLevel1 = new System.Windows.Forms.LinkLabel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkHelp
            // 
            this.lnkHelp.AutoSize = true;
            this.lnkHelp.Location = new System.Drawing.Point(130, 185);
            this.lnkHelp.Name = "lnkHelp";
            this.lnkHelp.Size = new System.Drawing.Size(29, 13);
            this.lnkHelp.TabIndex = 7;
            this.lnkHelp.TabStop = true;
            this.lnkHelp.Text = "Help";
            this.lnkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHelp_LinkClicked);
            // 
            // lnkLevel2
            // 
            this.lnkLevel2.AutoSize = true;
            this.lnkLevel2.Location = new System.Drawing.Point(123, 156);
            this.lnkLevel2.Name = "lnkLevel2";
            this.lnkLevel2.Size = new System.Drawing.Size(42, 13);
            this.lnkLevel2.TabIndex = 6;
            this.lnkLevel2.TabStop = true;
            this.lnkLevel2.Text = "Level 2";
            this.lnkLevel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLevel2_LinkClicked);
            // 
            // lnkLevel1
            // 
            this.lnkLevel1.AutoSize = true;
            this.lnkLevel1.Location = new System.Drawing.Point(123, 129);
            this.lnkLevel1.Name = "lnkLevel1";
            this.lnkLevel1.Size = new System.Drawing.Size(42, 13);
            this.lnkLevel1.TabIndex = 5;
            this.lnkLevel1.TabStop = true;
            this.lnkLevel1.Text = "Level 1";
            this.lnkLevel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLevel1_LinkClicked);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(32, 23);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(221, 65);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome To Jitter Jump!\r\n\r\nChoose a level to begin\r\n\r\nCreated by Adrian Cerejo an" +
    "d Naman Sharma\r\n";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lnkHelp);
            this.Controls.Add(this.lnkLevel2);
            this.Controls.Add(this.lnkLevel1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkHelp;
        private System.Windows.Forms.LinkLabel lnkLevel2;
        private System.Windows.Forms.LinkLabel lnkLevel1;
        private System.Windows.Forms.Label lblWelcome;
    }
}