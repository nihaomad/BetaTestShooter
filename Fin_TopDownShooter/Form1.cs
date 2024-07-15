using AxWMPLib;
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
    public partial class Shooter : Form
    {
        public Shooter()
        {
            InitializeComponent();
            wplayer.URL = (@"C:\Users\63929\source\repos\Fin_TopDownShooter\Fin_TopDownShooter\Resources\terror-ambience-7003.mp3");
            wplayer.controls.play();
            axWindowsMediaPlayer1.Hide();

        }

        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void Play_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            form = null; 
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show a confirmation message box with a question icon
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the result
            if (result == DialogResult.Yes)
            {
                // Close the application
                Application.Exit();
            }
        
    }

        private void Shooter_Load(object sender, EventArgs e)
        {

        }

        private void Shooter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
