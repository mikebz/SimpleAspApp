using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAspApp.Models;

namespace SimpleAspTests
{
    [TestClass]
    public class LoanTest
    {
        [TestMethod]
        public void TestLoanCalculation()
        {
            Loan loan = new Loan((decimal).05, 1000, 5);
            decimal payment = loan.FinalAmount();
            decimal assumedAmount = (decimal)1.2762815625 * 1000;
            Assert.AreEqual(assumedAmount, payment);
        }
    }
}
