using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Test.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var subscription = new Subscription(null);
            var name = new Name("Marcos", "Paulo");
            var document = new Document("123456789", EDocumentType.CPF);
            var email = new Email("marcos@gmail.com");
            var student = new Student(name, document, email);
            student.AddSubscription(subscription);
        }
    }
}
