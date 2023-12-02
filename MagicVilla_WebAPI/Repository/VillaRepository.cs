using MagicVilla_WebAPI.Data;
using MagicVilla_WebAPI.Models;
using MagicVilla_WebAPI.Repository.IRepostiory;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVilla_WebAPI.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
