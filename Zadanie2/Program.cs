Console.WriteLine("Введите координаты по оси X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты по оси Y");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
	System.Console.WriteLine("1");
}
if (x < 0 && y > 0)
{
	System.Console.WriteLine("2");
}
if (x < 0 && y < 0)
{
	System.Console.WriteLine("3");
}
if (x > 0 && y < 0)
{
	System.Console.WriteLine("4");
}