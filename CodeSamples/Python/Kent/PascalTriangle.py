t=[]
m=[]
def new_row(l):
    o=[]
    if l==[]:
        l.append(1)
        return l
    elif l == [1]:
        l.append(1)
        return l
    else:
        ll=len(l)
        o.append(l[0])
        for i in range(ll-1):
           p=(l[i])+(l[i+1])
           o.append(p)
        o.append(l[ll-1])
        return o
r = int(input('Enter the desired height of Pascal\'s triangle:'))
for i in range(r):
    t=new_row(t)
    r=(t[:])
    m.append(r)
print('Printing whole list of lists:\n',m)
print('Printing list of lists, one list at a time:')
for i in m:
    print(i)
    
