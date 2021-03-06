using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_form
{
    public partial class GameForm : Form
    {
        logic_class Obj_Logic = new logic_class();
        public object obj_logic;

        public GameForm()
        {
            InitializeComponent();
        //code to enable the load button 

            btn_spin.Enabled = false;
            btn_headshot.Enabled = false;
            btn_shootaway.Enabled = false;
        }

       
        //add button to spin the chambber
  
        private void btn_spin_Click(object sender, EventArgs e)
        {
            btn_shootaway.Enabled = true;
            btn_headshot.Enabled = true;
            btn_spin.Enabled = false;

            //code to change display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Game_form.Resources.spin.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            image_showbox.Image = bmp_Object;

            //spin the chamber

            Random Obj_random = new Random();
            Obj_Logic.spin_position = Obj_random.Next(1, 7);
            
            // add sound on spinnig

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Game_form.Properties.Resources.spin_wav);

            Sound_Object.Play();
        }

        // add load button to reload 
        private void btn_load_Click(object sender, EventArgs e)
        {
            btn_spin.Enabled = true;
            btn_load.Enabled = false;
            
            //code to display gif in picture box on button click   

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Game_form.Resources.load.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            image_showbox.Image = bmp_Object;

            // add sound on reload button


            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Game_form.Properties.Resources.reload);

            Sound_Object.Play();

            // load logic

            Obj_Logic.load_position = 1;
        }

        // add button to play again 
        private void btn_playagain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        // add button to exit the game
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        // create shoot on head button 
        private void btn_headshot_Click(object sender, EventArgs e)

            // add gif on headshot button 
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Game_form.Resources.headshot.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            image_showbox.Image = bmp_Object;


            //add sound when shoot on head

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Game_form.Properties.Resources.shots);

            Sound_Object.Play();

            //add logic

            Obj_Logic.head_shot = Obj_Logic.shoot();
            if (Obj_Logic.head_shot == 1)
         
                // implement messages on fire
            {

                MessageBox.Show("You are DEAD, Hence lost the Game");
            }
            else
            {
                MessageBox.Show("You Missed the shot");
            }

        }

        // create shootaway button 
        private void btn_shootaway_Click(object sender, EventArgs e)


            // add image on shootaway button 
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Game_form.Resources.shoot.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            image_showbox.Image = bmp_Object;

            // implement sound when fire away


            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Game_form.Properties.Resources.shot);

            Sound_Object.Play();

            //add logic

            {
                if (Obj_Logic.chances <= 2)
                {
                    Obj_Logic.head_shot = Obj_Logic.shoot();
                    if (Obj_Logic.head_shot == 1)
                    {
                        MessageBox.Show("Don't worry, you are safe. You Win the Game");
                        btn_shootaway.Enabled = false;
                        btn_headshot.Enabled = false;
                    }

                    // show messages after shoot
                    else
                    {
                        MessageBox.Show("Opps!!! It was an Empty Shot");
                        Obj_Logic.chances++;
                        if (Obj_Logic.chances == 3)
                        {
                            MessageBox.Show(" Ooops.. Your Lifelines have finished.. You loose the Game");
                            btn_shootaway.Enabled = false;
                            btn_headshot.Enabled = false;
                        }
                    }
                    
                   
                }
                else
                {
                    MessageBox.Show("Lifelines are over");
                    btn_shootaway.Enabled = false;
                    btn_headshot.Enabled = false;
                }

            }

        }
    }
}
