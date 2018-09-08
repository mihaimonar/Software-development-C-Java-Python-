"""In gaa_mult_81.py define a Score class to model a GAA score. (Simply copy over the code you used in gaa_81.py). Extend the class so it supports multiplication. When your class is correctly implemented, running the following program should produce the given output:

from gaa_mult_81 import Score

def main():

    # Create some instances of Score
    s1 = Score()
    s2 = Score(3, 12)
    s3 = Score(4, 9)
    s4 = Score(2, 11)
    s5 = Score(1, 1)

    # Display
    print('Display...')
    print(s1)
    print(s2)
    print(s3)
    print(s4)

    # Multiplication
    print('Multiplication...')
    s2 = s2 * 2
    print(s2)
    print(s2 > s3)

    # Right multiplication
    print('Right multiplication...')
    s2 = 2 * s2
    print(s2)
    print(s2 > s3)

    # In-place multiplication
    print('In-place multiplication...')
    s2alias = s2
    s2 *= 2
    print(s2)
    print(s2alias)
    print(s2 == s2alias)

if __name__ == '__main__':
    main()
$ python3 gaa_mult_81_demo.py
Display...
0 goal(s) and 0 point(s)
3 goal(s) and 12 point(s)
4 goal(s) and 9 point(s)
2 goal(s) and 11 point(s)
Multiplication...
6 goal(s) and 24 point(s)
True
Right multiplication...
12 goal(s) and 48 point(s)
True
In-place multiplication...
24 goal(s) and 96 point(s)
24 goal(s) and 96 point(s)
True"""
class Score(object):
    def __init__(self,goals=0,points=0):
        self.goals=goals
        self.points=points
        self.total=self.goals*3+self.points
    def __eq__(self, other):
        if self.total==other.total:
            return True
        return False
    def __gt__(self, other):
        if self.total>other.total:
            return True
        return False
    def __ge__(self, other):
        if self.total>=other.total:
            return True
        return False
    def __add__(self, other):
        otherinstancegoals=self.goals+other.goals
        otherinstancepoints=self.points+other.points
        return Score(otherinstancegoals,otherinstancepoints)
    def __sub__(self, other):
        otherinstancegoals = self.goals-other.goals
        otherinstancepoints = self.points-other.points
        return(Score(otherinstancegoals, otherinstancepoints))
    def __iadd__(self, other):
        otherinstancegoals = self.goals+other.goals
        otherinstancepoints = self.points+other.points
        newinstance=Score(otherinstancegoals, otherinstancepoints)
        self.goals,self.points=newinstance.goals,newinstance.points
        return self
    def __isub__(self, other):
        otherinstancegoals = self.goals-other.goals
        otherinstancepoints = self.points-other.points
        newinstance = Score(otherinstancegoals, otherinstancepoints)
        self.goals, self.points = newinstance.goals, newinstance.points
        return self
    def __mul__(self, other):
        #s2=s2*2  requires __mul__ function as the new s2 is a totaly different object with a diferent namespace
        #than the old s2
        #s2*=2 is inplace   and needs __imul__ function and keeps the old s2 namespace

        #here i ceated as in __add__ funct a new instance that takes the new created variables
        #goals and points as arguments...doing self.goals=self.goals*other and returning self would be wrong as
        #this is INPLACE  modification so it will update the existing self and not create a new variable
        goals= self.goals*other
        points=self.points*other
        return Score(goals,points)
    def __rmul__(self, other):
        """if isinstance(other,Score):#this alternative construct can tell if the item provided as argument
            #is a class ,here cllass name Score must be provided as self didn t work
            goals=self.goals*other.goals
            points=self.points*other.points
            return Score(goals,points)
        elif isinstance(other,(int,float)):#here we say if other is an integer or foat to multiply..
            goals=self.goals*other
            points=self.points*other
            return Score(goals,points)
        else:
            print("wrong data type provided and can t multiply")"""
        goals= self.goals*other
        points=self.points*other
        return Score(goals,points)
    #if __imul__ isn't defined i think the code will use the __mul__ function instead,
    #but i defined it because mult will give us the wrong answer for inplace multyplyng
    def __imul__(self, other):
        self.goals=self.goals*other
        self.points=self.points*other
        return self










    def __str__(self):
        return("{} goal(s) and {} point(s)".format(self.goals,self.points))


def main():

    # Create some instances of Score
    s1 = Score()
    s2 = Score(3, 12)
    s3 = Score(4, 9)
    s4 = Score(2, 11)
    s5 = Score(1, 1)

    # Display
    print('Display...')
    print(s1)
    print(s2)
    print(s3)
    print(s4)

    # Multiplication
    print('Multiplication...')
    s2 = s2 * 2
    print(s2)
    print(s2 > s3)

    # Right multiplication
    print('Right multiplication...')
    s2 = 2 * s2
    print(s2)
    print(s2 > s3)

    # In-place multiplication
    print('In-place multiplication...')
    s2alias = s2#here s2alias takes the old value of s2
    s2 *= 2#but because her s2 gets updated in place the value of s2 alias will change as well
    #so whATEVER EQUALS TO S2 IN THE PROGRAM WILL CHANGE!!!
    #--second option --this is not same as s2*=somethingthat is above---this is the second option:) :
    # IF WE DO S2=S2+SOMETHING THEN this is not inplace so whatever was equal to s2 still has the old value of
    #s2 and the new s2 will be a new object with a new value so the item that contains the old
    #value of s2 will != the new value of s2 because the s2 will be a diferent object than the old s2
    print(s2)
    print(s2alias)
    print(s2 == s2alias)

if __name__ == '__main__':
    main()
