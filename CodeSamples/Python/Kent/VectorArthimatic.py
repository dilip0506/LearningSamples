#Dilip Kumar Nasu
#cs61002
#vector_arithmetic.py
import math
class vector(object):#defining a class
    def __init__(self,x,y):#init constructor invokes when object is created
        self.x=x
        self.y=y
    def __str__(self):#str directly prints objects
        return "vector: (%s,%s)" %(str(self.x),str(self.y))#converting type to string
    def __add__(self,vector_2):#add invokes when + is used(operator overloading)
        x=self.x+vector_2.x
        y=self.y+vector_2.y
        return(x,y)
    def __sub__(self,vector_2):#sub invokes when - is used
        x=self.x-vector_2.x
        y=self.y-vector_2.y
        return(x,y)
    def __mul__(self,vector_2):#mul invokes when * is used
        if isinstance(vector_2,vector):# is true if object is instance of class
            return (self.x*vector_2.x+self.y*vector_2.y)
        else:
            x=self.x*vector_2
            y=self.y*vector_2
            return (x,y)
    def magnitude(self):#fuction to cal magnitude
        return math.hypot(self.x,self.y)
v_1=vector(2,3)
v_2=vector(4,5)
print v_1
print v_2
print "sum of vectors is", (v_1+v_2)
print "difference of vectors is", (v_1-v_2)
print "multiplication of vector one with scalar 2", v_1*2
print "multiplication of vector two with scalar 3", v_2*3
print "Multiplication of vectors is",(v_1*v_2)
print "magnitude of first vector is :",(v_1.magnitude())
print "magnitude of second vector is :",(v_2.magnitude())
