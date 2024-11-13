using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using FacialRecognitionProject.Contracts.Profiling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Reg;
using System.Text.RegularExpressions;
using Emgu.CV.Face;
using System.Configuration;

namespace FacialRecognitionProject
{
	public partial class ProfilingForm : Form, IProfilingForm
	{

		// how to get value from App.config?
		private static readonly CascadeClassifier faceRecognizer = new CascadeClassifier(ConfigurationManager.AppSettings["PRE_TRAINED_MODEL"]);

		public ProfilingForm()
		{
			InitializeComponent();
		}

		public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public event EventHandler ClickSaveUserProfile;
		public event EventHandler Timer;
		public event EventHandler DisplayBox;

		public void ShowMessage(string message)
		{
			MessageBox.Show(message);
		}

		public void TimerStart()
		{
			
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			ClickSaveUserProfile?.Invoke(this, EventArgs.Empty);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

		}

		private void DetectFaceBtn_Click(object sender, EventArgs e)
		{
			faceRecognizer.;
		}
	}
}
