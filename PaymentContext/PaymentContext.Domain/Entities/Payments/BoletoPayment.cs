using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Domain.Entities.Payments
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(
            string barCode, 
            string ourNumber,
            DateTime paidDate, 
            DateTime expireDate, 
            decimal total, 
            decimal totalPaid, 
            string payer, 
            Document document, 
            Address address, 
            Email email) : base(
                paidDate, 
                expireDate, 
                total, 
                totalPaid, 
                payer, 
                document, 
                address, 
                email)
        {
            BarCode = barCode;
            OurNumber = ourNumber;
        }

        public string BarCode { get; private set; }
        public string OurNumber { get; private set; }
    }
}
