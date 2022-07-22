using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculatorLibrary.Interface;
using SimpleCalculatorLibrary.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculatorApplication.Tests
{
    [TestClass()]
    public class AdditionServiceTests
    {
        private readonly ISimpleCalculatorService _simpleCalculatorService;

        #region Constructor
        public AdditionServiceTests()
        {
            _simpleCalculatorService = new SimpleCalculatorService();
        }
        #endregion

        #region AdditionTestScenarios
        [TestMethod()]
        public void AdditionTestScenario1()
        {
            Assert.AreEqual(_simpleCalculatorService.AddService(0, 0), 0);
        }

        [TestMethod()]
        public void AdditionTestScenario2()
        {
            Assert.AreEqual(_simpleCalculatorService.AddService(-2545, 2545), 0);
        }

        [TestMethod()]
        public void AdditionTestScenario3()
        {
            Assert.AreEqual(_simpleCalculatorService.AddService(897, -897), 0);
        }

        [TestMethod()]
        public void AdditionTestScenario4()
        {
            Assert.AreEqual(_simpleCalculatorService.AddService(547, 879), 1426);
        }

        [TestMethod()]
        public void AdditionTestScenario5()
        {
            Assert.AreEqual(_simpleCalculatorService.AddService(-7854, -2478), -10332);
        }

        [TestMethod()]
        public void AdditionTestScenario6()
        {
            Assert.AreEqual(_simpleCalculatorService.AddService(365.254, -365.254), 0);
        }

        [TestMethod()]
        public void AdditionTestScenario7()
        {
            Assert.AreEqual(_simpleCalculatorService.AddService(1475.54, 445697.549), 447173.089);
        }

        [TestMethod()]
        public void AdditionTestScenario8()
        {
            Assert.AreEqual(_simpleCalculatorService.AddService(54846.658, -8784.94), 46061.718);
        }

        [TestMethod()]
        public void AdditionTestScenario9()
        {
            Assert.AreEqual(_simpleCalculatorService.AddService(-987.654862, 2687.987), 1700.332);
        }

        [TestMethod()]
        public void AdditionTestScenario10()
        {
            Assert.AreEqual(_simpleCalculatorService.AddService(-3657, -2779.6756), -6436.676);
        }
        #endregion
    }
}