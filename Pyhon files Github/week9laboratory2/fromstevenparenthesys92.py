from task1stack92 import Stack
#from Valy

def matcher(line):
   s = Stack()
   p = ["()", "[]", "{}"]
   for c in line:
      #print("line",line)
      #print("cccccc",c)
      if c in "([{":
         s.push(c)
      if c in ")]}":
         if s.is_empty():#if it meets a right)}] and no left inside stack then there is no match and returns false
            return False
         ob = s.pop()
         #print("0bbb",ob)
         if ob + c not in p:#if we have some line like [(])...even though they match
            #and we have 2 ( and 2 [,this code will fail cause when it
            #encounters the first ] it will pop a ( and added together will be (] and this is not in the list,my code
            #covers this situation but this is Steven's
            return False
   return s.is_empty()
def main():
   import sys
   for line in sys.stdin:
      print(matcher(line))
if __name__ == "__main__":
    main()