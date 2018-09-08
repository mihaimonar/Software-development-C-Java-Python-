import sys
text=sys.stdin
s=set("evil")
for word in text:
     check=""
     word=word.strip()
     for c in word.lower():
        if c in "evil":
           check+=c
     if check=="evil":
        print (word)