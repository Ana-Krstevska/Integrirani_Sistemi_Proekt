using Integrirani_Sistemi_Proekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Data.Services
{
    public interface IClothingsService
    {
        Task<IEnumerable<Clothing>> GetAllAsync();
        Task<Clothing> GetByIdAsync(int id);
        Task AddAsync(Clothing clothing);
        Task<Clothing> UpdateAsync(int id, Clothing newClothing);
        Task DeleteAsync(int id);

    }
}
