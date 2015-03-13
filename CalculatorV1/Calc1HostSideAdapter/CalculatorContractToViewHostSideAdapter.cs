using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc1HostSideAdapter
{
    using System.AddIn.Pipeline;
    using Calc1HVA;
    using Calc1Contract;

    [HostAdapter]
    public class CalculatorContractToViewHostSideAdapter : Calc1HVA.ICalculator
    {
        private ICalc1Contract calc1Contract;

        private System.AddIn.Pipeline.ContractHandle contractHandle;

        public CalculatorContractToViewHostSideAdapter(ICalc1Contract calc1Contract)
        {
            this.calc1Contract = calc1Contract;
            this.contractHandle = new ContractHandle(calc1Contract);
        }

        public double Add(double a, double b)
        {
            return calc1Contract.Add(a, b);
        }

        public double Subtract(double a, double b)
        {
            return calc1Contract.Subtract(a, b);
        }

        public double Multiply(double a, double b)
        {
            return calc1Contract.Multiply(a, b);
        }

        public double Divide(double a, double b)
        {
            return calc1Contract.Divide(a, b);
        }
    }
}
