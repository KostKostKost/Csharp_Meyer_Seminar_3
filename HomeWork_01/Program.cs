int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i] + " ");
}

System.Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 20 && array[i] < 90)
    {
        Console.Write(array[i] + " ");
    }
}