JavaScript is dynamic typed(no types) JavaScript is not scalable
TS makes js scalable
TS is superset of javascript that transpiler(source-to-source compiler) to plain Javascript.
TS is Sytax surgar and provides more control on JavaScript
by adding some type and checking types(enable typechecker ex: checkjs:true,strict:false)

adds strongly typed
Modules and classes(like namespace using same names defferianting them)
Template strings
interfaces
Generics to javascript

function x(num: number) : number {// takes only number as input and returns number(type checking at compile time)
return num * num
}

class Person {// actually no class in js it just (alternative to prototype function)
  constructor(public name: string){
}
}
var per = new person("dilip ")





(viual code build using typescript intelligence comes from ts file we can create ts file for other frameworks npm has around 3000)
npm install -g typescript
tsc -init(initiates new typescript and creates tsconfig.js)
tsc -w(watch mode)
when yoe compile a ts file javascript file is create with ES standards used in tsconfig.js

google in angular create appscript(joined microsoft to use typescript feature)

typescript is working with popular javascript frameworks to make prodection easy

let decimal: number = 6;
let list: Array<number> = [1, 2, 3];

1. Static typing(strong typing)
2. interfaces: can defince type of interface common for all
ex: interface ICat{
name:string
age?:number
}
note '?' is optinal property
let fluffy:Icat


