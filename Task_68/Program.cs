// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.Write("Введите первую цифру ф-ции Аккермана, ");
int numberM = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите вторую цифру ф-ции Аккермана, ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SolveAkkerman(int firstNumber, int secondNumber)
{
    if (firstNumber == 0) return secondNumber + 1;
    else if (secondNumber == 0) return SolveAkkerman(firstNumber - 1, 1);
    return SolveAkkerman(firstNumber - 1, SolveAkkerman(firstNumber, secondNumber - 1));
}

int result = SolveAkkerman(numberM, numberN);
Console.WriteLine($"Значение ф-ции Аккермана для заданных чисел равно {result}");