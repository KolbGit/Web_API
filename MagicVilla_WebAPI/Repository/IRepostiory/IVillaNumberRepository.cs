using MagicVilla_WebAPI.Models;

namespace MagicVilla_WebAPI.Repository.IRepostiory
{
    public interface IVillaNumberRepository : IRepostiory<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
