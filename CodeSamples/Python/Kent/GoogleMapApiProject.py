import urllib
import json
class Tour(object):
    def __init__(self,*loca):
        self._x=loca
        if len(self._x)<=1:
            self._x=loca[0]
    def distance(self,mode="driving"):
        self.mode=mode
        self.dis_l=[]
        for i,j in enumerate(self._x):
            if (i>=(len(self._x)-1)):
                return sum(self.dis_l)
            g={'origins':self._x[i],'destinations':self._x[i+1]}
            O_D=urllib.urlencode(g)
            web_obj = urllib.urlopen("http://maps.googleapis.com/maps/api/distancematrix/json?"+str(O_D)+"&mode="+str(self.mode)+"&sensor=false")
            s = web_obj.read()
            r = json.loads(s)
            t = r['rows'][0]['elements'][0]['distance']['value']
            self.dis_l.append(t)
        web_obj.close()
    def __rmul__(self,m):
        if isinstance(m,int) and m>0 :
            return '; '.join(self._x*m)
        else:
            raise ValueError("invalid input")
    def __mul__(self,m):
        if isinstance(m,int) and m>0:
            return '; '.join(self._x*m)
        else:
            raise ValueError("invalid input")
    def __add__(self,Tour_2):
        return self._x+Tour_2._x
    def __eq__(self,Tour_2):
        return self._x==Tour_2._x
    def __str__(self):
       return '; '.join(self._x)
class Drv_dis(object):
    def __init__(self,x):
        self.x=x
    def __gt__(self,Tour_2):
        return self.x>Tour_2.x
    def __lt__(self,Tour_2):
        return self.x<Tour_2.x
    
def main():
    t1= Tour("New York, NY", "Lansing, MI", "Sacramento, CA")#object for tour
    t2= Tour("Sacramento, CA", "Oakland, CA",)
    print ("t1:{}\nt2:{}".format(t1,t2))#print tour locations
    print("t1 distances:\n =>driving-{} km; biking-{} km; walking-{} km".format(round(t1.distance()/1000), round(t1.distance('bicycling')/1000),round(t1.distance('walking')/1000)))#print individual distance on travaling mode
    print("t2 distances:\n =>driving-{} km; biking-{} km; walking-{} km".format(round(t2.distance()/1000), round(t2.distance('bicycling')/1000),round(t2.distance('walking')/1000)))
    t3=t1+t2#concatenating two objects
    print ("t1+t2 is t3:\n",'; '.join(t3))
    t4=Tour(t3)
    print("t3 distances:\n =>driving-{} km; biking-{} km; walking-{} km".format(round(t4.distance()/1000), round(t4.distance('bicycling')/1000),round(t4.distance('walking')/1000)))
    t6=t1*3
    t1_d=t1.distance()
    t2_d=t2.distance()
    D_d=Drv_dis(t1)
    D_d1=Drv_dis(t2)
    print("t1<t2:",D_d<D_d1)#comaparing distance objects
    print("t1>t2:",D_d>D_d1)
    print("t1=t2:",t1==t2)
main()

        
