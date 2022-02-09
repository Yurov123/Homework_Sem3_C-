//  Задать номер четверти, показать диапазоны для возможных координат
// могу ошибаться в решении,но другого варианта не вижу,точнее не понимаю как можно задать четверть

Console.WriteLine("Enter x: ");
double x = Convert.ToDouble(Console.ReadLine());
 
Console.WriteLine("Enter y: ");
double y = Convert.ToDouble(Console.ReadLine());
 
if ((x > 0) && (y > 0))
Console.WriteLine("1 quarter");
else
{
    if ((x < 0) && (y > 0))
        Console.WriteLine("2 quarter");
    else
    {
    if ((x < 0) && (y < 0))
        Console.WriteLine("3 quarter");
    else
    {
    if ((x > 0) && (y < 0))
        Console.WriteLine("4 quarter");
    else
        Console.WriteLine("The point lies on the axis");
    }
    }
}



















