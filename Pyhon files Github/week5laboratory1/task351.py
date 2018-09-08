"""Write a program called q3_51.py that reads dates from stdin (one date per line). Each date is structured as follows:

day_number month_name long_year

The program should convert each date to its short form and print it:

day_number/month_number/short_year

For example:

$ cat dates_51.txt
3 February 1998
31 March 1975
4 December 1984
14 January 2000

$ python3 q3_51.py < dates_51.txt
3/2/98
31/3/75
4/12/84
14/1/00"""
import sys
dictio={"January":1,"February":2,"March":3,"April":4,"May":5,"June":6,"July":7,"August":8,"September":9,"October":10,\
        "November":11,"December":12}
for line in sys.stdin:
    line=line.strip().split()
    print("{}/{}/{}".format(line[0],dictio[line[1]],line[2][2:]))