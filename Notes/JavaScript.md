JavaScript is a interpreter language
diffrent bowsers uses diffrent javasript engines
V8: chrome and node.js
SpiderMonkey: firefox
JavaScriptCore:safari
Chakara: MicrsoftEdge/IE

javasript at the bottom

Implemets :ECMAScript standard

npm is javascript package manager

js use stack frame as execution context

stack frame has diffrent exection context how object and functions are called

js excution has two phase
creation phase(creates scope chain,VO,this value(below as ex)) and execution phase(stats execution and intilaizes values)
executionContextObj = {
    'scopeChain': { /* variableObject + all parent execution context's variableObject */ },
    'variableObject': { /* function arguments / parameters, inner variable and function declarations */ },
    'this': {}
}

..scope..
js uses lexical scope (in the order methods are declared (not called) are pushed into stack) the other scope is dynamic scope(in the order methods are called are pushed inside the stack(look for variable in upper level of statck)))
var is function scope, let is block scope
in nested function if a varible declaration o intilaization is not found it look in the parent funtion and chain contion child funtion can have parent funtion varibale vice versa is not possible

null vs undefined: if you do not set any thing it is undefined if computer unable to set it is null

no typecasting in JavaScript(dynamic types)
has Coercion below are examples
var = 42;
var explicit = String(x);
var implicit = x+ "";
== vs ===(php type)

javascript need a interpreter to run. every browser has interpreter built-in (like inspect element)
node is also an interpreter
objects can have objects

prototypes are created using function key word in javascript they are also types. use new keword to create new type.classes are introduced in ECMAScript 2015, are primarily syntactical sugar(just names no specific implimentations)

object can be using object method
ex:var h = new Object();//creating object
   h.name = "dilip";//adding values
other wat is using object literal
ex: var h = {};
    var h = {		//oject literal with values
	first:"dilip",
	last:"nasu"
	}
h.phone = "12345" //adding new property
delete h.phone // to delete propety
we can loop throught each property
object literal is better then object() method 

window is th global object in a browser, global for node interpreter
ex: type globle in node script mode and window in console
variable and function created are in the global object

Object.create() method is also used to create a object

..object constructor..(creates a prototype)
function person(first, last, phone){
this.first = first,
this.last = last
this.phone = phone,
this.print = function(){
	return this.first + this.last
}
}
var p = new person("dilip","kumar","123456")//using oject construtor. we create any no of objects

var x1 = {};            // new object
var x2 = "";            // new primitive string
var x3 = 0;             // new primitive number
var x4 = false;         // new primitive boolean
var x5 = [];            // new array object
var x6 = /()/           // new regexp object
var x7 = function(){};  // new function object 
// in above object creat you can also use new keyword folloed by method name ex: var h = new array()

creating primitive without method name is good for performace

var x = new Number(42);// x is instance of number created fom object method is it like heave

var x = 42; // here x is not instance of number it is primitivie //but primitive is a type of object has all the methods number has 
//primitivie means no methods attached to it

prmitives are immutable// it will resset but not acutually changes
objects are mmutables and are stored by refrence// every thing other than premitive is object
objects are pass by refrence


Objects are mutable: They are addressed by reference, not by value.

variable without var keyword is global no matter where it is declared. if you put var keyword then the variable will no be in the global context

..this..//keyword//every is connect to global object
this referce to current execution context
when their is no object this refers to globla object.
new function defines its own this value when call with object.(watch example this)
An arrow function does not create its own this ex:()=>{} (watch example this.js)
this refrence to global object in global execution context
in method this refrece to that object the method is invoke on
console.log(this)//gives an empty object in node interpreter (they use modules for each script need to learn)
function(){console.log(this)} // referece to globle object because all global methods and variables are add to gloabal object  

setTimeout is aysc function at the it return the value is undefined(arrow function using callback in callback exmaple)
because the function is not in function scope chain(lexical scope) arrow function return value as lexical scope with refrence
..Prototype..
types(objects) have properties
		|------can add methods
x---prototype---|
		|------can add properties
x is prototype(created using function keyword)

Every type has a prototype poperty. when a property to object like h.properties name that property is only to that object 
in object construtor to add propety for actual type that is prototype we use prototype property ex: person.Prototype.address (person is function name)
Only modify or delete your own prototypes or propeties. Never make changes on standard JavaScript objects.

the prototype chain follow look for a property or method in current intance then prototype(or constructor created from function) the function(created from object) then master object(propeties are tightly bound to instance type)

prototype saves the space. instead of having the methods in every instance. better to look at one place i.e. ref to prototype. beaware of changing the master type prototypes

..prototype inheritance..
thumb rule: you must create a object of prototye(object constructor) to use its methods and properties
konw to diffrence between created object or prototype
prototype		   | 	object
var h = function(){        |	var h = {
or function h(type){	   |	type:"dilip",
this.type = type;	   |	method:function(){}
this.method = function(){} |	}
}

to use prototype first create object var ho = new h();
ho.method
object can be direstly accessed using object name

To inherite from other prototype there are three steps

1)use call method to invoke no all memeber created in prototype that are part of that 
prototypename.call(this)//tis refers to current object
2)prototypename.prototype = Object.create(prototyetoin.prototype)//invoke all members add using prototype property
3)prototypename.prototype.constructor = prototypename //step 2 ( its a regular constructor and not the prototype constructor.) to invoke prototype constructor(explore more)
4)to override or hide a method add a method to prototype using prototype property after the steps(the prototype chain follow look for a property or method in current intance then prototype)


..hoisting..// may not work if we have diffrent javasript file(need to check)
in hoisting function can be called before and after function implemention in javascript
but when you set a funtion to varible it will no work
ex: fun()//
    var fun = function(){};//will not work in hoisting
    fun(){}// will work
ex2: console.log(i);// identfies the variable but not take the value (value as undefined)(takes declaration but not initilization)
    var i = "hi";//if you comment this the above line gives an error i is not defined
hoisting: javascript engine first go throught the code and first and copies all it variable and fucction to memory the excutes
ex:code			|how js engine runs
    console.log(i)      |var i;
    var i = 42;		|funtion hi(){}
    hi();		|console.log(i)
    function hi(){} 	|hi();
			|i = 42;// reason why i is undefined in ex2  

..function..
arguments.lenght reurn the number of arguments
sample: funtion hi(){ console.log("hi");}
When we call a funtion with () funtion will execute ex:hi() (output: hi)
if we call only with name it will return the function ex:hi (ouput:funtion hi(){ console.log("hi");})


we can add method of other object to a object:
ex: var f = {h:funtion(){}}
    var i = {}
    i.j = f.h;//h function is added to i object if we have this keyword in h function that this ref to i object
we out adding function to object we can directly can that method on other object using below methods 
we have call, apply and bind method to invoke a method on objects
ex: function hi()
var obj = {}
hi.call(obj,[arguments])
apply takes input as array hi.apply([obj],[arguments])
bind binds the method to an object
ex: var t = method.bind(object);
     call the method using t passing arguments t([arguments])

..function Selfinvocation..
(function (first) {//we can also write without a parameter
    console.log(first);
})("dilip");


x.__proto__ //gets the prototype of that instance


..firstclassfunction...
function can assign to varibles,array
functions can pass as arguments
can return from functions
alows to create higher order functions(also called callbacks)

..arrayfuntions..//higerfunctions
//below are functions for array prototype creates new array will not change the orinal array(save to new array)//look MDN for example
map()//takes a funtion as argument and run on each element in function
filter()//run on each elemnets are return 
redunce()//reduces to with the logic pass throug funtion

..synchronous..
When you execute something synchronously, you wait for it to finish before moving on to another task. When you execute something asynchronously, you can move on to another task before it finishes.Each time a function is called, program execution waits until that function returns before continuing to the next line of code.Asynchronous execution avoids this
javascript is synchronous and single thread language
when we run a process that block that single thread application hangs(a function runing long time makes the page unressponisve)
so javascript has asychronous function

..Asychronous..
execution stack//
Browser API// manages the function execution with their api (ex: settimeout().. etc) place the function on function queue 
function queue//waiting function are on function
event loop//if there are no tasks on exection stack places function on th stack(manages the flow)

--------//flow diagram
global execution
-----------       ---------
exe stack         browserapi
-----------       ----------
	|eventloop    |ex:settimeout()//keep on function queue 
        |(manages)    |
  	--------------------
	funtion queue
	---------------------

asyc functions//there even more(browerapi or node interprter api)
setTimeout();
XMLHttpRequest();,jQuery.ajax(),fetch()
database calls



..callbacks..(do this after this(simple understaning))
controls the flow of async functions(when to call what)
passing function as a parameter(help in adding new function logic and control the flow for example getting data from database(pass a query and make a callback when the query exec the callback raises) no halt in the execution)
without callback: if you want open a file, read and write data to it in aync way the program stops at opening the file if any error raise their is a halt 
using callback the bowserAPI's handles(until the file is opened) them when done adds that to function queue eventloop adds it to exe stack


..closures..
clousres works on lexical scoping (scope chain gives the parent variable to their child function(aslo same for global execution context(look funtion scope(console.dir(functionname()in inspect element)))))
lexical scope at global context has a problem(closures solves it)


TRUTHY AND FALSY IN JAVASCRIPT
JavaScript allows us to use non-boolean values in conditional statements. Thus, instead of just true and false, a whole set of values are equivalent to true and false. In JavaScript, the following values are treated as falsy:

undefined
null
NaN
0
'' (any empty string)
false (the boolean value)

Any other value is treated as truthy, including, but not limited to:

Any nonzero number
Any nonempty string
Any nonnull object or array
true (the boolean value)
