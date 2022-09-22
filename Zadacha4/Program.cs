Console.WriteLine ("Введите первое число");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье число");
int num3=Convert.ToInt32(Console.ReadLine());
if ((num1>num2) & (num1>num3))
{
    Console.WriteLine ($"первое число {num1} больше");
}
else if ((num2>num1) & (num2>num3))
{
    Console.WriteLine ($"второе число {num2} больше");
}
else if ((num3>num1) & (num3>num2))
{
    Console.WriteLine ($"третье число {num3} больше");
}
else
{
    Console.WriteLine ($"числа равны");
}

