

internal class Program
{
    private static void Main(string[] args)
    {
        Maths maths1 = new Maths(); // (0 0 +)
        Maths maths2 = new Maths(5,7,'-');
        Maths maths3 = new Maths('*', 10, 4);
        Maths maths4 = new Maths(maths2);
        
        Console.WriteLine(maths1.ToString());
        Console.WriteLine(maths2.ToString());
        Console.WriteLine(maths3.ToString());
        Console.WriteLine(maths4.ToString());

        maths4.Sign = '+';
        maths4.Num2 = 0;
        Console.WriteLine(maths4.Num1);

        Console.WriteLine(maths2.Calc());
        Console.WriteLine(maths3.Calc());
        Console.WriteLine(maths4.Calc());

        // ПРОВЕРКА ВВОДА на тип данных
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        char c = char.Parse(Console.ReadLine());
        Maths maths5 = new Maths(x,y,c);
    }
}