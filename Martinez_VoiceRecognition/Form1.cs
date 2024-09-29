using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Martinez_VoiceRecognition
{
	public partial class Form1 : Form
	{

		SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
		SpeechSynthesizer synthesizer = new SpeechSynthesizer();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				synthesizer.SelectVoiceByHints(VoiceGender.Female);
				Choices commands = new Choices();
				commands.Add
					(new string[] {"ic say hello", "ic print my name",
				"ic read selected text", "ic", "ic run edge",
				"ic turn off", "ic timecheck",
				"ic date today", "buang man ka ic edge mana"});
				GrammarBuilder gBuilder = new GrammarBuilder();
				gBuilder.Append(commands);
				Grammar grammar = new Grammar(gBuilder);

				recEngine.LoadGrammarAsync(grammar);
				recEngine.SetInputToDefaultAudioDevice();
				recEngine.SpeechRecognized += recEngine_SpeechRecognized;
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

		private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
		{
			switch (e.Result.Text)
			{
				case "ic say hello":
					richTextBox1.Text += "\n ic say hello";
					synthesizer.SpeakAsync("Hello Raf! How are you?");
					break;

				case "ic print my name":
					richTextBox1.Text += "\n Raf";
					break;
				case "ic read selected text":
					synthesizer.SpeakAsync(richTextBox1.SelectedText);
					break;
				case "ic":
					richTextBox1.Text += "\n ic";
					synthesizer.SpeakAsync("I'm fine sir! Ready to assist you!");
					break;
				case "ic run edge":
					richTextBox1.Text += "\n  jb run notepad";
					var isFound = Process.Start(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86
						), "Microsoft/Edge/Application", @"msedge.exe"));
					break;
				case "ic turn off":
					synthesizer.Speak("Bye-bye!");
					Environment.Exit(0);
					break;
				case "ic timecheck":
					richTextBox1.Text += $"\n {DateTime.Now.ToShortTimeString()}";
					synthesizer.SpeakAsync($"The time noww is: {DateTime.Now.ToShortTimeString()}");
					break;
				case "ic date today":
					richTextBox1.Text += $"\n {DateTime.Now.ToShortDateString()}";
					synthesizer.SpeakAsync($"Today is: {DateTime.Now.ToShortDateString()}");
					break;
				case "buang man ka ic edge mana":
					synthesizer.SpeakAsync($"Mas buang ka!");
					break;
			}
		}

		private void btnEnable_Click(object sender, EventArgs e)
		{
			try
			{
				recEngine.RecognizeAsync(RecognizeMode.Multiple);
				this.btnEnable.Enabled = false;
				
				if(this.label1.Text.Equals("VOICE CONTROL OFF"))
				{
					this.label1.Text = "VOICE CONTROL ON";
					this.label1.ForeColor = Color.ForestGreen;
				}
				else
				{
					this.label1.Text = "VOICE CONTROL OFF";
					this.label1.ForeColor = Color.Black;
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.ToString());
			}
		}

		private void btnDisable_Click(object sender, EventArgs e)
		{
			try
			{
				recEngine.RecognizeAsyncStop();
				btnDisable.Enabled = false;

				if (this.label1.Text.Equals("VOICE CONTROL ON"))
				{
					this.label1.Text = "VOICE CONTROL OFF";
					this.label1.ForeColor = Color.Black;
				}
				else
				{
					this.label1.Text = "VOICE CONTROL ON";
					this.label1.ForeColor = Color.ForestGreen;
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.ToString());
			}
			finally
			{
				btnEnable.Enabled = true;
			}
		}
	}
}
