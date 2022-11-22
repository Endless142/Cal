bool end = false;
int num1Input;
int num2Input;
int operationInput;

do

{
Console.WriteLine("Операции: 1 - сложение, 2 - вычитание 3 - умножение, 4 - деление, 5 - возвести в сепень, 6 - квадратный корень, 7 - 1% от числа, 8 - факториал, 9 - Выйти из программы");
Console.WriteLine("Выберите операцию из списка");
while (!int.TryParse(Console.ReadLine(), out operationInput))
{
Console.WriteLine("Выберите операцию из списка");
}

if (operationInput == 1)
{
Console.WriteLine("Введите первое число");
while (!int.TryParse(Console.ReadLine(), out num1Input))
{
Console.WriteLine("Введите целое число!");
};
double num1 = Convert.ToDouble(num1Input);

Console.WriteLine("Введите второе число");
while (!int.TryParse(Console.ReadLine(), out num2Input))
{
Console.WriteLine("Введите целое число!");
};
double num2 = Convert.ToDouble(num2Input);
Console.WriteLine($"{num1}+{num2} = {num1 + num2}");

}

else if (operationInput == 2)
{

Console.WriteLine("Введите первое число");
while (!int.TryParse(Console.ReadLine(), out num1Input))
{
Console.WriteLine("Введите целое число!");
};
double num1 = Convert.ToDouble(num1Input);

Console.WriteLine("Введите второе число");
while (!int.TryParse(Console.ReadLine(), out num2Input))
{
Console.WriteLine("Введите целое число!");
};
double num2 = Convert.ToDouble(num2Input);
Console.WriteLine($"{num1}-{num2} = {num1 - num2}");

}

else if (operationInput == 3)
{

Console.WriteLine("Введите первое число");
while (!int.TryParse(Console.ReadLine(), out num1Input))
{
Console.WriteLine("Введите целое число!");
};
double num1 = Convert.ToDouble(num1Input);

Console.WriteLine("Введите второе число");
while (!int.TryParse(Console.ReadLine(), out num2Input))
{
Console.WriteLine("Введите целое число!");
};
double num2 = Convert.ToDouble(num2Input);
Console.WriteLine($"{num1}*{num2} = {num1 * num2}");

}

else if (operationInput == 4)
{

Console.WriteLine("Введите первое число");
while (!int.TryParse(Console.ReadLine(), out num1Input))
{
Console.WriteLine("Введите целое число!");
};
double num1 = Convert.ToDouble(num1Input);

Console.WriteLine("Введите второе число");
while (!int.TryParse(Console.ReadLine(), out num2Input))
{
Console.WriteLine("Введите целое число!");
};
double num2 = Convert.ToDouble(num2Input);
if (num2 == 0)
{
Console.WriteLine($"Деление на 0 невозможно");
}
else
{
Console.WriteLine($"{num1}/{num2} = {num1 / num2}");
}
}

else if (operationInput == 5)
{

Console.WriteLine("Введите число");
while (!int.TryParse(Console.ReadLine(), out num1Input))
{
Console.WriteLine("Введите целое число!");
};
double num1 = Convert.ToDouble(num1Input);

Console.WriteLine("Введите степень");
while (!int.TryParse(Console.ReadLine(), out num2Input))
{
Console.WriteLine("Введите целое число!");
}; ;
double num2 = Convert.ToDouble(num2Input);
Console.WriteLine($"{num1} в степени {num2} = " + (Math.Pow(num1, num2)));

}
else if (operationInput == 6)
{

Console.WriteLine("Введите число");
while (!int.TryParse(Console.ReadLine(), out num1Input))
{
Console.WriteLine("Введите целое число!");
};
double num1 = Convert.ToDouble(num1Input);

Console.WriteLine($"Квадратный корень из {num1} = " + (Math.Sqrt(num1)));

}
else if (operationInput == 7)
{
    Console.WriteLine("Введите число");
    while (!int.TryParse(Console.ReadLine(), out num1Input))
    {
        Console.WriteLine("Введите целое число!");
    };
    double num1 = Convert.ToDouble(num1Input);

    Console.WriteLine($"1% из числа {num1} = {num1 / 100}");

}
else if (operationInput == 8)
{

    Console.WriteLine("Введите число");
    while (!int.TryParse(Console.ReadLine(), out num1Input))
    {
        Console.WriteLine("Введите целое число!");
    };
    double num1 = Convert.ToDouble(num1Input);

    long factorial = (1);
    if (factorial == 0)
    {
        Console.WriteLine("факториал 0 = 1");
    }
    else
        for (int i = 1; i <= num1; i++)
        {
            factorial *= i;
        }
    Console.WriteLine($"факториал {num1} = " + (factorial));
}
else if (operationInput == 9)
{
    end = true;
}
else
{
    Console.WriteLine("Выбирите операцию из списка");
}

}
while (!end);