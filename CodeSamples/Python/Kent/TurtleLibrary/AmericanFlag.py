#Dilip Kumar Nasu
#810867407
#cs61002:AP1
#American_flag.py

from turtle import *
x=-86 #intializing cordinates to print starts
y=77
a=-76
b=68
up()
setpos(-100,-100) #start position of turtle
down()
speed(10000)
def get_color(n): #function to return color values using differnt mathametical expressions as condition
    if n%2==0:
       r=0
       g=0
       b=0
       return r,g,b
    if n%5==2:
        r=1
        g=0
        b=0
        return r,g,b
    if n%4==1:
        r=0
        g=0
        b=1
        return r,g,b
    if n%2==1:
        r=1
        g=1
        b=1
        return r,g,b
def draw_rect(rectlen,recthig,clor): # function to draw rectangle
    rc=get_color(clor)
    color(rc)
    forward(rectlen)
    right(90)
    backward(recthig)
    right(90)
    forward(rectlen)
    left(90)
    forward(recthig)
    left(90)
def draw_strips(stlen,sthig,clor): # function to draw strips in the flag
    for rect in range(7):
        begin_fill()
        sc=get_color(clor)
        color(sc)
        forward(stlen)
        left(90)
        forward(sthig)
        left(90)
        forward(stlen)
        right(90)
        forward(sthig)
        right(90)
        end_fill()
    right(90)
    color(1,1,1)
    forward(15)
def star_draw(cir,clor): # function to draw star using for loop
        for i in range(5):
            begin_fill()
            strc=get_color(clor)
            color(strc)
            forward(cir)
            right(144)
            end_fill()
def star_loop(sl): # loop to print stars inside canton
    for cir in range(sl):
        global x # variable 'x' use inside the function is treated as local variable because no valve for 'x' is intiatized inside the function, making 'x' a global varible to use global value initialized at the top
        up()
        goto(x,y)
        down()
        star_draw(6,3)
        x=x+22
def star_loop_inner(sli): # another loop to print remaing stars in canton
    for cir in range(sli):
        global a # variable 'a' use inside the function is treated as local variable because no valve for 'a' is intiatized inside the function, making 'a' a global varible to use global value initialized at the top
        up()
        goto(a,b)
        down()
        star_draw(6,3)
        a=a+22
def draw_canton(canlen,canhig,clor): # function to draw canton
        begin_fill()
        cc=get_color(clor)
        color(cc)
        forward(canhig)
        left(90)
        forward(canlen)
        left(90)
        forward(canhig)
        left(90)
        forward(canlen)
        right(90)
        end_fill()
def draw_flag(A): #funtion to draw flag
    draw_rect(A,195,2)
    draw_strips(A,15,7)
    draw_canton(142,105,9)
draw_flag(370.5) # calling draw_flag function
star_loop(6) # calling star_loop function with 6 iterations
while (x>=21.5): # By running star_loop function the x value is manupulated by the loop, using the manupulated value of x a condition to change the value of y
        y=y-18
        up()
        goto(x,y)
        down()
        x=-86
        star_loop(6)
        if(y<=10):# condition to terminate while loop
            break
star_loop_inner(5)# calling star_loop_ function with 5 iterations
while (a>=18.35):# By running star_loop function the x value is manupulated by the loop, using the manupulated value of x a condition to change the value of y
        b=b-18
        up()
        goto(-76.33,b)
        down()
        a=-76
        star_loop_inner(5)
        if(b<=20):# condition to terminate while loop
            break
hideturtle()
