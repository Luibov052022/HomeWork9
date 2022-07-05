// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.


void PrintNatural(int M, int N)
{
    if (M > N) return;
    if (M % 2 == 0)
    {
        System.Console.Write(M + " ");
    }
    PrintNatural(M + 1, N);
}

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

PrintNatural(Prompt("Введите число 1: "), Prompt("Введите число 2: "));

