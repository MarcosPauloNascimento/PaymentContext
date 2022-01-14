using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Test.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var subscription = new Subscription(null);
            var student = new Student("Marcos", "Paulo", "123456789", "marcos@gmail.com");
            student.AddSubscription(subscription);
        }
    }
}
