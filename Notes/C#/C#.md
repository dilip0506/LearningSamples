use method to access members inside a class(create object of class)

C# is strongly typed language. class are types, has methods compiler does not allow methods which are not in that type(red line in code) but dynamics are used to stop this behaviour(aslo call late binding(using reflection))
accemble class/ activator class with system.reflection namespace

ternary operator: (return condition? true: false)

adding assemblies to project
1) use refrence section in project
2) add using nuGet package manager
3) you can add two projects to same solution and import using refrence section(can also import dll files from a source)


use @ before string to escape special characters (ex:@""hi""; output:"hi")

default values for data types:
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default-values-table

default type for refrence type is null(string is refrence type. so default value is null)

we cannot assign null values to datatype directly (use ? to assign null (example int? = null) database may have null as default so we need null int types)

The ?? operator is called the null-coalescing operator. It returns the left-hand operand if the operand is not null; otherwise it returns the right hand operand. 

implicit conversion happens when there is no data loss (for example int to float happpens, float to int float variable may loss data affter decimels when it converted to int)


comments type:
1) //
2)/* */
3? XML type
///<summary>
///this is class hi(when you mouse over some class description comes from xml comments(Exple on console.log))
///</summary>

for loop need lenth of array where foreach do not.

return terminates the complete method
breark to breat loop
throw terminates the application but should the exception
goto breaks the flow and takes specific line of code.(may cause an inifinte loop if you wirte inside loop and the loop after goto location)

keyword: continue

function parameters are of 4 types:
value type (int i)
enum is value type
reference type( ref int i) while calling aslo use ref keyword
output parameters (int i,  out int j)//one input and other output (out keyword use while calling also a variable is required to store ouput valu)
parameter array (int[] i)//mandatory parameter or (params int[] i) //when params keyword you may or may not pass a array, we can also extra parameter but decalre on left hand side. has only one params keyword and that should be at last(refer poject passbyvalandref)

types and type members(example classref)
we can have any number of namespaces and nested namespace in project. aslo namespace is not mandatory
we can aslo alias namespace using   hi = system.console
use "hi" instead of "system.console"
we can write any type insdie type(ex: class in class) you full qualified name to call it staring from name same
class,enums,interfaces,delegates are types
methods, properties,cosntructor,methods etc inside type are type members
types can aslo have all access specifiers when the are nested not under namespace inside namesapce they can have only(internal, public)
defualt: private for type members and internal for types
C# Preprocessor Directives(#region,#endregion)

attributes:(learn more in msdn documnetation)
attribute adds metadata to class, method .. etc that can be seen in reflection and identifies the actions at rutime and invokes necessary function(like ex:[HttpGet("{id}")],HttpPost])(we can change the behavior at runtime depending on the action)
provides declarative information with c# code which can be quaried using reflection

var keyword is not portable(CLR i.e., IL code)

value type:in stack
refrence type: in heap
pointer type:directly manipulate memory in managed language
unified type system is IL type system (language interoperability)

class vs struct
class is a refrence type used to define complex behaviours is a pointer to object(allocated in heap) car refered to same object 
struct is a value type with small implimentations(more effective in performance, allocated in stack) is a single value with multiple inputs (s.x,s.y like c language) memory concern, faster access. connot refer to same sturct: (ex: int i = 0; int j  = i; (both are diffrent variable.points to diffrent memory allocation change on will not effect other variable) where as class are refrence type two class obection can point to same memeoty location(ex: class c = new class(); class c1 = c) both are point to same location change in one will effect others)
no inheritance:A class or struct cannot inhert other strut but struct can inhert interface. structs cannot have destructors and expicite paramneter less constructor.{ex: hi(){}(which is empty custoructro for struct hi;)}
declaretion of class and struct are same both contain constructors, constants, fields, methods, properties, indexers, operators, events, and nested types. 
statics call cannot instantiate

we can have static consustructors(beacuse consuture should be public to access anywhere) static also invokes automatically. it should be parameterless. Static constructors are called only once no matter how many instance you create. it is called first then other members. object creatation is aslo not nessary(refer classcunstructe example)
We can pass default values to constructor. see example(projectnameclassconstructor)
static vs instance (see image stin.jpg)
statis class is used to create static members we cannot create object of static class

abstract class cannot be instatiated it is type of class like animal class. a dog, cat.. etc inherite animal class and implements. Animal class is incomplete.

base keyword controls parent class constructor which one to call(example inheritance)
base keyword aslo call base class methods(their implemetation while overriding or hidding parent method)

sealed class cannot be extended and inherited. we can use extension methods for sealed class to add methods.
partial class extends class to diffrent files with same namespace. in acctual compliation it becomes a single class

prop short form of property
propfull long for of property, can impliment logic in get and set method can also use access specifiers
to set property value use "value" keyword(MyVar = value)(also "value" keyword holds the value coming from the property(validation and other operations are performed on "value" keyword not on variable name or property name))


return type cannot change signature of method (example: int hi() is string hi() cannot be implemented)
but parameter types can overload the function (example void hi(int i) and void hi(string j) or we can even have combination hi(string i, int j) and hi(int j, string i) and out or ref keyword before the variable aslo overload(hi(string i, int j) and hi(string i, out or ref int i)
name, type, kind not return type not even params keyword

virtual method can have implementation, but we can change the implimentation in dervied class using override keyword.(overridden)

virtual and override method: the use of the virtual and override modifier enables base class type( base n = new derived) to access the derived class method body that is defined in DerivedClass: new key work hides accutul implemetation of method we can also code with out new keyword be it rasies a warning (delcares you made it intensionally)

inheritence:(example inheritance and clsandstracess)
base class type with derived class data, base case object can access dervived call method body(using virtual and overridde keywords)

*child class refrence varibale cannot point to parent class. where as parent class refrence varibale can point to child class. because parent class cannot fullfill all reponsiblities of child class(because dog can be animal, but animal cannot be dog.base class already has all feilds of parent class so no need to do that. you can change animal to dog i.e, type casting). parent class responsibilites are already inherited by child class. So child class type has many responisibilties(like new methods) child class refrence type need to handle all of its methods. but parent class pointer will not have the implementation of child class. so, it is not possible.*(example inheritance and clsandstracess)

uisng virtual and override is also Polymorphism becasue base class method behaves diffrently we differnt value(passing derived class)
not only methods properties, eventhandlers, and indexers can aslo be polymorphed(see example polyusingshapeex)

inhertance:(see example: interfaces)
it cannot have implemetation this cannot be done. implematations is in inheritated class or struct.signature should be same
interfaces can have methods,events or delegats, properties only declaration not implemetation
interfaces support multipule inheritance(not class)
int i;//interfaces cannot have fields.
interface memebers cannot have access modifiers. by default they are public
implicit with diffrent method names inside interface
explicit with same method name in both interfaces
a default is, one method can be called with out explicitly that will be default
interface cannot directly have object however, an interface refrence variable can point to dervied class 
to use the method type should be respective to interfeace (can use type casting or declare that type interfaces)
interface cannot inhert from other class

abstract class:(ex:abstracts //aslo contains diffrent between abstract and interface)
abstract class can contain abstract memnbers but not mandatory(delegates,events,properties)
abstract class can have access modifires
abstract class can inherite from other class or interface(multiple interface)
abstract class should not be a seal class becasue abstract class should be inherited
abstract class can have funtion body. interface funtion should not have body
method with abstract keyword cannot have inplimentation must be implemted in derived class with override keyword
if you dont want to implement all abstract method in this class make it abstract class
cannot have direct object. but its refrence variable can point to derived class

Delegate:(example: delegates)
delegate is a type safe function pointer
declaring a delegate
first create a function with some signature (return type and parameter)
then create a delegate(public delegate [type] name([parametes]))//here the type and parameters should match the funtion return tye and parametes.
then create instance of delegate with function name as paramter(delname n = new delname(funname))
now to instance varibale (here n) is used to call the function n("arguments");
muticast delegate (+=) append a funtion del += funtionname (+-) del -= functionname removes
what is delegate(function) returns a value// the delegate variable hold the last method value(same even if it has out parameter)

excetion handling(ex:Exceptionshandling):
exception handling should in order(ex: 1) filenotfound then genaral exception(raises and error"exception alredy handled"))
finally keyword excutes for madatory if any error occurs in the program(if an exception occurs in the code excution stops there use finally to close all resource and toperform othe operations)
(where there is "try" there should be "catch" finally is optonal be highly recommended. "throw" can be used anywhere in conditonal block like if,else)
inner excetion: is like nested exception(if a code catchs an exception then another exception caused(in the proccess) after, that excetion should also be handles. fistr exception is inner exception(see example));
CustomException:(ex: customexeption)
inherit exceptin class and uses those mesthod and construtors

ENUMS are strongly typed constants


no class for eventhandler(no class.eventhandler, direct call is a delgate)

var obj = new ArrayList()//inherited from object can add all types ex:(obj.add(1);obj.add("three"))
var list = new List<int>)()//alows only int type(chnage parameter for type)

var list = new int[]
int[] list = new int[] { 1, 2, 2, 4 };
int[] list = new int[5]
							

enums are strongle typed, options can assign only values provides ex: enum dog {a,b,c}
enums with switch case int paranthasis type enum name and press tab

switch
remove break to make two or more cases same behaviour but the above case should not have body
ex:case 10:
   case 20:
   case 30:
	break;
each case need only one break statment (either return,break, throw etc) which breakes the case

when a type is inhertied from ather type the devrived type will be of base class type
see project 12 for object type//manupulating types
class animal
class dog:animal
x(dog)//possible dog is type of animal
void x(animaml a){
if(a is dog){//verify the type
var dog = (dog)a//but cast into type of dog(this is one type)
var dog = a as dog //(other type)
if(dog!=null){
do something
}
}
}


regex//regular expression

Reflection
reflection is something to see the metadata about the type(type like class(class contains..)) to know the capabilites of a type(slides for more...) complete information about type its assemble, inherited from(there are also tool to know, this is programtic way)

we cannot reflect private types.
names of the methods and properties should be know before using reflection this is to understand the structure and behaviour of the type(implimetation).
we can read value without knowing the value(slides for more)
GetProperty(enum for program) for single value//need parameter
GetProperties(enum for prgram) all values retuns in array

Generics:(ex:generics)
generics makes methods an class generic(we can pass parameter type and parameter) they are not fixed to single type
exmaple hi(int i) we can pass only int hi<t>(t i): here hi<type>(argument) type is sent in "<>":
used in collections
//defineing a type or type members with parameter type "class class<type>" reset is same as other concepts (creating obeject..etc)

convert.tostring() converts null to empty string .ToString raise an exception if we used it on null(parser and trypasrser)

only partial class can have partial methods

we can override Equals and Tostring(according to your requirement) method for your requirement can add new logic(for example camparing two names(implemnt it with equal method with firstname and lastname together) because c1 object has both first name and last name c1=c2 give false where they should be equal)
ToString ovrrid: to get some thing meaningful class cl = new class(); c1.Tostring gives fullname(namespace.class) to get required result override it
when you override Equals to method overide GetHashCode method to(^)

MultiThread:
-OS
 -process
  -thread

every application has one thread to excute it is can main thread. it is a single thread resposible for all task in a program. using multipule threads to run difrrent process simultanious us multi threading(Time Sharing)
advantage:max cpu resorce usage
time sharing is like:
t1 : 2 2 2 2 2 2 2 2 2
t2 : 2 2 2 - - - 2 2 2(--- at that point process may stoped or not responeding the resource is allocated to new method(other thread))
t3 : 2 2 2 2 2 2 2 2 2


garbage collection
example of orpans for garbage collection is local variable in a method when the method is done they will become orphans
when garbage collector starts everything stops
we can manage grabage colllector(gc.collect,gc.finalizer)
calling gc all time(for example in loop) is expensive thier is IDisposable interface to implement for de-allocating memory(example: an array with thousand values)
learn: IDisposable,gc and gcfinalizers methods
advansed IDisposable interface provides more options(read documentation):
using keyword invokes Dispose method in a good way(using (class c1 = new class c1){//})

dispose: completly close or garbages vs close: can reopen vs stop: can stop like time and restrat(depening on serionr using(may dispos stop or close//read doc for more clarity))
gc collects unrefrenced and weak refrence objects manage your app accordings(delegete pointing to event is like strong refrence dispose in unload event// sometimes you need week refernece type in future re-reference it(think at development))

validation
checking input data is validation. Input data should not harm application(slide)
for security, stability and performance
program defensively(do validation )
complier validates the object type but not object data(slides)
debug/trace
debug is diffrenct from trace
assert() put in debug or trace (alerts the developer (stops the execution))
users should not see the debug information(big problem )
Debug is used during debugging. Trace is writing to the log file. It is kind of like logging. Both are very similar, but do tracing for long term retention, debugging for real time debugging.
trace happens all the time in debug build and release build
debugger need a debugger point for debuging 

unit test (learn)

"is" checks for type
==//compare using(with same refrence and content)//can also be overloaded but method is preffered for oops
.equals//(content comparision)//can be overloaded or overrided
to handle exception it should be raised
throw can also used out of try and catch blocks to throw exceptions in "if" statements