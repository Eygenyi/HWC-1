
Console.Write("Enter number1 ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number2 ");
int numb2 = Convert.ToInt32(Console.ReadLine());
if (numb1 > numb2)
{
    Console.Write("Max number is " + numb1);
    Console.Write("     Min number is: " + numb2);
}
else
{
    Console.Write("Max number is " + numb2);
    Console.Write("     Min number is: " + numb1);
}