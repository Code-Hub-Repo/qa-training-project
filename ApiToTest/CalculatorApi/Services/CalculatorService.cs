namespace CalculatorApi.Services;

public interface ICalculatorService
{
    int Add(int a, int b);
    int Subtract(int a, int b);
}

public class CalculatorService : ICalculatorService
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
}