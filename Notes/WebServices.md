http://web.archive.org (is to see old archived websites)

webservice can be from anywhere  from a phone, computer or a internet connected fridge(should ask the info properly)
to avoid refreshing the page to get data we need a webservice(webservice is a framework for conversation between two computers)
Webservice has some requirements for usage.
modren webservice are always handled over http but change in format of meessages
to use web service we need to know the API of the wenservices

Message format.
SAOP format is a particular(kind) of XML format, Generic XML format, JSON, other...

Request Syntax:(how to call)
Named methods.(calling a webservice with method sytnax(like calling a method))
URI: (URL)
Parameter names and datatype

Requesting actions:(actions to call)
Named methods (like named methods reques action)
HTTP verbs(POST, GET, PUT, PATCH, DELETE)

Authentication(if the web service is secured, action to be taken)
username or password
Authentication tokens

Receiving the data:
Formats: SOAP, XML, JSON
Metadata: describe data structure, include field/property names and data types
Content: the actual data

we need not to know what technology is used to build a webservice except api

History
before web serive there are other implementaion for exchange data
EDI: Electronic Data Interchange
RPC: remote Procedure call(always to call funtions and routines)
CORBA: (interoperate with other tech or lang but very complex)

XML:(derived from SGML other markup language)(3 goals:readable for humans and machines, general can understand by diffrent tech(above are binary formats), simple)(plain text)(Because it has strict formatting rules, you can easily validate whether a particular XML snippet properly represents expected data)
Then diffrent standards emerged based on XML:
XMLRPC, ATOM and RSS are well known in todays webservices,(there are many XML language designs)
and the SOAP can was introduced, SOAP is a XML message fromate, XML-RPC base standard. became very powerful(became WS-* web service everything)
JSON
Most recent is JSON(smaller then XML less decorative notaion(light weight, faster)), popular on mobile devices(and WS-*) uses http
but XML is heavly used in enterpise computing where computers and computers exchange

Transport Protocols
in predated internet whatever electronic commution aviable like EDI used telephone connection to transfar data.
then Telex, Telnet, Bi-directional modems.
(non-http protocols)While XML internet was get popular so used internet protocols for web sevices, First FTP, where files with data are exchanged. they are async. next SMPT to send the msg via email or file and POP to get messages(two protols to send and receive msgs)(async too)
HTTP used now. Simple text vacabulary.HTTP uses diffrent methods get, post, put, delete, trace, options, connect patch(not all clients or browser support all(different web services uses diffrent methods read documentation)) and has HTTP headers to modify the request in some way.
a get request send using URI
Post request sends data using body, can define diffrent parameter like content-type(messaege formate or type), content-length, (what you see in network tab)(http is easy to secure, api key, token bases such as open ID, OAUTH, all support SSL)

Message Formats:
XML, JSON, RSS(also XML type), Atom
SOAP is a xml format (complex, need libraries on both sides client and server, has very restrict vocabulary and methad)
other formats: AMF(action message fromat is a bianary format need tool to see the data(smaller and faster, not supported by many)))
other text formates:HTML, Comma and tab separated, arbitrary format require custom fomats
Binary format:Spred sheets, Zipped or archived databases, images

SOAP
SAOP uses function(operations) to perform taskes(more text because of more meta data. need engines to pharse the data, developer has to trust library(need a light weight(JSON)))

REST web service:(Web a REST implemetation uses all http methods it is call restfull service)
rest is an architecture not a specific messaging format.
Rest can generate both Plain XML(any XML fromat such as RSS, ATOM or any custom) and JSON
can perform all http methods and verbs(restfull services translate them to server side actions,client capable of creating them)
constraints: statelessness: every request is independent.
cacheable: Rest result can be cacheable on client to reduce trancetions
very usefull of mobile devices because of bandwidth, storage well suited

ODATA:
based on Rest standard
can choose XML and JSON but message formats has restrictions need libraies on clinet and server(like SOAP)

Other web serivce standars
XML-RPS. XML Remote Procedure Call
UDDi: Universal Discovery and Description
WSDL: Web Service Description Language
WSDM: Web Service Distributed Management
WS-*: All the other
(there many standards)These standards are managed by an organization named The Web Services Interoperability Organization.
www.ws-i.org

To know about web services. web services registries was created(will be a directive of avilable services)
UDDI: universal description descovery and integration(XML)(not used mostly now but still used in some large companies)
now we have public free usefull sites
xmethods.com
service-repository
programableweb.com




Authenticating web api
1)in header name//like JWT 
 Authorization token JWT
 it should send by every request

2)Has API key to authenticate //like key while using mapbox

3) OAuth very popular

4)OpenId

