using System.Collections.Generic;
using MediatR;

namespace CqrsDemo.Web.Application.Commands
{
    public class CreateCentreCommand : IRequest<bool>
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Country { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public List<CandidateDto> Candidates { get; private set; }

        public CreateCentreCommand(int v1, string v2, string v3, string v4, string v5, List<CandidateDto> cands)
        {
            this.Id = v1;
            this.Name = v2;
            this.Country = v3;
            this.State = v4;
            this.City = v5;
            this.Candidates = cands;
        }
    }

    public class CandidateDto
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int SubjectId { get; private set; }
        public string SubjectName { get; private set; }       

        public CandidateDto(int v1, string v2, string v3, int v4, string v5)
        {
            this.Id = v1;
            this.FirstName = v2;
            this.LastName = v3;
            this.SubjectId = v4;
            this.SubjectName = v5;
        } 
    }
}