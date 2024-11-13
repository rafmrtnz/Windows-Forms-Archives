
namespace Martinez_FaceDetectionAndRecognition
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
			this.textName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.start = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.cameraBox = new Emgu.CV.UI.ImageBox();
			((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
			this.SuspendLayout();
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(629, 33);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(159, 20);
			this.textName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(569, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Full Name";
			// 
			// start
			// 
			this.start.Location = new System.Drawing.Point(572, 76);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(216, 23);
			this.start.TabIndex = 3;
			this.start.Text = "Capture";
			this.start.UseVisualStyleBackColor = true;
			this.start.Click += new System.EventHandler(this.start_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(572, 105);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(216, 23);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// cameraBox
			// 
			this.cameraBox.Location = new System.Drawing.Point(12, 12);
			this.cameraBox.Name = "cameraBox";
			this.cameraBox.Size = new System.Drawing.Size(551, 426);
			this.cameraBox.TabIndex = 2;
			this.cameraBox.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cameraBox);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.start);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textName);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button start;
		private System.Windows.Forms.Button saveButton;
		private Emgu.CV.UI.ImageBox cameraBox;
	}
}

