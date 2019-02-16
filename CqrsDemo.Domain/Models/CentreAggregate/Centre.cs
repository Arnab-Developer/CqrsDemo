using System;
using System.Collections.Generic;
using CqrsDemo.Domain.SeedWork;
using CqrsDemo.Domain.Exceptions;

namespace CqrsDemo.Domain.Models.CentreAggregate
{
    public class Centre : Entity, IAggregateRoot
    {
        private readonly List<Candidate> _candidates;

        public int Id { get; private set; }
        public string Name { get; private set; }
        public Address CentreAddress { get; private set; }
        public IReadOnlyCollection<Candidate> Candidates => _candidates;

        public Centre(int id, string name, string country, string state, string city)
        {
            if (id == 0 ||
                string.IsNullOrWhiteSpace(name))
            {
                throw new CentreDomainException();
            }

            Id = id;
            Name = name;
            CentreAddress = new Address(country, state, city);
            _candidates = new List<Candidate>();
        }

        public void AddCandidate(int id, string firstName, string lastName, int subjectId, string subjectName)
        {
            var candidate = new Candidate(id, firstName, lastName, subjectId, subjectName);
            _candidates.Add(candidate);
        }
    }
}