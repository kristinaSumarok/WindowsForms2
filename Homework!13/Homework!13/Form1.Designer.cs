namespace Homework_13
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_ball = new System.Windows.Forms.Timer(this.components);
            this.timer_bonusBall = new System.Windows.Forms.Timer(this.components);
            this.label_ballSize = new System.Windows.Forms.Label();
            this.label_ballSpeed = new System.Windows.Forms.Label();
            this.textBox_ballSize = new System.Windows.Forms.TextBox();
            this.textBox_ballSpeed = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label_gameOver = new System.Windows.Forms.Label();
            this.label_lives = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.timer_score = new System.Windows.Forms.Timer(this.components);
            this.label_maxScores = new System.Windows.Forms.Label();
            this.label_myScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 531);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer_ball
            // 
            this.timer_ball.Interval = 1;
            this.timer_ball.Tick += new System.EventHandler(this.timer_ball_Tick);
            // 
            // timer_bonusBall
            // 
            this.timer_bonusBall.Interval = 3000;
            this.timer_bonusBall.Tick += new System.EventHandler(this.timer_bonusBall_Tick);
            // 
            // label_ballSize
            // 
            this.label_ballSize.AutoSize = true;
            this.label_ballSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ballSize.Location = new System.Drawing.Point(804, 24);
            this.label_ballSize.Name = "label_ballSize";
            this.label_ballSize.Size = new System.Drawing.Size(178, 25);
            this.label_ballSize.TabIndex = 1;
            this.label_ballSize.Text = "Ball size (1-150):";
            // 
            // label_ballSpeed
            // 
            this.label_ballSpeed.AutoSize = true;
            this.label_ballSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ballSpeed.Location = new System.Drawing.Point(804, 155);
            this.label_ballSpeed.Name = "label_ballSpeed";
            this.label_ballSpeed.Size = new System.Drawing.Size(178, 25);
            this.label_ballSpeed.TabIndex = 2;
            this.label_ballSpeed.Text = "Ball Speed (1-5):";
            // 
            // textBox_ballSize
            // 
            this.textBox_ballSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ballSize.Location = new System.Drawing.Point(809, 69);
            this.textBox_ballSize.Name = "textBox_ballSize";
            this.textBox_ballSize.Size = new System.Drawing.Size(136, 30);
            this.textBox_ballSize.TabIndex = 3;
            this.textBox_ballSize.Text = "35";
            // 
            // textBox_ballSpeed
            // 
            this.textBox_ballSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ballSpeed.Location = new System.Drawing.Point(809, 198);
            this.textBox_ballSpeed.Name = "textBox_ballSpeed";
            this.textBox_ballSpeed.Size = new System.Drawing.Size(136, 30);
            this.textBox_ballSpeed.TabIndex = 4;
            this.textBox_ballSpeed.Text = "3";
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.OrangeRed;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(820, 277);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(125, 40);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_gameOver
            // 
            this.label_gameOver.AutoSize = true;
            this.label_gameOver.BackColor = System.Drawing.Color.Red;
            this.label_gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gameOver.Location = new System.Drawing.Point(206, 237);
            this.label_gameOver.Name = "label_gameOver";
            this.label_gameOver.Size = new System.Drawing.Size(352, 69);
            this.label_gameOver.TabIndex = 6;
            this.label_gameOver.Text = "Game over!";
            this.label_gameOver.Visible = false;
            // 
            // label_lives
            // 
            this.label_lives.AutoSize = true;
            this.label_lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lives.Location = new System.Drawing.Point(65, 556);
            this.label_lives.Name = "label_lives";
            this.label_lives.Size = new System.Drawing.Size(88, 25);
            this.label_lives.TabIndex = 7;
            this.label_lives.Text = "Lives: 3";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(264, 556);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(76, 25);
            this.label_score.TabIndex = 8;
            this.label_score.Text = "Score:";
            // 
            // timer_score
            // 
            this.timer_score.Interval = 1000;
            this.timer_score.Tick += new System.EventHandler(this.timer_score_Tick);
            // 
            // label_maxScores
            // 
            this.label_maxScores.AutoSize = true;
            this.label_maxScores.BackColor = System.Drawing.Color.LightSalmon;
            this.label_maxScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maxScores.Location = new System.Drawing.Point(39, 337);
            this.label_maxScores.Name = "label_maxScores";
            this.label_maxScores.Size = new System.Drawing.Size(0, 42);
            this.label_maxScores.TabIndex = 9;
            // 
            // label_myScore
            // 
            this.label_myScore.AutoSize = true;
            this.label_myScore.BackColor = System.Drawing.Color.LightSalmon;
            this.label_myScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_myScore.Location = new System.Drawing.Point(517, 337);
            this.label_myScore.Name = "label_myScore";
            this.label_myScore.Size = new System.Drawing.Size(0, 42);
            this.label_myScore.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 596);
            this.Controls.Add(this.label_myScore);
            this.Controls.Add(this.label_maxScores);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_lives);
            this.Controls.Add(this.label_gameOver);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_ballSpeed);
            this.Controls.Add(this.textBox_ballSize);
            this.Controls.Add(this.label_ballSpeed);
            this.Controls.Add(this.label_ballSize);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_ball;
        private System.Windows.Forms.Timer timer_bonusBall;
        private System.Windows.Forms.Label label_ballSize;
        private System.Windows.Forms.Label label_ballSpeed;
        private System.Windows.Forms.TextBox textBox_ballSize;
        private System.Windows.Forms.TextBox textBox_ballSpeed;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_gameOver;
        private System.Windows.Forms.Label label_lives;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Timer timer_score;
        private System.Windows.Forms.Label label_maxScores;
        private System.Windows.Forms.Label label_myScore;
    }
}

