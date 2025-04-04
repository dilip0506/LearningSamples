import socket, time, argparse

parser = argparse.ArgumentParser()
parser.add_argument('--host', dest= "hostName",  default="127.0.0.1", help= "Takes host name from options or default's to local\127.0.0.1")
parser.add_argument('--port', dest= "portNumber",  default=8080, help= "Takes host name from options or default's to is 8080")
args = parser.parse_args()

host = args.hostName  
serverPort = int(args.portNumber)  

print("server port number is:", serverPort) 
filename = input("Input file name: ")


class ClientSetup():

    BUFFERSIZE = 2048

    def __init__(self):
        self.clientSocket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

    def connectToServer(self):
        try:
            self.clientSocket.connect((host, serverPort))
        except IOError:
            print("Error connecting to server")
            self.clientSocket.close()
            exit()

    def getContent(self):
        self.connectToServer()
        startTime = time.time()
        fileData = ''
        self.clientSocket.send(b'fileContent /' + filename.encode())
        while True:
            fileContent = self.clientSocket.recv(ClientSetup.BUFFERSIZE).decode("utf-8")
            if not fileContent:  
                break
            fileData += fileContent
        endTIme = time.time()
        print(fileData)
        timeLapsed = endTIme - startTime
        self.printLogs(timeLapsed)
        self.clientSocket.close()     
        print('The connection is closed')
        
    def printLogs(self,timeLapsed):
        print(f"Round Trip Time (RTT): {str(timeLapsed)}Seconds")
        print("Host Name: ", socket.gethostname())
        print("Port Number: ", serverPort)
        print("Host IP Address: ", host)
        print("File Requested: ", filename)
        print("Peer Name: ", str(self.clientSocket.getpeername()))
        print('Socket Family: ', str(self.clientSocket.family))
        print('Socket Protocol: ', str(self.clientSocket.proto))
        print('Socket Type: ', str(self.clientSocket.type))
        print('Time Out: ', str(self.clientSocket.timeout))

    
    def main(self):
        self.getContent()
    
if __name__ == "__main__":
    ClientSetup().main()


"""
References
https://docs.python.org/3/library/socket.html
https://www.geeksforgeeks.org/command-line-arguments-in-python/
https://www.geeksforgeeks.org/socket-programming-python/
"""