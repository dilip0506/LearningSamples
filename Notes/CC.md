ex12pg51

abc    i0=0  bc
bc,a   i1=0  c   
c,ab   i2=0  
,abc
bc,a   i1=1 b  
b,ac   i12=0 
,acb
abc,   i0=1 ac
ac,b   i1=0 c
c,ba   i2=0 
bac
ac,b  i1=1  a
a,bc  i2=0 
bca   
abc i0=2 ab
ab,c i1=0 b
b,ca  i2=0 
cab
ab,c  i1=1 a
a,cb  i2=0 
cba
more step that are stoping iteration

hasttable:
computes hash function with a hash method. and assigns a key
if two hash values are same that causes collsion
collision can be solved in two ways
1) linear probing: inserting the value in next avilabe slot : but their be other collision can occure(clusturing) and there are limited sloted and runtime is to O(n)
2)sperate chaing solves the problem created a linked list whr the collision occure all with a are linked to one list(one index(hash table is pointer to array of linked list))
note: make a good hash function(to avoid collision)
	should use all info provided by the key
	unifomly distribute output accore the index
	map similar key to diffrent hash function
	use inly ver fast operations

diffrence between | and || is (using the || and && forms, rather than the | and & forms of these operators, will not bother to evaluate the right-hand operand alone.(
Logical || and && check the right hand side only if necessary. The | and & check both all the time.))
| and & can be used to perform the bitwise operation on byte/short/int/long values. ||  and && cannot.

bitwise operations(operations are performed on bits)
example 1 | 2  
/* 00000001
   00000010
 = 00000011 */ = 3
bitwise operators: |, &, ~, ^, x<<y(left shit with y bits),x>>y(right shit with y bits).


in Recursive call after all recursive call(code after the call executes)
ex(
void ex(){
ex(){
notrun
ex()
willnotrun
}
}
