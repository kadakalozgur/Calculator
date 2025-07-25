using System.Globalization;
using System.Security.AccessControl;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double result = 0;
        double firstnumber = 0;
        double secondnumber = 0;
        string process = "";
        bool sqrt = false;
        bool processCompleted = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void disablebutton()
        {

            buttonzero.Enabled = false;
            buttonone.Enabled = false;
            buttontwo.Enabled = false;
            buttonthree.Enabled = false;
            buttonfour.Enabled = false;
            buttonfive.Enabled = false;
            buttonsix.Enabled = false;
            buttonseven.Enabled = false;
            buttoneight.Enabled = false;
            buttonnine.Enabled = false;
            buttonsum.Enabled = false;
            buttonminus.Enabled = false;
            xbutton.Enabled = false;
            buttondivide.Enabled = false;
            buttonresult.Enabled = false;
            buttoncomma.Enabled = false;
            xybutton.Enabled = false;
            sqrtbutton.Enabled = false;

            buttonzero.BackColor = Color.Gray;
            buttonone.BackColor = Color.Gray;
            buttontwo.BackColor = Color.Gray;
            buttonthree.BackColor = Color.Gray;
            buttonfour.BackColor = Color.Gray;
            buttonfive.BackColor = Color.Gray;
            buttonsix.BackColor = Color.Gray;
            buttonseven.BackColor = Color.Gray;
            buttoneight.BackColor = Color.Gray;
            buttonnine.BackColor = Color.Gray;
            buttonsum.BackColor = Color.Gray;
            buttonminus.BackColor = Color.Gray;
            xbutton.BackColor = Color.Gray;
            buttondivide.BackColor = Color.Gray;
            buttonresult.BackColor = Color.Gray;
            buttoncomma.BackColor = Color.Gray;
            xybutton.BackColor = Color.Gray;
            sqrtbutton.BackColor = Color.Gray;

        }

        private void enablebutton()
        {

            buttonzero.Enabled = true;
            buttonone.Enabled = true;
            buttontwo.Enabled = true;
            buttonthree.Enabled = true;
            buttonfour.Enabled = true;
            buttonfive.Enabled = true;
            buttonsix.Enabled = true;
            buttonseven.Enabled = true;
            buttoneight.Enabled = true;
            buttonnine.Enabled = true;
            buttonsum.Enabled = true;
            buttonminus.Enabled = true;
            xbutton.Enabled = true;
            buttondivide.Enabled = true;
            buttonresult.Enabled = true;
            buttoncomma.Enabled = true;
            xybutton.Enabled = true;
            sqrtbutton.Enabled = true;

            buttonzero.BackColor = Color.FromArgb(60, 60, 60);
            buttonone.BackColor = Color.FromArgb(60, 60, 60);
            buttontwo.BackColor = Color.FromArgb(60, 60, 60);
            buttonthree.BackColor = Color.FromArgb(60, 60, 60);
            buttonfour.BackColor = Color.FromArgb(60, 60, 60);
            buttonfive.BackColor = Color.FromArgb(60, 60, 60);
            buttonsix.BackColor = Color.FromArgb(60, 60, 60);
            buttonseven.BackColor = Color.FromArgb(60, 60, 60);
            buttoneight.BackColor = Color.FromArgb(60, 60, 60);
            buttonnine.BackColor = Color.FromArgb(60, 60, 60);
            buttonsum.BackColor = Color.FromArgb(60, 60, 60);
            buttonminus.BackColor = Color.FromArgb(60, 60, 60);
            xbutton.BackColor = Color.FromArgb(60, 60, 60);
            buttondivide.BackColor = Color.FromArgb(60, 60, 60);
            buttonresult.BackColor = Color.FromArgb(71, 177, 232);
            buttoncomma.BackColor = Color.FromArgb(60, 60, 60);
            xybutton.BackColor = Color.FromArgb(60, 60, 60);
            sqrtbutton.BackColor = Color.FromArgb(60, 60, 60);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonone_Click(object sender, EventArgs e)
        {

            if (label1.Text == "0")
            {

                label1.Text = "";

            }

            label1.Text += "1";

        }

        private void buttontwo_Click(object sender, EventArgs e)
        {

            if (label1.Text == "0")
            {

                label1.Text = "";

            }

            label1.Text += "2";

        }

        private void buttonclear_Click(object sender, EventArgs e)
        {

            if (label1.Text == "Invalid Input")
            {

                label1.Font = new Font("Segoe UI", 26, FontStyle.Bold);

                label1.Text = "0";
                label2.Text = "";

                enablebutton();

            }

            if (label1.Text == "Cannot Be Divided By Zero")
            {

                label1.Font = new Font("Segoe UI", 26, FontStyle.Bold);

                label1.Text = "0";
                label2.Text = "";

                enablebutton();

            }

            label1.Text = "0";

            label2.Text = "";

        }

        private void buttonthree_Click(object sender, EventArgs e)
        {

            if (label1.Text == "0")
            {

                label1.Text = "";

            }

            label1.Text += "3";

        }

        private void buttonfour_Click(object sender, EventArgs e)
        {

            if (label1.Text == "0")
            {

                label1.Text = "";

            }

            label1.Text += "4";

        }

        private void buttonfive_Click(object sender, EventArgs e)
        {

            if (label1.Text == "0")
            {

                label1.Text = "";

            }

            label1.Text += "5";

        }

        private void buttonsix_Click(object sender, EventArgs e)
        {

            if (label1.Text == "0")
            {

                label1.Text = "";

            }

            label1.Text += "6";

        }

        private void buttonseven_Click(object sender, EventArgs e)
        {

            if (label1.Text == "0")
            {

                label1.Text = "";

            }

            label1.Text += "7";

        }

        private void buttoneight_Click(object sender, EventArgs e)
        {

            if (label1.Text == "0")
            {

                label1.Text = "";

            }

            label1.Text += "8";

        }

        private void buttonnine_Click(object sender, EventArgs e)
        {

            if (label1.Text == "0")
            {

                label1.Text = "";

            }

            label1.Text += "9";

        }

        private void buttonzero_Click(object sender, EventArgs e)
        {

            if (label1.Text == "0")
            {

                label1.Text = "0";

            }

            else
            {
                label1.Text += "0";
            }


        }

        private void backspacebutton_Click(object sender, EventArgs e)
        {


            if (label1.Text == "Invalid Input")
            {

                label1.Font = new Font("Segoe UI", 26, FontStyle.Bold);

                label1.Text = "0";
                label2.Text = "";

                enablebutton();

            }

            if (label1.Text == "Cannot Be Divided By Zero")
            {

                label1.Font = new Font("Segoe UI", 26, FontStyle.Bold);

                label1.Text = "0";
                label2.Text = "";

                enablebutton();

            }

            if (label1.Text.Length > 0)
            {

                label1.Text = label1.Text.Remove(label1.Text.Length - 1);

            }


            if (label1.Text == "" || label1.Text == "-")
            {

                label1.Text = "0";

            }

        }

        private void buttonsum_Click(object sender, EventArgs e)
        {

            if (processCompleted)
            {
                firstnumber = 0;
                secondnumber = 0;
                process = "";
                processCompleted = false;
            }

            if (label1.Text == "√")
            {

                label1.Text = "Invalid Input";
                label2.Text = "Error";

                disablebutton();

                return;

            }

            if (label1.Text.StartsWith("√"))
            {

                string numberstring = label1.Text.Substring(1);

                double number = Convert.ToDouble(numberstring);


                if (number < 0)
                {

                    label1.Font = new Font("Segoe UI", 18, FontStyle.Bold);

                    label1.Text = "Invalid Input";
                    label2.Text = "Error";

                    disablebutton();

                    return;

                }

                firstnumber = number;

                label2.Text = "√" + Convert.ToString(firstnumber) + " + ";

                label1.Text = "0";

                process = "+";

                firstnumber = Math.Sqrt(number);
            }

            else
            {

                firstnumber = Convert.ToDouble(label1.Text);

                label2.Text = Convert.ToString(firstnumber) + " + ";

                label1.Text = "0";

                process = "+";

            }

        }

        private void buttonresult_Click(object sender, EventArgs e)
        {

            if (label2.Text == "")
            {

                if (label1.Text.StartsWith("√"))
                {

                    string numberString = label1.Text.Substring(1);
                    double number = Convert.ToDouble(numberString);
                    double sqrtResult = Math.Sqrt(number);

                    label2.Text = label1.Text + " = ";
                    label1.Text = Convert.ToString(sqrtResult);

                    processCompleted = true;

                    return;

                }

                label2.Text = label1.Text + " =";
                processCompleted = true;

                return;

            }

            if (label1.Text == "√")
            {

                label1.Text = "Invalid Input";
                label2.Text = "Error";

                disablebutton();

                return;

            }
    
            if (label1.Text.StartsWith("√") && label2.Text == "")
            {
                string numberString = label1.Text.Substring(1);
                double number = Convert.ToDouble(numberString);
                double sqrtResult = Math.Sqrt(number);

                label2.Text = label1.Text + " = ";
                label1.Text = Convert.ToString(sqrtResult);

                processCompleted = true;

                return;
            }      

            if (label1.Text.StartsWith("√"))
            {

                sqrt = true;

                string stringnumber = label1.Text.Substring(1);

                double number2 = Convert.ToDouble(stringnumber);

                if (number2 < 0)
                {

                    label1.Text = "Invalid Input";
                    label2.Text = "Error";

                    disablebutton();

                    return;

                }

                secondnumber = Math.Sqrt(number2);

            }

            else
            {

                secondnumber = Convert.ToDouble(label1.Text);

            }


            if (process == "+")
            {

                result = firstnumber + secondnumber;

                if (sqrt)
                {

                    label2.Text += label1.Text + " = ";

                }

                else
                {

                    label2.Text += Convert.ToString(secondnumber) + " = ";

                }

                label1.Text = Convert.ToString(result);

                sqrt = false;

                processCompleted = true;

            }

            if (process == "-")
            {

                result = firstnumber - secondnumber;

                if (sqrt)
                {

                    label2.Text += label1.Text + " = ";

                }

                else
                {

                    label2.Text += Convert.ToString(secondnumber) + " = ";

                }

                label1.Text = Convert.ToString(result);

                sqrt = false;

                processCompleted = true;

            }

            if (process == "x")
            {

                result = firstnumber * secondnumber;

                if (sqrt)
                {

                    label2.Text += label1.Text + " = ";

                }

                else
                {

                    label2.Text += Convert.ToString(secondnumber) + " = ";

                }

                label1.Text = Convert.ToString(result);

                sqrt = false;

                processCompleted = true;

            }

            if (process == "/")
            {

                if (secondnumber == 0)
                {

                    label1.Font = new Font("Segoe UI", 18, FontStyle.Bold);

                    label1.Text = "Cannot Be Divided By Zero";
                    label2.Text = "Error";

                    disablebutton();

                    return;

                }

                result = firstnumber / secondnumber;

                if (sqrt)
                {

                    label2.Text += label1.Text + " = ";

                }

                else
                {

                    label2.Text += Convert.ToString(secondnumber) + " = ";

                }

                label1.Text = Convert.ToString(result);

                sqrt = false;

                processCompleted = true;

            }

            if(process == "xy")
            {

                result = Math.Pow(firstnumber, secondnumber);

                if (sqrt)
                {

                    label2.Text += label1.Text + " = ";

                }

                else
                {

                    label2.Text += Convert.ToString(secondnumber) + " = ";

                }

                label1.Text = Convert.ToString(result);
                sqrt = false;
                processCompleted = true;

            }

        }

        private void buttonminus_Click(object sender, EventArgs e)
        {

            if (processCompleted)
            {
                firstnumber = 0;
                secondnumber = 0;
                process = "";
                processCompleted = false;
            }

            if (label1.Text == "√")
            {

                label1.Text = "Invalid Input";
                label2.Text = "Error";

                disablebutton();

                return;

            }

            if (label1.Text.StartsWith("√"))
            {

                string numberstring = label1.Text.Substring(1);

                double number = Convert.ToDouble(numberstring);


                if (number < 0)
                {

                    label1.Font = new Font("Segoe UI", 18, FontStyle.Bold);

                    label1.Text = "Invalid Input";
                    label2.Text = "Error";

                    disablebutton();

                    return;

                }

                firstnumber = number;

                label2.Text = "√" + Convert.ToString(firstnumber) + " - ";

                label1.Text = "0";

                process = "-";

                firstnumber = Math.Sqrt(number);
            }

            else
            {

                firstnumber = Convert.ToDouble(label1.Text);

                label2.Text = Convert.ToString(firstnumber) + " - ";

                label1.Text = "0";

                process = "-";


            }
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {

            if (processCompleted)
            {
                firstnumber = 0;
                secondnumber = 0;
                process = "";
                processCompleted = false;
            }

            if (label1.Text == "√")
            {

                label1.Text = "Invalid Input";
                label2.Text = "Error";

                disablebutton();

                return;

            }

            if (label1.Text.StartsWith("√"))
            {

                string numberstring = label1.Text.Substring(1);

                double number = Convert.ToDouble(numberstring);


                if (number < 0)
                {

                    label1.Font = new Font("Segoe UI", 18, FontStyle.Bold);

                    label1.Text = "Invalid Input";
                    label2.Text = "Error";

                    disablebutton();

                    return;

                }

                firstnumber = number;

                label2.Text = "√" + Convert.ToString(firstnumber) + " ÷ ";

                label1.Text = "0";

                process = "/";

                firstnumber = Math.Sqrt(number);
            }

            else
            {

                firstnumber = Convert.ToDouble(label1.Text);

                label2.Text = Convert.ToString(firstnumber) + " ÷ ";

                label1.Text = "0";

                process = "/";


            }
        }

        private void xbutton_Click(object sender, EventArgs e)
        {

            if (processCompleted)
            {
                firstnumber = 0;
                secondnumber = 0;
                process = "";
                processCompleted = false;
            }

            if (label1.Text == "√")
            {

                label1.Text = "Invalid Input";
                label2.Text = "Error";

                disablebutton();

                return;

            }

            if (label1.Text.StartsWith("√"))
            {

                string numberstring = label1.Text.Substring(1);

                double number = Convert.ToDouble(numberstring);


                if (number < 0)
                {

                    label1.Font = new Font("Segoe UI", 18, FontStyle.Bold);

                    label1.Text = "Invalid Input";
                    label2.Text = "Error";

                    disablebutton();

                    return;

                }

                firstnumber = number;

                label2.Text = "√" + Convert.ToString(firstnumber) + " x ";

                label1.Text = "0";

                process = "x";

                firstnumber = Math.Sqrt(number);
            }

            else
            {

                firstnumber = Convert.ToDouble(label1.Text);

                label2.Text = Convert.ToString(firstnumber) + " x ";

                label1.Text = "0";

                process = "x";

            }
        }

        private void buttoncomma_Click(object sender, EventArgs e)
        {

            var culture = new CultureInfo("tr-TR");

            if (label1.Text == "√" || label1.Text == "√,")
            {

                return;

            }

            if (label1.Text.StartsWith("√"))
            {

                string sqrtNumber = label1.Text.Substring(1);

                if (!sqrtNumber.Contains(",") && double.TryParse(sqrtNumber + "0", out _))
                {
                    label1.Text += ",";
                }
            }

            else
            {

                if (!label1.Text.Contains(",") && double.TryParse(label1.Text + "0", out _))
                {

                    label1.Text += ",";

                }
            }
        }

        private void sqrtbutton_Click(object sender, EventArgs e)
        {

            if (label1.Text == "Invalid Input" || label1.Text == "Cannot Be Divided By Zero")
            {
                return;
            }
                
            if (processCompleted)
            {
                label1.Text = "√";
                label2.Text = "";
                processCompleted = false;
                return;
            }

            if (!label1.Text.StartsWith("√"))
            {
                
                if (label1.Text == "0")
                {
                    label1.Text = "√";
                }

                else
                {
                    label1.Text = "√" + label1.Text;
                }
            }      
        }
        private void xybutton_Click(object sender, EventArgs e)
        {

            if (label1.Text == "Invalid Input" || label1.Text == "Cannot Be Divided By Zero")
            {

                return;

            }

            if (processCompleted)
            {
                firstnumber = 0;
                secondnumber = 0;
                process = "";
                processCompleted = false;
            }

            if (label1.Text == "√")
            {

                label1.Text = "Invalid Input";
                label2.Text = "Error";

                disablebutton();

                return;

            }

            if (label1.Text.StartsWith("√"))
            {

                string numberstring = label1.Text.Substring(1);
                double number = Convert.ToDouble(numberstring);

                if (number < 0)
                {

                    label1.Text = "Invalid Input";
                    label2.Text = "Error";
                    disablebutton();
                    return;

                }

                firstnumber = Math.Sqrt(number);
                label2.Text = "√" + numberstring + " ^ ";
            }

            else
            {

                firstnumber = Convert.ToDouble(label1.Text);
                label2.Text = label1.Text + " ^ ";

            }

            label1.Text = "0";
            process = "xy";

        }
    }
}
