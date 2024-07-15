namespace Fin_TopDownShooter
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.MUSIC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sound = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(286, 232);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(790, 69);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // MUSIC
            // 
            this.MUSIC.AutoSize = true;
            this.MUSIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUSIC.Location = new System.Drawing.Point(117, 232);
            this.MUSIC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MUSIC.Name = "MUSIC";
            this.MUSIC.Size = new System.Drawing.Size(123, 37);
            this.MUSIC.TabIndex = 2;
            this.MUSIC.Text = "MUSIC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(972, 623);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Help";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Sound
            // 
            this.btn_Sound.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sound.BackgroundImage = global::Fin_TopDownShooter.Properties.Resources.sound_on;
            this.btn_Sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sound.Location = new System.Drawing.Point(3, 658);
            this.btn_Sound.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sound.Name = "btn_Sound";
            this.btn_Sound.Size = new System.Drawing.Size(20, 20);
            this.btn_Sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_Sound.TabIndex = 1;
            this.btn_Sound.TabStop = false;
            this.btn_Sound.Click += new System.EventHandler(this.btn_Sound_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(32, 605);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(299, 55);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back to Main Menu";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fin_TopDownShooter.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MUSIC);
            this.Controls.Add(this.btn_Sound);
            this.Controls.Add(this.trackBar1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label MUSIC;
        private System.Windows.Forms.PictureBox btn_Sound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back;
    }
}