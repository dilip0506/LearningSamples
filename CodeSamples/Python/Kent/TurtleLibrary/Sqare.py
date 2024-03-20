#Dilip Kumar Nasu
#cs61002
#turtlesquare
from turtle import *
from random import *
Sn=Screen()# 
n=Turtle()
x=40
y=int(input("Enter the number of square you want between 1 to 10"))
while y>10 or y<1:
 print("Enter a value between 1 to 10")
 y= int(input("Enter the number of square you want between 1 to 10"))
 
s=int(input("Enter side of square"))

for square in range(y):# run loop to for squares
       begin_fill() # fill square with color
       color(random(),random(),random())
       right(40) #rotate clockwise 40 degree angle
       forward(s)#draws line with the length of user input
       right(90)#rotate clockwise 90 degree angle
       forward(s)
       right(90)
       forward(s)
       right(90)
       forward(s)
       right(90)
       end_fill()
