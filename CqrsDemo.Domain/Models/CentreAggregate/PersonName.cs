using CqrsDemo.Domain.SeedWork;
using CqrsDemo.Domain.Exceptions;

namespace CqrsDemo.Domain.Models.CentreAggregate
{
    public class PersonName : ValueObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public PersonName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName))
            {
                throw new CentreDomainException();
            }

            FirstName = firstName;
            LastName = lastName;
        }

        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
    }
}