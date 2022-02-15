using Integrirani_Sistemi_Proekt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Data.Services
{
    public class BrandsService : IBrandsService
    {
        private readonly AppDbContext _context;

        public BrandsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Brand brand)
        {
            await _context.Brands.AddAsync(brand);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Brands.FirstOrDefaultAsync(n => n.Id == id);
            _context.Brands.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Brand>> GetAllAsync()
        {
            var result =await _context.Brands.ToListAsync();
            return result;
        }

        public async Task<Brand> GetByIdAsync(int id)
        {
            var results = await _context.Brands.FirstOrDefaultAsync(n => n.Id == id);
            return results;
        }

        public async Task<Brand> UpdateAsync(int id, Brand newBrand)
        {
            _context.Update(newBrand);
            await _context.SaveChangesAsync();
            return newBrand;
        }
    }
}
