using System;

class DemoBreak
{
public static void Main()
{
for (int i=0;i<=100;i++)
{
Console.WriteLine(i);
if(i==50)
break;
}
Console.WriteLine("End of the loop");
}
}