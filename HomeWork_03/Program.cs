double[] array = { 1.23, 2.45, 3.67, 4.89, 5.01 };

double maxNumber = array[0];
double minNumber = array[0];

foreach (double number in array)
{
    if (number > maxNumber)
    {
        maxNumber = number;
    }

    if (number < minNumber)
    {
        minNumber = number;
    }
}

double diff = maxNumber - minNumber;

System.Console.Write($"Массив {array}");
System.Console.WriteLine();
System.Console.Write($"Максимальный элеменет {maxNumber}");
System.Console.WriteLine();
System.Console.Write($"Минимальный элеменет {minNumber}");
System.Console.WriteLine();
System.Console.Write($"Разница между максимальным и минимальным {diff}");