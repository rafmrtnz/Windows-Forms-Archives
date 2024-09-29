namespace SampleErrorThrowing
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
			this.firstName = new System.Windows.Forms.TextBox();
			this.lastName = new System.Windows.Forms.TextBox();
			this.age = new System.Windows.Forms.TextBox();
			this.email = new System.Windows.Forms.TextBox();
			this.username = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.save = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.search = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// firstName
			// 
			this.firstName.Location = new System.Drawing.Point(80, 10);
			this.firstName.Name = "firstName";
			this.firstName.Size = new System.Drawing.Size(245, 20);
			this.firstName.TabIndex = 0;
			// 
			// lastName
			// 
			this.lastName.Location = new System.Drawing.Point(80, 36);
			this.lastName.Name = "lastName";
			this.lastName.Size = new System.Drawing.Size(245, 20);
			this.lastName.TabIndex = 0;
			// 
			// age
			// 
			this.age.Location = new System.Drawing.Point(80, 62);
			this.age.Name = "age";
			this.age.Size = new System.Drawing.Size(245, 20);
			this.age.TabIndex = 0;
			// 
			// email
			// 
			this.email.Location = new System.Drawing.Point(80, 88);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(245, 20);
			this.email.TabIndex = 0;
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(80, 114);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(245, 20);
			this.username.TabIndex = 0;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(80, 140);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(245, 20);
			this.password.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "First Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Last Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Age";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 117);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Username";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 143);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Password";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(331, 36);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(457, 404);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// save
			// 
			this.save.Location = new System.Drawing.Point(28, 203);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(75, 23);
			this.save.TabIndex = 3;
			this.save.Text = "Save";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// update
			// 
			this.update.Location = new System.Drawing.Point(109, 203);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(75, 23);
			this.update.TabIndex = 3;
			this.update.Text = "Update";
			this.update.UseVisualStyleBackColor = true;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(190, 203);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(75, 23);
			this.delete.TabIndex = 3;
			this.delete.Text = "Delete";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// search
			// 
			this.search.Location = new System.Drawing.Point(382, 13);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(257, 20);
			this.search.TabIndex = 0;
			this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(335, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Search";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.update);
			this.Controls.Add(this.save);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.search);
			this.Controls.Add(this.password);
			this.Controls.Add(this.username);
			this.Controls.Add(this.email);
			this.Controls.Add(this.age);
			this.Controls.Add(this.lastName);
			this.Controls.Add(this.firstName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox firstName;
		private System.Windows.Forms.TextBox lastName;
		private System.Windows.Forms.TextBox age;
		private System.Windows.Forms.TextBox email;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.TextBox search;
		private System.Windows.Forms.Label label7;
	}
}

