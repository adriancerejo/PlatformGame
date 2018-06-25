using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Adrian & Naman
//June 8 2018
//Main form to choose level or help
namespace PlatformGame
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void lnkLevel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//open level 1
            frmLevel1 row = new frmLevel1();
            this.Visible = false;
            row.ShowDialog();
            this.Visible = true;
        }

        private void lnkLevel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//open level 2
            frmLevel2 row = new frmLevel2();
            this.Visible = false;
            row.ShowDialog();
            this.Visible = true;
        }

        private void lnkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//open help
            frmHelp row = new frmHelp();
            this.Visible = false;
            row.ShowDialog();
            this.Visible = true;
        }
    }
}
