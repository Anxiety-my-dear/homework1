Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int b = 0;
Console.Write("Целые числа:");
int y;
while(( n > 0 ) ? (b <= n):(b >= n))
{
    y = (b % 2);
    if (y == 0) Console.Write("{0},", b);
    if (n>0) b++; 
    else b--;
}
