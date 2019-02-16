using System;
using Xunit;
using CqrsDemo.Domain.Models.CentreAggregate;
using CqrsDemo.Domain.Exceptions;

namespace CqrsDemo.Domain.UnitTest
{
    public class CentreAggregateTest
    {
        [Fact]
        public void VerifyCentreId()
        {
            Assert.Throws<CentreDomainException>(() => new Centre(0, "centre1", "India", "Gujrat", "city1"));
        }

        [Fact]
        public void VerifyCentreWorksProperly()
        {
            var centre = new Centre(1, "centre1", "India", "Gujrat", "city1");
            Assert.Equal("centre1", centre.Name);
        }

        [Fact]
        public void VerifyCandidateAdd()
        {
            var centre = new Centre(1, "centre1", "India", "Gujrat", "city1");

            centre.AddCandidate(1, "jon", "doe", 2, ".net");
            centre.AddCandidate(2, "rahul", "doe", 3, "java");

            Assert.Equal(2, centre.Candidates.Count);
        }
    }
}
