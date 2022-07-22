using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculatorLibrary.Interface;
using SimpleCalculatorLibrary.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculatorApplication.Tests
{
    [TestClass()]
    public class SubtractionServiceTests
    {
        private readonly ISimpleCalculatorService _simpleCalculatorService;

        #region Constructor
        public SubtractionServiceTests()
        {
            _simpleCalculatorService = new SimpleCalculatorService();
        }
        #endregion

        #region SubtractionTestScenarios
        [TestMethod()]
        public void SubtractionTestScenario1()
        {
            Assert.AreEqual(_simpleCalculatorService.SubtractService(0, 0), 0);
        }

        [TestMethod()]
        public void SubtractionTestScenario2()
        {
            Assert.AreEqual(_simpleCalculatorService.SubtractService(-2545, 2545), -5090);
        }

        [TestMethod()]
        public void SubtractionTestScenario3()
        {
            Assert.AreEqual(_simpleCalculatorService.SubtractService(897, -897), 1794);
        }

        [TestMethod()]
        public void SubtractionTestScenario4()
        {
            Assert.AreEqual(_simpleCalculatorService.SubtractService(547, 879), -332);
        }

        [TestMethod()]
        public void SubtractionTestScenario5()
        {
            Assert.AreEqual(_simpleCalculatorService.SubtractService(-7854, -2478), -5376);
        }

        [TestMethod()]
        public void SubtractionTestScenario6()
        {
            Assert.AreEqual(_simpleCalculatorService.SubtractService(365.254, -365.254), 730.508);
        }

        [TestMethod()]
        public void SubtractionTestScenario7()
        {
            Assert.AreEqual(_simpleCalculatorService.SubtractService(1475.54, 445697.549), -444222.009);
        }

        [TestMethod()]
        public void SubtractionTestScenario8()
        {
            Assert.AreEqual(_simpleCalculatorService.SubtractService(54846.658, -8784.94), 63631.598);
        }

        [TestMethod()]
        public void SubtractionTestScenario9()
        {
            Assert.AreEqual(_simpleCalculatorService.SubtractService(-987.654862, 2687.987), -3675.642);
        }

        [TestMethod()]
        public void SubtractionTestScenario10()
        {
            Assert.AreEqual(_simpleCalculatorService.SubtractService(-3657, -2779.6756), -877.324);
        }
        #endregion
    }
}