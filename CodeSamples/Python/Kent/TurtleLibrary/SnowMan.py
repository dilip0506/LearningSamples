#Dilip Kumar Nasu
#cs61002
#snow_person.py
import turtle
import time
class Line(object):
    """Class for Line"""
    def __init__(self, start=(0.0, 0.0),last=(0.0,0.0),pencolor="black",pensize=1):
        """
        create a line
        start is starting coordinate of line
        last is ending coordinate of line
        pencolor is turtule pen color
        pensize is turtle pen size 
        """
        self.start = start
        self.last=last
        self.pencolor=pencolor
        self.pensize=pensize
    def __str__(self):
        return "start:{}".format(self.start)
    def draw(self):
        "used to draw lines"
        turtle.pensize(self.pensize)
        turtle.pencolor(self.pencolor)
        turtle.up()
        turtle.goto(self.start)
        turtle.down()
        turtle.goto(self.last)

class Circle(Line):
    """creates a circle"""
    def __init__(self,radius,start=(0.0,0.0),pencolor="Black",pensize=1):
        """
        radius takes radius of each circle
        """
        Line.__init__(self,start,pencolor,pensize)
        self.radius = radius
        self.pencolor=pencolor
        self.pensize=pensize
    def __str__(self):
        "return cordinates and radius of each circle"
        return "start:{},radius:{}".format(self.start,self.radius)
    def draw(self):
        """draws circles"""
        turtle.up()
        turtle.pensize(self.pensize)
        turtle.color(self.pencolor)
        turtle.goto(self.start)
        turtle.down()
        turtle.circle(self.radius)
    def draw_button(self):
        """draw circles for buttons and eyes and fills color"""
        turtle.up()
        turtle.goto(self.start)
        turtle.begin_fill()
        turtle.fillcolor(self.pencolor)
        turtle.circle(self.radius)
        turtle.end_fill()

class Rectangle(Line):
    """creates rectangle"""
    def __init__(self,rtlen,rthig,start=(0.0,0.0),pencolor="black"):
        """
        rtlen is lenght of rectangel
        rthig is height of rectangle
        """
        Line.__init__(self,start,pencolor)
        self.rtlen=rtlen
        self.rthig=rthig
        self.pencolor=pencolor
    def draw(self):
        """draw rectangles"""
        turtle.up()
        turtle.goto(self.start)
        turtle.down()
        turtle.begin_fill()
        turtle.fillcolor(self.pencolor)
        for i in range(2):
            turtle.forward(self.rtlen)
            turtle.right(90)
            turtle.backward(self.rthig)
            turtle.right(90)
        turtle.end_fill()

class Triangle(Line):
    """Creates triangle"""
    def __init__(self,slen,start=(0.0,0.0),pencolor="black"):
        """
        slen is lenght of side of triangle 
        """
        Line.__init__(self,start,pencolor)
        self.slen=slen
        self.pencolor=pencolor
    def draw(self):
        """draw rectangles"""
        turtle.up()
        turtle.goto(self.start)
        turtle.down()
        turtle.begin_fill()
        turtle.fillcolor(self.pencolor)
        for q in range(3):
            turtle.forward(self.slen)
            turtle.left(120)
        turtle.end_fill()

class Snow_Person(Circle):
    """
    creates snow person with 3 snow balls
    """
    def __init__(self,radius,start=(0.0,0.0),pencolor="black"):
        """takes radius and cooridinates to draw circles"""
        Circle.__init__(self,radius,start,pencolor)
        self.radius=radius          
        x,y=start
        self.Circle_Body=[Circle(self.radius,(x,y)),Circle(self.radius-20,(x,y+140)),Circle(self.radius-40,(x,y+240))]#for three circles
    def draw(self):
        """to draw circles"""
        for cl in self.Circle_Body:
            print(cl)
            cl.draw()
    
class Snow_Man(object):
    """draws snow man with hat, arms and buttons"""
    def __str__(self):
        return "above are cordinates and radius of each circle of snow man"
    def __init__(self):
        sp = Snow_Person(70,(-100.0,-100.0))#object to draw circles for snow man body
        sp.draw()
        self.Circle_Button=[Circle(4,(-108,165),"blue"),Circle(4,(-88,165),"blue"),#for snow man eyes
                            Circle(10,(-100,-65),"grey"),Circle(10,(-100,-10),"grey"),# for snow man buttons
                            Circle(7,(-100,63),"grey"),Circle(7,(-100,100),"grey")#for snow man buttons
                            ]
        for cb in self.Circle_Button:
            cb.draw_button()
        self.hat_draw=[Rectangle(40,50,(-120,195),"Red"),Rectangle(80,10,(-140,185),"Red")]
        for sm_ht in self.hat_draw:
            sm_ht.draw()
        self.sm_hd=[Line((-145,100),(-195,130),"Red",5),Line((-55,100),(5,130),"Red",5)]
        for sm_h in self.sm_hd:
            sm_h.draw()
        self.mouth()
    def mouth(self):
        """to draw mouth for snow man"""
        self.man_mouth=[Line((-115,161),(-108,155),"Red",2),Line((-108,155),(-92,155),"Red",2),Line((-92,155),(-85,161),"Red",2)]
        for q in self.man_mouth:
            q.draw()
            
class Snow_Lady(object):
    """draws snow lady with hat, arms and buttons"""
    def __str__(self):
        return "above are cordinates and radius of each circle of snow lady"
    def __init__(self,):
        sp = Snow_Person(70,(100.0,-100.0))#object to draw circles for snow lady body
        sp.draw()
        self.Circle_Button=[Circle(4,(88,165),"green"),Circle(4,(112,165),"green"),#for snow lady eyes
                            Circle(10,(100,-65),"purple"),Circle(10,(100,-10),"yellow"),#for snow lady buttons
                            Circle(7,(100,63),"purple"),Circle(7,(100,100),"yellow"),#for snow lady buttons
                            Circle(6,(100,150),"Red")#snow lady lips
                            ]
        for cb in self.Circle_Button:
            cb.draw_button()
        sl_ht = Triangle(60,(70,190),"yellow")#object to draw triangle or hat
        sl_ht.draw()
        self.lady_hd=[Line((55,100),(-5,130),"Red",5),Line((145,100),(195,70),"Red",5),Line((195,70),(140,30),"Red",5),#instance for snow lady arms
                      Line((73,190),(63,155),"Red",3),Line((78,190),(73,165),"Red",3),Line((122,190),(128,165),"Red",3),Line((127,190),(137,155),"Red",3)#instance for hair
                     ]
        for q in self.lady_hd:#for hands
            q.draw()
        self.mouth()
    def mouth(self):
        """to draw mouth for snow lady"""
        turtle.pensize(2)
        turtle.up()
        turtle.goto(87,160)
        turtle.setheading(300)#sets angle for circle
        turtle.down()
        turtle.color("red")
        turtle.circle(14,extent=120)

def main():
    turtle.speed(100)
    Snow_Man()#object for snow man
    Snow_Lady()#oject for snow lady
    turtle.hideturtle()
    time.sleep(5)
    turtle.bye()
main()
