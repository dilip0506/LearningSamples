#Dilip Kumar Nasu
#cs61002
#04/07/2016
#DNA.py
str1_u=list(input("Enter first string:\n"))
str2_u=list(input("Enter second string:\n"))
str1=[x.lower() for x in str1_u]
str2=[y.lower() for y in str2_u]
s=[str1,str2]
def match(s1,s2):# function to check matched strings
    a=0
    b=0
    m=[]
    n=[]
    for i,j in zip(s1,s2):#creating a dictionary to compare two strings    
        if i==j:
            a=a+1
            m.append(i)
            n.append(j)
        if i!=j:
            b=b+1
            m.append(i.upper())
            n.append(j.upper())
    print ('matchs are %d' %a)
    print ('missmatchs are %d' %b)
    print ("".join(m))
    print ("".join(n))
def insert_indel(index, string):#function to insert indel
    string.insert(index,'-')
    return ''.join(string)

def delete_indel(index,string):#function to delete indel
    del string[index]
    return ''.join(string)
    

def print_indel_index(x): #function to print indexs of indels
    l=[]
    for a,v in enumerate(x):
        if v=='-':
          l.append(a)
    l_2=[i+1 for i in l]
    return l_2

while True:
    action = input("\nActions should be in lower cases\npress a to add indel \npress d to delete indel \npress s for score. Score the present alignment \npress q to quit.\n")

    if action == 's':#To score the match
        str1=list(str1)
        str2=list(str2)
        f_l=[]
        c_l=[]
        if len(str1)>len(str2):#adding indels at the end
           s=len(str1)-len(str2)
           f='-'*s
           for i in f:
               f_l.append(i)
           str2=str2+f_l
        elif len(str1)<len(str2):
           q=len(str2)-len(str1)
           c='-'*q
           for i in c:
               c_l.append(i)
           str1=str1+c_l
        match(str1,str2)
        
    elif action == 'a':# To add indels
        p=[]
        q=0
        print ("".join(str1))
        print ("".join(str2))
        indel_insert = int(input("enter string number in which indel has to be added:"))
        if indel_insert==1:
            indel_insert_index=int(input("enter index value to add indel:"))
            p=s[indel_insert-1]
            q=indel_insert_index-1
            if q>=0 and q<len(str1):
                str1=insert_indel(q,p)
            else:
                print ("index out of range")
        elif indel_insert==2:
            indel_insert_index=int(input("enter index value to add indel:"))
            p=s[indel_insert-1]
            q=indel_insert_index-1
            if q>=0 and q<len(str2):
                str2=insert_indel(q,p)
            else:
                print ("index out of range")
        else:
            print ("Enter valid input")
    
    elif action == 'd':#to delete indel
        print (''.join(str1))
        print (''.join(str2))
        indel_insert_d = int(input("enter string no. from which indel has to be deleted:"))
        if indel_insert_d==1:
            p_l_1=print_indel_index(str1)
            if len(p_l_1)==0:
                print ("No indels found")
            else:
                print ('index of indels are:' + str(p_l_1).strip('[]'))
                i_input=int(input("Enter index to delete indel:"))
                if i_input in p_l_1:
                    delete_indel(i_input-1,str1)
                else:
                    print ("index not found")
        elif indel_insert_d==2:
            p_l_2=print_indel_index(str2)
            if len(p_l_2)==0:
                print ("No indels found")
            else:
                print ('index of indels are:' + str(p_l_2).strip('[]'))
                i_input=int(input("Enter index to delete indel:"))
                if i_input in p_l_2:
                    delete_indel(i_input-1,str2)
                else:
                    print ("index not found")
        else:
            print ("Enter valid input")
                
    elif action == 'q':#quit the loop
        print (''.join(str1))
        print (''.join(str2))
        break
    else:
        print ("Enter valid input")
