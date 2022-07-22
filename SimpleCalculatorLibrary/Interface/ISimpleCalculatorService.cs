using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculatorLibrary.Interface
{
    public interface ISimpleCalculatorService
    {
        double AddService(double value1, double value2);

        double SubtractService(double value1, double value2);

        double MultiplyService(double value1, double value2);

        double DivideService(double value1, double value2);
    }
}
