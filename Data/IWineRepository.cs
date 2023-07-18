using APIWine.Models;
using Microsoft.EntityFrameworkCore;

namespace APIWine.Data
{
    public interface IWineRepository
    {
        Task Delete(long id);
        Task<IEnumerable<Wine>> GetAll();
        Task<Wine> GetById(long id);
        Task Insert(Wine wine);
        Task Update(long id, Wine wine);
    }
    public class wineRepository : IWineRepository
    {
        private readonly AppDbContext _context;

        public wineRepository(AppDbContext context)
        {
            _context = context;

        }

        public async Task Delete(long id)
        {
            if (_context.Wines == null)
            {
                throw new WineNotFoundExceptiont();
            }
            var wine = await _context.Wines.FindAsync(id);
            if (wine == null)
            {
                throw new WineNotFoundExceptiont();
            }

            _context.Wines.Remove(wine);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Wine>> GetAll()
        {
            return await _context.Wines.ToListAsync();
        }

        public async Task<Wine> GetById(long id)
        {
            return await _context.Wines.FindAsync();
        }

        public async Task Insert(Wine wine)
        {
            if (_context.Wines == null)
            {
                throw new ArgumentException(nameof(wine));

            }
            _context.Wines.Add(wine);
            await _context.SaveChangesAsync();
        }

        public async Task Update(long id, Wine wine)
        {
            _context.Entry(wine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WineExists(id))
                {
                    throw new WineNotFoundExceptiont();
                }
                else
                {
                    throw;
                }
            }
        }
        private bool WineExists(long id)
        {
            return (_context.Wines?.Any(e => e.id == id)).GetValueOrDefault();
        }


    }
    public class WineNotFoundExceptiont : Exception
    {

    }

}
