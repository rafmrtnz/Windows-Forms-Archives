using System;
using System.Windows.Forms;

namespace Martinez_FlappyBird
{
	public partial class Form1 : Form
	{
		int pipeSpeed = 8;
		int gravity = 5;
		int score = 0;
		int previousScore = 0;
		int highestScore = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void gameTimerEvent(object sender, EventArgs e)
		{
			flappyBird.Top += gravity;
			pipeBottom.Left -= pipeSpeed;
			pipeTop.Left -= pipeSpeed;
			scoreText.Text = $"Score {score}";

			if (pipeBottom.Left < -150)
			{
				pipeBottom.Left = 800;
				score++;
			}
			if (pipeTop.Left < -180)
			{
				pipeTop.Left = 950;
				score++;
			}


			if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
				flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
				flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
				flappyBird.Top < -25)
				endGame();

			if (score > 5)
				pipeSpeed = 15;
		}

		private void gamekeyisdown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
				gravity = -15;
		}

		private void gamekeyisup(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				gravity = 15;

				if (!gameTimer.Enabled)
				{
					NewGame();
				}
			}
		}

		private void endGame()
		{
			gameTimer.Stop();
			
			if (score > highestScore)
				highestScore = score;
			
			scoreText.Text += " Game Over! Press space bar to play again.";
		}

		private void NewGame()
		{
			prevScore.Text = $"Highest Score: {highestScore}";
			prevScore.Visible = true;

			flappyBird.Top = 100;
			pipeBottom.Left = 800;
			pipeTop.Left = 950;
			score = 0;
			pipeSpeed = 8;
			gravity = 5;
			scoreText.Text = "Score: 0";

			gameTimer.Start();
		}
	}
}
