using CqrsDemo.Domain.SeedWork;
using CqrsDemo.Domain.Exceptions;

namespace CqrsDemo.Domain.Models.CentreAggregate
{
    public class Candidate : Entity
    {
        public int Id { get; private set; }
        public PersonName CandidateName { get; private set; }
        public Subject CandidateSubject { get; private set; }

        public Candidate(int id, string firstName, string lastName, int subjectId, string subjectName)
        {
            if (id == 0)
            {
                throw new CentreDomainException();
            }

            Id = id;
            CandidateName = new PersonName(firstName, lastName);
        }
    }
}