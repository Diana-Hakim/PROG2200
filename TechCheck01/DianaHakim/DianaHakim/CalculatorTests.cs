using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DianaHakim
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            double annualSalary = (double)sc.GetAnnualSalary(50);

            // Assert   
            Assert.AreEqual(104000, annualSalary);
        }
        [TestMethod]
        public void HourlyWageTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            double hourlyWage = (double)sc.GetHourlyWage(52000);

            // Assert   
            Assert.AreEqual(25, hourlyWage);
        }
        [TestMethod]
        public void AnnualSalaryTestNegative()
        {
            SalaryCalculator sc = new SalaryCalculator();
            try
            {
                decimal annualSalary = sc.GetAnnualSalary(-50);
                Assert.Fail("Exception - Negitive Annual Salary");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Hourly wage must greater then zero.", ex.Message);
            }
        }
        [TestMethod]
        public void HourlyTestNegative()
        {
            SalaryCalculator sc = new SalaryCalculator();
            try
            {
                decimal annualSalary = sc.GetHourlyWage(-50);
                Assert.Fail("Exception - Negitive Hourly Salary");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Yearly wage must greater then zero.", ex.Message);
            }
        }
        [TestMethod]
        public void AnnualSalaryTestZero()
        {
            SalaryCalculator sc = new SalaryCalculator();
            try
            {
                decimal annualSalary = sc.GetAnnualSalary(0);
                Assert.Fail("Exception - Zero Annual Salary");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Hourly wage must greater then zero.", ex.Message);
            }
        }
        [TestMethod]
        public void HourlyTestZero()
        {
            SalaryCalculator sc = new SalaryCalculator();
            try
            {
                decimal annualSalary = sc.GetHourlyWage(0);
                Assert.Fail("Exception - Zero Hourly Salary");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Yearly wage must greater then zero.", ex.Message);
            }
        }

        [TestMethod]
        public void EmpDataTestTA()
        {
            EmpData data = new EmpData();
            Assert.AreEqual(data.EmpAccount(1500, 3)["Tax Amount"], 375);
        }
        [TestMethod]
        public void EmpDataTestDD()
        {
            EmpData data = new EmpData();
            Assert.AreEqual(data.EmpAccount(1500, 3)["Dependent Deduction"], 225);
        }

        [TestMethod]
        public void EmpDataTestNT()
        {
            EmpData data = new EmpData();
            Assert.AreEqual(data.EmpAccount(1500, 3)["Net Tax Amount"], 150);
        }
        [TestMethod]
        public void EmpDataTestTH()
        {
            EmpData data = new EmpData();
            Assert.AreEqual(data.EmpAccount(1500, 3)["Total Take Home"], 1350);
        }


    }
}
