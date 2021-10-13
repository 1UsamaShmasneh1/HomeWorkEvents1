using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question4._1
{
    public partial class Form1 : Form
    {
        private Dote dote = new Dote();
        Square square= new Square();
        int maxWigth;
        int maxHeight;
        bool goLeft, goRight, goDown, goUp;
        public Form1()
        {
            InitializeComponent();
            new Settings();
            dote.OutchEvent += TouchedHandeler;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {

        }

        private void TimerEvent(object sender, EventArgs e)
        {
            if (goLeft)
            {
                dote.X--;
            }
            if (goRight)
            {
                dote.X++;
            }
            if (goDown)
            {
                dote.Y++;
            }
            if (goUp)
            {
                dote.Y--;
            }
            if (dote.X < 0)
            {
                dote.X = maxWigth;
            }
            if (dote.X > maxWigth)
            {
                dote.X = 0;
            }
            if (dote.Y < 0)
            {
                dote.Y = maxHeight;
            }
            if (dote.Y > maxHeight)
            {
                dote.Y = 0;
            }
            if (dote.X == square.X && dote.Y == square.Y)
            {
                GameOver();
            }                
            PictureBox.Invalidate();
        }

        private void UpdatePB(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush doteColour = Brushes.Black;
            Brush squareColour = Brushes.Red;
            canvas.FillEllipse(doteColour, new Rectangle
                (
                dote.X * Settings.Width,
                dote.Y * Settings.Height, 
                Settings.Width, Settings.Height
                ));
            canvas.FillEllipse(squareColour, new Rectangle
                (
                square.X * Settings.Width,
                square.Y * Settings.Height,
                Settings.Width, Settings.Height
                ));
        }
        private void Restart()
        {
            maxWigth = PictureBox.Width / Settings.Width - 1;
            maxHeight = PictureBox.Height / Settings.Height - 1;

            dote = new Dote();
            square= new Square();
            StartButton.Enabled = false;
            StopButton.Enabled = false;
            Timer.Start();
        }
        private void TouchedHandeler()
        {
            StatusLabel.Text = "Outch";
        }
        private void GameOver()
        {
            dote.OnOutch();
            Timer.Stop();
            StartButton.Enabled = true;
            StopButton.Enabled = true;
        }
    }
}
