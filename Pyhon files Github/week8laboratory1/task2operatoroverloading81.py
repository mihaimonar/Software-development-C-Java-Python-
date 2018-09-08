"""In gaa_81.py define a Score class to model a GAA score. A score consists of a number of goals and points.
When your class is correctly implemented, running the following program should produce the given output:

from gaa_81 import Score

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

    # Equality / inequality
    print('Equality / inequality...')
    print(s1 == s2)
    print(s1 != s2)
    print(s2 == s3)
    print(s2 != s3)
    print(s3 == s4)
    print(s3 != s4)

    # Greater than / less than
    print('Greater than / less than...')
    print(s1 > s2)
    print(s2 < s3)

    # Greater than or equal to / less than or equal to
    print('Greater than or equal to / less than or equal to...')
    print(s1 >= s2)
    print(s2 >= s3)
    print(s3 >= s2)
    print(s2 >= s4)
    print(s4 >= s2)
    print(s1 <= s2)
    print(s2 <= s3)
    print(s3 <= s2)
    print(s2 <= s4)
    print(s4 <= s2)

    # Addition
    print('Addition...')
    s6 = s3 + s4
    print(s6)

    # Subtraction
    print('Subtraction...')
    s6 = s2 - s5
    print(s6)

    # In-place addition
    print('In-place addition...')
    s2alias = s2
    s2 += s5
    print(s2)
    print(s2 > s5)
    print(s2 == s2alias)

    # In-place subtraction
    print('In-place subtraction...')
    s2 -= s5
    print(s2)
    print(s2 > s5)
    print(s2 == s2alias)

    # Sorting
    print('Sorting...')
    for s in sorted([s1, s2, s3, s4, s5, s6], reverse=True):
        print(s)

if __name__ == '__main__':
    main()
$ python3 gaa_81_demo.py
Display...
0 goal(s) and 0 point(s)
3 goal(s) and 12 point(s)
4 goal(s) and 9 point(s)
2 goal(s) and 11 point(s)
Equality / inequality...
False
True
True
False
False
True
Greater than / less than...
False
False
Greater than or equal to / less than or equal to...
False
True
True
True
False
True
True
True
False
True
Addition...
6 goal(s) and 20 point(s)
Subtraction...
2 goal(s) and 11 point(s)
In-place addition...
4 goal(s) and 13 point(s)
True
True
In-place subtraction...
3 goal(s) and 12 point(s)
True
True
Sorting...
3 goal(s) and 12 point(s)
4 goal(s) and 9 point(s)
2 goal(s) and 11 point(s)
2 goal(s) and 11 point(s)
1 goal(s) and 1 point(s)
0 goal(s) and 0 point(s)
Hint: do not try to do all of this exercise in one go. Take a copy the code given above and comment out those parts
that you have not yet implemented."""
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
   # def __sorted_(self):







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

    # Equality / inequality
    print('Equality / inequality...')
    print(s1 == s2)
    print(s1 != s2)
    print(s2 == s3)
    print(s2 != s3)
    print(s3 == s4)
    print(s3 != s4)

    # Greater than / less than
    print('Greater than / less than...')
    """print(s1 > s2)
    print(s2 > s1)
    print(s2 < s3)"""

    # Greater than or equal to / less than or equal to
    print('Greater than or equal to / less than or equal to...')
    print(s1 >= s2)
    print(s2 >= s3)
    print(s3 >= s2)
    print(s2 >= s4)
    print(s4 >= s2)
    print(s1 <= s2)
    print(s2 <= s3)
    print(s3 <= s2)
    print(s2 <= s4)
    print(s4 <= s2)

    # Addition
    print('Addition...')
    s6 = s3 + s4
    print(s6)

    # Subtraction
    print('Subtraction...')
    s6 = s2 - s5
    print(s6)

    # In-place addition
    print('In-place addition...')
    s2alias = s2
    s2 += s5
    print(s2)
    #print(s2 > s5)
    print(s2 == s2alias)

    # In-place subtraction
    print('In-place subtraction...')
    s2 -= s5
    print(s2)
    #print(s2 > s5)
    print(s2 == s2alias)

    # Sorting
    print('Sorting...')
    for s in sorted([s1, s2, s3, s4, s5, s6], reverse=True):#i think because we have the __gt__ function implemented sorted will
        #use that function to realise which one is bigger but here we have two of them that are equal at the start but it seems
        #the program prefers one over the other for some reason...if we don t have the __gt__ function implemented in the class
        #sorted will need a key to be provided and in the case of classes that key will have to be a function
        #defined outside the class that returns one of the class atributes: funct(object):
                                                                               # return object.name and that sorted function
        #will take all the objects provided in the list and sort them by name
        #---------------------http://www.thegeekstuff.com/2014/06/python-sorted/-----------------------------
        print(s)

if __name__ == '__main__':
    main()
