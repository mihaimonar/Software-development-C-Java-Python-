using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _160818_C_MOck3
{
    public partial class frmEstimate : Form
    {   // pnlDisplay.Visible = false;---we can also do this execercise using a panel which makes life easier
        //--we put the panel on the form,we add the butons to it and we can hide all the panel and make some butons visible
        //or one or two,and then we can hide the butons and make the panel visible and that will contain a lot butons,
        //spares us of the task of saying to multiple buttons to be visible or false independently and we can achievev taht
        //by only saying panel visible=true or false,of course some butons have to be disabled when we have it to true or enabled 
        //when we have it to false ///what we will achieve by doing this is a multipage efect as we have some butons
        //visible and some invisible and when we go to next page we make the first butons invisible and make
        //the second butons visible(or we can leave the first butons visible if we want them in both pages)
        //---i ll do an execercise only with pane4ls anyways,with no functionality
        string strNights = "";string strRoom = "";
        Boolean boolChecker = false;
        
        double dblExchangeRate; double dblnight1;double dblnight2;double dblnight3;double dblnight4;
        double dblCurenCost;
        public frmEstimate()
        {
            InitializeComponent();
            
            rad1Night.Checked = true;
           
            

        }

        private void rad1Night_CheckedChanged(object sender, EventArgs e)
        {
            BackToFirstPage();
            strNights = " 1 Night";
        }

        private void rad2Nights_CheckedChanged(object sender, EventArgs e)
        {
            BackToFirstPage();
            strNights = " 2 Nights";
        }

        private void rad3Nights_CheckedChanged(object sender, EventArgs e)
        {
            BackToFirstPage();
            strNights = " 3 Nights";
        }

        private void rad4Nights_CheckedChanged(object sender, EventArgs e)
        {
            BackToFirstPage();
            strNights = " 4 Nights";
        }

        private void radSingle_CheckedChanged(object sender, EventArgs e)
        {
            btnClear.PerformClick();
            strRoom = "Single room for";
        }

        private void radDouble_CheckedChanged(object sender, EventArgs e)
        {
            btnClear.PerformClick();
            strRoom = "Double room for";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {   
           
            double dblEuroNoVat;
            double dblGBPPlusVat;
            double dblEuroPlusVat;
            try
            {


                

                dblnight1 = Convert.ToDouble(txt1Night.Text);//try to convert before calculating in case we have letters
                dblnight2 = Convert.ToDouble(txt2Nights.Text);
                dblnight3 = Convert.ToDouble(txt3Nights.Text);
                dblnight4 = Convert.ToDouble(txt4Nights.Text);
                dblExchangeRate = Convert.ToDouble(txtExchangeRate.Text);

                if (rad1Night.Checked)
                    dblCurenCost = dblnight1;
                else if (rad2Nights.Checked)
                    dblCurenCost = dblnight2;
                else if (rad3Nights.Checked)
                    dblCurenCost = dblnight3;
                else if (rad4Nights.Checked)
                    dblCurenCost = dblnight4;

                if (radDouble.Checked)
                    dblCurenCost *= 1.3;
                dblEuroNoVat = dblCurenCost * dblExchangeRate;
                dblGBPPlusVat = dblCurenCost * 1.23;
                dblEuroPlusVat = dblGBPPlusVat * dblExchangeRate;
                txtCostnoVatGBP.Text = Convert.ToString(Math.Round(dblCurenCost, 2, MidpointRounding.ToEven));
                txtCostNoVatEuro.Text = Convert.ToString(Math.Round(dblEuroNoVat, 2, MidpointRounding.ToEven));
                txtCostPlusVatGBP.Text = Convert.ToString(Math.Round(dblGBPPlusVat, 2, MidpointRounding.ToEven));
                txtCostPlusVatEuro.Text = Convert.ToString(Math.Round(dblEuroPlusVat, 2, MidpointRounding.ToEven));
                lblOutput.BackColor = System.Drawing.Color.White;
                lblOutput.Text = strRoom + strNights;

                

            }
            catch (Exception)
            {
                MessageBox.Show("Data entered must be of numeric type", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            


            //txtCostexVatGBP.Text = Convert.ToString(Math.Round(dblCopyCurentcost, 2, MidpointRounding.ToEven));

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCostnoVatGBP.Text = "";
            txtCostNoVatEuro.Text = "";
            txtCostPlusVatGBP.Text = "";
            txtCostPlusVatEuro.Text = "";
            lblOutput.Text = "                                           ";
            lblOutput.BackColor = System.Drawing.Color.Yellow;
        }

        private void btnGO_Click(object sender, EventArgs e)
        {   //if all content of the text boxes is good then goes to next page,
            if (string.IsNullOrEmpty(txt1Night.Text) || string.IsNullOrEmpty(txt2Nights.Text) || string.IsNullOrEmpty(txt3Nights.Text)
                || string.IsNullOrEmpty(txt4Nights.Text) || string.IsNullOrEmpty(txtExchangeRate.Text))
                MessageBox.Show("Exchange rate or Prices not entered");
            else
            {
                boolChecker = true;
                lblExchangRate.Visible = false; txtExchangeRate.Visible = false; lblEuros.Visible = false;
                lblCostPerNight.Visible = false; txt1Night.Visible = false; txt2Nights.Visible = false; txt3Nights.Visible = false;
                txt4Nights.Visible = false; btnGO.Visible = false;
                grpRoom.Visible = true; radDouble.Visible = true; radSingle.Visible = true;
                lblCostNOVatGBP.Visible = true; txtCostnoVatGBP.Visible = true; lblGBP1.Visible = true; txtCostNoVatEuro.Visible = true;
                btnCalculate.Visible = true; lblEuro1.Visible = true;
                lblCostPlusVatGBP.Visible = true; txtCostPlusVatGBP.Visible = true; lblGBP2.Visible = true; txtCostPlusVatEuro.Visible = true;
                lblEuro2.Visible = true; btnClear.Visible = true; lblOutput.Visible = true;
                lblHotelBooking.ForeColor = System.Drawing.Color.Blue;
                radSingle.Checked = true;
                //rad1Night.Checked = true; don t want this cause this performs a click and performing a click will bring it back to the first page
                //cause changing a nights radio buton or checking it will throw us back to first page,especially if boolchecker=true,
                //cause everynight buton has a function that checks the boolchecker,we want to continue with the buton that is
                //selected in the first page and keep it same in the second,if we went back by pressing one o fthe nights button lets say
                //btn nights3 will bring us to first opage nights radio will be selected  and presing go and keeping this rad1 checked=true
                //will say to go back to page one cause it performs a click so it actually tyhrows us in a loop and we don t want that
                btnClear.PerformClick();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("are you sure you want to exit the program", "reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void BackToFirstPage()
        {
            if (boolChecker)
            {
                lblExchangRate.Visible = true; txtExchangeRate.Visible = true; lblEuros.Visible = true;
                lblCostPerNight.Visible = true; txt1Night.Visible = true; txt2Nights.Visible = true; txt3Nights.Visible = true;
                txt4Nights.Visible = true; btnGO.Visible = true;
                grpRoom.Visible = false; radDouble.Visible = false; radSingle.Visible = false;
                lblCostNOVatGBP.Visible = false; txtCostnoVatGBP.Visible = false; lblGBP1.Visible = false; txtCostNoVatEuro.Visible = false;
                btnCalculate.Visible = false; lblEuro1.Visible = false;
                lblCostPlusVatGBP.Visible = false; txtCostPlusVatGBP.Visible = false; lblGBP2.Visible = false; txtCostPlusVatEuro.Visible = false;
                lblEuro2.Visible = false; btnClear.Visible = false; lblOutput.Visible = false;
                lblHotelBooking.ForeColor = System.Drawing.Color.Red;
                
                boolChecker = false;
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            btnExit.PerformClick();

        }
        private void IsNumeric(TextBox textboxToCheck)
            //this will be put in the text boxes code and every time we cluick on them and change their content 
            //for every single click it works !,and will do this check if we actually have a number,but if we leave it empty
            //actually it will allow it(which is not good),but buton Go checks if tehy are empty so doesnt matter that much
        {
            try
            {
                if (textboxToCheck.Text != "")
                    double.Parse(textboxToCheck.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("Entries must be numeric");
                textboxToCheck.Text = "";
                textboxToCheck.Focus();
            }
        }

        private void txtExchangeRate_TextChanged(object sender, EventArgs e)
        {
            IsNumeric(txtExchangeRate);//is numeric won t let us input the wrong content when we try to change the 
            //curent text
        }

        private void txt1Night_TextChanged(object sender, EventArgs e)
        {
            IsNumeric(txt1Night);
        }

        private void txt2Nights_TextChanged(object sender, EventArgs e)
        {
            IsNumeric(txt2Nights);
        }

        private void txt3Nights_TextChanged(object sender, EventArgs e)
        {
            IsNumeric(txt3Nights);
        }

        private void txt4Nights_TextChanged(object sender, EventArgs e)
        {
            IsNumeric(txt4Nights);
        }

        private void frmEstimate_Load(object sender, EventArgs e)
        {
            

        }

        private void frmEstimate_MouseMove(object sender, MouseEventArgs e)
        {///this is an event...we cliuck on the form and go on the events buton and you sleelct what u want,
            //i wanted that when someone first moves the mouse to check all the boxes if they have 
            //the right default conntent ,if not to clear them and put the cursor on them(focus)
            //--if i was puting the is numeric in teh form load it will give me the warning message before 
            //it displays the form and i don t want that
            //i need to set up a boolean or counter to do this only for one mouse move!that boolean or counter have to be a class variable
            //as if its local it will clear every time
            ArrayList mylist = new ArrayList { txtExchangeRate, txt1Night, txt2Nights, txt3Nights, txt4Nights };
            for (int i = 0; i <mylist.Count; i++)
            {
                IsNumeric((TextBox)mylist[i]);//downcasting from Object to textbox
                
            }
           
        }
    }
}
