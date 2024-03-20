class Node:
    def __init__(self, data=None):
        self.data = data
        self.next = None


class LinkedList:
    def __init__(self):
        self.head = None

    def insertAtFront(self, data):
        newNode = Node(data)
        newNode.next = self.head
        self.head = newNode

    def insertAtSpecifiedPosition(self, position, data):
        node = self.head
        newNode = Node(data)
        if(position == 0):
            self.head = newNode
            newNode.next = node
            return
        count = 1
        nextNode = node.next
        while(node.next != None and count < position):
            count += 1
            node = node.next
            nextNode = node.next
        node.next = newNode
        newNode.next = nextNode

    def insertAtBack(self, data):
        if(self.head is None):
            self.head = Node(data)
        else:
            node = self.head
            while(node.next != None):
                node = node.next
            node.next = Node(data)

    def returnAtFront(self):
        if(self.isEmptyLinkedList()):
            return
        return self.head.data

    def returnAtSpecifiedPosition(self, position):
        if(self.isEmptyLinkedList()):
            return
        node = self.head
        count = 1
        while(node.next != None and count < position):
            count += 1
            node = node.next
        return node.data

    def TraverseToPrint(self):
        node = self.head
        while(node != None):
            print(node.data)
            node = node.next

    def removeAtFront(self):
        if(self.isEmptyLinkedList()):
            return
        self.head = self.head.next

    def removeAtBack(self):
        if(self.isEmptyLinkedList()):
            return
        node = self.head
        while(node.next.next != None):
            node = node.next
        node.next = None

    def RemoveAtSpecifiedPosition(self, position):  # fix last value
        if(self.isEmptyLinkedList()):
            return
        if(position in [0, 1]):
            self.removeAtFront()
            return
        node = self.head
        nextNode = node.next
        count = 2
        while(nextNode.next != None and count < position):
            count += 1
            node = node.next
            nextNode = node.next
        node.next = nextNode.next

    def isEmptyLinkedList(self):
        if(self.head == None):
            return True

    def isFull(self, desiredLength):
        # There is nothing like full linked list. when keep a desired length as needed
        node = self.head
        count = 1
        while(node.next != None):
            count += 1
            if(count >= desiredLength):
                return True
            node = node.next
        return False

    def FindIndexOfDataItem(self, dataItem):
        node = self.head
        count = 0
        while(node != None):
            count += 1
            if(node.data == dataItem):
                return count
            node = node.next
        return 0


ll = LinkedList()
ll.insertAtFront(1)
ll.insertAtSpecifiedPosition(2, 2)
ll.insertAtBack(3)
ll.insertAtBack(4)
ll.insertAtBack(5)
ll.removeAtFront()
ll.removeAtBack()
print(ll.returnAtSpecifiedPosition(2))
print(ll.returnAtFront())
print('Empty' if ll.isEmptyLinkedList() else 'Not Empty')
print('Full' if ll.isFull(5) else 'Not Full')
print(ll.FindIndexOfDataItem(3))
ll.TraverseToPrint()
