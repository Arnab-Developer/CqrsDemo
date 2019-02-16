using CqrsDemo.Web.Application.Commands;

namespace CqrsDemo.Web.SeedWorks
{
    public interface ICreateCentreCommandHandler
    {
        bool Handle(CreateCentreCommand message);
    }
}