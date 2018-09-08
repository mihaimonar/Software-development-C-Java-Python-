"""DCU’s Marks and Standards defines the rules on whether a student passes, passes by compensation or fails at the
 end of the year. For compensation to apply all of the following criteria must be met:

A minimum precision mark of 45% has been obtained. (A precision mark is the weighted average mark for a student
 across all modules. The weighting of each module is proportional to the credits associated with that module i.e. a
 10 credit module carries twice as much weight as a 5 credit module.)
A maximum of 1/6 of the credits for the academic year have been failed.
The marks obtained in the individual failed modules are 35%+.
Write a program called student_81.py that models a CA1 student. Once all results for the year have been submitted
the program determines whether the student has passed, passed by compensation or failed. Below is a preliminary
 version of the program. Your task is to extend the provided code by implementing the add_mark(), precision_mark(),
  passed() and passed_by_compensation() methods:

from collections import namedtuple

Module = namedtuple('Module', 'code title ects')

CA1_MODULES = {'CA103': Module('CA103', 'Computer Systems', 5),
               'CA106': Module('CA106', 'Web Design', 5),
               'CA115': Module('CA115', 'Digital Innovation', 5),
               'CA116': Module('CA116', 'Computer Programming I', 10),
               'CA117': Module('CA117', 'Computer Programming II', 10),
               'CA169': Module('CA169', 'Networks and Internet', 5),
               'CA170': Module('CA170', 'Operating Systems', 5),
               'CA172': Module('CA172', 'Problem Solving', 5),
               'MS121': Module('MS121', 'IT Mathematics', 10)}

class Student(object):

    def __init__(self, idnum, surname, firstname, mods=CA1_MODULES):
        self.__idnum = idnum
        self.__surname = surname
        self.__firstname = firstname
        self.__mods = mods
        self.__marks = {code: 0 for code in self.__mods.keys()}

    def __str__(self):
        name = '{} : {} {}'.format(self.__idnum,
                                   self.__firstname,
                                   self.__surname)
        uline = '-' * len(name)
        results =  '\n'.join([code + ' : ' + self.__mods[code].title +
                              ' : ' + str(self.__marks[code])
                              for code in sorted(self.__mods.keys())])
        pm = 'Precision mark: {:.2f}'.format(self.precision_mark())
        if self.passed():
            outcome = 'Pass'
        elif self.passed_by_compensation():
            outcome = 'Pass by compensation'
        else:
            outcome = 'Fail'

        return '\n'.join([name, uline, results, pm, outcome])

    def add_mark():
        pass

    def precision_mark():
        pass

    def passed():
        pass

    def passed_by_compensation():
        pass
Once your Student class is correctly implemented, running the following program should produce the given output:

from student_81 import Student

def main():

    s1 = Student(15334499, 'Jones', 'Zoe')
    s1.add_mark('CA103', 71)
    s1.add_mark('CA106', 65)
    s1.add_mark('CA115', 84)
    s1.add_mark('CA116', 85)
    s1.add_mark('CA117', 70)
    s1.add_mark('CA169', 68)
    s1.add_mark('CA170', 74)
    s1.add_mark('CA172', 90)
    s1.add_mark('MS121', 50)

    s2 = Student(15667755, "Brent", "Tom")
    s2.add_mark('CA103', 55)
    s2.add_mark('CA106', 35)
    s2.add_mark('CA115', 70)
    s2.add_mark('CA116', 64)
    s2.add_mark('CA117', 66)
    s2.add_mark('CA169', 50)
    s2.add_mark('CA170', 55)
    s2.add_mark('CA172', 60)
    s2.add_mark('MS121', 35)

    s3 = Student(15112277, 'Brody', 'Joe')
    s3.add_mark('CA103', 35)
    s3.add_mark('CA106', 35)
    s3.add_mark('CA115', 60)
    s3.add_mark('CA116', 60)
    s3.add_mark('CA117', 60)
    s3.add_mark('CA169', 60)
    s3.add_mark('CA170', 60)
    s3.add_mark('CA172', 60)
    s3.add_mark('MS121', 60)

    print(s1)
    print(s2)
    print(s3)

if __name__ == '__main__':
    main()
$ python student_81_demo.py
15334499 : Zoe Jones
--------------------
CA103 : Computer Systems : 71
CA106 : Web Design : 65
CA115 : Digital Innovation : 84
CA116 : Computer Programming I : 85
CA117 : Computer Programming II : 70
CA169 : Networks and Internet : 68
CA170 : Operating Systems : 74
CA172 : Problem Solving : 90
MS121 : IT Mathematics : 50
Precision mark: 71.83
Pass
15667755 : Tom Brent
--------------------
CA103 : Computer Systems : 55
CA106 : Web Design : 35
CA115 : Digital Innovation : 70
CA116 : Computer Programming I : 64
CA117 : Computer Programming II : 66
CA169 : Networks and Internet : 50
CA170 : Operating Systems : 55
CA172 : Problem Solving : 60
MS121 : IT Mathematics : 35
Precision mark: 54.58
Fail
15112277 : Joe Brody
--------------------
CA103 : Computer Systems : 35
CA106 : Web Design : 35
CA115 : Digital Innovation : 60
CA116 : Computer Programming I : 60
CA117 : Computer Programming II : 60
CA169 : Networks and Internet : 60
CA170 : Operating Systems : 60
CA172 : Problem Solving : 60
MS121 : IT Mathematics : 60
Precision mark: 55.83
Pass by compensation"""
from collections import namedtuple

Module = namedtuple('Module', 'code title ects')

CA1_MODULES = {'CA103': Module('CA103', 'Computer Systems', 5),
               'CA106': Module('CA106', 'Web Design', 5),
               'CA115': Module('CA115', 'Digital Innovation', 5),
               'CA116': Module('CA116', 'Computer Programming I', 10),
               'CA117': Module('CA117', 'Computer Programming II', 10),
               'CA169': Module('CA169', 'Networks and Internet', 5),
               'CA170': Module('CA170', 'Operating Systems', 5),
               'CA172': Module('CA172', 'Problem Solving', 5),
               'MS121': Module('MS121', 'IT Mathematics', 10)}


class Student(object):
    def __init__(self, idnum, surname, firstname, mods=CA1_MODULES):
        self.__idnum = idnum
        self.__surname = surname
        self.__firstname = firstname
        self.__mods = mods
        self.__marks = {code: 0 for code in self.__mods.keys()}

    def __str__(self):
        name = '{} : {} {}'.format(self.__idnum,
                                   self.__firstname,
                                   self.__surname)
        uline = '-' * len(name)
        results = '\n'.join([code + ' : ' + self.__mods[code].title +
                             ' : ' + str(self.__marks[code])
                             for code in sorted(self.__mods.keys())])
        pm = 'Precision mark: {:.2f}'.format(self.precision_mark())
        if self.passed():
            outcome = 'Pass'
        elif self.passed_by_compensation():
            outcome = 'Pass by compensation'
        else:
            outcome = 'Fail'

        return '\n'.join([name, uline, results, pm, outcome])

    def add_mark(self,module,other):
        self.__marks[module]=other

    def precision_mark(self):
        total=0#this will hold the average mark on all modules at the end of he year
        creditsper5ectsmodule=1/(6+2*3)#every 5 credit module is calculated a s a part of a whole(1),so we have
        #6 modules with 5 credits so 6*1  and 3 modules with double credits that are calculated as 2 parts of a whole()
        #for each module so altogether we will dicvide 1/12 to find out how much % a 5 credit module is worth and
        #for modules that have 10 credits we will multiply this percentage by 2 cause they worth double
        for key in self.__marks.keys():
            if self.__mods[key].ects==5:
                total+=self.__marks[key]*creditsper5ectsmodule#for 5 credits we do percentage of that grade *grade
            else:
                total+=self.__marks[key]*creditsper5ectsmodule*2#here we do grade *percentage82 because the modules that don t have 5 credits
                #will have 10 credits in our case which are double!
        return total








    def passed(self):
        for key in self.__marks:
            if self.__marks[key]<40:
                return False#if any of the marks is bellow 40 then we return False which in our conditional bellow
            #will be like IF False:print passed...but because is false ,if false evaluates to false and won t be
            #executed as if is execeuted ony when True. so in order to print passed we need all our marks to be above 40
        return True


    def passed_by_compensation(self):#if at least one of our grades is bellow 40 then this function will evaluate if
        #we pass b compensation:which
        decision=0
        ects=0#calculates ects of ONLY modules that were passed
        totalects=0#calculates ects for all modules
        #purpose for the 2 variables above is to see ects/totalects---this will show the % that passed,
        for key in self.__mods:
            if self.__marks[key]>=40:
                ects+=self.__mods[key].ects#ects points of all modules that were passed
        for key in self.__mods:
            totalects+=self.__mods[key].ects
        if 1-ects/totalects>1/6:#doing 1-ects/totalects will calculate the %that didn t pass and compare if it;s
            #>than 1/6 as this is the threshold,if we didn t pass more than 1/6 then we don t pass by compensation
            return False#----all this return False ..explained: if Any of the rules is broken then everything colapses
        #so if one returns False then  we don t pass b compensation,BUT if ALL are True then we return at the end of the program
        #and doing IF passbycompensation(),will be  IF TRUE wich will let IF execute as we have TRUE after IF and then
        #the print that we passed will execeute


        if self.precision_mark()<45:
            return False
        for key in self.__marks:
            if self.__marks[key]<35:
                return False
        return True




def main():
    s1 = Student(15334499, 'Jones', 'Zoe')
    s1.add_mark('CA103', 71)
    s1.add_mark('CA106', 65)
    s1.add_mark('CA115', 84)
    s1.add_mark('CA116', 85)
    s1.add_mark('CA117', 70)
    s1.add_mark('CA169', 68)
    s1.add_mark('CA170', 74)
    s1.add_mark('CA172', 90)
    s1.add_mark('MS121', 50)

    s2 = Student(15667755, "Brent", "Tom")
    s2.add_mark('CA103', 55)
    s2.add_mark('CA106', 35)
    s2.add_mark('CA115', 70)
    s2.add_mark('CA116', 64)
    s2.add_mark('CA117', 66)
    s2.add_mark('CA169', 50)
    s2.add_mark('CA170', 55)
    s2.add_mark('CA172', 60)
    s2.add_mark('MS121', 35)

    s3 = Student(15112277, 'Brody', 'Joe')
    s3.add_mark('CA103', 35)
    s3.add_mark('CA106', 35)
    s3.add_mark('CA115', 60)
    s3.add_mark('CA116', 60)
    s3.add_mark('CA117', 60)
    s3.add_mark('CA169', 60)
    s3.add_mark('CA170', 60)
    s3.add_mark('CA172', 60)
    s3.add_mark('MS121', 60)

    print(s1)
    print(s2)
    print(s3)


if __name__ == '__main__':
    main()
