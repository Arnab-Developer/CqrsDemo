using System;
using System.Threading.Tasks;
using CqrsDemo.Domain.Models.CentreAggregate;

namespace CqrsDemo.Infrustructure.Repositories
{
    public class CentreRepository : ICentreRepository
    {
        public async Task<bool> Add(Centre c)
        {
            return await Task.FromResult(true);
        }
    }
}
