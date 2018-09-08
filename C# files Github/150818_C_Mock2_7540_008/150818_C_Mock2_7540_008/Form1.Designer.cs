namespace _150818_C_Mock2_7540_008
{
    partial class Form1
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
            this.lblEuroFlight = new System.Windows.Forms.Label();
            this.lblExchangeRate = new System.Windows.Forms.Label();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.txtCostLondon = new System.Windows.Forms.TextBox();
            this.txtCostManchester = new System.Windows.Forms.TextBox();
            this.txtCostLiverpool = new System.Windows.Forms.TextBox();
            this.txtCostNewcastle = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBaggage = new System.Windows.Forms.GroupBox();
            this.radExtra = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.grpUkCities = new System.Windows.Forms.GroupBox();
            this.radNewcastle = new System.Windows.Forms.RadioButton();
            this.radLiverpool = new System.Windows.Forms.RadioButton();
            this.radManchester = new System.Windows.Forms.RadioButton();
            this.radLondon = new System.Windows.Forms.RadioButton();
            this.lblcostPerFlight = new System.Windows.Forms.Label();
            this.chkboxReturnFlight = new System.Windows.Forms.CheckBox();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblCostnoVat = new System.Windows.Forms.Label();
            this.lblCostPlusVat = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.dateDeparture = new System.Windows.Forms.DateTimePicker();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblGBP1 = new System.Windows.Forms.Label();
            this.lblGBp2 = new System.Windows.Forms.Label();
            this.txtCostexVatGBP = new System.Windows.Forms.TextBox();
            this.txtCostInclVatGBP = new System.Windows.Forms.TextBox();
            this.txtCostExclVatEuro = new System.Windows.Forms.TextBox();
            this.txtCostInclVatEuro = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menStrpFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menStrpExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEuro1 = new System.Windows.Forms.Label();
            this.lblEuro2 = new System.Windows.Forms.Label();
            this.grpBaggage.SuspendLayout();
            this.grpUkCities.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEuroFlight
            // 
            this.lblEuroFlight.AutoSize = true;
            this.lblEuroFlight.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroFlight.ForeColor = System.Drawing.Color.Red;
            this.lblEuroFlight.Location = new System.Drawing.Point(335, 20);
            this.lblEuroFlight.Name = "lblEuroFlight";
            this.lblEuroFlight.Size = new System.Drawing.Size(132, 26);
            this.lblEuroFlight.TabIndex = 0;
            this.lblEuroFlight.Text = "Euro Flight";
            this.lblEuroFlight.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblExchangeRate
            // 
            this.lblExchangeRate.AutoSize = true;
            this.lblExchangeRate.Location = new System.Drawing.Point(200, 46);
            this.lblExchangeRate.Name = "lblExchangeRate";
            this.lblExchangeRate.Size = new System.Drawing.Size(91, 13);
            this.lblExchangeRate.TabIndex = 1;
            this.lblExchangeRate.Text = "Exchange rate £1";
            // 
            // txtExchange
            // 
            this.txtExchange.Location = new System.Drawing.Point(304, 46);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.Size = new System.Drawing.Size(100, 20);
            this.txtExchange.TabIndex = 2;
            this.txtExchange.Text = "1.25";
            this.txtExchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCostLondon
            // 
            this.txtCostLondon.Location = new System.Drawing.Point(304, 100);
            this.txtCostLondon.Name = "txtCostLondon";
            this.txtCostLondon.Size = new System.Drawing.Size(100, 20);
            this.txtCostLondon.TabIndex = 3;
            this.txtCostLondon.Text = "50.00";
            this.txtCostLondon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCostManchester
            // 
            this.txtCostManchester.Location = new System.Drawing.Point(304, 126);
            this.txtCostManchester.Name = "txtCostManchester";
            this.txtCostManchester.Size = new System.Drawing.Size(100, 20);
            this.txtCostManchester.TabIndex = 4;
            this.txtCostManchester.Text = "70.00";
            this.txtCostManchester.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCostLiverpool
            // 
            this.txtCostLiverpool.Location = new System.Drawing.Point(304, 152);
            this.txtCostLiverpool.Name = "txtCostLiverpool";
            this.txtCostLiverpool.Size = new System.Drawing.Size(100, 20);
            this.txtCostLiverpool.TabIndex = 5;
            this.txtCostLiverpool.Text = "75.00";
            this.txtCostLiverpool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCostNewcastle
            // 
            this.txtCostNewcastle.Location = new System.Drawing.Point(304, 178);
            this.txtCostNewcastle.Name = "txtCostNewcastle";
            this.txtCostNewcastle.Size = new System.Drawing.Size(100, 20);
            this.txtCostNewcastle.TabIndex = 6;
            this.txtCostNewcastle.Text = "60.00";
            this.txtCostNewcastle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(318, 415);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(613, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBaggage
            // 
            this.grpBaggage.Controls.Add(this.radExtra);
            this.grpBaggage.Controls.Add(this.radStandard);
            this.grpBaggage.Location = new System.Drawing.Point(613, 89);
            this.grpBaggage.Name = "grpBaggage";
            this.grpBaggage.Size = new System.Drawing.Size(160, 126);
            this.grpBaggage.TabIndex = 9;
            this.grpBaggage.TabStop = false;
            this.grpBaggage.Text = "Baggage";
            // 
            // radExtra
            // 
            this.radExtra.AutoSize = true;
            this.radExtra.Location = new System.Drawing.Point(22, 56);
            this.radExtra.Name = "radExtra";
            this.radExtra.Size = new System.Drawing.Size(49, 17);
            this.radExtra.TabIndex = 1;
            this.radExtra.TabStop = true;
            this.radExtra.Text = "Extra";
            this.radExtra.UseVisualStyleBackColor = true;
            this.radExtra.CheckedChanged += new System.EventHandler(this.radExtra_CheckedChanged);
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Location = new System.Drawing.Point(22, 20);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(68, 17);
            this.radStandard.TabIndex = 0;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            this.radStandard.CheckedChanged += new System.EventHandler(this.radStandard_CheckedChanged);
            // 
            // grpUkCities
            // 
            this.grpUkCities.Controls.Add(this.radNewcastle);
            this.grpUkCities.Controls.Add(this.radLiverpool);
            this.grpUkCities.Controls.Add(this.radManchester);
            this.grpUkCities.Controls.Add(this.radLondon);
            this.grpUkCities.Location = new System.Drawing.Point(51, 89);
            this.grpUkCities.Name = "grpUkCities";
            this.grpUkCities.Size = new System.Drawing.Size(109, 118);
            this.grpUkCities.TabIndex = 10;
            this.grpUkCities.TabStop = false;
            this.grpUkCities.Text = "UK Cities";
            // 
            // radNewcastle
            // 
            this.radNewcastle.AutoSize = true;
            this.radNewcastle.Location = new System.Drawing.Point(6, 83);
            this.radNewcastle.Name = "radNewcastle";
            this.radNewcastle.Size = new System.Drawing.Size(75, 17);
            this.radNewcastle.TabIndex = 3;
            this.radNewcastle.TabStop = true;
            this.radNewcastle.Text = "Newcastle";
            this.radNewcastle.UseVisualStyleBackColor = true;
            this.radNewcastle.CheckedChanged += new System.EventHandler(this.radNewcastle_CheckedChanged);
            // 
            // radLiverpool
            // 
            this.radLiverpool.AutoSize = true;
            this.radLiverpool.Location = new System.Drawing.Point(7, 60);
            this.radLiverpool.Name = "radLiverpool";
            this.radLiverpool.Size = new System.Drawing.Size(68, 17);
            this.radLiverpool.TabIndex = 2;
            this.radLiverpool.TabStop = true;
            this.radLiverpool.Text = "Liverpool";
            this.radLiverpool.UseVisualStyleBackColor = true;
            this.radLiverpool.CheckedChanged += new System.EventHandler(this.radLiverpool_CheckedChanged);
            // 
            // radManchester
            // 
            this.radManchester.AutoSize = true;
            this.radManchester.Location = new System.Drawing.Point(7, 36);
            this.radManchester.Name = "radManchester";
            this.radManchester.Size = new System.Drawing.Size(81, 17);
            this.radManchester.TabIndex = 1;
            this.radManchester.TabStop = true;
            this.radManchester.Text = "Manchester";
            this.radManchester.UseVisualStyleBackColor = true;
            this.radManchester.CheckedChanged += new System.EventHandler(this.radManchester_CheckedChanged);
            // 
            // radLondon
            // 
            this.radLondon.AutoSize = true;
            this.radLondon.Location = new System.Drawing.Point(7, 12);
            this.radLondon.Name = "radLondon";
            this.radLondon.Size = new System.Drawing.Size(61, 17);
            this.radLondon.TabIndex = 0;
            this.radLondon.TabStop = true;
            this.radLondon.Text = "London";
            this.radLondon.UseVisualStyleBackColor = true;
            this.radLondon.CheckedChanged += new System.EventHandler(this.radLondon_CheckedChanged);
            // 
            // lblcostPerFlight
            // 
            this.lblcostPerFlight.AutoSize = true;
            this.lblcostPerFlight.Location = new System.Drawing.Point(315, 84);
            this.lblcostPerFlight.Name = "lblcostPerFlight";
            this.lblcostPerFlight.Size = new System.Drawing.Size(71, 13);
            this.lblcostPerFlight.TabIndex = 11;
            this.lblcostPerFlight.Text = "Cost per flight";
            // 
            // chkboxReturnFlight
            // 
            this.chkboxReturnFlight.AutoSize = true;
            this.chkboxReturnFlight.Location = new System.Drawing.Point(51, 255);
            this.chkboxReturnFlight.Name = "chkboxReturnFlight";
            this.chkboxReturnFlight.Size = new System.Drawing.Size(83, 17);
            this.chkboxReturnFlight.TabIndex = 12;
            this.chkboxReturnFlight.Text = "Return flight";
            this.chkboxReturnFlight.UseVisualStyleBackColor = true;
            this.chkboxReturnFlight.CheckedChanged += new System.EventHandler(this.chkboxReturnFlight_CheckedChanged);
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(167, 268);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(76, 13);
            this.lblDeparture.TabIndex = 13;
            this.lblDeparture.Text = "departure date";
            // 
            // lblCostnoVat
            // 
            this.lblCostnoVat.AutoSize = true;
            this.lblCostnoVat.Location = new System.Drawing.Point(167, 302);
            this.lblCostnoVat.Name = "lblCostnoVat";
            this.lblCostnoVat.Size = new System.Drawing.Size(99, 13);
            this.lblCostnoVat.TabIndex = 15;
            this.lblCostnoVat.Text = "cost excluding VAT";
            // 
            // lblCostPlusVat
            // 
            this.lblCostPlusVat.AutoSize = true;
            this.lblCostPlusVat.Location = new System.Drawing.Point(167, 335);
            this.lblCostPlusVat.Name = "lblCostPlusVat";
            this.lblCostPlusVat.Size = new System.Drawing.Size(91, 13);
            this.lblCostPlusVat.TabIndex = 16;
            this.lblCostPlusVat.Text = "cost including Vat";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(468, 268);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(58, 13);
            this.lblReturn.TabIndex = 17;
            this.lblReturn.Text = "return date";
            // 
            // dateReturn
            // 
            this.dateReturn.Location = new System.Drawing.Point(532, 262);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(177, 20);
            this.dateReturn.TabIndex = 18;
            this.dateReturn.ValueChanged += new System.EventHandler(this.dateReturn_ValueChanged);
            // 
            // dateDeparture
            // 
            this.dateDeparture.Location = new System.Drawing.Point(264, 262);
            this.dateDeparture.Name = "dateDeparture";
            this.dateDeparture.Size = new System.Drawing.Size(143, 20);
            this.dateDeparture.TabIndex = 19;
            this.dateDeparture.ValueChanged += new System.EventHandler(this.dateDeparture_ValueChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(670, 299);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(670, 332);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.Yellow;
            this.lblOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(314, 386);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 19);
            this.lblOutput.TabIndex = 22;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGBP1
            // 
            this.lblGBP1.AutoSize = true;
            this.lblGBP1.Location = new System.Drawing.Point(378, 305);
            this.lblGBP1.Name = "lblGBP1";
            this.lblGBP1.Size = new System.Drawing.Size(29, 13);
            this.lblGBP1.TabIndex = 23;
            this.lblGBP1.Text = "GBP";
            // 
            // lblGBp2
            // 
            this.lblGBp2.AutoSize = true;
            this.lblGBp2.Location = new System.Drawing.Point(378, 337);
            this.lblGBp2.Name = "lblGBp2";
            this.lblGBp2.Size = new System.Drawing.Size(29, 13);
            this.lblGBp2.TabIndex = 24;
            this.lblGBp2.Text = "GBP";
            // 
            // txtCostexVatGBP
            // 
            this.txtCostexVatGBP.Enabled = false;
            this.txtCostexVatGBP.Location = new System.Drawing.Point(264, 302);
            this.txtCostexVatGBP.Name = "txtCostexVatGBP";
            this.txtCostexVatGBP.Size = new System.Drawing.Size(100, 20);
            this.txtCostexVatGBP.TabIndex = 25;
            this.txtCostexVatGBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCostInclVatGBP
            // 
            this.txtCostInclVatGBP.Enabled = false;
            this.txtCostInclVatGBP.Location = new System.Drawing.Point(264, 328);
            this.txtCostInclVatGBP.Name = "txtCostInclVatGBP";
            this.txtCostInclVatGBP.Size = new System.Drawing.Size(100, 20);
            this.txtCostInclVatGBP.TabIndex = 26;
            this.txtCostInclVatGBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCostExclVatEuro
            // 
            this.txtCostExclVatEuro.Enabled = false;
            this.txtCostExclVatEuro.Location = new System.Drawing.Point(481, 302);
            this.txtCostExclVatEuro.Name = "txtCostExclVatEuro";
            this.txtCostExclVatEuro.Size = new System.Drawing.Size(100, 20);
            this.txtCostExclVatEuro.TabIndex = 27;
            this.txtCostExclVatEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCostInclVatEuro
            // 
            this.txtCostInclVatEuro.Enabled = false;
            this.txtCostInclVatEuro.Location = new System.Drawing.Point(481, 332);
            this.txtCostInclVatEuro.Name = "txtCostInclVatEuro";
            this.txtCostInclVatEuro.Size = new System.Drawing.Size(100, 20);
            this.txtCostInclVatEuro.TabIndex = 28;
            this.txtCostInclVatEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(437, 46);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(36, 13);
            this.lblEuro.TabIndex = 29;
            this.lblEuro.Text = "Euro\'s";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menStrpFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menStrpFile
            // 
            this.menStrpFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menStrpExit});
            this.menStrpFile.Name = "menStrpFile";
            this.menStrpFile.Size = new System.Drawing.Size(37, 20);
            this.menStrpFile.Text = "File";
            // 
            // menStrpExit
            // 
            this.menStrpExit.Name = "menStrpExit";
            this.menStrpExit.Size = new System.Drawing.Size(92, 22);
            this.menStrpExit.Text = "Exit";
            this.menStrpExit.Click += new System.EventHandler(this.menStrpExit_Click);
            // 
            // lblEuro1
            // 
            this.lblEuro1.AutoSize = true;
            this.lblEuro1.Location = new System.Drawing.Point(587, 302);
            this.lblEuro1.Name = "lblEuro1";
            this.lblEuro1.Size = new System.Drawing.Size(28, 13);
            this.lblEuro1.TabIndex = 31;
            this.lblEuro1.Text = "euro";
            // 
            // lblEuro2
            // 
            this.lblEuro2.AutoSize = true;
            this.lblEuro2.Location = new System.Drawing.Point(587, 335);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(28, 13);
            this.lblEuro2.TabIndex = 32;
            this.lblEuro2.Text = "euro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEuro2);
            this.Controls.Add(this.lblEuro1);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.txtCostInclVatEuro);
            this.Controls.Add(this.txtCostExclVatEuro);
            this.Controls.Add(this.txtCostInclVatGBP);
            this.Controls.Add(this.txtCostexVatGBP);
            this.Controls.Add(this.lblGBp2);
            this.Controls.Add(this.lblGBP1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dateDeparture);
            this.Controls.Add(this.dateReturn);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblCostPlusVat);
            this.Controls.Add(this.lblCostnoVat);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.chkboxReturnFlight);
            this.Controls.Add(this.lblcostPerFlight);
            this.Controls.Add(this.grpUkCities);
            this.Controls.Add(this.grpBaggage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtCostNewcastle);
            this.Controls.Add(this.txtCostLiverpool);
            this.Controls.Add(this.txtCostManchester);
            this.Controls.Add(this.txtCostLondon);
            this.Controls.Add(this.txtExchange);
            this.Controls.Add(this.lblExchangeRate);
            this.Controls.Add(this.lblEuroFlight);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBaggage.ResumeLayout(false);
            this.grpBaggage.PerformLayout();
            this.grpUkCities.ResumeLayout(false);
            this.grpUkCities.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuroFlight;
        private System.Windows.Forms.Label lblExchangeRate;
        private System.Windows.Forms.TextBox txtExchange;
        private System.Windows.Forms.TextBox txtCostLondon;
        private System.Windows.Forms.TextBox txtCostManchester;
        private System.Windows.Forms.TextBox txtCostLiverpool;
        private System.Windows.Forms.TextBox txtCostNewcastle;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBaggage;
        private System.Windows.Forms.RadioButton radExtra;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.GroupBox grpUkCities;
        private System.Windows.Forms.RadioButton radNewcastle;
        private System.Windows.Forms.RadioButton radLiverpool;
        private System.Windows.Forms.RadioButton radManchester;
        private System.Windows.Forms.RadioButton radLondon;
        private System.Windows.Forms.Label lblcostPerFlight;
        private System.Windows.Forms.CheckBox chkboxReturnFlight;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblCostnoVat;
        private System.Windows.Forms.Label lblCostPlusVat;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.DateTimePicker dateReturn;
        private System.Windows.Forms.DateTimePicker dateDeparture;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblGBP1;
        private System.Windows.Forms.Label lblGBp2;
        private System.Windows.Forms.TextBox txtCostexVatGBP;
        private System.Windows.Forms.TextBox txtCostInclVatGBP;
        private System.Windows.Forms.TextBox txtCostExclVatEuro;
        private System.Windows.Forms.TextBox txtCostInclVatEuro;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menStrpFile;
        private System.Windows.Forms.ToolStripMenuItem menStrpExit;
        private System.Windows.Forms.Label lblEuro1;
        private System.Windows.Forms.Label lblEuro2;
    }
}

