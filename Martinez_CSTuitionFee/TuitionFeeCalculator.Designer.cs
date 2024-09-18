
namespace Martinez_CSTuitionFee
{
	partial class TuitionFeeCalculator
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
			GbMode = new GroupBox();
			Rdthreepayments = new RadioButton();
			Rdtwopayments = new RadioButton();
			RdCash = new RadioButton();
			Lbltuitionfee = new Label();
			Lbltotal = new Label();
			Txttuitionfee = new TextBox();
			Txttotal = new TextBox();
			Btncompute = new Button();
			GbMode.SuspendLayout();
			SuspendLayout();
			// 
			// GbMode
			// 
			GbMode.Controls.Add(Rdthreepayments);
			GbMode.Controls.Add(Rdtwopayments);
			GbMode.Controls.Add(RdCash);
			GbMode.Location = new Point(46, 106);
			GbMode.Margin = new Padding(4, 3, 4, 3);
			GbMode.Name = "GbMode";
			GbMode.Padding = new Padding(4, 3, 4, 3);
			GbMode.Size = new Size(233, 115);
			GbMode.TabIndex = 0;
			GbMode.TabStop = false;
			GbMode.Text = "Mode of Payment";
			// 
			// Rdthreepayments
			// 
			Rdthreepayments.AutoSize = true;
			Rdthreepayments.Location = new Point(7, 75);
			Rdthreepayments.Margin = new Padding(4, 3, 4, 3);
			Rdthreepayments.Name = "Rdthreepayments";
			Rdthreepayments.Size = new Size(184, 19);
			Rdthreepayments.TabIndex = 2;
			Rdthreepayments.Text = "Three Payments (10% interest)";
			Rdthreepayments.UseVisualStyleBackColor = true;
			// 
			// Rdtwopayments
			// 
			Rdtwopayments.AutoSize = true;
			Rdtwopayments.Checked = true;
			Rdtwopayments.Location = new Point(7, 48);
			Rdtwopayments.Margin = new Padding(4, 3, 4, 3);
			Rdtwopayments.Name = "Rdtwopayments";
			Rdtwopayments.Size = new Size(170, 19);
			Rdtwopayments.TabIndex = 1;
			Rdtwopayments.TabStop = true;
			Rdtwopayments.Text = "Two Payments (5% interest)";
			Rdtwopayments.UseVisualStyleBackColor = true;
			// 
			// RdCash
			// 
			RdCash.AutoSize = true;
			RdCash.Location = new Point(7, 22);
			RdCash.Margin = new Padding(4, 3, 4, 3);
			RdCash.Name = "RdCash";
			RdCash.Size = new Size(133, 19);
			RdCash.TabIndex = 0;
			RdCash.Text = "Cash (10% discount)";
			RdCash.UseVisualStyleBackColor = true;
			// 
			// Lbltuitionfee
			// 
			Lbltuitionfee.AutoSize = true;
			Lbltuitionfee.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lbltuitionfee.Location = new Point(334, 80);
			Lbltuitionfee.Margin = new Padding(4, 0, 4, 0);
			Lbltuitionfee.Name = "Lbltuitionfee";
			Lbltuitionfee.Size = new Size(122, 20);
			Lbltuitionfee.TabIndex = 1;
			Lbltuitionfee.Text = "Enter tuition fee";
			// 
			// Lbltotal
			// 
			Lbltotal.AutoSize = true;
			Lbltotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Lbltotal.Location = new Point(310, 193);
			Lbltotal.Margin = new Padding(4, 0, 4, 0);
			Lbltotal.Name = "Lbltotal";
			Lbltotal.Size = new Size(152, 20);
			Lbltotal.TabIndex = 2;
			Lbltotal.Text = "Your total tuition fee";
			// 
			// Txttuitionfee
			// 
			Txttuitionfee.Location = new Point(315, 106);
			Txttuitionfee.Margin = new Padding(4, 3, 4, 3);
			Txttuitionfee.Name = "Txttuitionfee";
			Txttuitionfee.Size = new Size(172, 23);
			Txttuitionfee.TabIndex = 3;
			// 
			// Txttotal
			// 
			Txttotal.AcceptsReturn = true;
			Txttotal.Location = new Point(315, 219);
			Txttotal.Margin = new Padding(4, 3, 4, 3);
			Txttotal.Name = "Txttotal";
			Txttotal.Size = new Size(172, 23);
			Txttotal.TabIndex = 4;
			// 
			// Btncompute
			// 
			Btncompute.Location = new Point(352, 142);
			Btncompute.Margin = new Padding(4, 3, 4, 3);
			Btncompute.Name = "Btncompute";
			Btncompute.Size = new Size(88, 39);
			Btncompute.TabIndex = 5;
			Btncompute.Text = "Compute";
			Btncompute.UseVisualStyleBackColor = true;
			Btncompute.Click += Btncompute_Click;
			// 
			// TuitionFeeCalculator
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(565, 417);
			Controls.Add(Btncompute);
			Controls.Add(Txttotal);
			Controls.Add(Txttuitionfee);
			Controls.Add(Lbltotal);
			Controls.Add(Lbltuitionfee);
			Controls.Add(GbMode);
			Margin = new Padding(4, 3, 4, 3);
			Name = "TuitionFeeCalculator";
			Text = "Tuition Fee";
			GbMode.ResumeLayout(false);
			GbMode.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.GroupBox GbMode;
		private System.Windows.Forms.RadioButton Rdthreepayments;
		private System.Windows.Forms.RadioButton Rdtwopayments;
		private System.Windows.Forms.RadioButton RdCash;
		private System.Windows.Forms.Label Lbltuitionfee;
		private System.Windows.Forms.Label Lbltotal;
		private System.Windows.Forms.TextBox Txttuitionfee;
		private System.Windows.Forms.TextBox Txttotal;
		private System.Windows.Forms.Button Btncompute;
	}
}

