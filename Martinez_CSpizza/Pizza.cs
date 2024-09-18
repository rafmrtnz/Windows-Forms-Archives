namespace Martinez_CSpizza
{


	public partial class Pizza : Form
	{
		// intialize constants, these will remain its value throughout the lifetime of the program.
		private const int _MAX_INGREDIENT = 6;
		private const double _DELUXE_PRICING = 185.00;
		private const double _SPECIAL_PRICING = 250.00;
		private const double _PROMO_PRICING = 290.00;

		public Pizza()
		{
			InitializeComponent();
		}

		private void btnCompute_Click_1(object sender, EventArgs e)
		{
			try
			{
				ProgramEntry();
			}
			catch (ArgumentException args)
			{
				MessageBox.Show(args.Message);
			}
		}

		/**
		 * <summary>
		 * Entry point of the program.
		 * </summary>
		 * **/
		private void ProgramEntry()
		{
			// check if user ticks a radio button by passing the GroupBox.
			(int idx, string typeOfPizza) pizza = PizzaType(GbPizza);

			// check if values are valid.
			bool isPizzaType = IsTypeOfPizzaValid(pizza.idx, pizza.typeOfPizza);
			if (!isPizzaType)
			{
				throw new ArgumentException("Oops something is missing... Please choose your pizza");
			}

			// check which ingredients are ticked.
			List<string> ingredientList = AddedIngredients(GbIngredients);
			ValidateAllowedIngredients(pizza.idx, ingredientList);

			// get quantity and pricing
			if (!int.TryParse(TxtQuantity.Text, out int quantity))
			{
				// diplay message and early exit.
				MessageBox.Show("Please enter valid amount of quantity");
				return;
			}

			// set pricing
			double pricing = SetPricing(quantity, pizza.idx);
			TxtPrice.Text = pricing.ToString();

			// set total billing
			string billing = SetTotalBill(quantity, pricing);
			TxtBill.Text = $"Php {billing}";
		}

		private (int idx, string typeOfPizza) PizzaType(GroupBox groupBox)
		{
			// declare the index and which type of pizza.
			int idx = 0;
			string typeOfPizza = "";

			foreach (Control control in groupBox.Controls)
			{
				// compare tpyes and cast the data type.
				if (control is RadioButton radio && radio.Checked)
				{
					typeOfPizza = radio.Text;
					break;
				}
				// increment index.
				idx++;
			}
			// return as a tuple.
			return (idx, typeOfPizza);
		}

		private bool IsTypeOfPizzaValid(int idx, string typeOfPizza)
		{
			return idx < 3 && typeOfPizza != "" ? true : false;
		}

		private List<string> AddedIngredients(GroupBox groupBox)
		{
			List<string> checkBoxNames = new List<string>();
			foreach (Control control in groupBox.Controls)
			{
				if (control is CheckBox checkBox && checkBox.Checked)
				{
					checkBoxNames.Add(checkBox.Name);  // Add the Name of the CheckBox
				}
			}
			return checkBoxNames;
		}

		private void ValidateAllowedIngredients(int idx, List<string> ingredients)
		{
			switch (idx)
			{
				case 0:
					if(ingredients.Count < _MAX_INGREDIENT || ingredients.Count > _MAX_INGREDIENT)
						throw new ArgumentException("Please select all ingredients.");
                    break;
				case 1:
					if(ingredients.Count < 1) throw new ArgumentException("Please select atleast one ingredient.");
					break;
				case 2:
					if (ingredients.Count < 1)
						throw new ArgumentException("Please select atleast one ingredient.");
					
					foreach (var item in ingredients)
					{
						if (Ckbtomato.Name == item || Ckbmushroom.Name == item)
							throw new ArgumentException("Tomato and mushroom are not available in the current pizza option.");
					}
					break;
				default: throw new ArgumentException("Something went wrong...");
			}
		}

		private double SetPricing(int quantity, int idx)
		{
			return idx switch
			{
				0 => _PROMO_PRICING,
				1 => _SPECIAL_PRICING,
				2 => _DELUXE_PRICING,
				_ => throw new ArgumentException("Something went wrong.")
			};
		}

		private string SetTotalBill(int quantity, double pricing)
		{
			return (pricing * quantity).ToString();
		}

		
	}
}
