"""In parentheses_92.py define a function called matcher() that takes a single parameter line (a string read from stdin).
 The matcher() function checks that all left and right parentheses in line match. matcher() should return True if
  parentheses match and False otherwise. Parentheses that need to be matched are “(){}[]”. For example:

from parentheses_92 import matcher
import sys

def main():

    for line in sys.stdin:
        print(matcher(line.strip()))

if __name__ == '__main__':
    main()
$ cat parentheses_92.txt
()
(())
(({}))
(())(){}{(([]))}
(()
(()){()]
)(()){([()])}

$  python3 parentheses_92_demo.py < parentheses_92.txt
True
True
True
True
False
False
False
Hints:

This problem is relatively easy to solve if you make good use of the stack class defined in stack_92.py so feel free to
from stack_92 import Stack.
If “lefties” are “({[” then righties are ”)}]”. Push lefties and pop on meeting a righty."""
from task1stack92 import Stack
import sys
def matcher(line):
    stack=Stack()
    line=list(line.strip())
    print(line)
    for item in line:
        if item == "{" or item == "[" or item == "(":
            stack.push(item)
    print(stack.l)
    for item in line:
        #print("item is",item)
        if item == "}":
            try:
                stack.l.remove("{")
            except:
                return False
        elif item == "]":
            try:
                stack.l.remove("[")
            except:
                return False
        else:
            if item == ")":
                try:
                    stack.l.remove("(")
                except:
                    return False
    if len(stack.l) == 0:
        return True
    else:

        return False
def main():
    for line in sys.stdin:
        print(matcher(line))
if __name__ == "__main__":
    main()

