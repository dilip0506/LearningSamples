using System;

class DemoContinue
{
static void Main()
{
for(int i=0;i<=100;i++)
{
Console.WriteLine(i);
if(i==7||i==77)
continue;
Console.WriteLine(i);
}
}
}