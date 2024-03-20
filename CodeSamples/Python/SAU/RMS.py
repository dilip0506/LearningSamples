class Food:
    def __init__(self, ItemId, ItemName, Price):
        self.Id = ItemId
        self.ItemName = ItemName
        self.Price = Price


class Order:
    def __init__(self, ItemId, ItemName="", Price=0, Quantity=1, ItemTotal=0):
        self.Id = ItemId
        self.ItemName = ItemName
        self.Price = Price
        self.Quantity = Quantity
        self.ItemTotal = ItemTotal


class Node:
    def __init__(self, data, prev=None, next=None):
        self.data = data
        self.prev = prev
        self.next = next


class DoublyLinkedList:
    def __init__(self):
        self.head = None

    def InsertNode(self, data):
        newNode = Node(data)
        if self.head is None:
            newNode.prev = self.head
            self.head = newNode
        else:
            node = self.head
            while node.next is not None:
                node = node.next
            node.next = newNode
            newNode.prev = node

    def GetNode(self, Id):
        if self.head is None:
            return
        if self.head.data.Id == Id:
            return self.head
        node = self.head
        while node is not None:
            if Id == node.data.Id:
                return node
            node = node.next

    def DeleteNode(self, node):
        if self.head is None or node is None:
            return
        if self.head == node:
            self.head = node.next
        if node.next is not None:
            node.next.prev = node.prev
        if node.prev is not None:
            node.prev.next = node.next


class ProcessMenu:
    def __init__(self, menuList):
        self.menuList = menuList
        self.Id = 1

    def AddItemToMenu(self, ItemName, Price):
        food = Food(self.Id, ItemName, Price)
        self.menuList.InsertNode(food)
        self.Id += 1

    def GetMenuItem(self, Itemid):
        return self.menuList.GetNode(Itemid)

    def PrintMenu(self):
        node = self.menuList.head
        while node is not None:
            food = node.data
            print(f"\n{food.Id}) Name:{food.ItemName}\tPrice:{food.Price}")
            node = node.next

    def DeleteItem(self, ItemId):
        item = self.GetMenuItem(ItemId)
        self.menuList.DeleteNode(item)
        self.Id -= 1

    def AddPredfinedItems(self, dlist):
        foodItems = {2: "Crunchy Taco", 6: "Pizza"}
        for item in foodItems:
            self.AddItemToMenu(foodItems[item], item)


class ProcessOrder:
    def __init__(self, customerList, menu):
        self.customerList = customerList
        self.menu = menu
        self.Id = 1

    def AddItemToOrder(self, menuItem, Quantity):
        ItemName = menuNode.data.ItemName
        Price = menuNode.data.Price
        ItemTotal = Quantity*Price
        order = Order(self.Id, ItemName, Price, Quantity, ItemTotal)
        self.customerList.InsertNode(order)
        self.Id += 1

    def GetOrderItem(self, Itemid):
        return self.customerList.GetNode(Itemid)

    def PrintOrder(self):
        node = self.customerList.head
        while node is not None:
            order = node.data
            print(
                f"\n{order.Id}) Name:{order.ItemName}\tPrice:{order.Price}\tQuantity:{order.Quantity}\tItemTotal:{order.ItemTotal}")
            node = node.next

    def DeleteOrderItem(self, ItemId):
        orderNode = self.GetOrderItem(ItemId)
        self.customerList.DeleteNode(orderNode)
        self.Id -= 1

    def CalculateTotal(self):
        total = 0
        node = self.customerList.head
        while node is not None:
            order = node.data
            total += order.ItemTotal
            node = node.next
        return total


class Menu:
    def __init__(self):
        self.menuList = DoublyLinkedList()
        self.CustomerList = DoublyLinkedList()
        self.processMenu = ProcessMenu(self.menuList)
        self.processMenu.AddPredfinedItems(self.menuList)
        self.processOrder = ProcessOrder(self.CustomerList, self.processMenu)


    def MainMenuList(self):
        while True:
            print("\nRestaurant Management System")
            print("----------------------------")
            print("1.Admin Menu")
            print("2.Customer Menu")
            print("3.Exit")
            selectedOption = input('Enter your option:')
            match selectedOption:
                case '1':
                    self.AdminMenuList()
                case '2':
                    self.CustomerMenuList()
                case '3':
                    exit('good bye')
                case _:
                    print("Something's wrong with the input")


    def AdminMenuList(self):
        while True:
            print("\nADMIN SECTION")
            print("-------------")
            print("1.Dispaly menu")
            print("2.Add items to Menu")
            print("3.Delete items from Menu")
            print("4.Back to RMS")
            selectedOption = input('Enter your option:')
            match selectedOption:
                case '1':
                    self.processMenu.PrintMenu()
                case '2':
                    name = input('Enter Item Name:')
                    price = int(input('Enter Item Price:'))
                    self.processMenu.AddItemToMenu(name, price)
                    print('Insert Successfull\n')
                case '3':
                    self.processMenu.PrintMenu()
                    itemId = int(input('Enter Item Id:'))
                    self.processMenu.DeleteItem(itemId)
                case '4':
                    self.MainMenuList()
                case _:
                    print("Something's wrong with the input")


    def CustomerMenuList(self):
        while True:
            print("\nCUSTOMER SECTION")
            print("----------------")
            print("1.Add Items to your order")
            print("2.View your ordered item")
            print("3.Delete an item from order")
            print("4.Display final bill")
            print("5.Back to main menu")
            selectedOption = input('Enter your option:')
            match selectedOption:
                case '1':
                    self.processMenu.PrintMenu()
                    itemId = int(input("Enter food item number you want to order:"))
                    menuItem = self.processMenu.GetMenuItem(itemId)
                    if(menuItem is None):
                        print('\nItem Not found, please select from following')
                        self.processMenu.PrintMenu()
                        continue
                    quantity = int(input("Enter quantity:"))
                    self.processOrder.AddItemToOrder(menuItem, quantity)
                case '2':
                    self.processOrder.PrintOrder()
                case '3':
                    self.processOrder.PrintOrder()
                    itemId = int(input('Enter Item Id:'))
                    self.processOrder.DeleteOrderItem(itemId)
                case '4':
                    print(f"\nTotal is: {self.processOrder.CalculateTotal()}")
                case '5':
                    self.MainMenuList()
                case _:
                    print("Something's wrong with the input")

ad = Menu()
ad.MainMenuList()
