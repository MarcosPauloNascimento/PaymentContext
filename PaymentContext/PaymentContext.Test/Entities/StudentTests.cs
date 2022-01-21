using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Entities.Payments;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Test.Entities
{
    [TestClass]
    public class StudentTests
    {
        private Subscription _subscription;
        private Name _name;
        private Document _document;
        private Email _email;
        private Address _address;
        private Student _student;

        public StudentTests()
        {
            _name = new Name("Marcos", "Paulo");
            _document = new Document("123456789", EDocumentType.CPF);
            _email = new Email("marcos@gmail.com");
            _student = new Student(_name, _document, _email);
            _address = new Address("Rua 1", "100", "Bairro", "SP", "BR", "05890230");
            _subscription = new Subscription(null);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHasActiveSubscription()
        {
            var payment = new PayPalPayment("1234567", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Joãozinho", _document, _address, _email);
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
            _student.AddSubscription(_subscription);

            Assert.IsFalse(_student.IsValid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenSubscriptionHasNoPayment()
        {
            _student.AddSubscription(_subscription);

            Assert.IsFalse(_student.IsValid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenHasNoActiveSubscription()
        {
            var payment = new PayPalPayment("1234567", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Joãozinho", _document, _address, _email);
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
            Assert.IsTrue(_student.IsValid);
        }
    }
}
