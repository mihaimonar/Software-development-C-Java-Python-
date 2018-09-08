"""In time_82.py define a Time class to model a 24-hour time as follows:
class Time###this was a picture but couldn t copy it
----------
integer hour
integer minute
ineger second
-----------
__init__()
__eq__()
__gt__()
__add__()
__iadd__()
__str__()
integer time_to_seconds()
Time seconds to time()#####picture of a class
----------------------(time to seconds has a continuous line under it)








../../_images/time_82.png
Each box consists of three compartments: class name, data attributes, methods. If a data attribute is underlined it is
 a class variable (otherwise it is an instance variable). If a method is underlined it is a class method
 (otherwise it is an instance method).

When your class is correctly implemented, running the following program should produce the given output:

from time_82 import Time

def main():

    t1 = Time()
    t2 = Time(9,35,16)
    t3 = Time(0,0,4)
    t4 = Time(9,35,16)

    # Check string representation
    print('Printing times...')
    print(t1)
    print(t2)
    print(t3)

    # Check equality
    print('Checking equality...')
    print(t2 == t4)
    print(t1 == t3)

    # Check greater than/less than
    print('Checking greater than/less than...')
    print(t2 > t3)
    print(t2 < t3)
    print(t4 > t1)
    print(t4 < t1)

    # Check addition
    print('Checking addition...')
    t5 = t2 + t2 + t2
    print(t5)
    print(t5 > t2)

    # Check increment
    print('Checking increment...')
    t33 = t2
    t2 += t2
    t2 += t4
    print(t2)
    print(t33 is t2)
    print(t2 > t3)

    # Check class method
    print('Checking class method...')
    t6 = Time.seconds_to_time(123456)
    print(t6)
    print(t6 > t1)

if __name__ == '__main__':
    main()
$ python3 time_82_demo.py
Printing times...
The time is 00:00:00
The time is 09:35:16
The time is 00:00:04
Checking equality...
True
False
Checking greater than/less than...
True
False
True
False
Checking addition...
The time is 04:45:48
False
Checking increment...
The time is 04:45:48
True
True
Checking class method...
The time is 10:17:36
True"""
#solution could b edifferen a points but i wanted to use functions in methods or methods in methods
#just to get a hand on how tings work in classes
class Time(object):
    def __init__(self,hour=0,minute=0,second=0):
        self.hour=hour
        self.minute=minute
        self.second=second
    def __eq__(self, other):
        if self.hour==other.hour and self.minute==other.minute and self.second==other.second:
            return True
        return False
    @staticmethod
    def time_to_seconds(other):# it is static as it doesn t make refernce to self methods,variables or to instance itself(self)
        seconds=other.hour*60*60+other.minute*60+other.second
        return seconds

    def __add__(self,other):
        otherTimeinstseconds=(self.hour+other.hour)*60*60+(self.minute+other.minute)*60+self.second+other.second
        #this creates totalseconds for both instances adedd
        #print(otherTimeinstseconds)
        return self.seconds_to_time(otherTimeinstseconds)#this returns a new Time instance by converting totalseconds to time format
        #and is a good example of how to us e a class method
        #return is included in thos class method and it will return a new instance
        #of the class cls(if this funct is used in time it will pass time to cls and will xcreae atime cls,if its car will return car,
        #cls basically is a place holder for the class in which this method is used ,so if we inherit from a parent class
        #that holds a cls method and we use the classmethod in the child class then the new instance will take the \
        #child class name so cls does that job ..if clasmethod returns TIMe(ble,bla,bla) instead of cls(hyd,ydgw,Yy)
        #if we return like Time(...) then if we inherit the classmethod in the subclass then it will return a TIme
        #class even though it is used in a child class with another name .If we use cls it will put the child class if the
        #iherited cls is writeen like cls(cyeh,geu,dygey) so cls! not the name of the class like:TIME(cbhydcb,dugw,dygd)
        #return newinstance..i stored the function that is returned in this newinstance variable,but it
        #seems i can return the function instead (and the function when executed will return a new Time instance)
        #which is actually the purpose of the __add __ ..to return a new instance of time !



    def __iadd__(self, other):
        totalseconds=self.time_to_seconds(self)+self.time_to_seconds(other)#use a static method in a instance method
        newinstance=self.seconds_to_time(totalseconds)#store the return of the class method-which returns a instance of Time
        #  in a variable which will be the name of the instance so we can retrieve time,hour,min atributes and store them
        #bellow in self(__iadd__ purpose is to update the self ,so it's a inplace replacement)
        #if self changes inplace all variables that were equal to it will change everywhere
        self.hour,self.minute,self.second=newinstance.hour,newinstance.minute,newinstance.second
        return self#don t forget to RETURN something !!!
    def __gt__(self, other):#here we can use the convert to seconds functions ...much easier :)
        if self.hour>other.hour:#my logic idf it aint greater and aint smaller they must
            #be equal hours then we do another elif for minutes ,and if minutes are not either> or<
            #they are equal and we go to seconds..this is not the recomeneded solution,ideally we
            #shoulfd transform everything to seconds
            return True
        elif self.hour <other.hour:
            return False
        elif self.minute>other.minute:
            return True
        elif self.minute<other.minute:
            return False
        elif self.second>other.second:
            return True
        elif self.second<other.second:
            return False
        else:
            self==other
            print("They are equal)")
    @classmethod
    def seconds_to_time(cls,secondsargument):#these classmethods are ususaly used for creating a new class instance as
        #in this example,cls arg is esential,so don't use the CLass actual name,TIme instead of cls! as this is a chance
        #for subclasses to use this parent method and when they use it this cls method will create instances of the child cls
        #as child will substitute cls,if we have Time instead in class method then a subclass will not be able to create a new instance
        #of that subclass if it usess the clasmethod of the parent in it nd when it uses it it will actually create a instance of Time
        #because when created the classmethod had as argument the name Time ...so alway use cls not TIMe or car or shit or anything else
        minute,second=divmod(secondsargument,60)
        hour,minute=divmod(minute,60)
        days,hour=divmod(hour,24)
        return cls(hour,minute,second)

    def __str__(self):
        return "The time is {:02d}:{:02d}:{:02d}".format(self.hour,self.minute,self.second)
    #02d will put zero 2 times if there is no argument provided,if it's 05d will put 5 zeros ,but only if there is no argument
    #so if we have 1 it will do 00001,but if we have 12345 will not put a 0 anywhere ,..it only fills the empty spaces at the front
    #with zeros


def main():
    t1 = Time()
    t2 = Time(9, 35, 16)
    t3 = Time(0, 0, 4)
    t4 = Time(9, 35, 16)

    # Check string representation
    print('Printing times...')
    print(t1)
    print(t2)
    print(t3)

    # Check equality
    print('Checking equality...')
    print(t2 == t4)
    print(t1 == t3)

    # Check greater than/less than
    print('Checking greater than/less than...')
    print(t2 > t3)
    print(t2 < t3)
    print(t4 > t1)
    print(t4 < t1)

    # Check addition
    print('Checking addition...')
    t5 = t2 + t2 +t2
    print(t5)
    print(t5 > t2)

    # Check increment
    print('Checking increment...')
    t33 = t2
    t2 += t2
    t2 += t4
    print(t2)
    print(t33 is t2)
    print(t2 > t3)

    # Check class method
    print('Checking class method...')
    t6 = Time.seconds_to_time(123456)
    print(t6)
    print(t6 > t1)


if __name__ == '__main__':
    main()