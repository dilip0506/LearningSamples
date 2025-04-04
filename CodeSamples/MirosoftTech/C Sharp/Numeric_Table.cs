using System;
class Numeric_Table
{
static void Main()
{
int s = 1;
do
{
Console.Write("Enter the number: ");
string x = Console.ReadLine();
if(x=="")
return;
try
{
int y = int.Parse(x);
Console.WriteLine("\n"+"Table of " + y + " is:" +"\n");
for(int i=1;i<=10;i++)
Console.WriteLine("{0}*{1}={2}",y,i,y*i);
}
catch (FormatException)
{
Console.WriteLine("\n"+"Enter numeric values only..."+"\n");
}
Console.WriteLine("Press Enter Key to close..."+"\n");
}
while(s==1);
}
}