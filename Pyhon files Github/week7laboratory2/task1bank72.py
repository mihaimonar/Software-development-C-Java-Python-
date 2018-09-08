"""In bank_72.py define a BankAccount class to model a bank account. A bank account has a single data attribute:
 balance which can be zero or any positive floating point value. For any new BankAccount instance balance defaults to zero.
 In addition to an __init__() method the BankAccount class defines the following instance methods:

deposit() : adds an amount (supplied as an argument) to the balance
withdraw() : subtracts an amount (supplied as an argument) from the balance (or says ‘Insufficient funds available’
 if withdrawing that amount would cause the balance to become negative)
__str__() : returns a string describing the current balance
Once your class is correctly implemented, running the following program should produce the given output:

from bank_72 import BankAccount

def main():
    b1 = BankAccount()
    print(b1)
    b1.withdraw(1)
    b1.deposit(100)
    b1.deposit(150)
    print(b1)
    b1.withdraw(50)
    print(b1)
    b1.deposit(20)
    b1.withdraw(100)
    print(b1)

    b2 = BankAccount(1000)
    b2.deposit(1)
    b2.withdraw(2000)
    print(b2)
    b2.withdraw(1001)
    print(b2)

if __name__ == '__main__':
    main()
$ python3 bank_72_demo.py
Your current balance is: 0.00 euro
Insufficient funds available
Your current balance is: 250.00 euro
Your current balance is: 200.00 euro
Your current balance is: 120.00 euro
Insufficient funds available
Your current balance is: 1001.00 euro
Your current balance is: 0.0"""
class BankAccount(object):
    def __init__(self,balance=0):
        self.balance=balance
    def deposit(self,amount):
        self.balance+=amount
    def withdraw(self,amount):
        if amount>self.balance:
            print("Insuficient funds available")
        else:
            self.balance=self.balance-amount
    def __str__(self):
        return ("Your curent balance is {:.2f} euro".format(self.balance))
    #__str___must have a RETURN not a Print!
    #if we do return("bcjcb",self.balance)..it will say error as this will create a tuple and
    #str method must return a string not a tuple so use format to avoid comma separation!!

def main():
    b1 = BankAccount()
    print(b1)
    b1.withdraw(1)
    b1.deposit(100)
    b1.deposit(150)
    print(b1)
    b1.withdraw(50)
    print(b1)
    b1.deposit(20)
    b1.withdraw(100)
    print(b1)

    b2 = BankAccount(1000)
    b2.deposit(1)
    b2.withdraw(2000)
    print(b2)
    b2.withdraw(1001)
    print(b2)

if __name__ == '__main__':
    main()






