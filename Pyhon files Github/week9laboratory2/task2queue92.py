"""In queue_92.py define a Queue class to model the queue abstract data type as follows:
Queue
-------
list l
------
init
enqueue
dequeue
first
is_empty
__len__

../../_images/queue_92.png
Each box consists of three compartments: class name, data attributes, methods. If a data attribute is underlined it is
a class variable (otherwise it is an instance variable). If a method is underlined it is a class method (otherwise it is an instance method).

Read the notes on queue methods to determine their required behaviour.

When your class is correctly implemented, running the following program should produce the given output:

from queue_92 import Queue

def main():

    q = Queue()

    print(len(q))
    q.enqueue(1)
    print(q.first())
    print(q.is_empty())
    print(q.dequeue())
    print(q.is_empty())
    try:
        print(q.dequeue())
    except IndexError:
        print('Error')
    try:
        print(q.first())
    except IndexError:
        print('Error')
    q.enqueue('cat')
    q.enqueue('dog')
    q.enqueue('fish')
    print(len(q))
    print(q.dequeue())
    print(q.dequeue())
    print(q.dequeue())
    print(q.is_empty())

if __name__ == '__main__':
    main()
$ python3 queue_92_demo.py
0
1
False
1
True
Error
Error
3
cat
dog
fish
True"""
class Queue(object):
    def __init__(self):
        self.l=[]
    def __len__(self):
        return len(self.l)
    def enqueue(self,item):
        self.l.append(item)
    def dequeue(self):# i had problems here as if i was deleting without storing it beforehand in a variable
        #i couldn't return the element [0] as it was already deleted,so i stored it in item and returned item
        item=self.l[0]
        del self.l[0]
        return item


    def first(self):
        return self.l[0]
    def is_empty(self):
        if self.l==[]:
            return True
        return False


def main():

    q = Queue()

    print(len(q))
    q.enqueue(1)
    print(q.first())
    print(q.is_empty())
    print(q.dequeue())
    print(q.is_empty())
    try:
        print(q.dequeue())
    except IndexError:
        print('Error')
    try:
        print(q.first())
    except IndexError:
        print('Error')
    q.enqueue('cat')
    q.enqueue('dog')
    q.enqueue('fish')
    print(len(q))
    print(q.dequeue())
    print(q.dequeue())
    print(q.dequeue())
    print(q.is_empty())

if __name__ == '__main__':
    main()