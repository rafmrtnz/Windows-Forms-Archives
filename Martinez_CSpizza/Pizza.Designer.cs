

namespace Martinez_CSpizza
{
	partial class Pizza
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
			LblPrice = new Label();
			LblQuantity = new Label();
			LblBill = new Label();
			TxtPrice = new TextBox();
			TxtBill = new TextBox();
			TxtQuantity = new TextBox();
			GbPizza = new GroupBox();
			RdPromo = new RadioButton();
			RdSpecial = new RadioButton();
			Rddeluxe = new RadioButton();
			GbIngredients = new GroupBox();
			Ckbtomato = new CheckBox();
			CkbOnions = new CheckBox();
			Ckbmushroom = new CheckBox();
			Ckbbaconham = new CheckBox();
			Ckbpepper = new CheckBox();
			Ckbcheese = new CheckBox();
			btnCompute = new Button();
			GbPizza.SuspendLayout();
			GbIngredients.SuspendLayout();
			SuspendLayout();
			// 
			// LblPrice
			// 
			LblPrice.AutoSize = true;
			LblPrice.Location = new Point(12, 134);
			LblPrice.Name = "LblPrice";
			LblPrice.Size = new Size(33, 15);
			LblPrice.TabIndex = 0;
			LblPrice.Text = "Price";
			// 
			// LblQuantity
			// 
			LblQuantity.AutoSize = true;
			LblQuantity.Location = new Point(12, 192);
			LblQuantity.Name = "LblQuantity";
			LblQuantity.Size = new Size(53, 15);
			LblQuantity.TabIndex = 1;
			LblQuantity.Text = "Quantity";
			// 
			// LblBill
			// 
			LblBill.AutoSize = true;
			LblBill.Location = new Point(206, 227);
			LblBill.Name = "LblBill";
			LblBill.Size = new Size(23, 15);
			LblBill.TabIndex = 2;
			LblBill.Text = "Bill";
			// 
			// TxtPrice
			// 
			TxtPrice.Location = new Point(12, 152);
			TxtPrice.Name = "TxtPrice";
			TxtPrice.Size = new Size(147, 23);
			TxtPrice.TabIndex = 3;
			TxtPrice.TextAlign = HorizontalAlignment.Right;
			// 
			// TxtBill
			// 
			TxtBill.Location = new Point(206, 245);
			TxtBill.Name = "TxtBill";
			TxtBill.Size = new Size(147, 23);
			TxtBill.TabIndex = 4;
			TxtBill.TextAlign = HorizontalAlignment.Right;
			// 
			// TxtQuantity
			// 
			TxtQuantity.Location = new Point(12, 210);
			TxtQuantity.Name = "TxtQuantity";
			TxtQuantity.Size = new Size(147, 23);
			TxtQuantity.TabIndex = 5;
			TxtQuantity.TextAlign = HorizontalAlignment.Right;
			// 
			// GbPizza
			// 
			GbPizza.Controls.Add(RdPromo);
			GbPizza.Controls.Add(RdSpecial);
			GbPizza.Controls.Add(Rddeluxe);
			GbPizza.Location = new Point(12, 12);
			GbPizza.Name = "GbPizza";
			GbPizza.Size = new Size(147, 100);
			GbPizza.TabIndex = 6;
			GbPizza.TabStop = false;
			GbPizza.Text = "Pizza";
			// 
			// RdPromo
			// 
			RdPromo.AutoSize = true;
			RdPromo.Location = new Point(6, 72);
			RdPromo.Name = "RdPromo";
			RdPromo.Size = new Size(61, 19);
			RdPromo.TabIndex = 2;
			RdPromo.TabStop = true;
			RdPromo.Text = "Promo";
			RdPromo.UseVisualStyleBackColor = true;
			// 
			// RdSpecial
			// 
			RdSpecial.AutoSize = true;
			RdSpecial.Location = new Point(6, 47);
			RdSpecial.Name = "RdSpecial";
			RdSpecial.Size = new Size(62, 19);
			RdSpecial.TabIndex = 1;
			RdSpecial.TabStop = true;
			RdSpecial.Text = "Special";
			RdSpecial.UseVisualStyleBackColor = true;
			// 
			// Rddeluxe
			// 
			Rddeluxe.AutoSize = true;
			Rddeluxe.Location = new Point(6, 22);
			Rddeluxe.Name = "Rddeluxe";
			Rddeluxe.Size = new Size(61, 19);
			Rddeluxe.TabIndex = 0;
			Rddeluxe.TabStop = true;
			Rddeluxe.Text = "Deluxe";
			Rddeluxe.UseVisualStyleBackColor = true;
			// 
			// GbIngredients
			// 
			GbIngredients.Controls.Add(Ckbtomato);
			GbIngredients.Controls.Add(CkbOnions);
			GbIngredients.Controls.Add(Ckbmushroom);
			GbIngredients.Controls.Add(Ckbbaconham);
			GbIngredients.Controls.Add(Ckbpepper);
			GbIngredients.Controls.Add(Ckbcheese);
			GbIngredients.Location = new Point(206, 12);
			GbIngredients.Name = "GbIngredients";
			GbIngredients.Size = new Size(241, 183);
			GbIngredients.TabIndex = 7;
			GbIngredients.TabStop = false;
			GbIngredients.Text = "Ingredients";
			// 
			// Ckbtomato
			// 
			Ckbtomato.AutoSize = true;
			Ckbtomato.Location = new Point(6, 147);
			Ckbtomato.Name = "Ckbtomato";
			Ckbtomato.Size = new Size(66, 19);
			Ckbtomato.TabIndex = 5;
			Ckbtomato.Text = "Tomato";
			Ckbtomato.UseVisualStyleBackColor = true;
			// 
			// CkbOnions
			// 
			CkbOnions.AutoSize = true;
			CkbOnions.Location = new Point(6, 122);
			CkbOnions.Name = "CkbOnions";
			CkbOnions.Size = new Size(64, 19);
			CkbOnions.TabIndex = 4;
			CkbOnions.Text = "Onions";
			CkbOnions.UseVisualStyleBackColor = true;
			// 
			// Ckbmushroom
			// 
			Ckbmushroom.AutoSize = true;
			Ckbmushroom.Location = new Point(6, 97);
			Ckbmushroom.Name = "Ckbmushroom";
			Ckbmushroom.Size = new Size(90, 19);
			Ckbmushroom.TabIndex = 3;
			Ckbmushroom.Text = "Mushrooms";
			Ckbmushroom.UseVisualStyleBackColor = true;
			// 
			// Ckbbaconham
			// 
			Ckbbaconham.AutoSize = true;
			Ckbbaconham.Location = new Point(6, 72);
			Ckbbaconham.Name = "Ckbbaconham";
			Ckbbaconham.Size = new Size(101, 19);
			Ckbbaconham.TabIndex = 2;
			Ckbbaconham.Text = "Bacon && Ham";
			Ckbbaconham.UseVisualStyleBackColor = true;
			// 
			// Ckbpepper
			// 
			Ckbpepper.AutoSize = true;
			Ckbpepper.Location = new Point(6, 47);
			Ckbpepper.Name = "Ckbpepper";
			Ckbpepper.Size = new Size(63, 19);
			Ckbpepper.TabIndex = 1;
			Ckbpepper.Text = "Pepper";
			Ckbpepper.UseVisualStyleBackColor = true;
			// 
			// Ckbcheese
			// 
			Ckbcheese.AutoSize = true;
			Ckbcheese.Location = new Point(6, 22);
			Ckbcheese.Name = "Ckbcheese";
			Ckbcheese.Size = new Size(64, 19);
			Ckbcheese.TabIndex = 0;
			Ckbcheese.Text = "Cheese";
			Ckbcheese.UseVisualStyleBackColor = true;
			// 
			// btnCompute
			// 
			btnCompute.Location = new Point(30, 245);
			btnCompute.Name = "btnCompute";
			btnCompute.Size = new Size(89, 23);
			btnCompute.TabIndex = 8;
			btnCompute.Text = "Compute";
			btnCompute.UseVisualStyleBackColor = true;
			btnCompute.Click += btnCompute_Click_1;
			// 
			// Pizza
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(459, 284);
			Controls.Add(btnCompute);
			Controls.Add(GbIngredients);
			Controls.Add(GbPizza);
			Controls.Add(TxtQuantity);
			Controls.Add(TxtBill);
			Controls.Add(TxtPrice);
			Controls.Add(LblBill);
			Controls.Add(LblQuantity);
			Controls.Add(LblPrice);
			Name = "Pizza";
			Text = "Pizza";
			GbPizza.ResumeLayout(false);
			GbPizza.PerformLayout();
			GbIngredients.ResumeLayout(false);
			GbIngredients.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}



		#endregion

		private Label LblPrice;
		private Label LblQuantity;
		private Label LblBill;
		private TextBox TxtPrice;
		private TextBox TxtBill;
		private TextBox TxtQuantity;
		private GroupBox GbPizza;
		private GroupBox GbIngredients;
		private RadioButton RdPromo;
		private RadioButton RdSpecial;
		private RadioButton Rddeluxe;
		private CheckBox Ckbtomato;
		private CheckBox CkbOnions;
		private CheckBox Ckbmushroom;
		private CheckBox Ckbbaconham;
		private CheckBox Ckbpepper;
		private CheckBox Ckbcheese;
		private Button btnCompute;
	}
}
