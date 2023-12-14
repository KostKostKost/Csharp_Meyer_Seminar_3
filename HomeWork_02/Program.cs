int[] array = new int[10];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    System.Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine();
System.Console.Write($"В массиве содержится {count} четных чисел");