using MagicVilla.Models;
using MagicVilla.Repository.IRepository;
using System.Linq.Expressions;

namespace MagicVilla.Repostiory.IRepostiory
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
