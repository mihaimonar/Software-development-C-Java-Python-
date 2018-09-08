"""In employee_91.py define an Employee class to model an employee. Also define Manager and AssemblyWorker classes.
The relationship between the three classes can be depicted as follows:
Employee
-------
str name
int number
-------
init
wages()
str
--------end of parent class.

Manager
-------
float salary
-------
init()
wages()
--------subclass of Employee

Assemblyworker
------------
float hourly rate
float hours
---------
init
wages()
------------subclass of employee as well

Arrows connect subclasses to superclasses. Each box consists of three compartments: class name, data attributes, methods.
If a data attribute is underlined it is a class variable (otherwise it is an instance variable).
If a method is underlined it is a class method (otherwise it is an instance method).

An Employee is defined by a name and an employee number.

A Manager earns a fixed salary per year but is paid on a weekly basis (you can simply assume there are 52 weeks in a year).

An AssemblyWorker is paid by the hour and works some number of hours per week.

The wages() method returns the weekly pay for any Employee or subclass thereof.

When your classes are correctly implemented, running the following program should produce the given output:

from employee_91 import Employee, Manager, AssemblyWorker

def main():

    e1 = Manager('Mary', 1, 50000)
    e2 = AssemblyWorker('Fred', 2, 15.50, 40)
    e3 = Employee('Sean', 3)

    print(e1)
    print(e2)
    print(e3)

if __name__ == '__main__':
    main()
$ python3 employee_91_demo.py
Name: Mary
Number: 1
Wages: 961.54
Name: Fred
Number: 2
Wages: 620.00
Name: Sean
Number: 3
Wages: 0.00"""
class Employee(object):
    def __init__(self,name,number):
        self.name=name
        self.number=number
    def wages(self):
        self.wage=0.0
        return self.wage
    def __str__(self):
        return "Name: {}\nNumber: {}\nWages: {:.2f}".format(self.name,self.number,self.wages())
class Manager(Employee):
    def __init__(self,name,number,salary):
        super().__init__(name,number)
        self.salary=salary
    def wages(self):
        weeklywage=self.salary/52
        return weeklywage
class AssemblyWorker(Employee):
    def __init__(self,name,number,hourly_rate=0.0,hours=0.0):
        super().__init__(name,number)
        self.hourly_rate=hourly_rate
        self.hours=hours
    def wages(self):
        weeklywage=self.hourly_rate*self.hours
        return weeklywage

def main():

    e1 = Manager('Mary', 1, 50000)
    e2 = AssemblyWorker('Fred', 2, 15.50, 40)
    e3 = Employee('Sean', 3)

    print(e1)
    print(e2)
    print(e3)

if __name__ == '__main__':
    main()


