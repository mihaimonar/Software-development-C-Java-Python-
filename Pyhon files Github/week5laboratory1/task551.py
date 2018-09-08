"""Middle-distance runners run some arbitrary number of races (at least one) in a season. Write a program called q5_51.py that reads runners’ times for the season from stdin. Each line read from stdin is structured as follows:

Runner’s name: time_1 time_2 time_3 ...

Each name is a single string. Each time is in the form minutes:seconds. Having read in all times the program should print the name of the runner with the best time over the course of the season along with that time (you may assume there will always be one clear winner). Should any of the times be invalid then the corresponding runner should be ignored. For example:

$ cat runners_51.txt
Rachel 8:12 8:32 8:00 7:12 8:09
Fred 11:12 11:13 11:14 11:14 11:10
Naomi 8:45 9:01 10:11 8:18 9:00
Jimmy 8:12 8:2b 8:19 7:13 10:11
Ned 7:34 7:00 6:45 7:19 7:01

$ python3 q5_51.py < runners_51.txt
Ned : 6:45"""
import sys
dictio={}
for line in sys.stdin:
    line=line.strip().split()
    lista=[]
    for item in line[1:]:
        item=item.split(":")
        if item[1][0]=="0":
            try:
                seconds=int(item[1][1])
            except ValueError:
                continue
        else:
            try:
                seconds=int(item[1])
            except ValueError:
                continue
        try:
            minutes=int(item[0])
        except ValueError:
            continue
        time=minutes*60+seconds
        lista.append(time)
    dictio[line[0]]=lista
print(dictio)
smallesttime=1000000000000000000000000#here we set the time to a huge value because we look something smaller than this
#we usually set it to 0 as we are looking a bigger value than this and we replace the 0 with the bigger value when one is found
#but here we have the opposite case
for k,v in dictio.items():
    mintime=min(dictio[k])
    if mintime<smallesttime:
        smallesttime=mintime
for k,v in dictio.items():
    if smallesttime in v:
        minutes,seconds=divmod(smallesttime,60)
        print("{} : {}:{}".format(k,minutes,seconds))
