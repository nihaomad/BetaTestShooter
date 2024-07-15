using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fin_TopDownShooter
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            btn_Sound.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Shooter.wplayer.controls.play();
            btn_Sound.Image = Properties.Resources.sound_on;
            Shooter.wplayer.settings.volume = trackBar1.Value;

            if (trackBar1.Value == 0)
            {
                btn_Sound.Image = Properties.Resources.sound_off;
            }

        }

        private void btn_Sound_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {


            // MessageBox.Show("Welcome to the game! Have fun and good luck.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
              "Controls:\n" +
              "Move Up: Up Arrow\n" +
              "Move Down: Down Arrow\n" +
              "Move Left: Left Arrow\n" +
              "Move Right: Right Arrow\n" +
              "Shoot: Space or Ctrl\n",
              "Help",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information
          );
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Close the current form (Form2)
            this.Close();
            this.Dispose(); // Optionally dispose to release resources

            // Show the main menu form (Form3)
            Shooter mainMenu = new Shooter();
            mainMenu.Show();
        }
    }
}
