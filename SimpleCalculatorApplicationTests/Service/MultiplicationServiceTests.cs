using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculatorLibrary.Interface;
using SimpleCalculatorLibrary.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculatorApplication.Tests
{
    [TestClass()]
    public class MultiplicationServiceTests
    {
        private readonly ISimpleCalculatorService _simpleCalculatorService;

        #region Constructor
        public MultiplicationServiceTests()
        {
            _simpleCalculatorService = new SimpleCalculatorService();
        }
        #endregion

        #region MultiplicationTestScenarios
        [TestMethod()]
        public void MultiplicationTestScenario1()
        {
            Assert.AreEqual(_simpleCalculatorService.MultiplyService(0, 0), 0);
        }

        [TestMethod()]
        public void MultiplicationTestScenario2()
        {
            Assert.AreEqual(_simpleCalculatorService.MultiplyService(-2545, 2545), -6477025);
        }

        [TestMethod()]
        public void MultiplicationTestScenario3()
        {
            Assert.AreEqual(_simpleCalculatorService.MultiplyService(897, -897), -804609);
        }

        [TestMethod()]
        public void MultiplicationTestScenario4()
        {
            Assert.AreEqual(_simpleCalculatorService.MultiplyService(547, 879), 480813);
        }

        [TestMethod()]
        public void MultiplicationTestScenario5()
        {
            Assert.AreEqual(_simpleCalculatorService.MultiplyService(-7854, -2478), 19462212);
        }

        [TestMethod()]
        public void MultiplicationTestScenario6()
        {
            Assert.AreEqual(_simpleCalculatorService.MultiplyService(365.254, -365.254), -133410.485);
        }

        [TestMethod()]
        public void MultiplicationTestScenario7()
        {
            Assert.AreEqual(_simpleCalculatorService.MultiplyService(1475.54, 445697.549), 657644561.451);
        }

        [TestMethod()]
        public void MultiplicationTestScenario8()
        {
            Assert.AreEqual(_simpleCalculatorService.MultiplyService(54846.658, -8784.94), -481824599.731);
        }

        [TestMethod()]
        public void MultiplicationTestScenario9()
        {
            Assert.AreEqual(_simpleCalculatorService.MultiplyService(-987.654862, 2687.987), -2654803.43);
        }

        [TestMethod()]
        public void MultiplicationTestScenario10()
        {
            Assert.AreEqual(_simpleCalculatorService.MultiplyService(-3657, -2779.6756), 10165273.669);
        }
        #endregion
    }
}