using System;

class DoWhile
{
public static void Main()
{
Console.WriteLine("Enter the value");
int x=int.Parse(Console.ReadLine());
while(x==10)
{
for(int i=0;i<=10;i++)
Console.WriteLine("{0}",x*i);
x++;
}
}
}