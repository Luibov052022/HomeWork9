// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.


int SumNatural(int M, int N)
{
    if (M > N) return 0;

    return M + SumNatural(M + 1, N);
}

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

Console.WriteLine($"Сумма натуральных элементов в промежутке равна {SumNatural(Prompt("Введите число 1: "), Prompt("Введите число 2: "))}");

