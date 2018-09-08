"""Write a program called q4_51.py that reads a list of integers from stdin. Each line contains a single integer.
After reading all integers the program should print the mean, mode and median of the values entered to one decimal place only.

The mean is average of the list of numbers.
The mode is the most frequent number in the list of numbers (you can assume there will always be a single mode).
The median is the middle number in the sorted list of numbers (if an even number of numbers is entered the median
is the average of the two middle numbers in the sorted list). For example the median of [1, 1, 2, 4, 5] is 2 while
the median of [2, 2, 3, 4] is (2+3)/2 = 2.5.
Example 1:

$ cat nums_01_51.txt
1
4
5
1
2

$ python3 q4_51.py < nums_01_51.txt
Mean: 2.6
Mode: 1.0
Median: 2.0
Example 2:

$ cat nums_02_51.txt
2
4
2
3

$ python3 q4_51.py < nums_02_52.txt
Mean: 2.8
Mode: 2.0
Median: 2.5"""
import sys
lista=[]
for line in sys.stdin:
    line=line.strip()
    lista.append(int(line))
mean=sum(lista)/len(lista)
print(type(mean))
maxcount=max([lista.count(item) for item in lista])#we see the count of all items in list and then max count
#we will assume that we have only one number that ocuurs more times and we don t have 2 num or more that
#have the same max length
##in the code bellow,we get al strings with max count equals to our maxcount variable and because there are ore of them ,
#(in our case cbecause we assume that her is only one word with max count we will have multiple counts of that number
#and makig a set will just keep one num in the set which we need to convert to a string (and for that the item in teh set needs to be
#of str form and not int,and then we use join to make it a string and then we need it bk to int form for format..crAZY
mode=int("".join(set([str(item) for item in lista if lista.count(item)==maxcount])))###this fucking shit was string!!!!!!
#needed to convert to int....couldn t  format to decimal places cause of it
#maybe we can do a dictionary mapping for mode ,much easier
dictio={}
mode2={item:lista.count(item) for item in lista}#creates a dict comprehension ,a dictionary mode2 that stores numbers
#as keys and their count as value,and from here we can get the max value like:
maxvalue=max(sorted([(v,k) for k,v in mode2.items()]))#this will reverse keys and values first and then it will sort
#and sort always sorts by first value whic now is the value and not the key.and it will get the smallest values firts
# ..then...we can retrieve the max which will only return only one instance of the biggest value(cause we sorted by biggets value
#which is in fact the biggest count of a number)...but we might have 2 numbers with same count but only rerieves one
#--------another method-----------
""">>> d= {'a':2,'b':5,'c':3}
>>> max(d, key=d.get)
'b'
The key parameter takes a function, and for each entry in the iterable, it'll find the one
 for which the key function returns the highest value."""
#-----------another method----------
"""
@SiddharthaRT: you can use a lambda for the key: max(d, key=lamda k: (d[k], len(k))) will return the key with the
highest value, and if there is more than one such key,
it'll be the longest key of those that is returned. – Martijn Pieters♦ Oct 30 '14 at 7:37"""
#-----------another method-----------
"""
Getting key with maximum value in dictionary? 11 answers
I'm trying to get dict key where it's value is max in all dict's values. I found two ways, both not elegant enough.

d= {'a':2,'b':5,'c':3}
# 1st way
print [k for k in d.keys() if d[k] == max(d.values())][0]
"""
#--------------another method----------
"""

sorted(d.items(), key=lambda x: x[1])

This will sort the dictionary by the values of each entry within the dictionary from smallest to largest"""

print("modeee",mode2)
print("maxval",maxvalue)

print(type(mode))
lista=sorted(lista)
print(len(lista))
if len(lista)%2==1:
    print(lista)
    median=lista[len(lista)//2]#error built in function is not subscriptable
    #comes when we use a function with wronkg sintax..i vwas doing len[lista] it should be ()
else:
    if len(lista)%2==0:
        median=(lista[len(lista)//2-1]+lista[len(lista)//2])/2
print(type(median))
print ("Mean: {:.1f}\nMode: {:.1f}\nMedian: {:.1f}".format(mean,mode,median))#!!!!i will get two different results
#for mode because i modified the text so two values have  a maximum count and it will retrieve the 2 of them
#with my code but they are joined in the same string...anyway solution is good that it retrieves every numbers
#but it doesn t coincide with the teachers input and output...anyway look at another solutions---they will sugest
#how to get a max count for values and by using function max it will return only one value and we should get the key
#for that value
###max can take a key amnd that key can vbe a very complex key or more variables in a tuple ...look at another solutions


