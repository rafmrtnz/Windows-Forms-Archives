namespace Martinez_VoiceRecognition
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnEnable = new System.Windows.Forms.Button();
			this.btnDisable = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
			this.richTextBox1.Location = new System.Drawing.Point(13, 27);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(427, 456);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// btnEnable
			// 
			this.btnEnable.BackColor = System.Drawing.Color.Lime;
			this.btnEnable.Location = new System.Drawing.Point(13, 489);
			this.btnEnable.Name = "btnEnable";
			this.btnEnable.Size = new System.Drawing.Size(211, 23);
			this.btnEnable.TabIndex = 1;
			this.btnEnable.Text = "ENABLE VOICE CONTROL";
			this.btnEnable.UseVisualStyleBackColor = false;
			this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
			// 
			// btnDisable
			// 
			this.btnDisable.BackColor = System.Drawing.Color.Red;
			this.btnDisable.Location = new System.Drawing.Point(230, 489);
			this.btnDisable.Name = "btnDisable";
			this.btnDisable.Size = new System.Drawing.Size(210, 23);
			this.btnDisable.TabIndex = 1;
			this.btnDisable.Text = "DISABLE VOICE CONTROL";
			this.btnDisable.UseVisualStyleBackColor = false;
			this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(93, 529);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(249, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "VOICE CONTROL OFF";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Record Command";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 580);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDisable);
			this.Controls.Add(this.btnEnable);
			this.Controls.Add(this.richTextBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnEnable;
		private System.Windows.Forms.Button btnDisable;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

