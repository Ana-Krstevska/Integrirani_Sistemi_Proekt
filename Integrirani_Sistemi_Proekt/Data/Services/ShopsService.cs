using Integrirani_Sistemi_Proekt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Data.Services
{
    public class ShopsService : IShopsService
    {
        private readonly AppDbContext _context;

        public ShopsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Shop shop)
        {
            await _context.Shops.AddAsync(shop);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Shops.FirstOrDefaultAsync(n => n.Id == id);
            _context.Shops.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Shop>> GetAllAsync()
        {
            var result =await _context.Shops.ToListAsync();
            return result;
        }

        public async Task<Shop> GetByIdAsync(int id)
        {
            var results = await _context.Shops.FirstOrDefaultAsync(n => n.Id == id);
            return results;
        }

        public async Task<Shop> UpdateAsync(int id, Shop newShop)
        {
            _context.Update(newShop);
            await _context.SaveChangesAsync();
            return newShop;
        }
    }
}
