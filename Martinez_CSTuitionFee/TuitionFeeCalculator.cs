using System;
using System.Windows.Forms;

namespace Martinez_CSTuitionFee
{
	public partial class TuitionFeeCalculator : Form
	{
		private readonly double _TenPercent = .10;
		private readonly double _FivePercent = .05;
		private const string _ERROR_MSG = "Spaces, characters, decimals, and alphanumeric are not allowed. Please check tuition fee amount and try again.";

		public TuitionFeeCalculator()
		{
			InitializeComponent();
		}

		private void Btncompute_Click(object sender, EventArgs e)
		{
			ProcessTuitionFee();
		}

		private void ProcessTuitionFee()
		{
			// get mode of payment
			// pass the group box as a parameter
			// special data type, since this is returned as a tuple
			int modeOfPayment = ExtractMOP(GbMode);

			// get the value of tuition fee entered by user
			int tuitionEntered = ExtractTuitionEntered(Txttuitionfee);
			if (tuitionEntered <= 0)
			{
				MessageBox.Show(_ERROR_MSG);
				return;
			}

			// calculate tuition fee.
			string totalTuitioAmount = PaymentCalculataions(modeOfPayment, tuitionEntered);

			// set correct amount of data.
			Txttotal.Text = totalTuitioAmount;
		}

		private string PaymentCalculataions(int idx, int tuitionFee)
		{
			double result = 0;

			if (idx == 0)
				result = tuitionFee + (tuitionFee * _TenPercent);

			if (idx == 1)
				result = tuitionFee + (tuitionFee * _FivePercent);

			if (idx == 2)
				result = tuitionFee - (tuitionFee * _TenPercent);

			return result.ToString("#,##0");
		}

		private int ExtractTuitionEntered(TextBox tuition)
		{
			// try to convert text -> string.
			// the initial result is boolean, using that boolean result it then checks which condition it falls and returns it.
			return !int.TryParse(tuition.Text, out int tuitionEntered) ? 0 : tuitionEntered;
		}

		/**
		<summary>
			This method returns an only of extracted payment.
			Index is takes less steps compared to returning a whole string.
		</summary>
		**/
		private int ExtractMOP(GroupBox group)
		{
			// get the index for later switch case use.
			int idx = 0;
			RadioButton radio = new RadioButton();
			// use the controls base class for extraction
			foreach (Control control in group.Controls)
			{
				// compare and parse the control to radio button
				//if (control is RadioButton radio && radio.Checked)
				//{
				//	break;
				//}
				if (control is RadioButton)
				{
					 radio = (RadioButton)control;
				}

				if (radio.Checked)
				{
					break;
				}

				idx += 1;
			}
			return idx;
		}
	}
}
