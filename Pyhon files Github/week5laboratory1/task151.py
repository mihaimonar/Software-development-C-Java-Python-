"""Write a program called q1_51.py that reads a string from the command line and swaps all adjacent characters in the
 string and prints the result. You can assume the input string will always contain one or more characters. For example:

$ python3 q1_51.py tiger
itegr
$ python3 q1_51.py penguins
epgniusn"""
import sys
word=sys.argv[1]
i=0
while i<len(word)-1:#becausei we increment with 2 we have to say i<lenMINUS 1!!!
    """word=list(word)-------------this solution is very good too...but we need"".join to make it a string again
    try:
        word[i],word[i+1]=word[i+1],word[i]
        print("i",word[i],"i+1",word[i+1])
    except IndexError:
         word[i]=word[i]
    i+=2"""
    word=word[:i]+word[i+1]+word[i]+word[i+2:]#took me a while...i print everything to i and then swap letetrs i and i+1
    #and then add what is left from the word
    #if the word is even i+2:   will result in nothing but will not throw an error which is good
    print("i+2",word[i+2:])
    print(i,word)
    i+=2
print(word)