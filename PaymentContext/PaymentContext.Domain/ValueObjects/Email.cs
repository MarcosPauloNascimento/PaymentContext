﻿using Flunt.Validations;
using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string emailAddress)
        {
            EmailAddress = emailAddress;

            AddNotifications(new Contract<Email>()
                .Requires()
                .IsEmail(EmailAddress, "Email.EmailAddress", "Email inválido")
            );
        }
        public string EmailAddress { get; set; }
    }
}
