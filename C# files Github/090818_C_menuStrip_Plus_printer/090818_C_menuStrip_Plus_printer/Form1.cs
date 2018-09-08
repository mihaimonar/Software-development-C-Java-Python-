using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _090818_C_menuStrip_Plus_printer
{
    public partial class Form1 : Form
    {
        String myFile = "X:\\SwDev13\\C# 25-06-18\\090818_C_menuStrip_Plus_printer\\myFile090818_C#_menustrip_print.txt";
        string alltext = "";
        Boolean blnSaved = false;
        static List<string> myList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private async void menuOpen_Click(object sender, EventArgs e)///contains async word for the time delay
        {
            OpenFileDialog opfd = new OpenFileDialog();
            String line;
            txtOurText.Text = "";///we want the text box cleared from previous sesion when opening a file
            await Task.Delay(1000);////////////////////////////////////Time delay as i want the txt bx cleared when opening file
            //which is done a lline above but i want to see its been cleared cause if not it will clear and open the file so 
            //fast i won t see the clearing
            //cause on save 
            if (opfd.ShowDialog() == DialogResult.OK)
                try
                {
                    StreamReader sr = new StreamReader(opfd.FileName);
                    while ((line = sr.ReadLine()) != null)
                        txtOurText.Text = txtOurText.Text + line + "\r\n";
                    sr.Close();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
           
            //try ///this is also good but i have this in the file reader ..avbove is  dereks approach
            //{
            //    //Pass the file path and file name to the StreamReader constructor
            //    StreamReader sr = new StreamReader(myFile);//this needs to be a file path at first as it will not find the file and give an error,
            //    //and the file needs to exist otherwise error!
            //    //--we can get away with providing the file path only  when we are writing as if there is no file it will create one 
            //    //but not when we are reading a file has to exist so in this case trying to read a nonexistent file it will fail
            //    //and give us a console warning or message box depending how we wrothe the except catch

            //    //Read the first line of text
            //    line = sr.ReadLine();

            //    //Continue to read until you reach end of file
            //    while (line != null)
            //    {
            //        //write the lie to console window
            //        txtOurText.Text+=line + "\n";
            //        alltext += line + "\n";
                    
            //        //Read the next line
            //        line = sr.ReadLine();
            //    }

            //    //close the file
            //    sr.Close();
            //    
            //}
            //catch (Exception a)
            //{
            //    MessageBox.Show("could not find file: " + a.Message);
            //}
            //finally
            //{
                //Console.WriteLine("Executing finally block.");
            //}
            

        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            if (alltext != txtOurText.Text)
            {
                myList = txtOurText.Text.Split(new string[] { "\\n" }, StringSplitOptions.None).ToList();
                StreamWriter sw = null;// Holds address for StreamWriter. Reserves space in memory. 
                if (opfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        //Pass the filepath and filename to the StreamWriter Constructor. 
                        sw = new StreamWriter(opfd.FileName, false);// No need to create file C# does it for you. 
                                                                    // comma and true after file path allows for multiple entires of text.
                        for (int i = 0; i < myList.Count; i++) // Loops through the list
                            sw.WriteLine(myList[i]);           // Writes to file every item from the list.  
                                                               //Close the file                                                                                   //Write a line of text
                        //sw.write(txtOurText.Text) --writes a whole text at once,not line by line
                        //Close the file
                        sw.Close();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("could not find file: " + a.Message);
                    }
                }
               
            }
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefileAs = new SaveFileDialog();
           
            savefileAs.Filter = "Text (*.txt)|*.txt| Word Doc(*.doc)|*.doc";
            savefileAs.Title = "choose a title please";
            
            if (savefileAs.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    
                    
                    string name = savefileAs.FileName;
                    // Write to the file name selected.
                    // ... You can write the text from a TextBox instead of a string literal.
                    File.WriteAllText(name, txtOurText.Text);
                    
                }
                catch (Exception a)
                {
                    MessageBox.Show("could not find file: " + a.Message);
                }
            }
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            menuSave_Click(null, null);
            Application.Exit();
        }

        private void menuPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocumentOnPrintPage;
            printDocument.Print();
        }
        private void printDocumentOnPrintPage(object sender,PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.txtOurText.Text, this.txtOurText.Font, Brushes.Black, 10, 25);
        }

        private void menuCopy_Click(object sender, EventArgs e)
        {
            if(!txtOurText.SelectedText.Equals(""))///will throw an error if empty,this protects it
                Clipboard.SetText(txtOurText.SelectedText);


        }

        private void cmdPaste_Click(object sender, EventArgs e) { 
          
        }

        private void menuPaste_Click(object sender, EventArgs e)
        {
        if (Clipboard.ContainsText())
        {
            
            txtOurText.Text+= Clipboard.GetText(TextDataFormat.Text).ToString();
        }
    }
    }
}
