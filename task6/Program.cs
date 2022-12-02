while (Console.ReadKey().Key != ConsoleKey.Escape)
{
    Console.WriteLine("Введите число:");
    
    bool success = int.TryParse(Console.ReadLine(), out int x);
    if (success == true)
    {
        int y = (x % 2);

        if ((y == 1) | (y == -1)) Console.WriteLine("Нечётное");
        else Console.WriteLine("Чётное");
    }
    else Console.WriteLine("Error");
}
Console.Clear();