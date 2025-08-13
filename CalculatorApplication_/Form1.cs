using CalculatorApplication_.frmCal;

namespace CalculatorApplication_
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;
        double number1, number2;
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
        }

        private void bttnEqual_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtBoxInput1.Text);
            number2 = Convert.ToDouble(txtBoxInput2.Text);
            String op = cbOperator.SelectedItem.ToString();
            double result = 0;
            switch (op)
            {
                case "+":
                    result = cal.GetSum(number1, number2);
                    break;

                case "-":
                    result = cal.GetDifference(number2, number1);

                    break;
                case "*":
                    result = cal.GetProduct(number1, number2);
                    break;
                case "/":
                    result = cal.GetQuotient(number1, number2);
                    break;
            }
            lblDisplayTotal.Text = result.ToString();
        }
    }
}
