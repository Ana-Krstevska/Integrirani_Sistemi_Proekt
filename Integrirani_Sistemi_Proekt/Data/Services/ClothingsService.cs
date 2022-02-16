using Integrirani_Sistemi_Proekt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Data.Services
{
    public class ClothingsService : IClothingsService
    {
        private readonly AppDbContext _context;

        public ClothingsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Clothing clothing)
        {
            await _context.Clothings.AddAsync(clothing);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Clothings.FirstOrDefaultAsync(n => n.Id == id);
            _context.Clothings.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Clothing>> GetAllAsync()
        {
            var result =await _context.Clothings.ToListAsync();
            return result;
        }

        public async Task<Clothing> GetByIdAsync(int id)
        {
            var results = await _context.Clothings.FirstOrDefaultAsync(n => n.Id == id);
            return results;
        }

        public async Task<Clothing> UpdateAsync(int id, Clothing newClothing)
        {
            _context.Update(newClothing);
            await _context.SaveChangesAsync();
            return newClothing;
        }
    }
}
