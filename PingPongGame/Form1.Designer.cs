namespace PingPongGame
{
    partial class gameForm
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
            this.playGround = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.gameOverScreen = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.ballImage = new System.Windows.Forms.PictureBox();
            this.paddleImage = new System.Windows.Forms.PictureBox();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.playGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ballImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // playGround
            // 
            this.playGround.Controls.Add(this.button1);
            this.playGround.Controls.Add(this.gameOverScreen);
            this.playGround.Controls.Add(this.pointsLabel);
            this.playGround.Controls.Add(this.scoreLabel);
            this.playGround.Controls.Add(this.ballImage);
            this.playGround.Controls.Add(this.paddleImage);
            this.playGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playGround.Location = new System.Drawing.Point(0, 0);
            this.playGround.Name = "playGround";
            this.playGround.Size = new System.Drawing.Size(800, 450);
            this.playGround.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(284, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 193);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click here to start!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameOverScreen
            // 
            this.gameOverScreen.BackColor = System.Drawing.Color.SlateBlue;
            this.gameOverScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.gameOverScreen.Location = new System.Drawing.Point(280, 126);
            this.gameOverScreen.Name = "gameOverScreen";
            this.gameOverScreen.Size = new System.Drawing.Size(225, 193);
            this.gameOverScreen.TabIndex = 4;
            this.gameOverScreen.Text = "Game Over\r\n\r\nF1 - Restart\r\nESC - Exit\r\n";
            this.gameOverScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pointsLabel.Location = new System.Drawing.Point(725, 9);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(18, 20);
            this.pointsLabel.TabIndex = 3;
            this.pointsLabel.Text = "0";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.scoreLabel.Location = new System.Drawing.Point(654, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(53, 20);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score";
            // 
            // ballImage
            // 
            this.ballImage.BackColor = System.Drawing.Color.DarkRed;
            this.ballImage.Location = new System.Drawing.Point(383, 61);
            this.ballImage.Name = "ballImage";
            this.ballImage.Size = new System.Drawing.Size(30, 30);
            this.ballImage.TabIndex = 1;
            this.ballImage.TabStop = false;
            // 
            // paddleImage
            // 
            this.paddleImage.BackColor = System.Drawing.Color.Black;
            this.paddleImage.Location = new System.Drawing.Point(284, 418);
            this.paddleImage.Name = "paddleImage";
            this.paddleImage.Size = new System.Drawing.Size(200, 20);
            this.paddleImage.TabIndex = 0;
            this.paddleImage.TabStop = false;
            // 
            // gameTime
            // 
            this.gameTime.Interval = 2;
            this.gameTime.Tick += new System.EventHandler(this.gameTime_Tick);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playGround);
            this.Name = "gameForm";
            this.Text = "Ping Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            this.playGround.ResumeLayout(false);
            this.playGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ballImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playGround;
        private System.Windows.Forms.PictureBox ballImage;
        private System.Windows.Forms.PictureBox paddleImage;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label gameOverScreen;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Button button1;
    }
}

