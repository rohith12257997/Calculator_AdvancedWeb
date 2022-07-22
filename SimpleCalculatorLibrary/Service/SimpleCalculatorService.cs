using SimpleCalculatorLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculatorLibrary.Service
{
    public class SimpleCalculatorService : ISimpleCalculatorService
    {
        private double Response;

        public SimpleCalculatorService()
        {
            Response = new double();
        }

        public double AddService(double value1, double value2)
        {
            try
            {
                Response = value1 + value2;
                return Math.Round(Response, 3);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double SubtractService(double value1, double value2)
        {
            try
            {
                Response = value1 - value2;
                return Math.Round(Response, 3);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double MultiplyService(double value1, double value2)
        {
            try
            {
                Response = value1 * value2;
                return Math.Round(Response, 3);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double DivideService(double value1, double value2)
        {
            try
            {
                if (value2 == 0)
                {
                    throw new DivideByZeroException("Invalid inputs");
                }
                else
                    Response = value1 / value2;
                
                return Math.Round(Response, 3);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
