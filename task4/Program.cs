Console.Clear();
Console.WriteLine("Введите три числа:");
int x = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

int max = x;
if (max < c) max = c;
if (max < y) max = y;
Console.WriteLine("Максимальное число:{0}", max);