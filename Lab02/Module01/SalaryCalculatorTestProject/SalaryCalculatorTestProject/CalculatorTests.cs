using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace SalaryCalculatorTestProject
{
    /*		
        To get hourly, divide annual salary by 2080     
        $100,006.40 / 2080 = $48.08  hr

        To get annual, multiply hourly by 2080 
        $48.08 * 2080 = $100,006.40
    */

    [TestClass]
    public class CalculatorTests
    {
        // Done
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal annualSalary = sc.GetAnnualSalary(50);

            // Assert   
            Assert.AreEqual(104000, annualSalary);
        }
        // Done
        [TestMethod]
        public void HourlyWageTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal hourlyWage = sc.GetHourlyWage(52000); // /2080 = 25

            // Assert   
            Assert.AreEqual(25, hourlyWage);
        }

        // New Test Methods
        [TestMethod]
        public void AnnalSalaryTestNegative() 
        { 
            SalaryCalculator sc = new SalaryCalculator();
            try
            {
                decimal annualSalary = sc.GetAnnualSalary(-50);
                Assert.Fail("exception");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Hourly wage must greater then zero.", ex.Message);  
            }
        }

        // 2
        [TestMethod]
        public void HourlyTestNegative()
        {
            SalaryCalculator sc = new SalaryCalculator();
            try
            {
                decimal annualSalary = sc.GetHourlyWage(-5);
                Assert.Fail("exception");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Yearly wage must greater then zero.", ex.Message);
            }
        }
        // 3

        [TestMethod]
        public void TaxWithholdingTest()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();
            //Act - does not work
            //TaxData taxData = sc.TaxWitheld(1000.0, 2);
            //Act II - works
            TaxData taxData = new TaxData();
            taxData.SetValues(sc.Taxwtheld(1000.0, 2));
            //Assert
            Assert.AreEqual(60.0, taxData.ProvincialTaxWithheld);
            Assert.AreEqual(250.0, taxData.FederalTaxwithheld);
            Assert.AreEqual(40.0, taxData.DependentDeduction);
            Assert.AreEqual(270.0, taxData.TotalWithheld);
            Assert.AreEqual(730.0, taxData.TakeHome);
        }
    }// end of class
}
