using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martinez_Pad
{
	public partial class Form1 : Form
	{
		private const int _PROGRESS_BAR_MIN_LOAD_TIME = 0;
		private const int _PROGRESS_BAR_MAX_LOAD_TIME = 100;
		private const int _PROGRESS_BAR_INIT_VALUE_LOAD_TIME = 0;
		private const string _BASE_FILE = "NewTextFile";
		private readonly string _BASE_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

		public Form1()
		{
			InitializeComponent();
			richTextBox1.SelectionIndent = 10;
			richTextBox1.SelectionRightIndent = 10;
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();

			op.Title = "open";
			op.Filter = "Text Document(*.txt)|*.txt| All Files(*.*)|*.*";

			if (op.ShowDialog() == DialogResult.OK)
				richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
			this.Text = op.FileName;
		}

		/**
		 * <summary>
		 * Asynchronous method will run in parallel with other task.
		 * This will not block any and is effective if there are task
		 * that are also running which is required for the program.
		 * This also allows for smoother load times compared to
		 * using Threading.
		 * </summary>
		 * **/
		private async void ProgressBarLoader()
		{
			toolStripProgressBar1.Minimum = _PROGRESS_BAR_MIN_LOAD_TIME;
			toolStripProgressBar1.Maximum = _PROGRESS_BAR_MAX_LOAD_TIME;
			// set initial value.
			toolStripProgressBar1.Value = _PROGRESS_BAR_INIT_VALUE_LOAD_TIME;
			toolStripProgressBar1.Visible = true;
			toolStripStatusLabel1.Text = "Saving file in progress";
			for (int i = 0; i <= toolStripProgressBar1.Maximum; i++)
			{
				toolStripProgressBar1.Value = i;
				await Task.Delay(10);
			}

			if (toolStripProgressBar1.Value == _PROGRESS_BAR_MAX_LOAD_TIME)
			{
				await Task.Delay(800);
				toolStripProgressBar1.Value = _PROGRESS_BAR_INIT_VALUE_LOAD_TIME;
				toolStripProgressBar1.Visible = false;
				toolStripStatusLabel1.Text = "";
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog op = new SaveFileDialog();

			op.Title = "Save";
			op.Filter = "Text Document(*.txt)|*.txt| All Files(*.*)|*.*";

			if (op.ShowDialog() == DialogResult.OK)
			{
				ProgressBarLoader();
				richTextBox1.SaveFile(op.FileName, RichTextBoxStreamType.PlainText);
			}

			if (toolStripProgressBar1.Value == _PROGRESS_BAR_MAX_LOAD_TIME)
				toolStripProgressBar1.Value = _PROGRESS_BAR_INIT_VALUE_LOAD_TIME;
			this.Text = op.FileName;
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			string title = "Warning!";
			string message = "Do you want to save file before exit?";

			// check if notepad has content, if none then immediate exit.
			// i cant use Application.Exit() because it will re trigger this function,
			// i think it is not good to retrigger this function and should only be executed
			// once when condition is true.
			bool hasText = HasText();
			if (!hasText)
			{
				Environment.Exit(0);
			}

			// check user action choice
			int dialog = DisplayMessage(message, title);

			if (dialog == 3)
			{
				e.Cancel = true;
				return;
			}

			if (dialog == 2) Environment.Exit(0);

			bool willSave = SaveFile(saveFileDialog);

			if (!willSave)
			{
				e.Cancel = true;
				return;
			}

			richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
			this.Text = saveFileDialog.FileName;
		}

		private bool CheckFileBeforeExit(string content)
		{
			return !string.IsNullOrEmpty(content) ? true : false;
		}

		private bool HasText()
		{
			return richTextBox1.Text != "" ? true : false;
		}


		private void FileSaving(string baseFileName)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			string path = _BASE_PATH;
			string extension = ".txt";
			string fullPath = Path.Combine(path, baseFileName + extension);
			int counter = 1;

			while (File.Exists(fullPath))
			{
				string fileName = $"{baseFileName} ({counter})";
				fullPath = Path.Combine(path, fileName + extension);
				counter += 1;
			}

			richTextBox1.SaveFile(fullPath, RichTextBoxStreamType.PlainText);
			this.Text = saveFileDialog.FileName;
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			bool hasText = HasText();
			string msg = "Do you want to save changes?";
			string title = "Save";
			int result = 0;

			if (!hasText)
			{
				return;
			}

			result = DisplayMessage(msg, title);

			if (result == 3)
			{
				return;
			}

			if (result == 2)
			{
				richTextBox1.Clear();
				return;
			}

			bool willSave = SaveFile(saveFileDialog);

			if (!willSave)
			{
				return;
			}

			richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
			this.Text = saveFileDialog.FileName;
			richTextBox1.Clear();
		}

		public bool SaveFile(SaveFileDialog saveFileDialog)
		{
			saveFileDialog.Filter = "Text Document(*.txt)|*.txt| All Files(*.*)|*.*";
			saveFileDialog.Title = "Save";
			return saveFileDialog.ShowDialog() == DialogResult.OK ? true : false;
		}

		private int DisplayMessage(string message, string title)
		{
			var result = MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel);
			var choice = 3;

			if (result == DialogResult.Yes) choice = 1;

			if (result == DialogResult.No) choice = 2;

			return choice;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Undo();
		}

		private void redoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Redo();
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectAll();
		}

		private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectedText = System.DateTime.Now.ToString();
		}

		private void fontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("FontDialog Opened");
			FontDialog op = new FontDialog();

			if (op.ShowDialog() == DialogResult.OK)
				richTextBox1.Font = op.Font;
		}

		private void colorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog op = new ColorDialog();

			if (op.ShowDialog() == DialogResult.OK)
				richTextBox1.ForeColor = op.Color;
		}

		private void fileToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to view File menu.";

		}

		private void fileToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{

			toolStripStatusLabel1.Text = "";
		}

		private void newToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to create New file.";
		}

		private void newToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void saveToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to Save current file.";
		}

		private void saveToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void exitToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to Exit notepad.";
		}

		private void exitToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void editToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to view Edit menu.";
		}

		private void editToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void undoToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to Undo file.";
		}

		private void undoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void redoToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to Redo file.";
		}

		private void redoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void copyToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to Copy a text.";
		}

		private void copyToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void pasteToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to Paste a text.";
		}

		private void pasteToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void cutToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to Cut a text.";
		}

		private void cutToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void selectAllToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to Select All text.";
		}

		private void selectAllToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void dateTimeToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to add Date and Time to the notepad.";
		}

		private void dateTimeToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void formatToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to view Format menu";
		}

		private void formatToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void fontToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to change current Font.";
		}

		private void fontToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void colorToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to change current font.";
		}

		private void colorToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		private void openToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Click to Open a new file.";
		}

		private void openToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "";
		}

		
	}
}
