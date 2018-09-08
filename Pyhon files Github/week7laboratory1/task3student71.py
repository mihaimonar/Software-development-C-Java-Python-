"""In student_71.py define a Student class to model a student. A student has four data attributes: sid (student ID),
surname, forename and modlist (the list of modules for which the student is registered). For any new Student instance
modlist is empty by default. In addition to an __init__() method the Student class defines the following instance methods:

add_module() : adds a module (passed as an argument) to modlist (has no effect if modlist already contains the module)
del_module() : removes a module (passed as an argument) from modlist (has no effect if the module is not in modlist)
print_details() : prints student details (see example output below for how student details should be displayed)
When your class is correctly implemented, running the following program should produce the given output:

from student_71 import Student

def main():

    student1 = Student('Murphy', 'Jimmy', 15234654)
    student1.add_module('CA117')
    student1.add_module('CA116')
    student1.add_module('CA114')
    student1.print_details()

    student2 = Student('Lannister', 'Cersei', 15876123, ['CA115', 'CA216'])
    student2.del_module('CA216')
    student2.del_module('CA117')
    student2.del_module('CA216')
    student2.add_module('CA117')
    student2.print_details()

if __name__ == '__main__':
    main()
$ python3 student_71_demo.py
ID: 15234654
Surname: Murphy
Forename: Jimmy
Modules: CA117 CA116 CA114
ID: 15876123
Surname: Lannister
Forename: Cersei
Modules: CA115 CA117"""
class Student(object):
    def __init__(self,surname,forename,sid,modlist=None):#modlist is a list of modules for a student
        self.sid=sid
        self.surname=surname
        self.forename=forename
        if modlist==None:#why i done this!!...because lists are mutable and if we do in init:modlist=[],
            #then if we have a instance that doesn t provide a list as an argument then that instance will use the default list
            #but if there are more instances that do not supply a list as argument they will also take this list as default:
            #THE PROBLEM IS THAT THIS LIST WILL BE COMMON TO ALL INSTANCES AND DOING A FUNCTION ON THAT LIST LIKE APPEND OR OTHER FUNCTION
            #THEY WILL MODIFY THAT LIST IN PLACE (IN PLACE MEANS THAT IT WILL UPDATE THE SAME LIST AND NOT CREATE A NEW ONE)
            #AND THIS BEHAVIOUR OF HAVING A COMMON LIST FIOR MORE INSTANCES IS NOT DESIRED.
            #WE CAN SET UP A LIST LIKE A CLASS ATRIBUTE AND UPDATE THAT IF WE WANT LIKE THIS :
            #we can do a list=[] as class atribute(so above init) and update it in init if we want like Student.list.append(self.sid
            #...we can put what w e want in it so every time a instance is created that list will either contain atributes of the instances,
            #or we can create  a counter of each time we create a instance like:student.counter(this will be put in init function and
            #the initiation of the class counter variable will be above the init method
            #bk to why i done this...in this way the list will be unique for each instance so mutable variables set as default can
            #end up being shared by instances that take that default value so we don t want that with some exceptions as explained
            #bellow so to avoid use the default--- None--- even for class variables cause they will end up being shared as well if we set them
            #as being of mutable type
            self.modlist=[]
        else:
            self.modlist=modlist
    def add_module(self,module):
        if module not in self.modlist:
            self.modlist.append(module)
    def del_module(self,module):
        if module in self.modlist:
            self.modlist.remove(module)
    def print_details(self):
        print("ID:",self.sid,"\n""Surname:",self.surname,"\n""Forename:",self.forename)
        print("Modules:"," ".join(self.modlist))

def main():
    student1 = Student('Murphy', 'Jimmy', 15234654)
    student1.add_module('CA117')
    student1.add_module('CA116')
    student1.add_module('CA114')
    student1.print_details()

    student2 = Student('Lannister', 'Cersei', 15876123, ['CA115', 'CA216'])
    student2.del_module('CA216')
    student2.del_module('CA117')
    student2.del_module('CA216')
    student2.add_module('CA117')
    student2.print_details()


if __name__ == '__main__':
    main()



