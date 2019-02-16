using CqrsDemo.Domain.SeedWork;
using CqrsDemo.Domain.Exceptions;

namespace CqrsDemo.Domain.Models.CentreAggregate
{

    public class Address : ValueObject
    {
        public string Country { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }

        public Address(string country, string state, string city)
        {
            if (string.IsNullOrWhiteSpace(country) ||
                string.IsNullOrWhiteSpace(state) ||
                string.IsNullOrWhiteSpace(city))
            {
                throw new CentreDomainException();
            }

            Country = country;
            State = state;
            City = city;
        }
    }
}