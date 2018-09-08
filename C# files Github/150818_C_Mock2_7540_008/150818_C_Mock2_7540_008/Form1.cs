using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _150818_C_Mock2_7540_008
{
    public partial class Form1 : Form
    {   double dblCurentCost;
        double dblStandardBaggage = 10;
        double dblExtrabaggage = 15;
        string strCity = "London";
        string strBagagge = "standard baggage";
        string strReturnFlight = "single";
        string allStrings = "";
        double dblExchange;double dblLondon;double dblManchester;double dblLiverpool;double dblNewcastle;
        public Form1()
        {
            InitializeComponent();
            //because the first radio buton London will be automaticaly checheed it is bad advice to set a variable behind this buton
            //in our case the variable that wasn t set up if it was behind the radio was curentcost,but i moved it at the calculate function
            //as the other butons will need to be clicked and a click will be performed and it will execuete the code behind them
            //but because radio London(the first ) buton is already clicked we cant click on it as it is already checked=true
            //and will not run the code behind it (if a but is clicked already clicking on it will try again to set it 
            //to true but because it sees is already true it won t perform the click ...solution is to set the variable 
            ///behind that radio buton as defaul in init something like:
            //try{dblLondon=convert.todouble(txtLondon>to string and asign curentcost=dblLondon)
            //we can do that as the radioLondon is the default as it is highlighted automatically by the program,
            //if its a t the top of a gtoup box,or we can check it ourtselves in the init,or maybe better we can uncheck all the radios at the
            //start ,ythat would be ideal,so if the default tradio is lomndon then the curentcost ca be set to dblLondon
            //Catch{...you didn t provide a number}
            //---moral--behind the buton that is cliked set the things we want to happen when it is clicked a s default in the init()
            //as that button can not be clicked and we won t be able to ruyn the code behind that buton,we can click it though
            //if we switck to buton 2 and click again the buiton 1,but if we continuosly click 1 it will never happen,
            //
            chkboxReturnFlight.Visible = false;lblDeparture.Visible = false;dateDeparture.Visible = false;
            lblReturn.Visible = false;dateReturn.Visible = false;lblCostnoVat.Visible = false;txtCostexVatGBP.Visible = false;
            lblGBP1.Visible = false;
            txtCostExclVatEuro.Visible = false;lblEuro1.Visible = false;lblCostPlusVat.Visible = false;txtCostInclVatGBP.Visible = false;
            lblGBp2.Visible = false;txtCostInclVatEuro.Visible = false;lblEuro2.Visible = false;
            btnCalculate.Visible = false;btnClear.Visible = false;

            radLondon.Checked = true;
            radStandard.Checked = true;

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menStrpExit_Click(object sender, EventArgs e)
        {
            btnExit.PerformClick();
        }

        private void radLondon_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radManchester_CheckedChanged(object sender, EventArgs e)
        {
            strCity = "Manchester";
        }

        private void radLiverpool_CheckedChanged(object sender, EventArgs e)
        {
            strCity = "Liverpool";
        }

        private void radNewcastle_CheckedChanged(object sender, EventArgs e)
        {
            strCity = "Newcastle";
        }

        private void radStandard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radExtra_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkboxReturnFlight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxReturnFlight.Checked)
            {
                lblReturn.Visible = true;
                dateReturn.Visible = true;
            }
            else
            {
                dateReturn.Visible = false;
                lblReturn.Visible = false;
            }
        }

        private void dateDeparture_ValueChanged(object sender, EventArgs e)
        {
            if (dateReturn.Value.Date.CompareTo(dateDeparture.Value.Date) < 0)//checks if the return is smaller than 
                //departure
            {
                MessageBox.Show("departure date must be earlier than arrival date");
                dateDeparture.Value = System.DateTime.Now;
            }
        }

        private void dateReturn_ValueChanged(object sender, EventArgs e)
        {
            if (dateReturn.Value.Date.CompareTo(dateDeparture.Value.Date) < 0)
            {
                MessageBox.Show("Departure date must be earlier than arrival date");
                dateReturn.Value = System.DateTime.Now;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("london cost is" + dblLondon);
            if (radLondon.Checked)//because this is set as default as checked then if we leave these if s in the rad button s it won t set
                                  //the dblcurentcost to dblLondon because radlondon is checked and we don t need to press it,but
                                  //the seting of dblcurcost is done only when a click is performed so,i moved them here and it will 
                                  //do the check when calculate is pressed and will set our dblcurcost
                dblCurentCost = dblLondon;
            if (radManchester.Checked)
                dblCurentCost = dblManchester;
            Console.WriteLine("Manchester cost is" + dblManchester);
            if (radLiverpool.Checked)
                dblCurentCost = dblLiverpool;
            if (radNewcastle.Checked)
                dblCurentCost = dblNewcastle;
            double dblCopyCurentcost = dblCurentCost;
            if (chkboxReturnFlight.Checked == true)
            {
                dblCopyCurentcost = dblCopyCurentcost * 1.6;//..we don t want this as this will change our cost and if we press 
                //calculate again this will increase every time,we can store it in the display box directly
                strReturnFlight = "return";
            }
            if (radStandard.Checked)
                dblCopyCurentcost += dblStandardBaggage;
            else
            {
                dblCopyCurentcost += dblExtrabaggage;
                strBagagge = "extra baggage";
            }
            allStrings = strCity + " " + strReturnFlight + " with " + strBagagge;
            lblOutput.Text = allStrings;

            double dblCostPlusVatGBP = dblCopyCurentcost * 1.23;
            double dblcostEuroNoVat = dblCopyCurentcost * dblExchange;
            double dblcostEuroPlusVat = dblCostPlusVatGBP * dblExchange;
            txtCostexVatGBP.Text = Convert.ToString(Math.Round(dblCopyCurentcost, 2, MidpointRounding.ToEven));
            txtCostInclVatGBP.Text = Convert.ToString(Math.Round(dblCostPlusVatGBP, 2, MidpointRounding.ToEven));
            txtCostExclVatEuro.Text = Convert.ToString(Math.Round(dblcostEuroNoVat, 2, MidpointRounding.ToEven));
            txtCostInclVatEuro.Text = Convert.ToString(Math.Round(dblcostEuroPlusVat, 2, MidpointRounding.ToEven));



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCostexVatGBP.Text = "";
            txtCostInclVatGBP.Text = "";
            txtCostExclVatEuro.Text = "";
            txtCostInclVatEuro.Text = "";
            chkboxReturnFlight.Checked = false;//unchecks the chkbutton and brings us to the defauld state
        }

        private void btnGo_Click(object sender, EventArgs e)
        {   
            try
            {//mock3 project has a diferent aproach to checking textboxes content
                double numExchange=Convert.ToDouble(txtExchange.Text);
                double numLondon = Convert.ToDouble(txtCostLondon.Text);
                double numManchester = Convert.ToDouble(txtCostManchester.Text);
                double numLiverpool = Convert.ToDouble(txtCostLiverpool.Text);
                double numNewcastle = Convert.ToDouble(txtCostNewcastle.Text);
                dblExchange = numExchange;//a bit unecesary
                dblManchester = numManchester;
                dblLiverpool = numLiverpool;
                dblNewcastle = numNewcastle;
                dblLondon = numLondon;
               
                //if the above concersion succedes then it will show some butons andtxt and lables and hide some other ones
                //and if conversion fails then it won t do anything but show a error message
                chkboxReturnFlight.Visible = true; lblDeparture.Visible = true; dateDeparture.Visible = true;
                  lblCostnoVat.Visible = true; txtCostexVatGBP.Visible = true;
                lblGBP1.Visible = true;
                txtCostExclVatEuro.Visible = true; lblEuro1.Visible = true; lblCostPlusVat.Visible = true; txtCostInclVatGBP.Visible = true;
                lblGBp2.Visible = true; txtCostInclVatEuro.Visible = true; lblEuro2.Visible = true;
                btnCalculate.Visible = true; btnClear.Visible = true;
                lblEuroFlight.ForeColor= System.Drawing.Color.Blue;
                ///hiding some fields
                lblExchangeRate.Visible = false;txtExchange.Visible = false;lblEuro.Visible = false;
                lblcostPerFlight.Visible = false;txtCostLondon.Visible = false;txtCostLiverpool.Visible = false;
                txtCostNewcastle.Visible = false;txtCostManchester.Visible = false;

            }
            catch(Exception)
            {
                MessageBox.Show("Exchange rate or prices not entered","Reminder",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("are you sure you want to exit the program", "reminder", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
