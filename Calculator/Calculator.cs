namespace Calculator;

public class Calculator
{
    public double A { get; }
    public double B { get; }
    public char Op { get; }

    public Calculator(double a, double b, char op)
    {
        A = a;
        B = b;
        Op = op;
    }

    public double Add() => A + B;
    public double Subtract() => A - B;
    public double Multiply() => A * B;
    public double Divide()
    {
        if (B == 0) throw new DivideByZeroException();
        return A / B;
    }

    public double Calculate() => Op switch
    {
        '+' => Add(),
        '-' => Subtract(),
        '*' => Multiply(),
        '/' => Divide(),
        _   => throw new ArgumentException("Unsupported operation")
    };
}