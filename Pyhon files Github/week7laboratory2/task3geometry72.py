"""In geometry_72.py define three classes: Point, Segment and Circle. The Point class models a point in
a two dimensional space. A point has two data attributes: x and y. For any new Point instance x and y default to zero.
In addition to an __init__() method the Point class defines the following instance methods:

distance() : returns the distance between two points (the second point is passed as an argument to the method)
__str__() : returns a string describing the point
The Segment class models a line segment. A segment has two data attributes: p1 and p2. They are each instances of Point.
 In addition to an __init__() method the Segment class defines the following instance methods:

midpoint() : returns an instance of Point that is the midpoint in the segment
length() : returns the length of the segment
The Circle class models a circle. A circle has two data attributes: radius (a floating point number) and centre
(an instance of Point). In addition to an __init__() method the Circle class defines the following instance method:

overlap() : returns True if one Circle overlaps another (passed as an argument) and False otherwise
Once your classes are correctly implemented, running the following program should produce the given output:

from geometry_72 import Point, Segment, Circle

def main():
    p1 = Point()
    p2 = Point(5, 5)
    s1 = Segment(p1, p2)
    s2 = Segment(p2, p1)
    c1 = Circle(p1, 5)
    c2 = Circle(p2, 2)
    c3 = Circle(p1, 2)

    print(p1)
    print(p2)
    print(s1.midpoint())
    print(s2.midpoint())
    print(c1.overlaps(c2))
    print(c2.overlaps(c1))
    print(c1.overlaps(c3))
    print(c3.overlaps(c2))

if __name__ == '__main__':
    main()
$ python3 geometry_72_demo.py
(0.0, 0.0)
(5.0, 5.0)
(2.5, 2.5)
(2.5, 2.5)
False
False
True
False"""
from math import sqrt
class Point(object):
    def __init__(self,x=0,y=0):
        self.x=x
        self.y=y
    def distance(self,anotherpointinstance):
        distance=sqrt((self.x-anotherpointinstance.x)**2+(self.y-anotherpointinstance.y)**2)
        return distance
    def __str__(self):
        return("({:.1f}, {:.1f})".format(self.x,self.y))
class Segment(object):
    def __init__(self,pointone,pointtwo):#pointinstances takn as arguments,and they will contain x ,y instance variables
        self.pointone=pointone
        self.pointtwo=pointtwo


    def midpoint(self):#midpoint will be midpoint bettween x of point1 and z of point2,and y will have same rule
        midpointx = (self.pointone.x+self.pointtwo.x)/2
        midpointy=(self.pointone.y+self.pointtwo.y)/2
        midpoint=midpointx,midpointy#create a tupple
        return midpoint
class Circle(object):
    def __init__(self,centre,radius=0.0):
        self.centre=centre
        self.radius=radius
    def overlaps(self,Circleinstance):
        distance = sqrt((self.centre.x -Circleinstance.centre.x) ** 2 + (self.centre.y -Circleinstance.centre.y) ** 2)
        if self.radius+Circleinstance.radius>distance:
            return True
        return False

def main():
    p1 = Point()
    p2 = Point(5, 5)
    s1 = Segment(p1, p2)
    s2 = Segment(p2, p1)
    c1 = Circle(p1, 5)
    c2 = Circle(p2, 2)
    c3 = Circle(p1, 2)

    print(p1)
    print(p2)
    print(s1.midpoint())
    print(s2.midpoint())
    print(c1.overlaps(c2))
    print(c2.overlaps(c1))
    print(c1.overlaps(c3))
    print(c3.overlaps(c2))

if __name__ == '__main__':
    main()



