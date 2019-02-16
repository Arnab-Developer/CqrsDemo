using CqrsDemo.Web.Application.Commands;
using CqrsDemo.Domain.Models.CentreAggregate;
using CqrsDemo.Web.SeedWorks;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CqrsDemo.Web.Application.Commands
{
    public class CreateCentreCommandHandler : IRequestHandler<CreateCentreCommand, bool>
    {
        private ICentreRepository _repository;

        public CreateCentreCommandHandler(ICentreRepository repository)
        {
            _repository = repository;
        }

        public Task<bool> Handle(CreateCentreCommand message, CancellationToken cancellationToken)
        {
            var centre = new Centre(message.Id, message.Name, message.Country, message.State, message.City);

            centre.AddCandidate(1, "jon", "doe", 2, ".net");
            centre.AddCandidate(2, "rahul", "doe", 3, "java");

            return _repository.Add(centre);
        }
    }
}