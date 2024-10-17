
namespace Martinez_FlappyBird
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
			this.scoreText = new System.Windows.Forms.Label();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.ground = new System.Windows.Forms.PictureBox();
			this.flappyBird = new System.Windows.Forms.PictureBox();
			this.pipeBottom = new System.Windows.Forms.PictureBox();
			this.pipeTop = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
			this.SuspendLayout();
			// 
			// scoreText
			// 
			this.scoreText.AutoSize = true;
			this.scoreText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreText.Location = new System.Drawing.Point(12, 674);
			this.scoreText.Name = "scoreText";
			this.scoreText.Size = new System.Drawing.Size(94, 24);
			this.scoreText.TabIndex = 2;
			this.scoreText.Text = "Score: 0";
			// 
			// gameTimer
			// 
			this.gameTimer.Enabled = true;
			this.gameTimer.Interval = 20;
			this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
			// 
			// ground
			// 
			this.ground.Image = global::Martinez_FlappyBird.Properties.Resources.ground;
			this.ground.Location = new System.Drawing.Point(-12, 645);
			this.ground.Name = "ground";
			this.ground.Size = new System.Drawing.Size(641, 115);
			this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ground.TabIndex = 0;
			this.ground.TabStop = false;
			// 
			// flappyBird
			// 
			this.flappyBird.Image = global::Martinez_FlappyBird.Properties.Resources.Untitled__80_x_60_px_;
			this.flappyBird.Location = new System.Drawing.Point(97, 275);
			this.flappyBird.Name = "flappyBird";
			this.flappyBird.Size = new System.Drawing.Size(73, 52);
			this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.flappyBird.TabIndex = 1;
			this.flappyBird.TabStop = false;
			// 
			// pipeBottom
			// 
			this.pipeBottom.Image = global::Martinez_FlappyBird.Properties.Resources.pipe;
			this.pipeBottom.Location = new System.Drawing.Point(406, 420);
			this.pipeBottom.Name = "pipeBottom";
			this.pipeBottom.Size = new System.Drawing.Size(100, 234);
			this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pipeBottom.TabIndex = 1;
			this.pipeBottom.TabStop = false;
			// 
			// pipeTop
			// 
			this.pipeTop.Image = global::Martinez_FlappyBird.Properties.Resources.pipedown;
			this.pipeTop.Location = new System.Drawing.Point(510, -8);
			this.pipeTop.Name = "pipeTop";
			this.pipeTop.Size = new System.Drawing.Size(100, 192);
			this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pipeTop.TabIndex = 1;
			this.pipeTop.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aqua;
			this.ClientSize = new System.Drawing.Size(622, 707);
			this.Controls.Add(this.scoreText);
			this.Controls.Add(this.ground);
			this.Controls.Add(this.flappyBird);
			this.Controls.Add(this.pipeBottom);
			this.Controls.Add(this.pipeTop);
			this.Name = "Form1";
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
			((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox ground;
		private System.Windows.Forms.PictureBox pipeTop;
		private System.Windows.Forms.PictureBox pipeBottom;
		private System.Windows.Forms.Label scoreText;
		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.PictureBox flappyBird;
	}
}

