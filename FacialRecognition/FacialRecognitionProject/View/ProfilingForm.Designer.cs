namespace FacialRecognitionProject
{
	partial class ProfilingForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.FirstNameField = new System.Windows.Forms.TextBox();
			this.LastNameField = new System.Windows.Forms.TextBox();
			this.AgeField = new System.Windows.Forms.TextBox();
			this.GenderField = new System.Windows.Forms.TextBox();
			this.saveBtn = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.DetectFace = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(490, 500);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(509, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "First Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(509, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Last Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(509, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Age";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(509, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Gender";
			// 
			// FirstNameField
			// 
			this.FirstNameField.Location = new System.Drawing.Point(572, 22);
			this.FirstNameField.Name = "FirstNameField";
			this.FirstNameField.Size = new System.Drawing.Size(181, 20);
			this.FirstNameField.TabIndex = 1;
			// 
			// LastNameField
			// 
			this.LastNameField.Location = new System.Drawing.Point(572, 48);
			this.LastNameField.Name = "LastNameField";
			this.LastNameField.Size = new System.Drawing.Size(181, 20);
			this.LastNameField.TabIndex = 2;
			// 
			// AgeField
			// 
			this.AgeField.Location = new System.Drawing.Point(572, 74);
			this.AgeField.Name = "AgeField";
			this.AgeField.Size = new System.Drawing.Size(181, 20);
			this.AgeField.TabIndex = 3;
			// 
			// GenderField
			// 
			this.GenderField.Location = new System.Drawing.Point(572, 100);
			this.GenderField.Name = "GenderField";
			this.GenderField.Size = new System.Drawing.Size(181, 20);
			this.GenderField.TabIndex = 4;
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(572, 157);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(181, 25);
			this.saveBtn.TabIndex = 6;
			this.saveBtn.Text = "Save";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// DetectFace
			// 
			this.DetectFace.Location = new System.Drawing.Point(572, 126);
			this.DetectFace.Name = "DetectFace";
			this.DetectFace.Size = new System.Drawing.Size(181, 25);
			this.DetectFace.TabIndex = 5;
			this.DetectFace.Text = "Detect Face";
			this.DetectFace.UseVisualStyleBackColor = true;
			this.DetectFace.Click += new System.EventHandler(this.DetectFaceBtn_Click);
			// 
			// ProfilingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 524);
			this.Controls.Add(this.DetectFace);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.GenderField);
			this.Controls.Add(this.AgeField);
			this.Controls.Add(this.LastNameField);
			this.Controls.Add(this.FirstNameField);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ProfilingForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox FirstNameField;
		private System.Windows.Forms.TextBox LastNameField;
		private System.Windows.Forms.TextBox AgeField;
		private System.Windows.Forms.TextBox GenderField;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button DetectFace;
	}
}

