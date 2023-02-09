// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();
Console.WriteLine("Программа вычисления произведения чисел от 1 до N" !);

int AskInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size, int startNum, int endNum)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
         array[i] = i + 1 ;  
    return array;
}

int MultipArray (int[] arrayMultip)
{
    int multipRes = 1;
        for (int i = 0; i < arrayMultip.Length; i++)
        {
        multipRes = multipRes * arrayMultip[i]; 
        }
    return multipRes;
}

int numbN = AskInt("Введите число N для вычисления кубов чисел от 1 до N: ");
int[] array = CreateArray(numbN, 1, numbN);

Console.Write($"Произведение чисел от 1 до {numbN}  равно: {MultipArray(array)}");

Console.WriteLine();