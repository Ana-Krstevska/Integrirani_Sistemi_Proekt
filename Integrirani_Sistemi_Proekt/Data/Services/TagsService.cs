using Integrirani_Sistemi_Proekt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Data.Services
{
    public class TagsService : ITagsService
    {
        private readonly AppDbContext _context;

        public TagsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Tag tag)
        {
            await _context.Tags.AddAsync(tag);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Tags.FirstOrDefaultAsync(n => n.Id == id);
            _context.Tags.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Tag>> GetAllAsync()
        {
            var result =await _context.Tags.ToListAsync();
            return result;
        }

        public async Task<Tag> GetByIdAsync(int id)
        {
            var results = await _context.Tags.FirstOrDefaultAsync(n => n.Id == id);
            return results;
        }

        public async Task<Tag> UpdateAsync(int id, Tag newTag)
        {
            _context.Update(newTag);
            await _context.SaveChangesAsync();
            return newTag;
        }
    }
}
