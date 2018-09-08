"""In geometry_91.py define a Point class to model a point in two dimensions. Also define Shape, Triangle and Square classes.
 The relationship between the four classes can be depicted as follows:
 Point(object)---main class
 ------
 float x
 float y
 -----
 init
 distance()
---------------------------------------------------------
Shape(object)
----------
list points
----------
init
sides()
perimeter()
--------------------------------------------------------
Triangle(Shape)
-----------
-----------
area()
--------------------------------------------------------
Square(Shape)
-------------
------------
area()
----------------------------------------------------------




Arrows connect subclasses to superclasses. Each box consists of three compartments: class name, data attributes, methods.
If a data attribute is underlined it is a class variable (otherwise it is an instance variable). If a method is underlined
it is a class method (otherwise it is an instance method).

A Shape is defined by a sequence of connected instances of the Point class. (A connection from the last point to the
first point in the sequence is assumed.) Thus the __init__() method of the Shape class takes a single argument: a list of instances of Point.

The perimeter() method of the Shape class returns the length of the perimeter of an instance of Shape.

The sides() method of the Shape class returns a list containing the length of each side of an instance of Shape.
Note that the order of the sides in the list returned is important.
 If a shape is created from points P1, P2, P3 (in that order) then the sides returned must be P1-P2, P2-P3, P3-P1 (in that order).

The area, A, of a triangle whose sides are of length a, b, c, can be calculated using Heron’s method as follows:

A=s(s−a)(s−b)(s−c)−−−−−−−−−−−−−−−−−√
A=s(s−a)(s−b)(s−c)
where

s=a+b+c2
s=a+b+c2
When your classes are correctly implemented, running the following program should produce the given output:

from geometry_91 import Triangle, Square, Point

def main():

    t1 = Triangle([Point(0,0), Point(3,4), Point(6, 0)])
    print(t1.sides())
    print(t1.perimeter())
    print(t1.area())

    t2 = Triangle([Point(0,0), Point(4,0), Point(4, 3)])
    print(t2.sides())
    print(t2.perimeter())
    print(t2.area())

    s1 = Square([Point(0,0), Point(5,0), Point(5,5), Point(0,5)])
    print(s1.sides())
    print(s1.perimeter())
    print(s1.area())

if __name__ == '__main__':
    main()
$ python3 geometry_91_demo.py
[5.0, 5.0, 6.0]
16.0
12.0
[4.0, 3.0, 5.0]
12.0
6.0
[5.0, 5.0, 5.0, 5.0]
20.0
25.0"""
from math import sqrt
class Point(object):
    def __init__(self,x=0.0,y=0.0):
        self.x=x
        self.y=y
    @staticmethod
    def distance(point1,otherpointinstance):
        distance=sqrt((otherpointinstance.x-point1.x)**2+(otherpointinstance.y-point1.y)**2)
        return distance
class Shape(object):
    def __init__(self,points=None):#hereeee i tried to put default none and if none=none then self.points=[]..didn t work
        #for some reason
        if points == None:
            self.points=[]
        else:
            self.points=points
    def sides(self):
        if len(self.points)<3:
            print("Not enough points in the list to create a shape")
            return []
        else:
            self.allsides=[]
            i=0
            while i<len(self.points)-1:
                self.allsides.append(self.points[i].distance(self.points[i],self.points[i+1]))
                #we call the distance method on any instance of point,as it is a static method and it doesn t depend
                #on the instance,i should make it a instance method and give it a self argument..blabla...
                # anyway this creates distance between all points but it has to unite the last point with the first
                #point so the shape is complete of triangle,square...wont contain all the sides
                i+=1
            self.allsides.append(self.points[i].distance(self.points[0],self.points[i]))#here i conect the last point
            #with point 0 to complete the shape and append allsides to the list containing all sides
            return self.allsides
    def perimeter(self):
        return sum(self.sides())
class Triangle(Shape):
    def area(self):
        semiperi=self.perimeter()/2#we call the perimeter function from Shape class which returns a perimeter of all sides
        area=sqrt(semiperi*(semiperi-self.sides()[0])*(semiperi-self.sides()[1])*(semiperi-self.sides()[2]))
        return area
class Square(Shape):
    def area(self):
        area=self.sides()[0]**2#we call the sides() function from Shape which returns the list allsides containing all sides
        #of the square from which we only need one of them in our case as we have a ssquare and all sides should be equal
        ###our code supplied in the main and the point coordinates make sure this is a square,because is input from teacher
        #but if we give user random input to the  points then we might not end up with a square
        return area


def main():

    t1 = Triangle([Point(0,0), Point(3,4), Point(6, 0)])
    print(t1.sides())#if this wasn t done perimeter and area might not work so it is good to add the sides function
    #in the area and perimeter in case sides is not executed,it will automatically execeuted when we run area or perimeter funct
    print(t1.perimeter())
    print(t1.area())

    t2 = Triangle([Point(0,0), Point(4,0), Point(4, 3)])
    print(t2.sides())
    print(t2.perimeter())
    print(t2.area())

    s1 = Square([Point(0,0), Point(5,0), Point(5,5), Point(0,5)])
    print(s1.sides())
    print(s1.perimeter())
    print(s1.area())

if __name__ == '__main__':
    main()






