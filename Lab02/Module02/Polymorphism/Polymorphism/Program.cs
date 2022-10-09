using Moq;
using System;
using System.Collections.Generic;

//
//
//

namespace Polymorphism
{
    public class Program
    {
        private static void Main(string[] args)
        {
            const int hours = 55, wage = 70;

            var mock = new Mock<Utils>();
            mock.Setup(m => m.GetMockWorkers()).Returns(() =>
            new List<IWorker> { new Contractor(), new Employee() });

            List<IWorker> employees = mock.Object.GetMockWorkers();


            foreach (var e in employees)
            {
                e.CalculateWeeklySalary(hours, wage);
            }
            Console.ReadLine();
        }        
    }
}
