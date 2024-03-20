import glob
import random
n=0
k={}
files=glob.glob('*.txt')
assert len(files)!=0,"No files in folder"
for w in files:
    print (w)
def check_user():
    while True:
        f_name_u= input("Enter file name:")#To read file name
        if f_name_u in files:
            return f_name_u
        else:
            print ('file not found')
def name_file(f_name):
    i_file=open(f_name,"r")#open .txt file
    r=i_file.read()#reads the data in .txt file
    l=r.split()#creating list of data inside text file
    random.shuffle(l)
    k_r=dict(map(str,x.split(':')) for x in l)#coverting list into dictionary
    print ("total no of words: %d"%len(k_r))
    Test(k_r)
def Test(h):
    p=[]
    q=[]
    m=int(input("Enter no of questions:"))
    assert m<=len(h), "enter less than total words"
    for que,ans in h.items():#iteration to get items in dictionar
        global n
        print ("What is the meaning of:" + que)
        u_ans=input("Enter answer:")
        if u_ans==ans:#Comparing value with entered answer
            print ('correct answer')
            n=n+1
        else:
            print ('wrong answer')
            p.append(que)#appending wrong answered questions to list
            q.append(ans)#appending wrong answered answers to list
            n=n+1
        if n>=m:
            print ("End of quiz")
            print ("please look WrongAnswers file to view correct answers")
            break
    g = dict(zip(p,q))#creating dictionary for wrong answers from collected lists 
    if len(g)>=1:
        o_file=open("WrongAnswers.txt","w")
        for que,ans in g.items():            
            wrong=que+":"+ans+'\n'
            o_file.write(wrong)
        o_file.close()
f_name_c=check_user()
name_file(f_name_c)
