namespace Calc1AddInSideAdapter
{
    using System.AddIn.Pipeline;
    using Calc1AddInView;
    using Calc1Contract;
    
    [AddInAdapter]
    public class CalculatorViewToContractAddInSideAdapter : ContractBase, ICalc1Contract
    {
        private ICalculator view;

        public CalculatorViewToContractAddInSideAdapter(ICalculator view)
        {
            this.view = view;
        }

        public double Add(double a, double b)
        {
            return this.view.Add(a, b);
        }

        public double Subtract(double a, double b)
        {
            return this.view.Subtract(a, b);
        }

        public double Multiply(double a, double b)
        {
            return this.view.Multiply(a, b);
        }

        public double Divide(double a, double b)
        {
            return this.view.Divide(a, b);
        }
    }
}