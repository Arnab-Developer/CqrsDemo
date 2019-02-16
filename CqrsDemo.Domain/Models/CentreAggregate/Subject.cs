using CqrsDemo.Domain.SeedWork;
using CqrsDemo.Domain.Exceptions;

namespace CqrsDemo.Domain.Models.CentreAggregate
{
    public class Subject : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Subject(int id, string name)
        {
            if (id == 0||
                string.IsNullOrWhiteSpace(name))
            {
                throw new CentreDomainException();
            }

            Id = id;
            Name = name;
        }
    }
}