#Dilip Kumar Nasu
#cs61002
#turtlecircle
from turtle import * # to import only one time
from random import * # to import only one time
import turtle # typeerror in line 25 without turtle word

print("no of cirlces should be between 0-9")
no_c=int(input("enter no of circles"))# no_c defines no of circle as input

def is_number(no_c): #exception to test no of circle, circle no should no be a float value
    try:
        float(no_c)
        return true
    except valueError:
        return false
print("Enter the radius of the cirlce between 50-200")
radius = int(input("Enter the radius of circle"))
while radius<50 or radius>200:
    print("please input the value between 50-200")
    radius = int(input("Enter the radius of circle"))
x=Screen()#to make a graphic screen
forward(radius)
left(90)

for circle in range(no_c,0,-1):#concetric circle takes no of from circles from input check value for zero if not zero subtracts one from the input
    begin_fill()
    color(random(),random(),random())
    turtle.circle(radius*circle/no_c)
    end_fill()
    left(90)
    forward(radius/no_c)
    right(90)
