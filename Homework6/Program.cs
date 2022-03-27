static void ShowCharacter(string str, int position)
{
    System.Console.WriteLine(str[position-1]);
}

static double CalculateRetail(double wholesaleCost, double markupPercentage)
{
    return ((markupPercentage * 0.01) * wholesaleCost) + wholesaleCost;
}

static double Celsius(double fahrenheit)
{
    return (5.0 / 9.0) * (fahrenheit - 32.0);
}

static Boolean IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;

    var loopLimit = Math.Ceiling(Math.Sqrt(number)); 

    for (int i = 2; i <= loopLimit; ++i)  
       if (number % i == 0)  
           return false;
    return true;
}

System.Console.WriteLine("Enter a string");
var str = Console.ReadLine();
System.Console.WriteLine("Enter an integer");
var position = int.Parse(Console.ReadLine());
ShowCharacter(str, position);


System.Console.WriteLine("Enter an item's wholesale cost: ");
var wholesaleCost = Double.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the item's markup percentage");
var markupPercentage = Double.Parse(Console.ReadLine());
System.Console.WriteLine(CalculateRetail(wholesaleCost, markupPercentage));



double c;
for(int F =80; F <=100; F++)
{
    c = Celsius(F);
    System.Console.WriteLine(F + "F = " + c + "C");
}


System.Console.WriteLine("Please enter a number, to determine if it a prime number!");
var number = int.Parse(Console.ReadLine());
System.Console.WriteLine(IsPrime(number));

