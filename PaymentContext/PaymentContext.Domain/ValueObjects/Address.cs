using Flunt.Validations;
using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects
{
    public abstract class Address : ValueObject
    {
        protected Address(string street, string number, string neighborhood, string city, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract<Address>()
                .Requires()
                .IsGreaterThan(Street, 1, "Address.Street", "A Rua deve conter mais do que 1 caracter")
                .IsGreaterThan(City, 1, "Address.City", "O nome da cidade deve conter mais do que 1 caracter")
            );
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
    }
}
