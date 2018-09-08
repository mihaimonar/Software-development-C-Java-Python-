
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author SwDev13
 */
public class FileOperations {
     public static boolean writeTOtextFile( ArrayList<Account_class_110618> listofaccounts){
        boolean blnSuccessFileWrite=true;///if we can t write to a fil ethen this becomes false
        //an we can use this boolean if we want to find out if tyhe writing opeartion was succesfull
        try{
            FileWriter fw=new FileWriter("C:\\Users\\SwDev13\\Desktop\\names.txt");
            BufferedWriter bw=new BufferedWriter(fw);
            for (int i = 0; i < listofaccounts.size();i++) {
                bw.write(listofaccounts.get(i).getAccount()+" "+
                        listofaccounts.get(i).getPin()+" "+
                        listofaccounts.get(i).getBalance()+" "+
                        listofaccounts.get(i).getBlocked());
                bw.newLine();
            }
            bw.close();
            fw.close();
            
            
        }
        catch(Exception e){
            blnSuccessFileWrite=false;
        }
        return blnSuccessFileWrite;
    }
    public static boolean ReadFromFile(ArrayList<Account_class_110618> myarray){
         ///gets an empty listv as argument
        String line = "";
        boolean blnSucessfullRead = true;
        myarray.clear();
        try {
            
            FileReader fileReader = new FileReader("C:\\Users\\SWDev13\\Desktop\\names.txt");

            
            BufferedReader bufferedReader = new BufferedReader(fileReader);
          

            while((line = bufferedReader.readLine()) != null) {
               Account_class_110618 acc=new Account_class_110618();
               String [] splitline=line.split(" ");
               acc.setAccount(splitline[0]);
               acc.setPin(splitline[1]);
               acc.setbalance(Double.parseDouble(splitline[2]));
               acc.setblnBlocked(Boolean.parseBoolean(splitline[3]));
               myarray.add(acc);
            }   

            // Always close files.
            bufferedReader.close();         
        }
        catch(FileNotFoundException ex) {
            System.out.println("Unable to open file");
            
            blnSucessfullRead = false;     //in case we cannot read file into a list we set this to false            
            
        }
        catch(IOException ex) {
            System.out.println("Error reading file ");   
            
            blnSucessfullRead = false;         //if we cannot read file        
            
            
        }
        return blnSucessfullRead;
    }
}
