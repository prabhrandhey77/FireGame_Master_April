using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_Master_April
{
    public partial class Form1 : Form
    {
        int fire = 0;
        int firewy = 0;
        int bullet = 0;
        int shoot = 0;
       // funs obj = null;
        public funs obj = new funs();
        Random ran = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        // starting the game by clicking on start button 
        private void gamest1_Click(object sender, EventArgs e)
        {
            picBox.Image = FireGame_Master_April.Properties.Resources.start1;
            gameld.Enabled = true;
            gamest1.Enabled = false;
            reloadbtn.Visible = false;
        }
        //below function is loading the picture of load in the game
        private void gameld_Click(object sender, EventArgs e)
        {
            gameld.Enabled = false;
            spin_gun.Enabled = true;

            picBox.Image = FireGame_Master_April.Properties.Resources.load1;

        }

        //spin the gun image at spin image 
        private void spin_gun_Click(object sender, EventArgs e)
        {
            spin_gun.Enabled = false;
            shot_btn.Enabled = true;

            picBox.Image = FireGame_Master_April.Properties.Resources.spin1;
        }

        private void shot_btn_Click(object sender, EventArgs e)
        {
            // for shooting the button  
            fire++;
            shoot++;
            
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(FireGame_Master_April.Properties.Resources._40_smith_wesson_8x_gunshot_mike_koenig);
            player.Play();

            picBox.Image = FireGame_Master_April.Properties.Resources.shoot1;
            if (fire == 4)
            {
                MessageBox.Show("Wohh you survived");
                shot_away.Enabled = false;
                shot_btn.Enabled = false;

                reloadbtn.Visible = true;
                reloadbtn.Enabled = true;
                fire = 0;
            }
            else if (shoot == bullet)
            {
                MessageBox.Show("About to Die");
                shot_btn.Enabled = false;
                shot_away.Enabled = false;

                reloadbtn.Visible = true;
                reloadbtn.Enabled = true;
                fire = 0;
            }
            else
            {
                MessageBox.Show("Next Time Try");
            }


        }
        private void frstchance()
        {
            throw new NotImplementedException();
        }
        //shoot away button giving shoot away chances
        private void shot_away_Click(object sender, EventArgs e)
        {
            firewy++;
            shoot++;
            picBox.Image = FireGame_Master_April.Properties.Resources.shoot2;
            if (firewy == 2)
            {
                MessageBox.Show("About to die");
                shot_btn.Enabled = false;
                shot_away.Enabled = false;

                reloadbtn.Visible = true;
                reloadbtn.Enabled = true;
                fire = 0;
            }
            else if (shoot == bullet)
            {
                MessageBox.Show("Wohh You Suvived");
                shot_btn.Enabled = false;
                shot_away.Enabled = false;

                reloadbtn.Visible = true;
                reloadbtn.Enabled = true;
                fire = 0;
            }
            else
            {
                MessageBox.Show("Next Time Try");
            }
        }

        private void reloadbtn_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
            this.Hide();
        }
    }
}
