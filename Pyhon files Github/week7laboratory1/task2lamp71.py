"""In lamp_71.py define a Lamp class to model a lamp. A lamp has a single data attribute: on. on can be either True or False.
 For any new Lamp instance on is False by default. In addition to an __init__() method the Lamp class defines the following instance methods:

turn_on() : turns the lamp on (has no effect if already on)
turn_off() : turns the lamp off (has no effect if already off)
toggle() : turns the lamp on if currently off and off if currently on
When your class is correctly implemented, running the following program should produce the given output:

from lamp_71 import Lamp

def main():
    lamp1 = Lamp()
    print(lamp1.on)
    lamp1.turn_off()
    print(lamp1.on)
    lamp1.turn_on()
    lamp1.turn_on()
    print(lamp1.on)
    lamp1.turn_off()
    print(lamp1.on)
    lamp1.turn_off()
    print(lamp1.on)
    lamp1.toggle()
    print(lamp1.on)
    lamp1.toggle()
    lamp1.toggle()
    print(lamp1.on)

    lamp2 = Lamp(True)
    print(lamp2.on)
    lamp2.turn_on()
    lamp2.turn_on()
    print(lamp2.on)
    lamp1.turn_off()
    print(lamp2.on)
    lamp2.toggle()
    print(lamp2.on)

if __name__ == '__main__':
    main()
$ python3 lamp_71_demo.py
False
False
True
False
False
True
True
True
True
True
False"""
class Lamp(object):
    def __init__(self,on=False):
        self.on=on
    def turn_on(self):
        if self.on==False:
            self.on=True
    def turn_off(self):
        if self.on==True:
            self.on=False
    def toggle(self):
        if self.on==False:
            self.turn_on()
        else:
            self.turn_off()

def main():
    lamp1 = Lamp()
    print(lamp1.on)
    lamp1.turn_off()
    print(lamp1.on)
    lamp1.turn_on()
    lamp1.turn_on()
    print(lamp1.on)
    lamp1.turn_off()
    print(lamp1.on)
    lamp1.turn_off()
    print(lamp1.on)
    lamp1.toggle()
    print(lamp1.on)
    lamp1.toggle()
    lamp1.toggle()
    print(lamp1.on)

    lamp2 = Lamp(True)
    print(lamp2.on)
    lamp2.turn_on()
    lamp2.turn_on()
    print(lamp2.on)
    lamp1.turn_off()
    print(lamp2.on)
    lamp2.toggle()
    print(lamp2.on)

if __name__ == '__main__':
    main()