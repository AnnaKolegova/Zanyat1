Console.WriteLine ("Введите первое число");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int num2=Convert.ToInt32(Console.ReadLine());
if (num1>num2)
{
    Console.WriteLine ($"первое число {num1} больше второго числа {num2}");
}
else if (num1<num2)
{
    Console.WriteLine ($"второе число {num2} больше первого числа {num1}");
}
else
{
    Console.WriteLine ($"числа равны");
}

