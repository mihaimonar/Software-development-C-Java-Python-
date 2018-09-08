"""In employee_82.py define an Employee class to model an employee as follows:
Class Employee
=============
integer next employee number-class variable
string name
float hourly rate
float hours_worked
----------------
__init__()
add_hours()
__str__()

Each box consists of three compartments: class name, data attributes, methods. If a data attribute is underlined it is
 a class variable (otherwise it is an instance variable). If a method is underlined it is a class method (otherwise it is an instance method).

When your class is correctly implemented, running the following program should produce the given output:

from employee_82 import Employee

def main():

    # Check class attributes
    print('Checking class attributes...')
    print(Employee.next_employee_number)

    # Create two employees
    e1 = Employee('Jimmy')
    e2 = Employee('Mary', hours_worked=12, hourly_rate=12.40)

    # Check string representation
    print('Printing employees...')
    print(e1)
    print(e2)

    # Check adding hours
    print('Checking adding hours...')
    e1.add_hours(10.5)
    e2.add_hours(30)
    print(e1)
    print(e2)

    # Check class attributes
    print('Checking class attributes...')
    print(Employee.next_employee_number)

if __name__ == '__main__':
    main()
$ python3 employee_82_demo.py
Checking class attributes...
0
Printing employees...
Name: Jimmy
ID: 0
Hours: 0.00
Rate: 9.25
Wages: 0.00
Name: Mary
ID: 1
Hours: 12.00
Rate: 12.40
Wages: 148.80
Checking adding hours...
Name: Jimmy
ID: 0
Hours: 10.50
Rate: 9.25
Wages: 97.12
Name: Mary
ID: 1
Hours: 42.00
Rate: 12.40
Wages: 520.80
Checking class attributes...
2"""
class Employee(object):
    next_employee_number=0
    def __init__(self,name,employee_number=0,hourly_rate=9.25,hours_worked=0.0):
        self.name=name
        self.employee_number=Employee.next_employee_number#here it takes the initial value of nextemplnumb
        #and after this it increments that value,so next time when another employee instance is created
        #it will take the incremented value.I we only try to retrieve the class variable after creaing the 2
        #imstances jimmy an d mary,jimmi will have id o,marry 1,and after that the class variables increments so when
        #trying to retrieve it after the 2 instances it will have value of 2 as it was incremented
        self.hourly_rate=hourly_rate
        self.hours_worked=hours_worked
        self.wages=self.hourly_rate*self.hours_worked#if we set the wages here they are gonna stay unchanged if hours and rate change
        #so every time we change something like hours or rate we should update the wages as well!!!
        Employee.next_employee_number+=1
    def __str__(self):
        return "Name: {}\nID: {}\nHours: {:.2f}\nRate: {:.2f}\nWages: {:.2f}".format(self.name,self.employee_number,self.hours_worked\
                                                                         ,self.hourly_rate,self.wages)
    def add_hours(self ,hours):
        allhours=self.hours_worked+hours
        self.hours_worked=allhours
        self.wages=self.hours_worked*self.hourly_rate#every time hours are updated we update the wages variable,
        #if the rate updates as wages depends on i we have to update the wages every rate  update also


def main():
    # Check class attributes
    print('Checking class attributes...')
    print(Employee.next_employee_number)

    # Create two employees
    e1 = Employee('Jimmy')
    e2 = Employee('Mary', hours_worked=12, hourly_rate=12.40)

    # Check string representation
    print('Printing employees...')
    print(e1)
    print(e2)

    # Check adding hours
    print('Checking adding hours...')
    e1.add_hours(10.5)
    e2.add_hours(30)
    print(e1)
    print(e2)

    # Check class attributes
    print('Checking class attributes...')
    print(Employee.next_employee_number)


if __name__ == '__main__':
    main()


