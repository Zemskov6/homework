Console.WriteLine("Введите число на отрезке [10;99]");
int n = Convert.ToInt32(Console.ReadLine());
if (n>=10 && n<=99){
	int n1 = n/10;
	int n2 = n%10;
	if (n1>n2){
		System.Console.WriteLine(n1);
	}
	else{
		System.Console.WriteLine(n2);
	}
}
else{
	System.Console.WriteLine("Число вне отрезка");
}