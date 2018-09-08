"""In circle_81.py define a Point class to model a point in a two dimensional space. A point has two data attributes: x and y. For any new Point instance x and y default to zero. In addition to suitable __init__() and __str__() methods the Point class defines the following instance method:

midpoint() : returns an instance of Point that is the midpoint between this point and another point
In circle_81.py also define a Circle class to model a circle in a two dimensional space. A circle has two data attributes: radius (a floating point number) and centre (an instance of Point). For any new Circle instance the radius defaults to zero and its centre defaults to the Point (0,0). Define appropriate __init__() and __str__() methods.

It is possible to “add” circles. Adding two circles, A and B, produces a new circle whose centre is the midpoint between the centres of A and B and whose radius is the sum of the radii of A and B. Add the appropriate instance method to the Circle class to enforce this behaviour.

Once your classes are correctly implemented, running the following program should produce the given output:

from circle_81 import Point, Circle

def main():
    p1 = Point()
    p2 = Point(4,6)
    c1 = Circle(p1, 10)
    c2 = Circle(p2, 5)
    c3 = c1 + c2
    print(c3)

    p3 = Point(10,10)
    c4 = Circle(p3,15)
    c5 = c2 + c4
    print(c5)

if __name__ == '__main__':
    main()
$ python3 circle_81_demo.py
Centre: (2.0, 3.0)
Radius: 15
Centre: (7.0, 8.0)
Radius: 20"""
class Point(object):
    def __init__(self,x=0,y=0):
        self.x=x
        self.y=y
    def __str__(self):
        return("Point: ({},{})".format(self.x,self.y))
    def midpoint(self,anotherpointinst):
        #distance=sqrt((self.x-anotherpointinst.x)**2+(self.y-anotherpointinst.y)**2) this is dist formula
        return Point((self.x+anotherpointinst.x)/2,(self.y+anotherpointinst.y)/2)


class Circle(object):
    def __init__(self,pointinstance=Point(0,0),radius=0.0):
        self.pointinstance=pointinstance
        self.radius=radius
    def __str__(self):
        return("Circle: ({}, {})\nRadius: {}".format(self.pointinstance.x,self.pointinstance.y,self.radius))
    def __add__(self,othercircleinst):
        return Circle(Point((self.pointinstance.x + othercircleinst.pointinstance.x) / 2, (self.pointinstance.y + othercircleinst.pointinstance.y) / 2)
                      ,radius=self.radius+othercircleinst.radius)



def main():
    p1 = Point()
    p2 = Point(4, 6)
    c1 = Circle(p1, 10)
    c2 = Circle(p2, 5)
    c3 = c1 + c2
    print(c3)

    p3 = Point(10, 10)
    c4 = Circle(p3, 15)
    c5 = c2 + c4
    print(c5)


if __name__ == '__main__':
    main()
