This is the readme file for Computer Networking MCIS 6163 Project 1 - Simple Web Server & Client

In this project we will use Python to transfer files over a network using socket programmming.


Requirements:
IDE - Pycharm 2019.3.5
Language - Python 3.7
Packages - None 
Description:


This project introduces sockets in Python that help a multithreaded web server interact with
one or more web clients using a text-based protocol - HTTP. The multithreaded feature of the 
server can handle multiple client requests concurrently. If the requested file exists, then
the server returns a 200 OK message along with the data in the file. If the file is not
found, then the server responds with 404 Not Found message. Additionally, the Round Trip Time
and other relevant details such as host name, socket family, socket type, and others are
extracted from the client and server.

Instructions to run the web server:
1. In the command prompt, navigate to the folder that contains the server code file.
2. Run the server code file by typing python server_code_file_name host_name port. For
example, python server.py --host 127.0.0.1 --port 8080 --file sample.txt
You can change any file name you would like.
3. If no port number is given, then the server will run automatically on port 8080.
4. If the port is running, the server is binded to the port and waits for the incoming
requests from the clients by displaying the message 'Server is ready'.

Instructions to run the web client:
1. From the command line, navigate to the folder that contains the client code file.
2. Run the client code file by typing python client_code_file_name host_name port. For
example, python client.py --host 127.0.0.1 --port 8080
3. If the code is run with incomplete command line parameters, the default values of 
host name 127.0.0.1 and port 8080 are used.
4. Once the client side code is executed, the connection between client and server is
established.

5. The request is passed on to server and if the exists, the server responds with
'HTTP/1.1.200 OK' and displays the contents of file on both terminals.

6. In addition to the file content, other details like RTT, Host name, Port number,
Host IP address, peer name, Socket family, socket type, time out are extracted from
the server side.