Console.Write("Enter number1  ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number2  ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number3  ");
int numb3 = Convert.ToInt32(Console.ReadLine());
int max=numb1;
if (numb2 > max)
{
    max = numb2;
}
else
{
    numb1 = max;
}

if (numb3 > max)
{
    max = numb3;
}
else
{
    numb1 = max;
}

Console.Write("Max number is " + max);
