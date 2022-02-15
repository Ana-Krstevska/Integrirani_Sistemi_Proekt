using Integrirani_Sistemi_Proekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Data.Services
{
    public interface ITagsService
    {
        Task<IEnumerable<Tag>> GetAllAsync();
        Task<Tag> GetByIdAsync(int id);
        Task AddAsync(Tag tag);
        Task<Tag> UpdateAsync(int id, Tag newTag);
        Task DeleteAsync(int id);

    }
}
