// Напишите программу вычисления фунции Аккермана с помощью рекурсии
// Даны два неотрицательных числа m и n

void Maim()
{
    Console.Write("Введите число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    int Akkerman(int m, int n)
    {
        if(m == 0) return n + 1;
        else if(n ==0) return Akkerman(m - 1, 1);
        else return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    Console. Write($"Функция Аккермана = {Akkerman(m, n)}");
}
Maim();