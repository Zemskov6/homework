Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
while (n>9){
	System.Console.Write(n%10 + " ");
	n/=10;
}
System.Console.Write(n);

