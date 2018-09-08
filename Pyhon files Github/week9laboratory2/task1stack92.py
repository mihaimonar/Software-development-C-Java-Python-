"""In stack_92.py define a Stack class to model the stack abstract data type as follows:
Stack
--------
list l
--------
init
push()
pop()
top()
is_empty()
__len__()
../../_images/stack_92.png
Each box consists of three compartments: class name, data attributes, methods. If a data attribute is underlined
it is a class variable (otherwise it is an instance variable). If a method is underlined it is a class method
(otherwise it is an instance method).

Read the notes on stack methods to determine their required behaviour.

When your class is correctly implemented, running the following program should produce the given output:

from stack_92 import Stack

def main():

    s = Stack()

    print(len(s))
    s.push(1)
    print(s.top())
    print(s.is_empty())
    print(s.pop())
    print(s.is_empty())
    try:
        print(s.pop())
    except IndexError:
        print('Error')
    try:
        print(s.top())
    except IndexError:
        print('Error')
    s.push(1)
    s.push(2)
    s.push(3)
    print(len(s))
    print(s.pop())
    print(s.pop())
    print(s.pop())
    print(s.is_empty())
if __name__ == '__main__':
    main()"""
class Stack(object):
    def __init__(self):
        self.l=[]
    def push(self,element):
        self.l.append(element)
    def top(self):
        return self.l[-1]#here there should be some exception handling if the list is empty,
    #but we have the exception handling in the main and that will hadle it

    def is_empty(self):
        if self.l==[]:
            return True
        return False
    def __len__(self):
        return len(self.l)#why len function? because if we specify len to a class
    #it wont know what to measure but here we tell it to measure the length of l
    def pop(self):
        return self.l.pop()

def main():

    s = Stack()

    print(len(s))
    s.push(1)
    print(s.top())
    print(s.is_empty())
    print(s.pop())
    print(s.is_empty())
    try:
        print(s.pop())
    except IndexError:
        print('Error')
    try:
        print(s.top())
    except IndexError:
        print('Error')
    s.push(1)
    s.push(2)
    s.push(3)
    print(len(s))
    print(s.pop())
    print(s.pop())
    print(s.pop())
    print(s.is_empty())

if __name__ == '__main__':
    main()


