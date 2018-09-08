/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author SwDev13
 */
public class Account_class_110618 {
   
    private String accountNumber;
    private String pin;
    private double balance;
    private boolean blnBlocked;
    public  void setAccount (String accNB)
    {accountNumber=accNB;
    }
    public  void setPin (String PIN)
    {pin =PIN;
    }
    public void setbalance(double BALANCE){balance=BALANCE;}
    public void setblnBlocked(boolean bln){blnBlocked=bln;}
    public String getAccount(){return accountNumber;}
    public String getPin(){return pin;}
    public double getBalance(){return balance;}
    public boolean getBlocked(){return blnBlocked;}
    
    public boolean withdrawal(double amountToWithdraw){
        if (balance>=amountToWithdraw){
            balance-=amountToWithdraw;
            return true;
        }
        else
            return false;
    
    
    }
    
}
