Console.WriteLine(Addition.Add(7, 2));
Console.WriteLine(Substraction.Substract(10, 1));
Console.WriteLine(Multiplication.Multiply(3, 3));
Console.WriteLine(Division.Divide(18, 2));

public class Addition
    //esta clase implementa la operacion suma
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}
public class Division

{
    public static double Divide(int a, int b)
        //Esta clase implementa la operacion division
    {
        return (double)a / b;
    }
}

public class Substraction
// esta clase implementa la operacion resta
{
    public static int Substract(int a, int b)
    {
        return a - b;
    }
}

public class Multiplication
// esta clase implimenta la operacion mulitplicacion
{
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}