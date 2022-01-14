using Flunt.Validations;
using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract<Name>()
                .Requires()
                .IsGreaterThan(FirstName, 1, "Name.FirstName", "O nome deve conter mais do que 1 caracter")
                .IsGreaterThan(LastName, 1, "Name.FirstName", "O Sobrenome deve conter mais do que 1 caracter")
            );

        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
