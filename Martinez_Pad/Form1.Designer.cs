using System.Drawing;
using System.Windows.Forms;
namespace Martinez_Pad
{
	partial class Form1
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
			fileToolStripMenuItem = new ToolStripMenuItem();
			newToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			saveToolStripMenuItem = new ToolStripMenuItem();
			exitToolStripMenuItem = new ToolStripMenuItem();
			editToolStripMenuItem = new ToolStripMenuItem();
			undoToolStripMenuItem = new ToolStripMenuItem();
			redoToolStripMenuItem = new ToolStripMenuItem();
			copyToolStripMenuItem = new ToolStripMenuItem();
			pasteToolStripMenuItem = new ToolStripMenuItem();
			cutToolStripMenuItem = new ToolStripMenuItem();
			selectAllToolStripMenuItem = new ToolStripMenuItem();
			dateTimeToolStripMenuItem = new ToolStripMenuItem();
			formatToolStripMenuItem = new ToolStripMenuItem();
			fontToolStripMenuItem = new ToolStripMenuItem();
			colorToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1 = new MenuStrip();
			richTextBox1 = new RichTextBox();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel2 = new ToolStripStatusLabel();
			toolStripProgressBar1 = new ToolStripProgressBar();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			menuStrip1.SuspendLayout();
			statusStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F;
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "&File";
			fileToolStripMenuItem.MouseLeave += fileToolStripMenuItem_MouseLeave;
			fileToolStripMenuItem.MouseHover += fileToolStripMenuItem_MouseHover;
			// 
			// newToolStripMenuItem
			// 
			newToolStripMenuItem.Name = "newToolStripMenuItem";
			newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
			newToolStripMenuItem.Size = new Size(180, 22);
			newToolStripMenuItem.Text = "New";
			newToolStripMenuItem.Click += newToolStripMenuItem_Click;
			newToolStripMenuItem.MouseLeave += newToolStripMenuItem_MouseLeave;
			newToolStripMenuItem.MouseHover += newToolStripMenuItem_MouseHover;
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
			openToolStripMenuItem.Size = new Size(180, 22);
			openToolStripMenuItem.Text = "Open";
			openToolStripMenuItem.Click += openToolStripMenuItem_Click;
			openToolStripMenuItem.MouseLeave += openToolStripMenuItem_MouseLeave;
			openToolStripMenuItem.MouseHover += openToolStripMenuItem_MouseHover;
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
			saveToolStripMenuItem.Size = new Size(180, 22);
			saveToolStripMenuItem.Text = "Save";
			saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
			saveToolStripMenuItem.MouseLeave += saveToolStripMenuItem_MouseLeave;
			saveToolStripMenuItem.MouseHover += saveToolStripMenuItem_MouseHover;
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
			exitToolStripMenuItem.Size = new Size(180, 22);
			exitToolStripMenuItem.Text = "Exit";
			exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
			exitToolStripMenuItem.MouseLeave += exitToolStripMenuItem_MouseLeave;
			exitToolStripMenuItem.MouseHover += exitToolStripMenuItem_MouseHover;
			// 
			// editToolStripMenuItem
			// 
			editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, cutToolStripMenuItem, selectAllToolStripMenuItem, dateTimeToolStripMenuItem });
			editToolStripMenuItem.Name = "editToolStripMenuItem";
			editToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.E;
			editToolStripMenuItem.Size = new Size(39, 20);
			editToolStripMenuItem.Text = "&Edit";
			editToolStripMenuItem.MouseLeave += editToolStripMenuItem_MouseLeave;
			editToolStripMenuItem.MouseHover += editToolStripMenuItem_MouseHover;
			// 
			// undoToolStripMenuItem
			// 
			undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
			undoToolStripMenuItem.Size = new Size(164, 22);
			undoToolStripMenuItem.Text = "Undo";
			undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
			undoToolStripMenuItem.MouseLeave += undoToolStripMenuItem_MouseLeave;
			undoToolStripMenuItem.MouseHover += undoToolStripMenuItem_MouseHover;
			// 
			// redoToolStripMenuItem
			// 
			redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
			redoToolStripMenuItem.Size = new Size(164, 22);
			redoToolStripMenuItem.Text = "Redo";
			redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
			redoToolStripMenuItem.MouseLeave += redoToolStripMenuItem_MouseLeave;
			redoToolStripMenuItem.MouseHover += redoToolStripMenuItem_MouseHover;
			// 
			// copyToolStripMenuItem
			// 
			copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
			copyToolStripMenuItem.Size = new Size(164, 22);
			copyToolStripMenuItem.Text = "Copy";
			copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
			copyToolStripMenuItem.MouseLeave += copyToolStripMenuItem_MouseLeave;
			copyToolStripMenuItem.MouseHover += copyToolStripMenuItem_MouseHover;
			// 
			// pasteToolStripMenuItem
			// 
			pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
			pasteToolStripMenuItem.Size = new Size(164, 22);
			pasteToolStripMenuItem.Text = "Paste";
			pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
			pasteToolStripMenuItem.MouseLeave += pasteToolStripMenuItem_MouseLeave;
			pasteToolStripMenuItem.MouseHover += pasteToolStripMenuItem_MouseHover;
			// 
			// cutToolStripMenuItem
			// 
			cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
			cutToolStripMenuItem.Size = new Size(164, 22);
			cutToolStripMenuItem.Text = "Cut";
			cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
			cutToolStripMenuItem.MouseLeave += cutToolStripMenuItem_MouseLeave;
			cutToolStripMenuItem.MouseHover += cutToolStripMenuItem_MouseHover;
			// 
			// selectAllToolStripMenuItem
			// 
			selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
			selectAllToolStripMenuItem.Size = new Size(164, 22);
			selectAllToolStripMenuItem.Text = "Select All";
			selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
			selectAllToolStripMenuItem.MouseLeave += selectAllToolStripMenuItem_MouseLeave;
			selectAllToolStripMenuItem.MouseHover += selectAllToolStripMenuItem_MouseHover;
			// 
			// dateTimeToolStripMenuItem
			// 
			dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
			dateTimeToolStripMenuItem.ShortcutKeys = Keys.F5;
			dateTimeToolStripMenuItem.Size = new Size(164, 22);
			dateTimeToolStripMenuItem.Text = "Date/Time";
			dateTimeToolStripMenuItem.Click += dateTimeToolStripMenuItem_Click;
			dateTimeToolStripMenuItem.MouseLeave += dateTimeToolStripMenuItem_MouseLeave;
			dateTimeToolStripMenuItem.MouseHover += dateTimeToolStripMenuItem_MouseHover;
			// 
			// formatToolStripMenuItem
			// 
			formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem });
			formatToolStripMenuItem.Name = "formatToolStripMenuItem";
			formatToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.O;
			formatToolStripMenuItem.Size = new Size(57, 20);
			formatToolStripMenuItem.Text = "Format";
			formatToolStripMenuItem.MouseLeave += formatToolStripMenuItem_MouseLeave;
			formatToolStripMenuItem.MouseHover += formatToolStripMenuItem_MouseHover;
			// 
			// fontToolStripMenuItem
			// 
			fontToolStripMenuItem.Name = "fontToolStripMenuItem";
			fontToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
			fontToolStripMenuItem.Size = new Size(170, 22);
			fontToolStripMenuItem.Text = "Font";
			fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
			fontToolStripMenuItem.MouseLeave += fontToolStripMenuItem_MouseLeave;
			fontToolStripMenuItem.MouseHover += fontToolStripMenuItem_MouseHover;
			// 
			// colorToolStripMenuItem
			// 
			colorToolStripMenuItem.Name = "colorToolStripMenuItem";
			colorToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.H;
			colorToolStripMenuItem.Size = new Size(170, 22);
			colorToolStripMenuItem.Text = "Color";
			colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
			colorToolStripMenuItem.MouseLeave += colorToolStripMenuItem_MouseLeave;
			colorToolStripMenuItem.MouseHover += colorToolStripMenuItem_MouseHover;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// richTextBox1
			// 
			richTextBox1.AcceptsTab = true;
			richTextBox1.BulletIndent = 1;
			richTextBox1.Dock = DockStyle.Fill;
			richTextBox1.Location = new Point(0, 24);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(800, 426);
			richTextBox1.TabIndex = 1;
			richTextBox1.Text = "";
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel2, toolStripProgressBar1, toolStripStatusLabel1 });
			statusStrip1.Location = new Point(0, 428);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(800, 22);
			statusStrip1.TabIndex = 2;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel2
			// 
			toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			toolStripStatusLabel2.Size = new Size(102, 17);
			toolStripStatusLabel2.Text = "© Rafael Martinez";
			// 
			// toolStripProgressBar1
			// 
			toolStripProgressBar1.Name = "toolStripProgressBar1";
			toolStripProgressBar1.Size = new Size(100, 16);
			toolStripProgressBar1.Visible = false;
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(0, 17);
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(statusStrip1);
			Controls.Add(richTextBox1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Martinez_Pad";
			FormClosing += Form1_FormClosing;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem newToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem undoToolStripMenuItem;
		private ToolStripMenuItem redoToolStripMenuItem;
		private ToolStripMenuItem copyToolStripMenuItem;
		private ToolStripMenuItem pasteToolStripMenuItem;
		private ToolStripMenuItem cutToolStripMenuItem;
		private ToolStripMenuItem selectAllToolStripMenuItem;
		private ToolStripMenuItem dateTimeToolStripMenuItem;
		private ToolStripMenuItem formatToolStripMenuItem;
		private ToolStripMenuItem fontToolStripMenuItem;
		private ToolStripMenuItem colorToolStripMenuItem;
		private MenuStrip menuStrip1;
		private RichTextBox richTextBox1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripProgressBar toolStripProgressBar1;
		private ToolStripStatusLabel toolStripStatusLabel2;
	}
}
