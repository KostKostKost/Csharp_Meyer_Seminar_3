int[] array = new int[1];

array[0] = new Random().Next(1, 100000);
System.Console.Write(array[0]);
System.Console.WriteLine();
int number1 = 0;
int number2 = 0;
int number3 = 0;
if (array[0] > 9999)
{
    number1 = array[0] % 10;
    System.Console.Write(number1 + " ");

    number2 = array[0] % 100;
    System.Console.Write(number2 + " ");

    number3 = array[0] % 100;
    System.Console.Write(number3 + " ");
}