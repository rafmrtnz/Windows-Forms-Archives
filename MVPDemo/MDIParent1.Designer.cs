namespace MVPDemo
{
	partial class MDIParent1
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
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// form1ToolStripMenuItem
			// 
			this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
			this.form1ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.form1ToolStripMenuItem.Text = "Form1";
			this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1039, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// MDIParent1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1039, 564);
			this.Controls.Add(this.menuStrip);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MDIParent1";
			this.Text = "MDIParent1";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip;
	}
}



