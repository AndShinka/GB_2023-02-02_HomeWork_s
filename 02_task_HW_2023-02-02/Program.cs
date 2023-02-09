// 02_task_HW_2023-02-02 Подсчитать сумму цифр в числе
Console.Clear();

Console.WriteLine("Подсчитать сумму цифр в числе" !);

int AskInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumFigures(int numberA)
{
    int sum = 0;

    while (numberA > 0)
    {
        sum = sum + numberA %10;
        numberA = (numberA - (numberA % 10)) /10;
    }
    return sum;
}


int number = AskInt("Введите число для вычисления суммы цифр числа: ");

Console.WriteLine($" Сумма цифр числа {number} составляет: {SumFigures(number)}");


Console.WriteLine();