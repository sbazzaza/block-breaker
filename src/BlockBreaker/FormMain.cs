using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlockBreaker
{
    public partial class FormMain : Form
    {
        public static Graphics g;
        Game newGame;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            newGame = new Game(menuStrip1.Height);
            g = Graphics.FromHwnd(this.Handle);
            
            this.Width = Game.width + 17;
            this.Height = Game.height + 30 ;

            timer1.Enabled = true;
            timer1.Interval = 15;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            newGame.Draw();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!newGame.GameOver)
            {
                newGame.Move();
                Application.DoEvents();
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch ((char)e.KeyData)
            {
                case(char)Keys.Right :
                    newGame.RightKey();
                    break;
                case (char)Keys.Left:
                    newGame.LefttKey();
                    break;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame = new Game(menuStrip1.Height);
            newGame.Draw();
            newGame.GameOver = false;
        }

        private void pauseResumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
                timer1.Enabled = false;
            else
                timer1.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        


    }
}
