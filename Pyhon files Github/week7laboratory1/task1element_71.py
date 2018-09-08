"""In element_71.py define an Element class to model a chemical element. An element has four data attributes: number,
name, symbol, and boiling_point. In addition to an __init__() method the Element class defines the following instance method:

print_details() : prints element details (see example output below for how element details should be displayed)
When your class is correctly implemented, running the following program should produce the given output:

from element_71 import Element

def main():

    e1 = Element(1, 'Hydrogen', 'H', 20.3)
    e2 = Element(3, 'Lithium', 'Li', 1615)
    e3 = Element(11, 'Sodium', 'Na', 1156)
    e4 = Element(12, 'Magnesium', 'Mg', 1380)
    e5 = Element(79, 'Gold', 'Au', 3129)

    e1.print_details()
    e2.print_details()
    e3.print_details()
    e4.print_details()
    e5.print_details()

if __name__ == '__main__':
    main()
$ python3 element_71_demo.py
Number: 1
Name: Hydrogen
Symbol: H
Boiling point: 20.3 K
Number: 3
Name: Lithium
Symbol: Li
Boiling point: 1615 K
Number: 11
Name: Sodium
Symbol: Na
Boiling point: 1156 K
Number: 12
Name: Magnesium
Symbol: Mg
Boiling point: 1380 K
Number: 79
Name: Gold
Symbol: Au
Boiling point: 3129 K"""

class Element(object):
    def __init__(self,number,name,symbol,boiling_point):
        self.number=number
        self.name=name
        self.symbol=symbol
        self.boilingpoint=boiling_point
    def print_details(self):
        print("Number:",self.number,"\n""Name:",self.name,"\n""Symbol:",self.symbol,"\n""Boiling Point:",self.boilingpoint,"K")


def main():
    e1 = Element(1, 'Hydrogen', 'H', 20.3)
    e2 = Element(3, 'Lithium', 'Li', 1615)
    e3 = Element(11, 'Sodium', 'Na', 1156)
    e4 = Element(12, 'Magnesium', 'Mg', 1380)
    e5 = Element(79, 'Gold', 'Au', 3129)

    e1.print_details()
    e2.print_details()
    e3.print_details()
    e4.print_details()
    e5.print_details()


if __name__ == '__main__':
    main()