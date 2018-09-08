"""In bank_82.py define a BankAccount class to model a bank account as follows:
Bankaccount
-----------
int next_account_number-clsvariable
int totallodgements-clsvariable
float interest_rate-clsvariable
string forename
str surname
float balance
integer account_number
--------------------
__init__()
lodge()
apply_interest()
__iadd__()
__str__()

Each box consists of three compartments: class name, data attributes, methods. If a data attribute is underlined it is
 a class variable (otherwise it is an instance variable). If a method is underlined it is a class method
  (otherwise it is an instance method).

When your class is correctly implemented, running the following program should produce the given output:

from bank_82 import BankAccount

def main():

    # Check class attributes
    print('Checking class attributes...')
    print(BankAccount.next_account_number)
    print(BankAccount.total_lodgements)
    print(BankAccount.interest_rate)

    # Create two accounts
    b1 = BankAccount('Persephone', 'Murphy')
    b2 = BankAccount('Jemima', 'O\'Reilly', 30)

    # Check string representation
    print('Printing bank accounts...')
    print(b1)
    print(b2)

    # Check lodge
    print('Checking lodgements...')
    b1.lodge(100)
    b2.lodge(100)
    print(b1)
    print(b2)

    # Check increment
    print('Checking increment...')
    b3 = b1
    b1 += 22
    b2 += 23
    print(b1)
    print(b3 is b1)
    print(b2)

    # Check interest
    b1.apply_interest()
    b2.apply_interest()
    print(b1)
    print(b2)

    # Check class attributes
    print('Checking class attributes...')
    print(BankAccount.next_account_number)
    print(BankAccount.total_lodgements)
    print(BankAccount.interest_rate)

if __name__ == '__main__':
    main()
$ python3 bank_82_demo.py
Checking class attributes...
16555232
0
0.043
Printing bank accounts...
Name: Persephone Murphy
Account number: 16555232
Balance: 0.00
Name: Jemima O'Reilly
Account number: 16555233
Balance: 30.00
Checking lodgements...
Name: Persephone Murphy
Account number: 16555232
Balance: 100.00
Name: Jemima O'Reilly
Account number: 16555233
Balance: 130.00
Checking increment...
Name: Persephone Murphy
Account number: 16555232
Balance: 122.00
True
Name: Jemima O'Reilly
Account number: 16555233
Balance: 153.00
Name: Persephone Murphy
Account number: 16555232
Balance: 127.25
Name: Jemima O'Reilly
Account number: 16555233
Balance: 159.58
Checking class attributes...
16555234
4
0.043"""
class BankAccount(object):
    next_account_number=16555232
    total_lodgements=0
    interest_rate=0.043
    def __init__(self,forename,surname,balance=0.0,account_number=0):
        self.forename=forename
        self.surname=surname
        self.balance=balance
        self.account_number=self.next_account_number
        self.name=self.forename+" "+self.surname
        BankAccount.next_account_number+=1
    def __str__(self):
        return("Name: {}\nAccount number: {}\nBalance: {:.2f}".format(self.name,self.account_number,self.balance))
    def lodge(self,money):
        self.balance=self.balance+money
        #self.total_lodgements+=1#this will create a instance variable !!! which will be created from the
        #class variable self.totallodgements +1..ths will not update the class variable
        #no matter how many times we perform this operation it will only update the instance variable
        #which at the start will take the class totallogements of 0 as at the instance level there is no
        #instance variable named totallodgements yet and it will be incremented with 1.if we do lodge()
        #again then it will look at instance level and find the self.toallodgements instance variable and increment
        #it with 1 and store it in itsel(in the instance varaible self.totallodgenments)
        ###but because we don t want this behaviour now we will do :
        BankAccount.total_lodgements+=1
    def __iadd__(self, other):#this is almost no diferent than what lodge() does but with iadd
        #we can use the sign += instead of calling the function iadd()
        self.balance+=other
        BankAccount.total_lodgements+=1
        return self
    def apply_interest(self):
        totalbalance=self.balance+self.balance*self.interest_rate
        self.balance=totalbalance

def main():

    # Check class attributes
    print('Checking class attributes...')
    print(BankAccount.next_account_number)
    print(BankAccount.total_lodgements)
    print(BankAccount.interest_rate)

    # Create two accounts
    b1 = BankAccount('Persephone', 'Murphy')
    b2 = BankAccount('Jemima', 'O\'Reilly', 30)

    # Check string representation
    print('Printing bank accounts...')
    print(b1)
    print(b2)

    # Check lodge
    print('Checking lodgements...')
    b1.lodge(100)
    b2.lodge(100)
    print(b1)
    print(b2)

    # Check increment
    print('Checking increment...')
    b3 = b1
    b1 += 22
    b2 += 23
    print(b1)
    print(b3 is b1)
    print(b2)

    # Check interest
    b1.apply_interest()
    b2.apply_interest()
    print(b1)
    print(b2)

    # Check class attributes
    print('Checking class attributes...')
    print(BankAccount.next_account_number)
    print(BankAccount.total_lodgements)
    print(BankAccount.interest_rate)

if __name__ == '__main__':
    main()


