namespace Martinez_CSLargest
{
	partial class LargestValueIdentifier
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			TxtFValue = new TextBox();
			TxtSvalue = new TextBox();
			TxtTvalue = new TextBox();
			LblFirstValue = new Label();
			LblSecondValue = new Label();
			LblThirdValue = new Label();
			BtnIdentify = new Button();
			SuspendLayout();
			// 
			// TxtFValue
			// 
			TxtFValue.Location = new Point(95, 36);
			TxtFValue.Name = "TxtFValue";
			TxtFValue.Size = new Size(135, 23);
			TxtFValue.TabIndex = 0;
			TxtFValue.TextAlign = HorizontalAlignment.Right;
			// 
			// TxtSvalue
			// 
			TxtSvalue.Location = new Point(95, 76);
			TxtSvalue.Name = "TxtSvalue";
			TxtSvalue.Size = new Size(135, 23);
			TxtSvalue.TabIndex = 1;
			TxtSvalue.TextAlign = HorizontalAlignment.Right;
			// 
			// TxtTvalue
			// 
			TxtTvalue.Location = new Point(95, 121);
			TxtTvalue.Name = "TxtTvalue";
			TxtTvalue.Size = new Size(135, 23);
			TxtTvalue.TabIndex = 2;
			TxtTvalue.TextAlign = HorizontalAlignment.Right;
			// 
			// LblFirstValue
			// 
			LblFirstValue.AutoSize = true;
			LblFirstValue.Location = new Point(12, 39);
			LblFirstValue.Name = "LblFirstValue";
			LblFirstValue.Size = new Size(60, 15);
			LblFirstValue.TabIndex = 3;
			LblFirstValue.Text = "First Value";
			// 
			// LblSecondValue
			// 
			LblSecondValue.AutoSize = true;
			LblSecondValue.Location = new Point(12, 79);
			LblSecondValue.Name = "LblSecondValue";
			LblSecondValue.Size = new Size(77, 15);
			LblSecondValue.TabIndex = 4;
			LblSecondValue.Text = "Second Value";
			// 
			// LblThirdValue
			// 
			LblThirdValue.AutoSize = true;
			LblThirdValue.Location = new Point(12, 124);
			LblThirdValue.Name = "LblThirdValue";
			LblThirdValue.Size = new Size(65, 15);
			LblThirdValue.TabIndex = 5;
			LblThirdValue.Text = "Third Value";
			// 
			// BtnIdentify
			// 
			BtnIdentify.Location = new Point(12, 168);
			BtnIdentify.Name = "BtnIdentify";
			BtnIdentify.Size = new Size(218, 29);
			BtnIdentify.TabIndex = 6;
			BtnIdentify.Text = "Find The Largest Value";
			BtnIdentify.UseVisualStyleBackColor = true;
			BtnIdentify.Click += BtnIdentify_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(242, 239);
			Controls.Add(BtnIdentify);
			Controls.Add(LblThirdValue);
			Controls.Add(LblSecondValue);
			Controls.Add(LblFirstValue);
			Controls.Add(TxtTvalue);
			Controls.Add(TxtSvalue);
			Controls.Add(TxtFValue);
			Name = "Form1";
			Text = "CSLargest";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox TxtFValue;
		private TextBox TxtSvalue;
		private TextBox TxtTvalue;
		private Label LblFirstValue;
		private Label LblSecondValue;
		private Label LblThirdValue;
		private Button BtnIdentify;
	}
}
