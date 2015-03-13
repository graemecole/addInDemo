namespace Calc1AddInView
{
    using System.AddIn.Pipeline;

    [AddInBase]
    public interface ICalculator
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
    }
}