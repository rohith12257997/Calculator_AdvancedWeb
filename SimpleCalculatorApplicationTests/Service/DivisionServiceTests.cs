using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculatorLibrary.Interface;
using SimpleCalculatorLibrary.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculatorApplication.Tests
{
    [TestClass()]
    public class DivisionServiceTests
    {
        private readonly ISimpleCalculatorService _simpleCalculatorService;

        #region Constructor
        public DivisionServiceTests()
        {
            _simpleCalculatorService = new SimpleCalculatorService();
        }
        #endregion

        #region DivisionTestScenarios
        [TestMethod()]
        public void DivisionTestScenario1()
        {
            Assert.ThrowsException<DivideByZeroException>(() => _simpleCalculatorService.DivideService(0, 0));
        }

        [TestMethod()]
        public void DivisionTestScenario2()
        {
            Assert.ThrowsException<DivideByZeroException>(() => _simpleCalculatorService.DivideService(1458, 0));
        }

        [TestMethod()]
        public void DivisionTestScenario3()
        {
            Assert.AreEqual(_simpleCalculatorService.DivideService(0, -897), 0);
        }

        [TestMethod()]
        public void DivisionTestScenario4()
        {
            Assert.AreEqual(_simpleCalculatorService.DivideService(0, 879), 0);
        }

        [TestMethod()]
        public void DivisionTestScenario5()
        {
            Assert.AreEqual(_simpleCalculatorService.DivideService(-7854, -2478), 3.169);
        }

        [TestMethod()]
        public void DivisionTestScenario6()
        {
            Assert.AreEqual(_simpleCalculatorService.DivideService(365.254, -365.254), -1);
        }

        [TestMethod()]
        public void DivisionTestScenario7()
        {
            Assert.AreEqual(_simpleCalculatorService.DivideService(1475.54, 445697.549), 0.003);
        }

        [TestMethod()]
        public void DivisionTestScenario8()
        {
            Assert.AreEqual(_simpleCalculatorService.DivideService(54846.658, -8784.94), -6.243);
        }

        [TestMethod()]
        public void DivisionTestScenario9()
        {
            Assert.AreEqual(_simpleCalculatorService.DivideService(-987.654862, 2687.987), -0.367);
        }

        [TestMethod()]
        public void DivisionTestScenario10()
        {
            Assert.AreEqual(_simpleCalculatorService.DivideService(-3657, -2779.6756), 1.316);
        }
        #endregion
    }
}