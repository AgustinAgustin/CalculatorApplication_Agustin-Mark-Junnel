namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        CalculatorClass cal;
        double num1, num2;

        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //challenge 
            num1 = Convert.ToDouble(TxtBoxInput1.Text);
            num2 = Convert.ToDouble(TxtBoxInput2.Text);
            if (CBOperator.Text == "+")
            {
                cal.CalculateEvent += new information<double>(cal.GetSum);
                LBLDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculateEvent -= new information<double>(cal.GetSum);
            }
            else if (CBOperator.Text == "-")
            {
                cal.CalculateEvent += new information<double>(cal.GetDifference);
                LBLDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                cal.CalculateEvent -= new information<double>(cal.GetDifference);
            }
            else if (CBOperator.Text == "*")
            {
                cal.CalculateEvent += new information<double>(cal.GetProduct);
                LBLDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent -= new information<double>(cal.GetProduct);
            }
            else if (CBOperator.Text == "/")
            {
                cal.CalculateEvent += new information<double>(cal.GetQuitient);
                LBLDisplayTotal.Text = cal.GetQuitient(num1, num2).ToString();
                cal.CalculateEvent -= new information<double>(cal.GetQuitient);
            }



        }


        //reset all
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Equals(typeof(TextBox)))
                {
                    TextBox txt = item as TextBox;
                    txt.Text = string.Empty;

                    LBLDisplayTotal.Text = "";
                    CBOperator.Text = "";
                }
            }
        }
    }
}