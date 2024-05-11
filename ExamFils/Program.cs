// Задайте значение M и N. Напишите программу, которая выводит вввсе натуральные
// числа в промежутке от M до N. Использовать рекурсию, не использовать цикл

Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());  
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
void PrintNumbers(int N)
{
    if(N < M) return;
    PrintNumbers(N - 1);
    Console.Write(N + " ");
}
void Maim()
{
    PrintNumbers(N);
}
Maim();