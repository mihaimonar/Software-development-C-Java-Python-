"""In gaa_71.py define a Score class to model a GAA score. A score has two data attributes: goals and points.
For any new Score instance goals and points default to zero. One goal is equivalent to three points.
 In addition to an __init__() method the Score class defines the following instance methods:

greater_than() : returns True if one score is greater than another and False otherwise
less_than() : returns True if one score is less than another and False otherwise
equal_to : returns True if one score is equal to another and False otherwise
When your class is correctly implemented, running the following program should produce the given output:

from gaa_71 import Score

def main():

    score1 = Score()
    score2 = Score(3, 9)
    score3 = Score(4, 6)

    print(score1.less_than(score2))
    print(score3.less_than(score1))
    print(score1.greater_than(score2))
    print(score3.greater_than(score2))
    print(score1.greater_than(score1))
    print(score2.greater_than(score1))
    print(score2.equal_to(score1))
    print(score3.equal_to(score2))

if __name__ == '__main__':
    main()
$ python3 gaa_71_demo.py
True
False
False
False
False
True
False
True"""
class Score(object):
    def __init__(self,goals=0,points=0):
        self.goals=goals
        self.points=points
        self.score=3*self.goals+self.points
    def greater_than(self,anothscoreinstance):
        if self.score>anothscoreinstance.score:
            return True#if this is executed then the second return isn't,if this isn t executed then False will be returned
        return False
    def less_than(self,anothscoreinstance):
        if self.score<anothscoreinstance.score:
            return True
        return False
    def equal_to(self,anothscoreinstance):
        if self.score==anothscoreinstance.score:
            return  True
        return False

def main():

    score1 = Score()
    score2 = Score(3, 9)
    score3 = Score(4, 6)

    print(score1.less_than(score2))
    print(score3.less_than(score1))
    print(score1.greater_than(score2))
    print(score3.greater_than(score2))
    print(score1.greater_than(score1))
    print(score2.greater_than(score1))
    print(score2.equal_to(score1))
    print(score3.equal_to(score2))

if __name__ == '__main__':
    main()


