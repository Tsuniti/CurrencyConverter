using System.ComponentModel;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (inputDollars.Text == string.Empty)
            {
                MessageBox.Show("Please enter dollar amount");
                return;
            }
            if (selectingÑurrencies.Text == string.Empty)
            {
                MessageBox.Show("Please select a currency");
                return;
            }
            double currency;
            switch (selectingÑurrencies.Text)
            {
                case "UAH":
                    currency = 38.0796;
                    break;

                case "EUR":
                    currency = 0.9278;
                    break;

                default:
                    throw new Exception("Something went wrong");
            }
            result.Text = Convert.ToString(double.Parse(inputDollars.Text) * currency);

        }

        private void inputDollars_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(inputDollars.Text, "[^0-9,]"))
            {

                int selectionStart = inputDollars.SelectionStart - 1; // çàïîìíèòü ïîçèöèþ êóðñîðà

                MessageBox.Show("Please enter only numbers.");
                for (int i = 0; i < inputDollars.Text.Length; i++)
                {
                    char ch = inputDollars.Text[i];
                    if (ch != ',' && !char.IsDigit(ch))
                    {
                        inputDollars.Text = inputDollars.Text.Remove(i, 1);
                        break;
                    }
                }

                inputDollars.SelectionStart = selectionStart;
            }
        }

    }
}
