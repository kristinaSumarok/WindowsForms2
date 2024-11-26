using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_13
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        
        private int ballSpeedX;
        private int ballSpeedY;

        private int ballSpeed;
        private int ballX;
        private int ballY;
        private int rectangleX;
        private int rectangleY;
        private int bonusBallX;
        private int bonusBallY;

        private int bonusBalldiameter = 30;
        private int ballDiameter = 30;
        private int rectangleWidth = 50;
        private Rectangle rectangle;
        private Rectangle ball;
        private Rectangle bonusBall;
        private int lives = 3;

        private bool isCollision;
        private bool isBonusBallVisible;
        private bool isBonusBallCought;

        private int score;
        private int bonusCought;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            CreateGraphicsProperties();

            Brush brush = new SolidBrush(Color.DarkRed);
            Brush brush2 = new SolidBrush(Color.Black);


            e.Graphics.FillEllipse(brush, ball);
            e.Graphics.FillRectangle(brush2, rectangle);

            if (isBonusBallVisible)
            {
                Brush brush3 = new SolidBrush(Color.Green);
                e.Graphics.FillEllipse(brush3, bonusBall);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateGraphicsLocation();
        }

        private void timer_ball_Tick(object sender, EventArgs e)
        {
            label_lives.Text = "Lives: " + lives;

            ChangeBallCoordinates();

            if (lives == 0)
            {
                EndGame();
            }

            if (rectangle.IntersectsWith(bonusBall)&& !isBonusBallCought)
            {
                score += 1000;
                bonusCought++;
                isBonusBallCought = true;
                if (bonusCought % 5 == 0)
                {
                    lives++;
                }
            }

            Refresh();
        }

        private void ChangeBallCoordinates()
        {
            ballX += ballSpeedX;
            ballY += ballSpeedY;

            if (ballX <= 0 || ballX >= pictureBox1.Width - ballDiameter)
            {
                ballSpeedX =-ballSpeedX;
            }
            else if (ballY >= pictureBox1.Height - ballDiameter|| ballY <=0)
            {
                ballSpeedY = -ballSpeedY;
            }

            if (!isCollision && rectangle.IntersectsWith(ball))
            {
                lives--;
                isCollision = true;
            }
            else if(!rectangle.IntersectsWith(ball))
            {
                isCollision = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && rectangleY > 0)
            {
                rectangleY -= 5;
            }

            if (e.KeyCode == Keys.Down && rectangleY < pictureBox1.Height - rectangleWidth)
            {
                rectangleY += 5;
            }

            if (e.KeyCode == Keys.Left && rectangleX > 0)
            {
                rectangleX -= 5;
            }

            if (e.KeyCode == Keys.Right && rectangleX < pictureBox1.Width - rectangleWidth)
            {
                rectangleX += 5;
            }

        }

        private void CreateGraphicsProperties()
        {
            ball = new Rectangle(ballX, ballY, ballDiameter, ballDiameter);
            rectangle = new Rectangle(rectangleX, rectangleY, rectangleWidth, rectangleWidth);
            bonusBall = new Rectangle(bonusBallX, bonusBallY, bonusBalldiameter, bonusBalldiameter);
        }

        private void CreateGraphicsLocation()
        {

            ballX = rand.Next(0, pictureBox1.Width - ballDiameter);
            ballY = rand.Next(0, pictureBox1.Height - ballDiameter);

            rectangleX = rand.Next(0, pictureBox1.Width - rectangleWidth);
            rectangleY = rand.Next(0, pictureBox1.Height - rectangleWidth);

            bonusBallX = rand.Next(0, pictureBox1.Width - bonusBalldiameter);
            bonusBallY = rand.Next(0, pictureBox1.Height - bonusBalldiameter);

        }

        private void timer_bonusBall_Tick(object sender, EventArgs e)
        {
            isBonusBallVisible = !isBonusBallVisible;

            if (isBonusBallVisible)
            {
                bonusBallX = rand.Next(0, pictureBox1.Width - bonusBalldiameter);
                bonusBallY = rand.Next(0, pictureBox1.Height - bonusBalldiameter);
                isBonusBallCought = false;
            }

            pictureBox1.Invalidate();
        }

        private void button_start_Click(object sender, EventArgs e)
        {

            bool isSizeValid = int.TryParse(textBox_ballSize.Text, out int parsedSize);
            bool isSpeedValid = int.TryParse(textBox_ballSpeed.Text, out int parsedSpeed);

            if (isSizeValid && isSpeedValid&& parsedSize <=150 && parsedSpeed<=5 && parsedSize>0 && parsedSpeed>0)
            {
                ballDiameter = parsedSize;
                ballSpeedX = parsedSpeed; 
                ballSpeedY = parsedSpeed;
                ballSpeed = parsedSpeed;
            }
            else
            {
                MessageBox.Show("Invalid size or speed");
                return;
            }

            Refresh();
            while (ball.IntersectsWith(rectangle))
            {
                ballX = rand.Next(0, pictureBox1.Width - ballDiameter);
                ballY = rand.Next(0, pictureBox1.Height - ballDiameter);
                Refresh();
            }

            textBox_ballSize.Enabled = false;
            textBox_ballSpeed.Enabled = false;
            button_start.Enabled = false;

            timer_ball.Start();
            timer_bonusBall.Start();
            timer_score.Start();
        }

        private void timer_score_Tick(object sender, EventArgs e)
        { 
            score += (ballSpeed *10) + ballDiameter;
            label_score.Text = "Score: " + score;
        }

        private void EndGame()
        {
            label_gameOver.Visible = true;
            timer_ball.Stop();
            timer_bonusBall.Stop();
            timer_score.Stop();
            label_myScore.Text = "Your score: \n"+ score;

            List<int> scores = new List<int>();

            if (File.Exists("Scores.txt"))
            {
                using (StreamReader reader = new StreamReader("Scores.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (int.TryParse(line, out int score))
                        {
                            scores.Add(score);
                        }
                    }
                }
            }

            scores.Add(score);
            scores.Sort((a, b) => b.CompareTo(a));
            label_maxScores.Text = "Top scores are:\n";

            using (StreamWriter writer = new StreamWriter("Scores.txt"))
            {
                for (int i = 0; i < Math.Min(scores.Count, 3); i++)
                {
                    writer.WriteLine(scores[i]);
                    label_maxScores.Text += ((i+1) +". " + scores[i] +"\n");
                }
            }
        }
    }
}
