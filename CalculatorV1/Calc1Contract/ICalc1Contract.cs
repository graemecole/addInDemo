namespace Calc1Contract
{
    using System.AddIn.Contract;
    using System.AddIn.Pipeline;

    // The AddInContractAttribute identifes this pipeline segment as a  
    // contract.
    [AddInContract]
    public interface ICalc1Contract : IContract
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
    }
}