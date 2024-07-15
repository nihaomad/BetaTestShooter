using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Fin_TopDownShooter
{
    public partial class Form2 : Form
    {
        bool goup;
        bool godown;
        bool goleft;
        bool goright;
        string facing = "up";
        double playerHealth;
        int speed = 10;
        int ammo;
        int zombieSpeed = 3;
        int score;
        bool gameOver;
        
        Random rnd = new Random();
        private WindowsMediaPlayer gunshotSound = new WindowsMediaPlayer();
        private WindowsMediaPlayer reloadingSound = new WindowsMediaPlayer();

       
        public Form2()
        {
            InitializeComponent();
            gunshotSound.URL = @"C:\Users\63929\source\repos\Fin_TopDownShooter\Fin_TopDownShooter\gun-shot-1-176892.mp3";
            reloadingSound.URL = @"C:\Users\63929\source\repos\Fin_TopDownShooter\Fin_TopDownShooter\load-gun-sound-effect-5-11003.mp3";

            RestartGame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (gameOver) return;
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                facing = "up";
                goup = true;
                player.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.Down)
            {
                facing = "down";
                godown = true;
                player.Image = Properties.Resources.down;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0)
            {
                ammo--;
                shoot(facing);
                gunshotSound.controls.play();
                if (ammo < 1)
                {
                    DropAmmo();
                }
            }
        }

        private void gameEngine(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                progressBar1.Value = Convert.ToInt32(playerHealth);
            }
            else
            {
                player.Image = Properties.Resources.dead;
                timer1.Stop();
                gameOver = true;
                restartimage.Enabled = true;
                restartimage.Visible = true;
            }

            label1.Text = "   Ammo:  " + ammo;
            label2.Text = "Kills: " + score;

            if (playerHealth < 20)
            {
                progressBar1.ForeColor = System.Drawing.Color.Red;
            }

            if (goleft && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goright && player.Left + player.Width < 930)
            {
                player.Left += speed;
            }
            if (goup && player.Top > 60)
            {
                player.Top -= speed;
            }
            if (godown && player.Top + player.Height < 700)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "ammo")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }
                if (x is PictureBox && x.Tag == "bullet")
                {
                    if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 930 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 700)
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                    }
                }
                if (x is PictureBox && x.Tag == "zombie")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        playerHealth -= 1;
                        player.BringToFront();
                    }
                    if (((PictureBox)x).Left > player.Left)
                    {
                        ((PictureBox)x).Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (((PictureBox)x).Top > player.Top)
                    {
                        ((PictureBox)x).Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (((PictureBox)x).Left < player.Left)
                    {
                        ((PictureBox)x).Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (((PictureBox)x).Top < player.Top)
                    {
                        ((PictureBox)x).Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }
                foreach (Control j in this.Controls)
                {
                    if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "zombie"))
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            this.Controls.Remove(j);
                            j.Dispose();
                            this.Controls.Remove(x);
                            x.Dispose();
                            makeZombies();
                        }
                    }
                }
            }
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = rnd.Next(10, 890);
            ammo.Top = rnd.Next(50, 600);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();
            reloadingSound.controls.play();
        }

        private void shoot(string direct)
        {
            bullet shoot = new bullet();
            shoot.direction = direct;
            shoot.bulletLeft = player.Left + (player.Width / 2);
            shoot.bulletTop = player.Top + (player.Height / 2);
            shoot.mkBullet(this);
        }

        private void makeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = rnd.Next(0, 900);
            zombie.Top = rnd.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(zombie);
            player.BringToFront();
        }

        private void RestartClickEvent(object sender, EventArgs e)
        {
            
            
            
            RestartGame();
            restartimage.Enabled = false;
            restartimage.Visible = false;
        }

        private void RestartGame()
        {
            gameOver = false;
            score = 0;
            playerHealth = 100;
            ammo = 10;

            // Reset player position and image
            player.Left = this.ClientSize.Width / 2;
            player.Top = this.ClientSize.Height / 2;
            player.Image = Properties.Resources.up;

            // Reset existing zombies to a new random position
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "zombie")
                {
                    x.Left = rnd.Next(0, 900);
                    x.Top = rnd.Next(0, 800);
                }
            }

            // Remove all existing bullets
            var bullets = this.Controls.OfType<PictureBox>().Where(b => b.Tag == "bullet").ToList();
            foreach (var bullet in bullets)
            {
                this.Controls.Remove(bullet);
                bullet.Dispose();
            }

            // Reset labels and progress bar
            progressBar1.Value = Convert.ToInt32(playerHealth);
            label1.Text = "   Ammo:  " + ammo;
            label2.Text = "Kills: " + score;
            progressBar1.ForeColor = System.Drawing.Color.Green; // Reset progress bar color

            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("haup ka")
        }


       


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
