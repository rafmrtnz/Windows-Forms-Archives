
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
			this.GbMode = new System.Windows.Forms.GroupBox();
			this.Rdthreepayments = new System.Windows.Forms.RadioButton();
			this.Rdtwopayments = new System.Windows.Forms.RadioButton();
			this.RdCash = new System.Windows.Forms.RadioButton();
			this.Lbltuitionfee = new System.Windows.Forms.Label();
			this.Lbltotal = new System.Windows.Forms.Label();
			this.Txttuitionfee = new System.Windows.Forms.TextBox();
			this.Txttotal = new System.Windows.Forms.TextBox();
			this.Btncompute = new System.Windows.Forms.Button();
			this.GbMode.SuspendLayout();
			this.SuspendLayout();
			// 
			// GbMode
			// 
			this.GbMode.Controls.Add(this.Rdthreepayments);
			this.GbMode.Controls.Add(this.Rdtwopayments);
			this.GbMode.Controls.Add(this.RdCash);
			this.GbMode.Location = new System.Drawing.Point(39, 92);
			this.GbMode.Name = "GbMode";
			this.GbMode.Size = new System.Drawing.Size(200, 100);
			this.GbMode.TabIndex = 0;
			this.GbMode.TabStop = false;
			this.GbMode.Text = "Mode of Payment";
			// 
			// Rdthreepayments
			// 
			this.Rdthreepayments.AutoSize = true;
			this.Rdthreepayments.Location = new System.Drawing.Point(6, 65);
			this.Rdthreepayments.Name = "Rdthreepayments";
			this.Rdthreepayments.Size = new System.Drawing.Size(168, 17);
			this.Rdthreepayments.TabIndex = 2;
			this.Rdthreepayments.Text = "Three Payments (10% interest)";
			this.Rdthreepayments.UseVisualStyleBackColor = true;
			// 
			// Rdtwopayments
			// 
			this.Rdtwopayments.AutoSize = true;
			this.Rdtwopayments.Checked = true;
			this.Rdtwopayments.Location = new System.Drawing.Point(6, 42);
			this.Rdtwopayments.Name = "Rdtwopayments";
			this.Rdtwopayments.Size = new System.Drawing.Size(155, 17);
			this.Rdtwopayments.TabIndex = 1;
			this.Rdtwopayments.TabStop = true;
			this.Rdtwopayments.Text = "Two Payments (5% interest)";
			this.Rdtwopayments.UseVisualStyleBackColor = true;
			// 
			// RdCash
			// 
			this.RdCash.AutoSize = true;
			this.RdCash.Location = new System.Drawing.Point(6, 19);
			this.RdCash.Name = "RdCash";
			this.RdCash.Size = new System.Drawing.Size(121, 17);
			this.RdCash.TabIndex = 0;
			this.RdCash.Text = "Cash (10% discount)";
			this.RdCash.UseVisualStyleBackColor = true;
			// 
			// Lbltuitionfee
			// 
			this.Lbltuitionfee.AutoSize = true;
			this.Lbltuitionfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbltuitionfee.Location = new System.Drawing.Point(286, 69);
			this.Lbltuitionfee.Name = "Lbltuitionfee";
			this.Lbltuitionfee.Size = new System.Drawing.Size(122, 20);
			this.Lbltuitionfee.TabIndex = 1;
			this.Lbltuitionfee.Text = "Enter tuition fee";
			// 
			// Lbltotal
			// 
			this.Lbltotal.AutoSize = true;
			this.Lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbltotal.Location = new System.Drawing.Point(266, 167);
			this.Lbltotal.Name = "Lbltotal";
			this.Lbltotal.Size = new System.Drawing.Size(152, 20);
			this.Lbltotal.TabIndex = 2;
			this.Lbltotal.Text = "Your total tuition fee";
			// 
			// Txttuitionfee
			// 
			this.Txttuitionfee.Location = new System.Drawing.Point(270, 92);
			this.Txttuitionfee.Name = "Txttuitionfee";
			this.Txttuitionfee.Size = new System.Drawing.Size(148, 20);
			this.Txttuitionfee.TabIndex = 3;
			// 
			// Txttotal
			// 
			this.Txttotal.AcceptsReturn = true;
			this.Txttotal.Location = new System.Drawing.Point(270, 190);
			this.Txttotal.Name = "Txttotal";
			this.Txttotal.Size = new System.Drawing.Size(148, 20);
			this.Txttotal.TabIndex = 4;
			// 
			// Btncompute
			// 
			this.Btncompute.Location = new System.Drawing.Point(302, 123);
			this.Btncompute.Name = "Btncompute";
			this.Btncompute.Size = new System.Drawing.Size(75, 34);
			this.Btncompute.TabIndex = 5;
			this.Btncompute.Text = "Compute";
			this.Btncompute.UseVisualStyleBackColor = true;
			this.Btncompute.Click += new System.EventHandler(this.Btncompute_Click);
			// 
			// TuitionFeeCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.Btncompute);
			this.Controls.Add(this.Txttotal);
			this.Controls.Add(this.Txttuitionfee);
			this.Controls.Add(this.Lbltotal);
			this.Controls.Add(this.Lbltuitionfee);
			this.Controls.Add(this.GbMode);
			this.Name = "TuitionFeeCalculator";
			this.Text = "Form1";
			this.GbMode.ResumeLayout(false);
			this.GbMode.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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

