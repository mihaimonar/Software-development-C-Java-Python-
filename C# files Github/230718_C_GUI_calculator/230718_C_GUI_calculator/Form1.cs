using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _230718_C_GUI_calculator
{
    public partial class Form1 : Form
    {
        static double total=0;
        static string operand="";//in doCalculations we have operand.equals,will fail if this is not initiated ,as only a initiated 
        //object has a method!!
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            updateText(btn5, txtResult);
        }


        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                doCalculations();//not sure it needs a try catch but
                //it will need to be the first operation performed in oreder to eveluate if theer was another operation before
                //it..if there wasn t then it will take the number in the text box and store in total(see docalculation() )
                //--if it sees that another operand was used before it then it will evaluate that operand to see if its -+/...
                //and will take the existing total and the text in the text box  and do the operation between them and
                //store it in total
            }
            catch (Exception) { }
            operand = "-";
            txtResult.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                doCalculations();
            }
            catch (Exception) { }
            operand = "*";
            txtResult.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
               doCalculations();
            }
            catch (Exception) { }
            operand = "/";
            txtResult.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            doCalculations();//if we do 2*3*=..this will calculate the 2*3=6 and then try to do 6*"" which will fail and 
            //go in the catch of doCalculations where everything will be reset and a mess will appear in teh error box
            if (operand.Equals(""))//in the case we press = straight awway
            {
                txtResult.Text = "0";
                //txtErrorCheckMihai.Text="if equalssssss()"+operand+"0000";...a checker to see the value of the operand and 0000 after to see if operand was""
                //as that will make the oooostick to the previous string 
            }
            else
                txtResult.Text = total.ToString();
            operand = "=";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            txtResult.Text = "0";
            operand = "";//clears the operand
            txtErrorCheckMihai.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                doCalculations();
            }
            catch(Exception)
            {

            }
            operand = "+";
            txtResult.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            updateText(btn1, txtResult);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            updateText(btn2, txtResult);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            updateText(btn3, txtResult);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            updateText(btn4, txtResult);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            updateText(btn6, txtResult);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            updateText(btn7, txtResult);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            updateText(btn8, txtResult);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            updateText(btn9, txtResult);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            updateText(btn0, txtResult);
        }
        public  void updateText(Button btn,TextBox txt)

        {   if (operand.Equals("="))//if we did a computation and peressed = and we eneter another number after our result
                //was displayed we want everything reset basically and start a new calculation
                //if not just do nothing and continue bellow
            {
                txt.Text = "0";
                total = 0;
                operand = "";//resets operand cause this is done every tioje we wkey a number and operand still being=
                //it will reset the txt box and we cannot write multipl edigit numbers
            }
            //if (btn.Text.Equals("0") & (txt.Text.Equals("0")))
            //{ }//if this condition appear we don t want anything done as we don t want numbers like 0000 or 0132
            if (!btn.Text.Equals("0") & (txt.Text.Equals("0")))
            {
                txt.Text = btn.Text;
            }
            else if (!txt.Text.Equals("0"))
                txt.Text += btn.Text;
        }
        public  void doCalculations()
        {
            if (operand.Equals("+"))//if thre uisa operand already this means we have already 2 numvbers and we can calculate
                //i mean there are 2 numbers because this function is used in the add ,subtract,multiply...functions at the first line ..
                //so everytime we ress a +,-..buton it will execute doCalculations and check if there is a previous operand and if yes that means there are 2 numbers:
                //if 2+..then at this plus there is no previous operan and it will just store the 2 ; if 2+3- when it comes to - it sees a previous  operand +
                //and 2 numbers and it will add them and themn set the opernad to -.BUt if we have 2+3+= it will do 5+"" as do calculations is first in equals
                //and it will fail so thats where the txt box was becoming 0 as the catch was reseting everything in this case!
            {
                try
                {
                    total = total + Convert.ToDouble(txtResult.Text);
                    txtResult.Text = "";
                }
                catch(Exception)//clears everything if we do 2*= or 8+=..,and when we enter = it will clear th operand
                {
                    total = 0;
                    txtResult.Text = "0";
                    operand = "";//clears the operand
                    txtErrorCheckMihai.Text = "you didn t enter a number after operand";
                }
            }
            else if (operand.Equals("-"))
            {
                try
                {
                    total = total - Convert.ToDouble(txtResult.Text);
                    txtResult.Text = "";
                }
                catch (Exception)
                {
                    total = 0;
                    txtResult.Text = "0";
                    operand = "";//clears the operand
                    txtErrorCheckMihai.Text = "you didn t enter a number after operand";
                }
            }
            else if (operand.Equals("*"))
            {
                try
                {
                    total = total * Convert.ToDouble(txtResult.Text);
                    txtResult.Text = "";
                }
                catch (Exception)
                {
                    total = 0;
                    txtResult.Text = "0";
                    operand = "";//clears the operand
                    txtErrorCheckMihai.Text = "you didn t enter a number after operand";
                }
            }
            else if (operand.Equals("/") & !txtResult.Text.Equals("0"))
            {
                try
                {
                    total = total / Convert.ToDouble(txtResult.Text);
                    txtResult.Text = "";
                }
                catch (Exception)
                {
                    total = 0;
                    txtResult.Text = "0";
                    operand = "";//clears the operand
                    txtErrorCheckMihai.Text = "you didn t enter a number after operand";
                }
            }
            else if (operand.Equals(""))
                total = Convert.ToDouble(txtResult.Text);
            

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
