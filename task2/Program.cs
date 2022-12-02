Console.Clear();
Console.WriteLine("Введите два числа:");
int x = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if(x == c) Console.WriteLine("Они равны!!");
else
{
if (x > c) Console.WriteLine("Большее число: " + x + "\nМеньшее число: " + c);
else Console.WriteLine("Большее число: " + c + "\nМеньшее число: " + x);
}