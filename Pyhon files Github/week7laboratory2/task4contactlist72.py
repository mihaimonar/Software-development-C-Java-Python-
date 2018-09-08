"""In contacts_72.py define two classes: Contact and ContactList. The Contact class models a contact.
A contact has three data attributes: name, phone, email. In addition to an __init__() method the Contact class the following instance method:

__str__() : returns a string describing a contact’s details
The ContactList class models a contact list. A contact list has a single data attribute: d. d is a dictionary that maps
 a name to an instance of the Contact class. In addition to an __init__() method the ContactList class defines the following instance methods:

add_contact() : adds a new Contact to the contact list (or updates an existing Contact if already present)
del_contact() : removes a Contact from the contact list (no effect if no such contact exists)
get_contact() : returns a string with the specified contact’s details (or returns ‘No such contact’ if not in the contact list)
__str__() : returns a string containing all contacts’ details listed in alphabetical order (it should make use of each
contact’s __str__() method in order to do so)
Once your classes are correctly implemented, running the following program against the contact details supplied below
should produce the given output:

from contacts_72 import Contact, ContactList
import sys

def main():
    cl = ContactList()
    for line in sys.stdin:
        [name, phone, email] = line.strip().split()
        c = Contact(name, phone, email)
        cl.add_contact(c)

    print(cl.get_contact('Jimmy'))
    print(cl.get_contact('Mary'))

    print(cl)
    cl.del_contact('Maggie')
    cl.del_contact('Maggie')

    c = Contact('Sue', '087-6442378', 'sue@eircom.net')
    cl.add_contact(c)
    c = Contact('Fred', '085-8776543', 'fred@yahoo.com')
    cl.add_contact(c)
    print(cl)

if __name__ == '__main__':
    main()
$ cat contacts_long_72.txt
Sue 085-6442378 sue@eircom.net
Jimmy 086-1223277 james@apple.com
Maggie 087-8822001 maggie@microsoft.com
Amy 087-3240516 amy@rte.ie
Wendy 086-9112645 wendy@physics.dcu.ie
Sean 085-3445123 sean@tcd.ie

$ python3 contacts_72_demo.py < contacts_long_72.txt
Jimmy 086-1223277 james@apple.com
Mary : No such contact
Contact list
------------
Amy 087-3240516 amy@rte.ie
Jimmy 086-1223277 james@apple.com
Maggie 087-8822001 maggie@microsoft.com
Sean 085-3445123 sean@tcd.ie
Sue 085-6442378 sue@eircom.net
Wendy 086-9112645 wendy@physics.dcu.ie
Contact list
------------
Amy 087-3240516 amy@rte.ie
Fred 085-8776543 fred@yahoo.com
Jimmy 086-1223277 james@apple.com
Sean 085-3445123 sean@tcd.ie
Sue 087-6442378 sue@eircom.net
Wendy 086-9112645 wendy@ph"""
import sys
from itertools import *
class Contact(object):
    def __init__(self,name,phone,email):
        self.name=name
        self.phone=phone
        self.email=email
    def __str__(self):
        return("{} {} {}".format(self.name,self.phone,self.email))
class ContactList(object):
    def __init__(self):
        self.dictio={}
    def add_contact(self,Contactinstance):
        self.dictio[Contactinstance.name]=Contactinstance
    def del_contact(self,string):
        if string in self.dictio:
            del self.dictio[string]

    def get_contact(self,string):
        return self.dictio.get(string,"{}: No such contact".format(string))

    def __str__(self):
        self.lista = []
        print("Contact list\n------------")
        for key in sorted(self.dictio.keys()):
            haha = str(self.dictio[key])
            # print(haha)
            self.lista.append(haha)


        # print(self.lista)
        # print(self.lista)
        stringg = "\n".join(self.lista).rstrip()
        return ("{}".format(stringg))



def main():
    cl = ContactList()
    for line in sys.stdin:
        [name, phone, email] = line.strip().split()
        c = Contact(name, phone, email)
        cl.add_contact(c)


    print(cl.get_contact('Jimmy'))
    print(cl.get_contact('Mary'))

    print(cl)
    cl.del_contact('Maggie')
    cl.del_contact('Maggie')

    c = Contact('Sue', '087-6442378', 'sue@eircom.net')
    cl.add_contact(c)
    c = Contact('Fred', '085-8776543', 'fred@yahoo.com')
    cl.add_contact(c)
    print(cl)
if __name__ == '__main__':
    main()






