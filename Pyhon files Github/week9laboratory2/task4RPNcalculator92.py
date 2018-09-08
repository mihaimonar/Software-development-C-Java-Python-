"""Reverse Polish Notation (RPN) is a mathematical notation in which every operator follows all of its operands. Examples:

2 + 3 is expressed as 2 3 +
2 + sqrt(3) is expressed as 2 3 r +
1 + 2 * 3 is expressed as 1 2 3 * +
5 * -2 is expressed as 5 2 n *
sqrt(-(2*(1-(2+3))*2)) is expressed as 2 1 2 3 + - * n r
In rpn_92.py define a function called calculator() that takes a single parameter line (an RPN expression read from stdin).
 The calculator() function computes the value of the RPN expression. Should the RPN expression be invalid then the
  calculator() function raises an IndexError exception. For example:

from rpn_92 import calculator
import sys

def main():

    for line in sys.stdin:
        try:
            a = calculator(line.strip())
            print('{:.2f}'.format(a))
        except IndexError:
            print('Invalid RPN expression')

if __name__ == '__main__':
    main()
$ cat rpn_92.txt
5
8.5 2 /
2 3 +
2 3 r +
1 2 3 * +
5 2 n *
1 2 3 + -
2 1 2 3 + - *
2 1 2 3 + - * n
2 1 2 3 + - * n r
6 +
9 r

$ python3 rpn_92_demo.py < rpn_92.txt
5.00
4.25
5.00
3.73
7.00
-10.00
-4.00
-8.00
8.00
2.83
Invalid RPN expression
3.00
Hints:

Convert all user-supplied numbers to floats.
In solving this problem make good use of the stack class defined in stack_92.py so feel free to from stack_92 import Stack.
You might find two dictionaries useful: binops maps from each of +-*/ to a corresponding function while uniops maps from
each of nr to a corresponding function.
When you encounter a number in an RPN expression push it onto the stack. If you encounter an operator pop its arguments
 from the stack (one or two), apply the operator to the popped argument(s) and push the result onto the stack.
If after processing an RPN expression you are left with a single number on the stack it is the answer (congratulations!)
 and your calculator() function should return it. Otherwise calculator() should raise an IndexError exception."""
import sys
from math import sqrt
from task1stack92 import Stack

def calculator(line):
    s=Stack()
    line=line.split()
    r=sqrt
    for item in line:
        try:
            if float(item):
                s.push(float(item))
        except ValueError:
            if item == "+":
                #print("s for sum is",s.l)
                sum=s.pop()+s.pop()
                s.push(sum)
            elif item == "-":# and len(s)>=2:
                last=s.pop()
                first=s.pop()
                difference =first-last
                s.push(difference)
            elif item == "/":# and len(s)>=2:
                last=s.pop()
                first=s.pop()
                division=first/last
                s.push(division)
            elif item=="*":# and len(s)>=2:
                multiplication=s.pop()*s.pop()
                s.push(multiplication)
            elif item =="r":
                squareroot=r(s.pop())
                s.push(squareroot)
            elif item =="n":
                negation=-s.pop()
                s.push(negation)

    return ''.join(map(str, s.l))

def main():

    for line in sys.stdin:
        try:
            a = calculator(line.strip())
            print("{:.2f}".format(float(a)))
        except IndexError:
            print('Invalid RPN expression')

if __name__ == '__main__':
    main()