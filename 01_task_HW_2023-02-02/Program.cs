// Найти кубы чисел от 1 до N
Console.Clear();

Console.WriteLine("Найти кубы чисел от 1 до N" !);
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

void PrintArray (int[] array)
{
    foreach(int element in array)
        Console.Write($"  {element} \t");
}

void CubeArray (int[] arrayCube)
{
    Console.WriteLine();
    Console.WriteLine($"Kубы чисел от 1 до {arrayCube.Length}: ");
    for (int i = 0; i < arrayCube.Length; i++)
        {
        arrayCube[i] = arrayCube[i] * arrayCube[i] * arrayCube[i]; 
        Console.Write($"  {arrayCube[i]} \t");
        }
}

int numbN = AskInt("Введите число N для вычисления кубов чисел от 1 до N: ");
int[] array = CreateArray(numbN, 1, numbN);
PrintArray(array);
CubeArray (array);

Console.WriteLine();