"""In customer_91.py define a Customer class to model a customer account. Also define a ValuedCustomer class.
The relationship between the two classes can be depicted as follows:
Customer
--------
float discount-class variable
string name
string balance
str address line1
str addr line2
str adr line3
----------
init()
owes()
str()

ValuedCustmer---child class
------------
float discount-class variable

Arrows connect subclasses to superclasses. Each box consists of three compartments: class name, data attributes, methods.
If a data attribute is underlined it is a class variable (otherwise it is an instance variable).
If a method is underlined it is a class method (otherwise it is an instance method).

Valued customers receive a 10% discount on their balances. Ordinary customers receive no discount.
The owes() method returns the amount due by a customer (taking into account any discount).

When your classes are correctly implemented, running the following program should produce the given output:

from customer_91 import Customer, ValuedCustomer

def main():

    c1 = Customer('Jimmy', 100, '22 Main Street', 'Naas', 'Kildare');
    c2 = ValuedCustomer('Lucy', 100, '23 Main Street', 'Roosky', 'Roscommon');
    c3 = Customer('Fred', 200, '24 Main Street', 'Sneem', 'Kerry');

    print(c1)
    print(c2)
    print(c3)

if __name__ == '__main__':
    main()
$ python3 customer_91_demo.py
Jimmy
22 Main Street
Naas
Kildare
Balance: 100.00
Discount: 0%
Amount due: 100.00
Lucy
23 Main Street
Roosky
Roscommon
Balance: 100.00
Discount: 10%
Amount due: 90.00
Fred
24 Main Street
Sneem
Kerry
Balance: 200.00
Discount: 0%
Amount due: 200.00"""
class Customer(object):
    discount=0.0
    def __init__(self,name,balance,addr_line1,addr_line2,addr_line3):
        self.name=name
        self.balance=balance
        self.addr1=addr_line1
        self.addr2=addr_line2
        self.addr3=addr_line3
    def __str__(self):
        return "{}\n{}\n{}\n{}\nBalance: {:.2f}\nDiscount: {}%\nAmount due: {:.2f}".format(self.name,self.addr1,self.addr2,\
                                                                    self.addr3,self.balance,int(self.discount*100),self.owes())
    def owes(self):
        owed=self.balance-self.balance*self.discount
        return owed
class ValuedCustomer(Customer):
    discount=0.10

def main():

    c1 = Customer('Jimmy', 100, '22 Main Street', 'Naas', 'Kildare');
    c2 = ValuedCustomer('Lucy', 100, '23 Main Street', 'Roosky', 'Roscommon');
    c3 = Customer('Fred', 200, '24 Main Street', 'Sneem', 'Kerry');

    print(c1)
    print(c2)
    print(c3)

if __name__ == '__main__':
    main()