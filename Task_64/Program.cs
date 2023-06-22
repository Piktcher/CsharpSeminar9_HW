// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.Write("Введите произвольное целое число, ");
int number = Convert.ToInt32(Console.ReadLine());

string GetNumbers(int startNumber)
{
    if (startNumber == 1)
    {
        return startNumber.ToString();
    }
    return (startNumber + " " + GetNumbers(startNumber - 1));
}

Console.WriteLine(GetNumbers(number));
