"""In point_71.py define a Point class to model a point in a two dimensional space. A point has two data attributes: x and y. For any new Point instance x and y default to zero. In addition to an __init__() method the Point class defines the following instance methods:

reflect() : reflects a point’s coordinates through the origin (the effect is to simply negate the point’s x and y coordinates)
distance() : returns the distance between two points (the second point is passed as an argument to the method)
When your class is correctly implemented, running the following program should produce the given output:

from point_71 import Point

def main():
    p1 = Point()
    p2 = Point(3,0)
    print('{:.1f}'.format(p1.distance(p2)))
    print('{:.1f}'.format(p2.distance(p1)))
    p3 = Point(3,0)
    p3.reflect()
    print('{:.1f}'.format(p3.distance(p2)))
    p4 = Point(1,1)
    print('{:.1f}'.format(p4.distance(p1)))

if __name__ == '__main__':
    main()
$ python3 point_71_demo.py
3.0
3.0
6.0
1.4"""
from math import sqrt
class Point(object):
    def __init__(self,x=0,y=0):
        self.x=x
        self.y=y
    def reflect(self):
        self.x=-self.x
        self.y=-self.y
    def distance(self,anotherinstanceofpoint):
        distance=sqrt((anotherinstanceofpoint.x-self.x)**2+(anotherinstanceofpoint.y-self.y)**2)
        return distance

def main():
    p1 = Point()
    p2 = Point(3,0)
    print('{:.1f}'.format(p1.distance(p2)))
    print('{:.1f}'.format(p2.distance(p1)))
    p3 = Point(3,0)
    p3.reflect()
    print('{:.1f}'.format(p3.distance(p2)))
    p4 = Point(1,1)
    print('{:.1f}'.format(p4.distance(p1)))

if __name__ == '__main__':
    main()