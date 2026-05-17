namespace MultiFileTest;

public static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Multiply(int a, int b) => a * b;
    public static int SumRange(int from, int to)
    {
        int total = 0;
        for (int i = from; i <= to; i++) total += i;
        return total;
    }
}