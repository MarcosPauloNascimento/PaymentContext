using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string emailAddress)
        {
            EmailAddress = emailAddress;
        }
        public string EmailAddress { get; set; }
    }
}
