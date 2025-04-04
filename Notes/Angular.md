to use npm install node
npm install //to install additional modules 

ng new appname

ng serve -o (or--open)

Typescript adds following to javascript
strongly typed
Modules and classes
Template strings
Interfaces
Generics


Building blocks of angular

components are basic building block of angular app(they work together like paraller or child and parent) every component should have template

Directive
  Component - Templates(HTML), style(CSS) & Logic(JavaScript)
noncomponent
  Attribute - styling HTML
  Structural - Manupulating HTML(on behaviour (ngIf,ngFor))

Data Flow
  interpolation - Variable Printing in Templates
  event binding - Trigger Events
  2-way binding - Variables updated in real time

Providers
  Services
    Reusable Logic
    Data Storing and Manipulation
  Libraries 



@Component({//component can be reused for <my-app> tag
  selector : 'my-app', //(like jquer selector)
  template: `<h3>dilip<h3>`,
  style:['h3{color: green;}']

//other way of writing component using url(we can keep them in diffrent file)
  selector: 'my-app',
  templateUrl: 'app.component.html',
  styleUrl: ['app.component.css']
  [directives: [],
  privides: []],
})
export class MyAppComponent{
console.log("hello angular")
}
<my-app></my-app>


Attribute Directives

includes
[class.red] = "true";
[ngClass] = "{red:true,box:true}"
[ngStyle] = "{background-color:blue, color:black}"//inline not prefred
[customOnHoverHIghlight]

Structural Directive includes
*ngIf
*ngFor
*ngRepeat


DataFlow

interpolation
{{ variablename }}
export class ex {
variablename = "hi";
variablename:array = [1,2,3]
}

"|" is pipe to pass diffrent option
ex {{ num | currency }}// prints the value in curracy format
ex2 {{ num | json }} //int the above example array prints in array form [1,2,3] inste of 1,2,3

event binding:
<button (click) = "onclik()"></button>// there are diffrent events like click,mouseenter etc(see doc..)
export class ex{
onclick(){
alert("hi");
}
} 

2way binding
note: import FormsModule in app.module.ts
<input [(ngModel)]="sample">
<span>{{ sample }}</span>
export class ex{
sample:string = "";
}


providers
services are passsed to provides and dependency injection
@Injectiable{//creating a service
export class service{
task = [];
}
}
@component({
providers:[]
})
export class seriveex{
constructor(public ser: service)// dependency injection
}
we call the service using ser object name(example ser.task)

every class should have a decorater in angular(every class/module should have export keyword because they run in their one scope)
for example: @component for component, @injectable for service

Routing:
in angular when we devolop a single page application Route is using to place a page on clicking the hyperlink(like#div.html(ex.html)in CPH preoject)

angular 2 Http return observables from server

------------------------------------------------------------------------------------------------------------
Pruralsight

We use below typeScript concepts in angular
1. Static typing(strong typing)
2. interfaces: can defince type of interface common for all
ex: interface ICat{
name:string
age?:number
}
note '?' is optinal property
let fluffy:Icat
3. class properties
4. public and private Accessibility(class members are public by default)
class Cat{
private name:string
public speak()
}
simplified:
Javascript				TypeScript
class{					class Cat{
private name:string				constructor(private name:string, private phone:number){
priavte phone:number					
constructor(name, phone){			}
this.name = name				}
this.color = color
}
}


Cmds
rm -rf node_modules
npm start(can also use ng serve)

angular bootstrap
angular.json( "main": "src/main.ts",) --> main.ts(platformBrowserDynamic().bootstrapModule(AppModule)) --> app.compnent.ts( selector: 'app-root') raise the app to index.html 




