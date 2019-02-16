using System.Threading.Tasks;
using CqrsDemo.Domain.SeedWork;

namespace CqrsDemo.Domain.Models.CentreAggregate
{
    public interface ICentreRepository : IRepository
    {
        Task<bool> Add(Centre c);
    }
}