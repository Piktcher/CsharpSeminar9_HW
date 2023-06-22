// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.Write("Введите произвольное целое число1, ");
int numberM = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите произвольное целое число2, ");
int numberN = Convert.ToInt32(Console.ReadLine());

int GetNumbersSum(int firstNumber, int lastNumber)
{
    if (firstNumber == lastNumber) return lastNumber;
    return (firstNumber + GetNumbersSum(firstNumber + 1, lastNumber));
}

int result = GetNumbersSum(numberM, numberN);
Console.WriteLine($"Сумма чисел между двумя введенными равна {result}");