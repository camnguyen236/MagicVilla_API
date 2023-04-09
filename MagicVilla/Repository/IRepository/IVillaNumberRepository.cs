using MagicVilla.Models;
using MagicVilla.Repository.IRepository;

namespace MagicVilla.Repostiory.IRepostiory
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
