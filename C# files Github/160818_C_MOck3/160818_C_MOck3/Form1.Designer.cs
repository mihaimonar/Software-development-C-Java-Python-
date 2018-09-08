namespace _160818_C_MOck3
{
    partial class frmEstimate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpNights = new System.Windows.Forms.GroupBox();
            this.rad4Nights = new System.Windows.Forms.RadioButton();
            this.rad3Nights = new System.Windows.Forms.RadioButton();
            this.rad2Nights = new System.Windows.Forms.RadioButton();
            this.rad1Night = new System.Windows.Forms.RadioButton();
            this.grpRoom = new System.Windows.Forms.GroupBox();
            this.radDouble = new System.Windows.Forms.RadioButton();
            this.radSingle = new System.Windows.Forms.RadioButton();
            this.lblHotelBooking = new System.Windows.Forms.Label();
            this.lblExchangRate = new System.Windows.Forms.Label();
            this.lblEuros = new System.Windows.Forms.Label();
            this.lblCostPerNight = new System.Windows.Forms.Label();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.txt1Night = new System.Windows.Forms.TextBox();
            this.txt2Nights = new System.Windows.Forms.TextBox();
            this.txt3Nights = new System.Windows.Forms.TextBox();
            this.txt4Nights = new System.Windows.Forms.TextBox();
            this.txtCostnoVatGBP = new System.Windows.Forms.TextBox();
            this.txtCostNoVatEuro = new System.Windows.Forms.TextBox();
            this.txtCostPlusVatGBP = new System.Windows.Forms.TextBox();
            this.txtCostPlusVatEuro = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGO = new System.Windows.Forms.Button();
            this.lblCostNOVatGBP = new System.Windows.Forms.Label();
            this.lblCostPlusVatGBP = new System.Windows.Forms.Label();
            this.lblGBP1 = new System.Windows.Forms.Label();
            this.lblGBP2 = new System.Windows.Forms.Label();
            this.lblEuro1 = new System.Windows.Forms.Label();
            this.lblEuro2 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpNights.SuspendLayout();
            this.grpRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(35, 20);
            this.menuFile.Text = "file";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(92, 22);
            this.menuExit.Text = "exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // grpNights
            // 
            this.grpNights.Controls.Add(this.rad4Nights);
            this.grpNights.Controls.Add(this.rad3Nights);
            this.grpNights.Controls.Add(this.rad2Nights);
            this.grpNights.Controls.Add(this.rad1Night);
            this.grpNights.Location = new System.Drawing.Point(30, 99);
            this.grpNights.Name = "grpNights";
            this.grpNights.Size = new System.Drawing.Size(175, 130);
            this.grpNights.TabIndex = 1;
            this.grpNights.TabStop = false;
            this.grpNights.Text = "Nights";
            // 
            // rad4Nights
            // 
            this.rad4Nights.AutoSize = true;
            this.rad4Nights.Location = new System.Drawing.Point(16, 94);
            this.rad4Nights.Name = "rad4Nights";
            this.rad4Nights.Size = new System.Drawing.Size(62, 17);
            this.rad4Nights.TabIndex = 3;
            this.rad4Nights.TabStop = true;
            this.rad4Nights.Text = "4 nights";
            this.rad4Nights.UseVisualStyleBackColor = true;
            this.rad4Nights.CheckedChanged += new System.EventHandler(this.rad4Nights_CheckedChanged);
            // 
            // rad3Nights
            // 
            this.rad3Nights.AutoSize = true;
            this.rad3Nights.Location = new System.Drawing.Point(16, 68);
            this.rad3Nights.Name = "rad3Nights";
            this.rad3Nights.Size = new System.Drawing.Size(62, 17);
            this.rad3Nights.TabIndex = 2;
            this.rad3Nights.TabStop = true;
            this.rad3Nights.Text = "3 nights";
            this.rad3Nights.UseVisualStyleBackColor = true;
            this.rad3Nights.CheckedChanged += new System.EventHandler(this.rad3Nights_CheckedChanged);
            // 
            // rad2Nights
            // 
            this.rad2Nights.AutoSize = true;
            this.rad2Nights.Location = new System.Drawing.Point(16, 44);
            this.rad2Nights.Name = "rad2Nights";
            this.rad2Nights.Size = new System.Drawing.Size(62, 17);
            this.rad2Nights.TabIndex = 1;
            this.rad2Nights.TabStop = true;
            this.rad2Nights.Text = "2 nights";
            this.rad2Nights.UseVisualStyleBackColor = true;
            this.rad2Nights.CheckedChanged += new System.EventHandler(this.rad2Nights_CheckedChanged);
            // 
            // rad1Night
            // 
            this.rad1Night.AutoSize = true;
            this.rad1Night.Location = new System.Drawing.Point(16, 20);
            this.rad1Night.Name = "rad1Night";
            this.rad1Night.Size = new System.Drawing.Size(57, 17);
            this.rad1Night.TabIndex = 0;
            this.rad1Night.TabStop = true;
            this.rad1Night.Text = "1 night";
            this.rad1Night.UseVisualStyleBackColor = true;
            this.rad1Night.CheckedChanged += new System.EventHandler(this.rad1Night_CheckedChanged);
            // 
            // grpRoom
            // 
            this.grpRoom.Controls.Add(this.radDouble);
            this.grpRoom.Controls.Add(this.radSingle);
            this.grpRoom.Location = new System.Drawing.Point(606, 99);
            this.grpRoom.Name = "grpRoom";
            this.grpRoom.Size = new System.Drawing.Size(173, 130);
            this.grpRoom.TabIndex = 2;
            this.grpRoom.TabStop = false;
            this.grpRoom.Text = "Room";
            this.grpRoom.Visible = false;
            // 
            // radDouble
            // 
            this.radDouble.AutoSize = true;
            this.radDouble.Location = new System.Drawing.Point(37, 57);
            this.radDouble.Name = "radDouble";
            this.radDouble.Size = new System.Drawing.Size(59, 17);
            this.radDouble.TabIndex = 1;
            this.radDouble.TabStop = true;
            this.radDouble.Text = "Double";
            this.radDouble.UseVisualStyleBackColor = true;
            this.radDouble.Visible = false;
            this.radDouble.CheckedChanged += new System.EventHandler(this.radDouble_CheckedChanged);
            // 
            // radSingle
            // 
            this.radSingle.AutoSize = true;
            this.radSingle.Location = new System.Drawing.Point(37, 31);
            this.radSingle.Name = "radSingle";
            this.radSingle.Size = new System.Drawing.Size(54, 17);
            this.radSingle.TabIndex = 0;
            this.radSingle.TabStop = true;
            this.radSingle.Text = "Single";
            this.radSingle.UseVisualStyleBackColor = true;
            this.radSingle.Visible = false;
            this.radSingle.CheckedChanged += new System.EventHandler(this.radSingle_CheckedChanged);
            // 
            // lblHotelBooking
            // 
            this.lblHotelBooking.AutoSize = true;
            this.lblHotelBooking.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelBooking.ForeColor = System.Drawing.Color.Red;
            this.lblHotelBooking.Location = new System.Drawing.Point(315, 24);
            this.lblHotelBooking.Name = "lblHotelBooking";
            this.lblHotelBooking.Size = new System.Drawing.Size(157, 26);
            this.lblHotelBooking.TabIndex = 3;
            this.lblHotelBooking.Text = "Hotel booking";
            // 
            // lblExchangRate
            // 
            this.lblExchangRate.AutoSize = true;
            this.lblExchangRate.Location = new System.Drawing.Point(253, 68);
            this.lblExchangRate.Name = "lblExchangRate";
            this.lblExchangRate.Size = new System.Drawing.Size(76, 13);
            this.lblExchangRate.TabIndex = 4;
            this.lblExchangRate.Text = "Exchange rate";
            // 
            // lblEuros
            // 
            this.lblEuros.AutoSize = true;
            this.lblEuros.Location = new System.Drawing.Point(437, 71);
            this.lblEuros.Name = "lblEuros";
            this.lblEuros.Size = new System.Drawing.Size(35, 13);
            this.lblEuros.TabIndex = 5;
            this.lblEuros.Text = "euro\'s";
            // 
            // lblCostPerNight
            // 
            this.lblCostPerNight.AutoSize = true;
            this.lblCostPerNight.Location = new System.Drawing.Point(348, 99);
            this.lblCostPerNight.Name = "lblCostPerNight";
            this.lblCostPerNight.Size = new System.Drawing.Size(71, 13);
            this.lblCostPerNight.TabIndex = 6;
            this.lblCostPerNight.Text = "cost per night";
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Location = new System.Drawing.Point(331, 68);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(100, 20);
            this.txtExchangeRate.TabIndex = 7;
            this.txtExchangeRate.Text = "uuu";
            this.txtExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExchangeRate.TextChanged += new System.EventHandler(this.txtExchangeRate_TextChanged);
            // 
            // txt1Night
            // 
            this.txt1Night.Location = new System.Drawing.Point(331, 119);
            this.txt1Night.Name = "txt1Night";
            this.txt1Night.Size = new System.Drawing.Size(100, 20);
            this.txt1Night.TabIndex = 8;
            this.txt1Night.Text = "50.00";
            this.txt1Night.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt1Night.TextChanged += new System.EventHandler(this.txt1Night_TextChanged);
            // 
            // txt2Nights
            // 
            this.txt2Nights.Location = new System.Drawing.Point(331, 143);
            this.txt2Nights.Name = "txt2Nights";
            this.txt2Nights.Size = new System.Drawing.Size(100, 20);
            this.txt2Nights.TabIndex = 9;
            this.txt2Nights.Text = "aa";
            this.txt2Nights.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt2Nights.TextChanged += new System.EventHandler(this.txt2Nights_TextChanged);
            // 
            // txt3Nights
            // 
            this.txt3Nights.Location = new System.Drawing.Point(331, 169);
            this.txt3Nights.Name = "txt3Nights";
            this.txt3Nights.Size = new System.Drawing.Size(100, 20);
            this.txt3Nights.TabIndex = 10;
            this.txt3Nights.Text = "130.00";
            this.txt3Nights.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt3Nights.TextChanged += new System.EventHandler(this.txt3Nights_TextChanged);
            // 
            // txt4Nights
            // 
            this.txt4Nights.Location = new System.Drawing.Point(331, 192);
            this.txt4Nights.Name = "txt4Nights";
            this.txt4Nights.Size = new System.Drawing.Size(100, 20);
            this.txt4Nights.TabIndex = 11;
            this.txt4Nights.Text = "160.00";
            this.txt4Nights.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt4Nights.TextChanged += new System.EventHandler(this.txt4Nights_TextChanged);
            // 
            // txtCostnoVatGBP
            // 
            this.txtCostnoVatGBP.Enabled = false;
            this.txtCostnoVatGBP.Location = new System.Drawing.Point(243, 290);
            this.txtCostnoVatGBP.Name = "txtCostnoVatGBP";
            this.txtCostnoVatGBP.Size = new System.Drawing.Size(100, 20);
            this.txtCostnoVatGBP.TabIndex = 12;
            this.txtCostnoVatGBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostnoVatGBP.Visible = false;
            // 
            // txtCostNoVatEuro
            // 
            this.txtCostNoVatEuro.Enabled = false;
            this.txtCostNoVatEuro.Location = new System.Drawing.Point(431, 290);
            this.txtCostNoVatEuro.Name = "txtCostNoVatEuro";
            this.txtCostNoVatEuro.Size = new System.Drawing.Size(100, 20);
            this.txtCostNoVatEuro.TabIndex = 13;
            this.txtCostNoVatEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostNoVatEuro.Visible = false;
            // 
            // txtCostPlusVatGBP
            // 
            this.txtCostPlusVatGBP.Enabled = false;
            this.txtCostPlusVatGBP.Location = new System.Drawing.Point(243, 334);
            this.txtCostPlusVatGBP.Name = "txtCostPlusVatGBP";
            this.txtCostPlusVatGBP.Size = new System.Drawing.Size(100, 20);
            this.txtCostPlusVatGBP.TabIndex = 14;
            this.txtCostPlusVatGBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostPlusVatGBP.Visible = false;
            // 
            // txtCostPlusVatEuro
            // 
            this.txtCostPlusVatEuro.Enabled = false;
            this.txtCostPlusVatEuro.Location = new System.Drawing.Point(431, 334);
            this.txtCostPlusVatEuro.Name = "txtCostPlusVatEuro";
            this.txtCostPlusVatEuro.Size = new System.Drawing.Size(100, 20);
            this.txtCostPlusVatEuro.TabIndex = 15;
            this.txtCostPlusVatEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostPlusVatEuro.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(669, 286);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Visible = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(669, 334);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(669, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(397, 378);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(75, 23);
            this.btnGO.TabIndex = 19;
            this.btnGO.Text = "go";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // lblCostNOVatGBP
            // 
            this.lblCostNOVatGBP.AutoSize = true;
            this.lblCostNOVatGBP.Location = new System.Drawing.Point(145, 291);
            this.lblCostNOVatGBP.Name = "lblCostNOVatGBP";
            this.lblCostNOVatGBP.Size = new System.Drawing.Size(95, 13);
            this.lblCostNOVatGBP.TabIndex = 20;
            this.lblCostNOVatGBP.Text = "Cost excluding Vat";
            this.lblCostNOVatGBP.Visible = false;
            // 
            // lblCostPlusVatGBP
            // 
            this.lblCostPlusVatGBP.AutoSize = true;
            this.lblCostPlusVatGBP.Location = new System.Drawing.Point(145, 337);
            this.lblCostPlusVatGBP.Name = "lblCostPlusVatGBP";
            this.lblCostPlusVatGBP.Size = new System.Drawing.Size(92, 13);
            this.lblCostPlusVatGBP.TabIndex = 21;
            this.lblCostPlusVatGBP.Text = "Cost including Vat";
            this.lblCostPlusVatGBP.Visible = false;
            // 
            // lblGBP1
            // 
            this.lblGBP1.AutoSize = true;
            this.lblGBP1.Location = new System.Drawing.Point(349, 293);
            this.lblGBP1.Name = "lblGBP1";
            this.lblGBP1.Size = new System.Drawing.Size(29, 13);
            this.lblGBP1.TabIndex = 22;
            this.lblGBP1.Text = "GBP";
            this.lblGBP1.Visible = false;
            // 
            // lblGBP2
            // 
            this.lblGBP2.AutoSize = true;
            this.lblGBP2.Location = new System.Drawing.Point(351, 343);
            this.lblGBP2.Name = "lblGBP2";
            this.lblGBP2.Size = new System.Drawing.Size(29, 13);
            this.lblGBP2.TabIndex = 23;
            this.lblGBP2.Text = "GBP";
            this.lblGBP2.Visible = false;
            // 
            // lblEuro1
            // 
            this.lblEuro1.AutoSize = true;
            this.lblEuro1.Location = new System.Drawing.Point(537, 293);
            this.lblEuro1.Name = "lblEuro1";
            this.lblEuro1.Size = new System.Drawing.Size(28, 13);
            this.lblEuro1.TabIndex = 24;
            this.lblEuro1.Text = "euro";
            this.lblEuro1.Visible = false;
            // 
            // lblEuro2
            // 
            this.lblEuro2.AutoSize = true;
            this.lblEuro2.Location = new System.Drawing.Point(537, 337);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(28, 13);
            this.lblEuro2.TabIndex = 25;
            this.lblEuro2.Text = "euro";
            this.lblEuro2.Visible = false;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.Yellow;
            this.lblOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(239, 357);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(365, 19);
            this.lblOutput.TabIndex = 26;
            this.lblOutput.Text = "                                                                                 " +
    "        ";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutput.Visible = false;
            // 
            // frmEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblEuro2);
            this.Controls.Add(this.lblEuro1);
            this.Controls.Add(this.lblGBP2);
            this.Controls.Add(this.lblGBP1);
            this.Controls.Add(this.lblCostPlusVatGBP);
            this.Controls.Add(this.lblCostNOVatGBP);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCostPlusVatEuro);
            this.Controls.Add(this.txtCostPlusVatGBP);
            this.Controls.Add(this.txtCostNoVatEuro);
            this.Controls.Add(this.txtCostnoVatGBP);
            this.Controls.Add(this.txt4Nights);
            this.Controls.Add(this.txt3Nights);
            this.Controls.Add(this.txt2Nights);
            this.Controls.Add(this.txt1Night);
            this.Controls.Add(this.txtExchangeRate);
            this.Controls.Add(this.lblCostPerNight);
            this.Controls.Add(this.lblEuros);
            this.Controls.Add(this.lblExchangRate);
            this.Controls.Add(this.lblHotelBooking);
            this.Controls.Add(this.grpRoom);
            this.Controls.Add(this.grpNights);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "drive estimates";
            this.Load += new System.EventHandler(this.frmEstimate_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmEstimate_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpNights.ResumeLayout(false);
            this.grpNights.PerformLayout();
            this.grpRoom.ResumeLayout(false);
            this.grpRoom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.GroupBox grpNights;
        private System.Windows.Forms.RadioButton rad4Nights;
        private System.Windows.Forms.RadioButton rad3Nights;
        private System.Windows.Forms.RadioButton rad2Nights;
        private System.Windows.Forms.RadioButton rad1Night;
        private System.Windows.Forms.GroupBox grpRoom;
        private System.Windows.Forms.RadioButton radDouble;
        private System.Windows.Forms.RadioButton radSingle;
        private System.Windows.Forms.Label lblHotelBooking;
        private System.Windows.Forms.Label lblExchangRate;
        private System.Windows.Forms.Label lblEuros;
        private System.Windows.Forms.Label lblCostPerNight;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.TextBox txt1Night;
        private System.Windows.Forms.TextBox txt2Nights;
        private System.Windows.Forms.TextBox txt3Nights;
        private System.Windows.Forms.TextBox txt4Nights;
        private System.Windows.Forms.TextBox txtCostnoVatGBP;
        private System.Windows.Forms.TextBox txtCostNoVatEuro;
        private System.Windows.Forms.TextBox txtCostPlusVatGBP;
        private System.Windows.Forms.TextBox txtCostPlusVatEuro;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Label lblCostNOVatGBP;
        private System.Windows.Forms.Label lblCostPlusVatGBP;
        private System.Windows.Forms.Label lblGBP1;
        private System.Windows.Forms.Label lblGBP2;
        private System.Windows.Forms.Label lblEuro1;
        private System.Windows.Forms.Label lblEuro2;
        private System.Windows.Forms.Label lblOutput;
    }
}

