using System;
class Switch
{
static void Main()
{
Console.WriteLine("Enter the value");
int Sno = int.Parse(Console.ReadLine());
switch(Sno)
{
case 1:
Console.WriteLine("Case 1 is selected");
break;
case 2:
Console.WriteLine("Case 2 is selected");
break;
default:
Console.WriteLine("Value Does not Exits");
break;
}
}
}