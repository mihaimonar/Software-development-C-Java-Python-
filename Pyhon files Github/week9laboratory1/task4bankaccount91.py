"""In bankaccount_91.py define a BankAccount class to model a bank account. Also define CurrentAccount and SavingsAccount
 classes. The relationship between the three classes can be depicted as follows:
Bank account---main class
-------------
int next account number-class variable
str forename
str surname
float balance
int account number
-------------
init()
lodge()
str
--------------------------------------------
Currentaccount(BankAccount)
----------
float overdraft-clas var
str account type-cls var
-----------
withdraw()
str()
---------------------------------------------
SavingsAccount(Bankaccount)
---------------
float interest rate-cls var
str account type-cls var
---------------
apply_interest()
withdraw()
str()
------------------------------------------------

Arrows connect subclasses to superclasses. Each box consists of three compartments: class name, data attributes, methods.
 If a data attribute is underlined it is a class variable (otherwise it is an instance variable).
  If a method is underlined it is a class method (otherwise it is an instance method).

Every new bank account is assigned a unique account number. The first account number is 16555232, the second 16555233, etc.

Every current account has an overdraft facility of 1000 Euro.

Savings accounts earn interest at a rate of 1%. Interest is applied by invoking the apply_interest() method.

When your classes are correctly implemented, running the following program should produce the given output:

from bankaccount_91 import CurrentAccount, SavingsAccount

def main():
    a1 = CurrentAccount('Joe', 'Murphy', 100)
    a2 = SavingsAccount('Mandy', 'Murray', 100)
    a3 = SavingsAccount('Jimmy', 'Smith', 200)

    # Print base classes
    print('Base classes...')
    print(a1.__class__.__bases__)
    print(a2.__class__.__bases__)

    # Print account details
    print('Account details...')
    print(a1)
    print(a2)
    print(a3)

    # Call some methods
    a1.lodge(50)
    a1.withdraw(100)
    a1.withdraw(100)
    a1.withdraw(1000)
    a2.withdraw(10)
    a2.withdraw(100)
    a2.lodge(20)
    a2.apply_interest()
    try:
        a1.apply_interest()
    except AttributeError:
        print('No such method')

    # Print account details
    print('Account details...')
    print(a1)
    print(a2)

if __name__ == '__main__':
    main()
$ python3 bankaccount_91_demo.py
Base classes...
(<class 'bankaccount_91.BankAccount'>,)
(<class 'bankaccount_91.BankAccount'>,)
Account details...
Name: Joe Murphy
Account number: 16555232
Balance: 100.00
Account type: current
Name: Mandy Murray
Account number: 16555233
Balance: 100.00
Account type: savings
Name: Jimmy Smith
Account number: 16555234
Balance: 200.00
Account type: savings
Insufficient funds available
Insufficient funds available
No such method
Account details...
Name: Joe Murphy
Account number: 16555232
Balance: -50.00
Account type: current
Name: Mandy Murray
Account number: 16555233
Balance: 111.10
Account type: savings"""
class BankAccount(object):
    next_account_number=16555232
    def __init__(self,forename,surname,balance=0.0):
        self.forename=forename
        self.surname=surname
        self.balance=balance
        self.account_number=BankAccount.next_account_number
        BankAccount.next_account_number+=1
    def lodge(self,money):
        self.balance+=money
    def __str__(self):
        return "Claaaaaaaaaaaass"


class CurrentAccount(BankAccount):
    overdraft=-1000.0
    account_type="curent"
    def withdraw(self,money):
        if (self.balance-money)<self.overdraft:
            print("Insufficient funds available")
        else:
            self.balance-=money
    def __str__(self):
        return "Name: {} {}\nAccount number: {}\nBalance: {:.2f}\nAccount type: {}".format(self.forename, self.surname, self.account_number,\
                                                                       self.balance,self.account_type)
class SavingsAccount(BankAccount):
    interest_rate=0.01
    account_type="savings"
    def apply_interest(self):
        self.balance=self.balance+self.balance*self.interest_rate
        return self.balance
    def withdraw(self,money):
        if self.balance-money<0:
            print("Insufficient funds available")
        else:
            self.balance-=money
    def __str__(self):
        return "Name: {} {}\nAccount number: {}\nBalance: {:.2f}\nAccount type: {}".format(self.forename, self.surname,
                                                                self.account_number, self.balance, self.account_type)


def main():
    a1 = CurrentAccount('Joe', 'Murphy', 100)
    a2 = SavingsAccount('Mandy', 'Murray', 100)
    a3 = SavingsAccount('Jimmy', 'Smith', 200)

    # Print base classes
    print('Base classes...')
    print(a1.__class__.__bases__)#will show the module where it is imported from and the class it belongs to
    #in the teachers code  it will print the module as he is importing this class,but because i use mine in
    #the same module i created is gonna show  __main_(here instead of main teacher has his module where
    #he imported this class# _.Bankaccount
    print(a2.__class__.__bases__)

    # Print account details
    print('Account details...')
    print(a1)
    print(a2)
    print(a3)

    # Call some methods
    a1.lodge(50)
    a1.withdraw(100)
    a1.withdraw(100)
    a1.withdraw(1000)
    a2.withdraw(10)
    a2.withdraw(100)
    a2.lodge(20)
    a2.apply_interest()
    try:
        a1.apply_interest()
    except AttributeError:
        print('No such method')

    # Print account details
    print('Account details...')
    print(a1)
    print(a2)

if __name__ == '__main__':
    main()