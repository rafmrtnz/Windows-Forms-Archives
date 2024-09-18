using System.Linq;

namespace Martinez_CSLargest
{
	public partial class LargestValueIdentifier : Form
	{
		private readonly string _ERROR_MSG = $"Only numeric and decimals are allowed. Numeric limit should be {long.MaxValue} only.";
				

		public LargestValueIdentifier()
		{
			InitializeComponent();
		}

		private void BtnIdentify_Click(object sender, EventArgs e)
		{
			string[] dataInput = { TxtFValue.Text, TxtSvalue.Text, TxtTvalue.Text };

			try
			{
				// validate and convert data
				int[] convertedData = ValidateInputs(dataInput);

				// get maximum value
				MessageBox.Show($"Maximum value is {FindLargest(convertedData)}");

			}
			catch(FormatException formatException)
			{
				MessageBox.Show(formatException.Message);
			}
		}

		private int[] ValidateInputs(string[] dataInput)
		{
			int[] alteredData = new int[dataInput.Length];

			for (int i = 0; i < dataInput.Length; i++)
			{
				if (!int.TryParse(dataInput[i], out int convertedData))
				{
					throw new FormatException(_ERROR_MSG);
				}

				alteredData[i] = convertedData;
			}
			
			return alteredData;
		}

		public double FindLargest(int[] myArray)
		{
			return myArray.Max();
		}
	}
}
