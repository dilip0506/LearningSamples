#Dilip Kumar Nasu
#garden.py
#cs61002:AP1
import math
#Reading input and coverting to string
length=float(input("Enter length of side of garden in feet:"))
spacing=float(input("Enter spacing between plants in feet:"))
depth=float(input("Enter depth of garden soil in feet:"))
fill=float(input("Enter depth of the fill in feet:"))
radius=length/4
#area of the semicircle flowerbed
area =(math.pi*(radius**2))/2
#semit is the result after truncation
semit=math.trunc(area/(spacing**2))
#calculating the number of plants for circle type of flowerbed
area=math.pi*(radius**2)
#cicut is the result after truncation
circt=math.trunc(area/(spacing**2))
#tp=total plants
tp=circt+(semit*4)
#The soil for semicircle type of quantity
volume=(math.pi*(radius**2)*depth)/2
#converting to cubic yards
#cv is cubic volume yards
cv=volume/27
#cvrs is the cubic volume yards after rounding semicircle
#1 because rounded to one decimal place
cvrs=round(cv,1)
#The soil for cicle type of quantity
volume=(math.pi*(radius**2)*depth)
cv=volume/27
cvrc=round(cv,1)
#The total cubic yards of soil for the garden
total=(cvrs * 4) + cvrc
totalr=round(total,1)
#tv is total volu4me
tv=(length**2)*fill
#tcs is total volume of circle and semicircle
tcs=(math.pi*(radius**2)*depth)*3
tf=tv-tcs
ctf=tf/27
ctfr=round(ctf,1)
print("plants for each semicircle garden: ", semit)
print("plants for the circle garden: ", circt)
print("Total plants for garden:", tp)
print("Soil for each semicircle garden:", cvrs)
print("soil for cicle garden:", cvrc)
print("Total soil for the garden:", totalr)
print("Total fill for the garden:", ctfr)
