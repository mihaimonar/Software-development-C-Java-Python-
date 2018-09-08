"""In coin_72.py define a Coin class to model a coin. A coin has a single data attribute: sideup which can take on the
values ‘Heads’ or ‘Tails’. For any new Coin instance sideup defaults to ‘Heads’. In addition to an __init__() method
the Coin class defines the following instance methods:

flip() : flips the coin after which sideup is random
getstate() : returns the current state of sideup
__str__() : returns a string describing the current state of the coin
Once your class is correctly implemented, running the following program should produce output similar to that given below:

from coin_72 import Coin

def main():
    c = Coin()
    for i in range(10):
        c.flip()
        print(c)

    total = 0
    p_state = c.sideup;
    for i in range(1000):
        c.flip()
        if p_state == c.sideup == 'Heads':
            total += 1
        p_state = c.sideup

    print('The odds of two heads in a row is: {:.2f}'.format(total/1000))

if __name__ == '__main__':
    main()
$ python3 coin_72_demo.py
Current state : Tails
Current state : Heads
Current state : Tails
Current state : Heads
Current state : Heads
Current state : Heads
Current state : Heads
Current state : Tails
Current state : Heads
Current state : Tails
The odds of two heads in a row is: 0.23
Hint: consult the notes on random numbers to find a way to simulate a random coin toss.

There is no verifier available for this exercise as it produces random output (although the odds of two heads in a row
 calculated by your code should be close 0.25).

Geometry"""
import random
class Coin(object):
    def __init__(self,sideup="Heads"):
        self.sideup=sideup
    def flip(self):
        lista=["Heads","Tails"]
        self.sideup=random.choice(lista)
    def getstate(self):
        return self.sideup
    def __str__(self):
        return ("Curent state : {}".format(self.getstate()))

def main():
    c = Coin()
    for i in range(10):#this will randomly change the side 10 times
        c.flip()
        print(c)

    total = 0
    p_state = c.sideup#creates a curent state Copy of the side then we flip it and if the curent side
    #stored in p_state coincides with the state after flipping and they both are heads we can create
    #a counter named total that will count how many times we have one head after another.
    for i in range(1000):
        c.flip()
        if p_state == c.sideup == 'Heads':#compares curent state from the previous flip with the state
            #after flipping and if both match head then increment the total counter that counts heads after head

            total += 1
        p_state = c.sideup#we take the curent state and store it in p_state and we go again in the
        #for loop and flip the coin and if curent state=flipped state and they==Heads then increment again
        #and so on

    print('The odds of two heads in a row is: {:.2f}'.format(total/1000))

if __name__ == '__main__':
    main()

