// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();

Console.WriteLine("Показать кубы чисел, заканчивающихся на четную цифру" !);
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

void EvenCubeArray (int[] arrayCube)
{
    Console.WriteLine();
    Console.WriteLine($"Kубы чисел, заканчивающихся на четную цифру {arrayCube.Length}: ");
    for (int i = 0; i < arrayCube.Length; i++)
        {
        arrayCube[i] = arrayCube[i] * arrayCube[i] * arrayCube[i]; 
        Console.Write(arrayCube[i] %2 == 0 ? $"  {arrayCube[i]} \t" : $"   \t");
        }
}

int numbN = AskInt("Введите число N для вычисления кубов чисел от 1 до N: ");
int[] array = CreateArray(numbN, 1, numbN);
PrintArray(array);
EvenCubeArray (array);

Console.WriteLine();
