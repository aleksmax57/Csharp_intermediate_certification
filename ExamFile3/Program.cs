// Задайте произвольный массив.Выведите его элеиенты, начиная с конца.
// Использовать рекурсию, не использовать циклы.

void Main()
{
    Console.Write("Введите целое число: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();
    int[] nums = new int[size];
    Console.Write("Массив случайных чисел: ");
    void PrintNums(int size)
    {
        if(size < 0) return;
        PrintNums(size - 1);
        Console.Write(size + " ");
    }
    Console.WriteLine("");
    PrintNums(size);
    Console.WriteLine("\n" + "Массив в обратном порядке: ");
    void ShowNums(int size)
    {
        if(size < 0) return;
        Console.Write(size + " ");
        ShowNums(size - 1);
    }
    ShowNums(size);
    Console.WriteLine("");
}
Main();
