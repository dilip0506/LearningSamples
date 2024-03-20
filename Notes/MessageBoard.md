we can place many components in single component
serives and components are injected into constructor parameter
to access data from webservice we have create a service in angular using http module
to use any component we have to register to app.module.ts file using import
components to declarations array
imported modules should add to imports array
services are added to providers array
bootstrap triggers the first compnent to raise

we used WebAPI template for this project

ngOnInit() function gets call we the component is iniatized and the construtor is called

when we call the service with a URL that does not get the data because angular or js does not support the cross origin data or data from different service(diffrent port differnt URL considers as diffrent server) so we need to enable the cors(cross origin resource sharing) in the backend(see code in startup.cs hove to enable cors) cors is not only the option we can use proxies and other things 

async and await is new way of writing javascript asyncoounors code
in this code serive returns promise we have to wait untill reponse is returned so aysc and await(in es6) change es5 to es6 in config

we have to refresh the page after post call to veiw new msgs
if the messages componet knows when the new-messagecomponent is post a msg then it will show immediately
below is one way but the data is coming from local angular array(no error or reponse when the backend is not resposing. the data is also not inserted user may loss data(fasle impression))
we can expose message array component to parent component(app.component) it has both new message(post) and message(get) componets(call) can silent both and update
we Output, EventEmiter and ViewChild from angular core(option 1)

we can do it with service
instead of calling getMessages method from the webservice we are directly calling in the constrcturor of the service and using the webserive.mesages array in the template loop
and in PostMessage method we are geting updated message list form backend and pushing to Message array, only successfully added messages are displayed in front end
try catch used at this point works for async and await functions(only) later we see obervables and promises

routing:
import routermodule from angular/route
create a list of routes using route objects
ex: var route = [{path:'',component:ExComponet}, {path:'ex2',Ex2Component}]
<router-outlet>is the tag where these components are loaded
routerLink = "ex2"//button,anchor tag to route
while passing data through routing into url we need to bind it [routerlink] = ['.ex2',name]
app.module in routes 'exe/:value'
to get params from url we use ActivatedRoute from @angular/router
this.Activate.snapshot.params.name(activate and name are variabless)



observable has it own error handiling callback(it has next, error, complete) i.e, error handling is diffrent for both
promise send only single value, observable(async pattern, emited data and notification over a period of time) send mutiple values they are observers(subsribers, they subscribe to the observale(subscribe is call backfuntion aslo has many callback but not for promises))

exposing directly variables(here messages array) from services is not a good idea so we have abservalbes i.e, subject(a subject allows subscribers to subscribe to it) we can send messages array through it
subject use s.next(value) to add subscribe be we can accidentally add the data to subject outside the service it may problem protect it by exposing observale instead of subject


validation:
Angular has many type of validation. most common validation is puting your validation logic inside the template or html it self. the other type is reactiveform or model driven form(we use)
we create model we expect out of the form(the model it self contains the validation logic in it)
import formBuilder, reactiveformbuilder [formGroup], formControlName

import validators form angular forms
var? "?" is null conditional operator

user authentication for backend
but now we are using few authnetication packets(we use token)
genarally asp.net has cookie authentication identity framework(production(each time they reload the app without loggin with cookie stored on server and client passed every time to know who the user but it is not as flexible as safe in some expects as tokens))
 With a token, the server generates the token, which contains the user ID, and assigned against a secret. The encrypted token is then sent upon registering or logging in, and is kept somehow on the browser. The token is then passed back with every request, and the server decrypts the token with the secret, and now the server knows who just sent the request since it contains the user ID. It's quite simple to implement, since it's a stateless method unlike a cookie. There is a lot more to it, but that's all we need to know for now to get started working with them. 
and token authentication(we are making in single auth coutrol)

once the user provides registration detail we need to send them a token which is stored in browser and passed back for every request
install nuget package(system.identitymodel.tokens.jwt)
token might be complex we can use a payload, user claims (research on jwttoken)

entity framework the core version is opensource object relational mapping(orm) framework takes the message using user model and allows us store in any kind of database(more flexible and secure)

in this app we are using mini database(in memoery)
DbContext is primary class intreacts with database between models
added ApiContext and made mani changes to startup class(to enable mini bd)

create a post function to edit the user information. only an authorized user should access the user information and edit it. but he should not get the info from url or public dataset(can pass id of other users we should take the id securly). token authentication helps in doing(and payload and claims) it will be encoded
jwttoken has no payload, no claims. But if we stuck the user ID in there as a payload, it would be encoded. Therefore, the browser, or any other client, would not be able to modify what's inside, guaranteeing that the user ID never changes. And when the user requests to edit their information, the token is passed along as a header to our user's edit function, and we decrypt it with a key that only the server has. And we now have the ID of the user that sent the request, and we can safely make the changes. Firststore our ID in the token

we are using a middleware to verifiy the token (from inside the auth header) at the backend.(added some code in startup class)
enabled middleware
added singing crediantilas, added some autherization code
