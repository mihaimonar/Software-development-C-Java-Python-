using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _200818_C_word_procesor_second
{
    public partial class Form1 : Form
    {
        String myFile = "X:\\SwDev13\\C# 25-06-18\\200818_C_Word_procesor_second\\200818_file_for_project.txt";
        string alltext = "";
        Boolean blnSaved = false;
        static List<string> myList = new List<string>();
        string stringFormatKeeper;
        public Form1()
        {
            InitializeComponent();
            richAlltext.ForeColor = Color.Black;
            richAlltext.Font = new Font("Tahoma", 12, FontStyle.Bold);

        }

        private void strFile_Click(object sender, EventArgs e)
        {

        }
        
        private async void strOpen_Click(object sender, EventArgs e)
        {
            //OpenFileDialog opfd = new OpenFileDialog();
            String line;
            richAlltext.Text = "";///we want the text box cleared from previous sesion when opening a file
            await Task.Delay(1000);////////////////////////////////////Time delay as i want the txt bx cleared when opening file
                                   //which is done a lline above but i want to see its been cleared cause if not it will clear and open the file so 
                                   //fast i won t see the clearing
                                   //cause on save 
            openFileDialog1.Filter = "rich text format files only (*.rtf)|*.rtf";//|text file format(*.txt)|*.txt";
            //
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)

                    richAlltext.LoadFile(openFileDialog1.FileName);//for some reasson it couldn t open some rtf files but could open other
                //..maybe they were corrupt
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            //if (opfd.ShowDialog() == DialogResult.OK)//this is another version of doing things and i have it in a previous project
            //{
            //    try
            //    {
            //        StreamReader sr = new StreamReader(opfd.FileName);
            //        while ((line = sr.ReadLine()) != null)
            //            richAlltext.Text = richAlltext.Text + line + "\r\n";
            //        //richAlltext.SelectionStart = richAlltext.Text.Length;
            //        //richAlltext.Focus();
            //        alltext = richAlltext.Text;//i need ths for he undo function when it goes back to go to the previous version of the text file
            //        //--i want this set up the moment the file was opened ,and if we write new stuff in it and want to undo it knows whats the 
            //        //the previous textptherwise alltext default is""
            //        sr.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void strSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefileAs = new SaveFileDialog();

            savefileAs.Filter = "Rich text File (*.rtf)|*.rtf";
            savefileAs.Title = "choose a title please";
            try
            {
                if (savefileAs.ShowDialog() == DialogResult.OK)
                    richAlltext.SaveFile(savefileAs.FileName, RichTextBoxStreamType.RichText);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //if (savefileAs.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {



            //        string name = savefileAs.FileName;
            //        // Write to the file name selected.
            //        // ... You can write the text from a TextBox instead of a string literal.
            //        File.WriteAllText(name, richAlltext.Text);

            //    }
            //    catch (Exception a)
            //    {
            //        MessageBox.Show("could not find file: " + a.Message);
            //    }
            //}
        }

        private void strCopy_Click(object sender, EventArgs e)
        {
            
            if (!richAlltext.SelectedText.Equals(""))
            {///will throw an error if empty,this protects it
                //Clipboard.SetText(richAlltext.SelectedText);
                richAlltext.Copy();
                
            }
        }

        private void strPaste_Click(object sender, EventArgs e)
        {
            richAlltext.Paste();///this function is more desired than the one with tyhe clipboard as it keeps the formating
            //if we copy bold and change text to italic it will paste bold,when the clipboard method will take the italic formating so this is beeetre
            richAlltext.Focus();
            richAlltext.SelectionStart = richAlltext.Text.Length;
            //if (Clipboard.ContainsText())
            //{

            // --don t need but usefull--   //richAlltext.Text += Clipboard.GetText(TextDataFormat.Text).ToString();//this adds to the end only
            //    //but bellow adds where the cursor is positioned
            //    string xx = Clipboard.GetText();

            //    //richAlltext.Text = richAlltext.Text.Insert(richAlltext.SelectionStart, xx);

            //    //richAlltext.Select(richAlltext.Text.Length , 0);--not usefull
            
            //-------------------------------the bellow thing is fuzzy and a bit worthless but can be usefull at times 
            //    /*richAlltext.Focus();//thsi is another way of puting the cursor at the end of the text
            //    int i = richAlltext.SelectionStart;///this holds to the position of the cursor as doing stuff to the text box will]
            //move the cursor---anyway 
            //    string xx = Clipboard.GetText();
            //    richAlltext.Text = richAlltext.Text.Insert(richAlltext.SelectionStart, xx);
            //    
            //    richAlltext.SelectionStart = i +xx.Length;//this same almost likerich.text.length if we paste at the end 
            //of the text,if we paste inside the text it takes the i position plus length of word and cursor will be at the end of the pasted word
            //which might want like that
            //    */-------------------------------------------------------------------------------------------------

            //}
        }

        private void strUndo_Click(object sender, EventArgs e)
        {//
            //richAlltext.Text = alltext;//undoes all the changes from the last version of the file to now
            //richAlltext.SelectionStart = richAlltext.Text.Length;
            //richAlltext.Focus();
            richAlltext.Undo();//undoes all the last change(last word i think\) to the text file
        }

        private void strClear_Click(object sender, EventArgs e)
        {
            richAlltext.Text = "";
        }

        private void strBold_Click(object sender, EventArgs e)
        {if(!richAlltext.Font.Bold)
            richAlltext.Font=     new Font(richAlltext.Font, FontStyle.Bold);
        else
            richAlltext.Font = new Font(richAlltext.Font, FontStyle.Regular);
        }

        private void strItalic_Click(object sender, EventArgs e)
        {
            if (!richAlltext.Font.Italic)
                richAlltext.Font = new Font(richAlltext.Font, FontStyle.Italic);
            else
                richAlltext.Font = new Font(richAlltext.Font, FontStyle.Regular);

        }

        private void strBlue_Click(object sender, EventArgs e)
        {
            if (!richAlltext.ForeColor.Equals(Color.Blue))
                richAlltext.ForeColor = Color.Blue;
            else
                richAlltext.ForeColor = Color.Black;
        }

        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void strDefault_Click(object sender, EventArgs e)
        {
            richAlltext.ForeColor = Color.Black;
            richAlltext.Font = new Font("Tahoma", 12, FontStyle.Bold);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            if (alltext != richAlltext.Text)///as long as we hav esome kind of input do the rest..
            {
                myList = richAlltext.Text.Split(new string[] { "\\n" }, StringSplitOptions.None).ToList();
                StreamWriter sw = null;// Holds address for StreamWriter. Reserves space in memory. 
                if (opfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        //Pass the filepath and filename to the StreamWriter Constructor. 
                        sw = new StreamWriter(opfd.FileName, false);// No need to create file C# does it for you. 
                                                                    // comma and true after file path allows for multiple entires of text.
                        //richAlltext.SaveFile(opfd.FileName,RichTextBoxStreamType.RichText);//alternative!!! to saving

                        for (int i = 0; i < myList.Count; i++) // Loops through the list
                            sw.WriteLine(myList[i]);           // Writes to file every item from the list.  
                                                               //Close the file                                                                                   //Write a line of text
                                                               //sw.write(txtOurText.Text) --writes a whole text at once,not line by line
                                                               //Close the file
                        alltext = richAlltext.Text;//updates the text string after we write it so if we ever want to undo the changes we 
                        //clear the richbox text if the content is diferent than the content of the alltext variable whcih holds the previous 
                        //file and it will make the richalltext=toalltext(so reversing it to thelast known saved version)
                        sw.Close();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("could not find file: " + a.Message);
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richAlltext.Focus();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)//i dragged from toolbox the openfiledialog an d double click it
            //alternatively u can create a openfiledialog instance by writing code as in the code in the open function but is comented out as i used another way of
            //opening files
        {

        }
    }
}
