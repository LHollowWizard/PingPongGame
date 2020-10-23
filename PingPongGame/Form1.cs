using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class gameForm : Form
    {

        public int speed_left = 5;
        public int speed_top = 5;
        public int points = 0;
        public bool gameStart = true;
        public bool gameOver = false;

        public gameForm()
        {
            InitializeComponent();

            //Takes out the border from the form
            this.FormBorderStyle = FormBorderStyle.None;

            //Makes it the front app all the time
            //this.TopMost = true;

            //Makes the game screen the size of the respective computer screen
            //this.Bounds = Screen.PrimaryScreen.Bounds;

            //Sets the right position for the game over screen, start button and paddle based on the size of the screen
            paddleImage.Top = playGround.Bottom - (playGround.Bottom / 10);
            button1.Left = (playGround.Width / 2) - (button1.Width / 2);
            button1.Top = (playGround.Height / 2) - (button1.Height / 2);
            gameOverScreen.Left = (playGround.Width / 2) - (gameOverScreen.Width / 2);
            gameOverScreen.Top = (playGround.Height/ 2) - (gameOverScreen.Height/ 2);

            //Hides game over screen
            gameOverScreen.Visible = false;

        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
            //Moves the paddle according to the mouse position
            paddleImage.Left = Cursor.Position.X - (paddleImage.Width / 2);

            //Moves the ball based on the speed it is going
            ballImage.Left += speed_left;
            ballImage.Top += speed_top;

            //Check for collisions with the paddle, then with all the four walls
            //Hitting something changes the ball direction
            bool ballCollideWithPaddleX = ballImage.Bottom >= paddleImage.Top && ballImage.Bottom <= paddleImage.Bottom;
            bool ballCollideWithPaddleY = ballImage.Left >= paddleImage.Left && ballImage.Right <= paddleImage.Right;
            bool ballCollideWithPaddle = ballCollideWithPaddleX && ballCollideWithPaddleY;
            if (ballCollideWithPaddle)
            {

                speed_top *= -1;

                points += 100;
                pointsLabel.Text = points.ToString();

                //Changes the background color randomly in order to add variety
                Random r = new Random();
                playGround.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
            }
            else if (ballImage.Left <= playGround.Left)
            {
                speed_left *= -1;
            }
            else if (ballImage.Right >= playGround.Right)
            {
                speed_left *= -1;
            }
            else if (ballImage.Top <= playGround.Top)
            {
                speed_top *= -1;
            }
            else if (ballImage.Bottom >= playGround.Bottom)
            {
                //When the game is over the game over screen appears, the game time stop ticking and gameOver is set to true to enable
                //The payer to restart
                gameTime.Enabled = false;
                gameOverScreen.Visible = true;
                gameOver = true;
            }
        }

        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Can only enter here after the game is, indeed, over
            if(gameOver) { 
                //If ESC is pressed, the form game closes
                if (e.KeyCode == Keys.Escape) this.Close();

                //If F1 is pressed the ball, speed, points and background are reset
                if (e.KeyCode == Keys.F1)
                {
                    ballImage.Top = 50;
                    ballImage.Left = 50;
                    speed_left = 4;
                    speed_top = 4;
                    pointsLabel.Text = "0";
                    points = 0;
                    gameOverScreen.Visible = false;
                    button1.Visible = true;
                    gameStart = true;
                    Cursor.Show();
                    playGround.BackColor = Color.White;
                    gameOver = false;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gameStart)
            {
                //Just what happens after clicking the button to start the game
                gameTime.Enabled = true;
                button1.Visible = false;
                Cursor.Hide();
                gameStart = false;
            }
        }
    }
}
