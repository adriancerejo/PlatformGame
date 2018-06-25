using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using System.IO;
//Adrian Cerejo & Naman Sharma
//May 31 2018
//Platform Game

namespace PlatformGame
{
    enum PlayerState
    {
        Jump,
        Left,
        Right,
        None
    }


    public partial class frmLevel1 : Form
    {
        //Global Variables for movement
        PlayerState MoveRight = PlayerState.None;
        PlayerState MoveLeft = PlayerState.None;
        bool Jump = false;

        int ScorePlayer = 0;
        int Gravity = 8;
        int JumpSpeed = 10;


        public frmLevel1()
        {
            InitializeComponent();
        }

        private void ActivateMovement(object sender, KeyEventArgs e)
        {//if Keys are pressed these bools activate movement code
            if (e.KeyCode == Keys.Right)
            {
                MoveRight = PlayerState.Right;
            }
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = PlayerState.Left;
            }
            if (e.KeyCode == Keys.Up && !Jump)
            {
                Jump = true;
            }
        }

        private void DeactivateMovement(object sender, KeyEventArgs e)
        {//if Keys are released these bools deactivate movement code
            if (e.KeyCode == Keys.Right)
            {
                MoveRight = PlayerState.None;
            }
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = PlayerState.None;
            }
            if (Jump)
            {
                Jump = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            {
                //move player if bools are activated
                
                //forces character down as gravity effect
                picPlayer.Top += JumpSpeed;

                //if right arrow is pressed moves right
                if (MoveRight == PlayerState.Right)
                {
                    picPlayer.Left += 5;
                }
                //if left arrow is pressed move left
                if (MoveLeft == PlayerState.Left)
                {
                    picPlayer.Left -= 5;
                }

                if (Jump == true && Gravity < 0)
                {
                    Jump = false;
                }
                //if up arrow is pressed jump and return to ground
                if (Jump == true)
                {
                    JumpSpeed = -10;
                    Gravity -= 1;
                }
                else
                {
                    JumpSpeed = 10;
                }

            }

            //foreach to land on platforms and collect coins and add score each time coin is collected
            foreach (Control x in this.Controls)
            {  
                //if player tries to jump towards bottom they stop
                if (x is PictureBox && x.Tag == "walls")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        JumpSpeed = 0;
                        picPlayer.Top += 10;
                    }
                }
                //if they hit the platform they go on top
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && !Jump )
                    {
                        Gravity = 8;
                        picPlayer.Top = x.Top - picPlayer.Height;
                    }
                    
                }
              
               
                //if they touch coin they collect it and get a point
                if (x is PictureBox && x.Tag == "coin")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && !Jump && x.Visible == true)
                    {
                        x.Visible = false;
                        ScorePlayer++;
                        lblCoinsCollected.Text = ScorePlayer.ToString();
                    }

                }
                //if they touch tnt they die and game is over
                if (x is PictureBox && x.Tag == "tnt")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && !Jump)
                    {
                        tmrGame.Enabled = false;
                        lblGameOver.Visible = true;
                    }
                }

            }
            
            //when player gets to door player wins and timer stops  
            if (picPlayer.Bounds.IntersectsWith(picDoor.Bounds) && ScorePlayer == 12)
            {
                tmrGame.Enabled = false;
              
                lblWin.Visible = true;


            }


            //stop player from moving past form
            if (picPlayer.Location.X <= 0)
            {
                picPlayer.Location = new System.Drawing.Point(0, 748);

            }
            else if (picPlayer.Location.X >= 450)
            {
                picPlayer.Location = new System.Drawing.Point(450, 748);

            }

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closes current form and opens help form



            frmHelp s = new frmHelp();
            s.Visible = true;


        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //call reset method if new game is clicked
            Reset2();

        }

        //methods
      
        //reset method for new game
        private void Reset2()
        {
            //fades away game over/win
            lblGameOver.Visible = false;
            lblWin.Visible = false;
            //resets player location
            picPlayer.Location = new System.Drawing.Point(218, 716);
            //reset score 
            ScorePlayer = 0;
            lblCoinsCollected.Text = ScorePlayer.ToString();

            //respawns coins
            PictureBox[] coin = new PictureBox[12];
            coin[0] = picCoin1;
            coin[1] = picCoin2;
            coin[2] = picCoin3;
            coin[3] = picCoin4;
            coin[4] = picCoin5;
            coin[5] = picCoin6;
            coin[6] = picCoin7;
            coin[7] = picCoin8;
            coin[8] = picCoin9;
            coin[9] = picCoin10;
            coin[10] = picCoin11;
            coin[11] = picCoin12;

            //loop through each picture box to make it visible
            for (int i = 0; i < coin.Length; i++ )
            {
                coin[i].Visible = true;
            }

                tmrGame.Enabled = true;


        }
    
    
    }
}