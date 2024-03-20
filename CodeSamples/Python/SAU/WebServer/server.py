import socket, threading, sys, os.path, argparse

commandLineArguments = argparse.ArgumentParser()
commandLineArguments.add_argument('--host', dest= "hostName",  default="127.0.0.1", help= "Takes host name from options or default's to localhost/127.0.0.1")
commandLineArguments.add_argument('--port', dest= "portNumber",  default=8080, help= "Takes port number from options line or default's to 8080")
commandLineArguments.add_argument('--file', dest= "fileName",  default="sample.txt", help= "Takes file name from options or default's to sample.txt")
args = commandLineArguments.parse_args()

host = args.hostName  
portNumber = int(args.portNumber)


class StartServerThread(threading.Thread): #inheriting Thread class

    BUFFERSIZE = 2048

    def __init__(self, ip, port, sock):
        threading.Thread.__init__(self)
        self.ip = ip
        self.port = port
        self.sock = sock 

    def run(self): #Will run when when thread is started
        emptyResoruce = ("/",'',None)
        try:
            msg = self.sock.recv(StartServerThread.BUFFERSIZE)
            urlResource = msg.split()[1]
            print(f"Requested URL is: {urlResource[1:]}")        
            urlResource = urlResource[1:].decode("utf-8")
            if urlResource in emptyResoruce:
                urlResource = args.fileName
            if os.path.isfile(urlResource)==True :
                print(f"Resource to process {urlResource}")
                resource = open(urlResource)
                output = resource.read()
                resource.close()
                self.sock.send(b'HTTP/1.1 200 OK')
                for i in range(0, len(output)):
                    self.sock.send(output[i].encode())
                print("File transfer success")
            else:
                print(f"Resource not found {urlResource}") 
                self.sock.send(b'HTTP/1.1 404 Not Found')
        except IOError:
            print("Error processing request") 
            self.sock.send(b'HTTP/1.1 404 Not Found')             
        finally:
            self.sock.close()



class StartServer():

    def __init__(self):
        self.ServerSocket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

    def bindSockect(self):
        try:           
            self.ServerSocket.bind((host, portNumber))
            print("Server bind is complete")
        except socket.error as message: 
            print(message)
            sys.exit()
        self.ServerSocket.listen(10)
        print("Server is ready")
        
    def startServer(self):
        self.bindSockect()
        threads = []
        while True:
            connectionDetails, address = self.ServerSocket.accept()
            print(f"Connection established with IP address: {address[0]} and port number: {str(address[1])}")
            print(connectionDetails)
            conn = StartServerThread(address[0], address[1], connectionDetails) #StartServerThread returns a thread object
            conn.start()
            threads.append(conn)
            for thread in threads:
                thread.join() #attaches to main thread
            
    def main(self):
        self.startServer()



if __name__ == "__main__":
    StartServer().main()


"""
References
https://realpython.com/intro-to-python-threading/#join-a-thread
https://docs.python.org/3/library/socket.html
https://www.geeksforgeeks.org/command-line-arguments-in-python/
https://www.geeksforgeeks.org/socket-programming-python/
"""