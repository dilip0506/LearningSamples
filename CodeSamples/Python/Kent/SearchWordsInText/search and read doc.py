def check(x):
    l = list()
    vl=list()
    va=set()
    search = set()
    f = open('ap_docs.txt', 'r')
    v = f.read()
    paragraphs = v.split("<NEW DOCUMENT>")
    len_p=len(paragraphs)
    for i in xrange((len_p)):
        l.append(i)
        value = set()
        dl=paragraphs[i].split()
        for i in dl:
            value.add(i.lower())
        vl.append(value)
    dicti =dict(zip(l,vl))
    dictionary = dict(zip(l, paragraphs))
    if x == 1:
        zs = raw_input("Enter the words you want to search: ").lower()
        zl=set(zs.split())            
        for i in dicti:
            if(zl.issubset(dicti[i])):
                va.add(i)
        p_result=[str(x) for x in va]
        print 'document : ',' '.join(p_result)
        
    elif x == 2:
        doc_num = int(raw_input('enter doument number: '))
        if doc_num<=len_p:
            print dictionary[doc_num]
        else:
            print 'please enter valid search number'
            doc_num = int(raw_input('enter doument number: '))
            print dictionary[doc_num]
while True:
    x = int(raw_input('what would you like to do?\
                   \n 1. Search for documents \
                   \n 2. Read Document\
                   \n 3.Quit program \n'))
    
    if (x >3):
        print ('invalid input')
    elif x==1 or x==2:
        check(x)
    elif x==3:
        break
    else:
        x = int(raw_input('\nwhat would you like to do?\
               \n 1. Search for documents \
               \n 2. Read Document\
               \n 3.Quit program \n'))
