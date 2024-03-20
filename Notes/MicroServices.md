Microserivce communicates using protocols such as HTTP/HTTPS, WebSockets, or AMQP.


The following are important aspects to enable success in going into production with a microservices-
based system:
• Monitoring and health checks of the services and infrastructure.
• Scalable infrastructure for the services (that is, cloud and orchestrators).
• Security design and implementation at multiple levels: authentication, authorization, secrets
management, secure communication, etc.
• Rapid application delivery, usually with different teams focusing on different microservices.
• DevOps and CI/CD practices and infrastructure.


• Authentication and authorization
• Service discovery integration
• Response caching
• Retry policies, circuit breaker, and QoS
• Rate limiting and throttling
• Load balancing
• Logging, tracing, correlation
• Headers, query strings, and claims transformation
• IP allowlisting


Microservice must own its domain data and logic. Just as a full application owns its logic and data. data access becomes much more complicated when you move to a microservices
architecture


Most microservice-based scenarios demand availability and high scalability as opposed to strong
consistency. Mission-critical applications must remain up and running, and developers can work
around strong consistency by using techniques for working with weak or eventual consistency. This is
the approach taken by most microservice-based architectures


HTTP chaining

• Blocking and low performance. Due to the synchronous nature of HTTP, the original request
doesn’t get a response until all the internal HTTP calls are finished.
• Coupling microservices with HTTP. Business microservices shouldn’t be coupled with other
business microservices. Ideally, they shouldn’t “know” about the existence of other microservices.
If your application relies on coupling microservices as in the example, achieving autonomy per
microservice will be almost impossible.
• Failure in any one microservice. If you implemented a chain of microservices linked by HTTP
calls, when any of the microservices fails (and eventually they will fail) the whole chain of
microservices will fail. A microservice-based system should be designed to continue to work as
well as possible during partial failures.

The goal when identifying model boundaries and size for each microservice isn’t to get to the most
granular separation possible, although you should tend toward small microservices if possible. 


With Azure API Management, you can secure your APIs using a key, a token, and IP filtering.
there are many other products in the market offering API Gateways features, such as
Apigee, Kong, MuleSoft, WSO2, and other products like Linkerd and Istio for service mesh ingress
controller features.

a better approach is to have several fined-grained API Gateways
that respond to different client needs.

RabbitMQ is low level messaging broker
NServiceBus, MassTransit, and Brighter runs on top of RabbitMQ(explorer them) or you can build it


Resiliently publishing to the event bus
A challenge when implementing an event-driven architecture across multiple microservices is how to
atomically update state in the original microservice while resiliently publishing its related integration
event into the event bus, somehow based on transactions. The following are a few ways to accomplish
this functionality, although there could be additional approaches as well.
• Using a transactional (DTC-based) queue like MSMQ. (However, this is a legacy approach.)
• Using transaction log mining.
• Using full Event Sourcing pattern.
• Using the Outbox pattern: a transactional database table as a message queue that will be the
base for an event-creator component that would create the event and publish it.


s to embed the API version number in the URL or into
an HTTP header


Each container (an instance of a Docker image) includes the following components:
• An operating system selection, for example, a Linux distribution, Windows Nano Server, or
Windows Server Core.
• Files added during development, for example, source code and application binaries.
• Configuration information, such as environment settings and dependencies.

for production environments, you might want to explore additional ways on how to store
secrets like the connection strings. An excellent way to manage application secrets is using Azure Key
Vault.
