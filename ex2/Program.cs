double getX(double k1, double k2, double b1, double b2)
{
    return (b2 - b1)/(k1 - k2); 
}

double getY(double k1, double k2, double b1, double b2)
{
    return k1 * ((b2 - b1)/(k1 - k2)) + b1; 
}

Console.WriteLine("Введите точку b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());



if ((k1 == k2) && (b1 == b2))
{ Console.WriteLine("Прямые совпадают "); }
else if (k1 == k2)
{ Console.WriteLine("Прямые параллельны ");}
else {
double x = getX(k1, k2, b1, b2);
double y = getY(k1, k2, b1, b2);
Console.WriteLine("(" + x + ";" + y + ")");}


