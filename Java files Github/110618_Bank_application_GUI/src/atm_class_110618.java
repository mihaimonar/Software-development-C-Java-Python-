/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author SwDev13
 */
import java.util.ArrayList;
public class atm_class_110618 {
    ArrayList<Account_class_110618> listOfAccounts=new ArrayList<>();
    private Account_class_110618 CustomerAccount;
    public atm_class_110618(){
        /*Account_class_110618 acc1=new Account_class_110618();
        Account_class_110618 acc2=new Account_class_110618();
        Account_class_110618 acc3=new Account_class_110618();
        Account_class_110618 acc4=new Account_class_110618();
        acc1.setAccount("00245");
        acc1.setPin("1234");
        acc1.setbalance(2000);
        acc1.setblnBlocked(false);
        listOfAccounts.add(acc1);
        
        acc2.setAccount("00246");
        acc2.setPin("2345");
        acc2.setbalance(50000);
        acc2.setblnBlocked(true);
        listOfAccounts.add(acc2);
        
        acc3.setAccount("00247");
        acc3.setPin("3456");
        acc3.setbalance(500);
        acc3.setblnBlocked(false);
        listOfAccounts.add(acc3);
        
        acc4.setAccount("00248");
        acc4.setPin("4567");
        acc4.setbalance(200);
        acc4.setblnBlocked(false);
        listOfAccounts.add(acc4); 
        
       FileOperations.writeTOtextFile(listOfAccounts);//writes the data to a file only 
       //because the acounts are created with code above ...we don t want this version though
        //because every time we login and go in the menu a instancve of the atm is created which populates this 
        //data all the time,so if we widraw money from all these accounts when we login again they will show again the initial value
        //and same if we add money they will be same as the default...
        
        
        !!!------------------------------------------------------------------------------------------------------------!!
        //--what we want is to read them from a file ,perform withdraw or deposit and then go to that file and 
        //overite all the accounts again...and we do that when we exit from the menu as this is the last action 
        //so on the exit button we place the writeto file function!!!
        -------------------------------------------------------------------------------------------------------------------
        
        
        
        
        */
        ///---------------bellow a text was created first and then the account swill be created and added to a list
       //--------------------------------------------------------------------------------------------------------------------
       FileOperations.ReadFromFile(listOfAccounts);//getting data from a file where we inputed 
       //everything in the order bellow with spaces between them
       //spaces between the account pin balance getblocked..exactly in this order!
       //and this will create an account object for every row in that file ...of course
       //there must be some condition stio check if the line sfrom that file all have the right amount and type
       //of data but that another day
       
    }

    

    public Account_class_110618 getCustomerAccount(){
        return CustomerAccount;
    }
    public ArrayList <Account_class_110618> getAllAccounts(){
        return listOfAccounts;
    }
    
    
    public boolean searchforAcount(String accountnb,String pin){
        boolean blnvalidAccount=false;
        for (int i = 0; i < listOfAccounts.size(); i++) {
            if (listOfAccounts.get(i).getAccount().equals(accountnb)
                &listOfAccounts.get(i).getPin().equals(pin)){
                blnvalidAccount=true; 
                CustomerAccount=listOfAccounts.get(i);
                i=listOfAccounts.size();
            }
        }
        return blnvalidAccount;
    }
    
}    
    


   
    

