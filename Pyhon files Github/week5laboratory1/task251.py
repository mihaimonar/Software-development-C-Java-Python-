"""Write a program called q2_51.py that reads a list of words from stdin (one word per line). The program should print
all words in the list that contain a single instance of each of the characters “e”, “v”, “i”, “l”, in that order.
 Matching characters can be in upper or lower case. Words must be output in the order they are read from stdin. For example:

$ cat evil_words_51.txt
aardvark
Evil
DEVILLED
live
devillish
fervidly
evilly
PREVAIL
previously
devotional
enviably
eevil
zebra

$ python3 q2_51.py < evil_words_51.txt
Evil
fervidly
PREVAIL
previously
devotional"""
import sys
for line in sys.stdin:
    linelower=line.strip().lower()
    #print("linelower",linelower)
    listlinelower=list(linelower)#making it a set to eliminate duplicates
    #of letetrs in evil will also eliminate duplicates of other letter than in evil
    #and when comparing len(set)==len(originalword)  it can exclude  words that contain
    #only one ocurence of e,v,i,l but that contain duplicates of other letters
    #and the whole word will be excluded even if it shouldn t
    lista=["e","v","i","l"]#do not make this a bloody set cause when we do for i in set
    #it will take items randomly so make it a list so it takes them in order
    ##summ=sum([1 for letter in listlinelower if letter in lista])###badd as it can coun4'e' s for example!
    evaluation=all([listlinelower.count(letter) for letter in lista])#if one count is 0 then it will evaluate to false
    #else will be true and means that all letters ha a count>0
    summ=sum([listlinelower.count(letter) for letter in lista])#retrieving the actual count
    print("sum",summ)
    temp=0
    count=0
    for letter in lista:
        #print("letter",letter)
        if evaluation==True and summ==len(lista):#here if the summ is equal to the len of the list containing the letters and knowing
            #from the evaluation that all letters were all counted at least once we can tell that in the moment summ=len(lista)
            #that all letters were counted excatly once
            if letter in linelower :#list comprehension and above condition coversed this case already so this if not really necesary
                index=linelower.index(letter)#get index of first letter in lista in the wordlinelower
                #print("index",index,"temp",temp)
                if index>=temp:
                    temp=index
                else:
                    count=1#count=1 so it hen if at the bottom of code evaluates count will know that condition was broken
                    break#the moment the new index is lower than the older index means the curent letter from lista has a
                    #index smalleer than the index of the prev letter from lista in the linelower word and this means the order is not kept
            else:
                count=1#letter not in linelower ,change count to 1
                break
        else:
            count=1#first if not true then ,increase count to 1 so it doesn t print the curent word
    if count==0:
        print(line)

"""import sys--------cool solution from Valy
text=sys.stdin
s=set("evil")
for word in text:
     check=""
     word=word.strip()
     for c in word.lower():
        if c in "evil":
           check+=c
     if check=="evil":
        print (word)"""
