using MagicVilla_WebAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_WebAPI.Repository.IRepostiory
{
    public interface IVillaRepository : IRepostiory<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
