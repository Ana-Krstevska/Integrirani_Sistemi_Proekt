using Integrirani_Sistemi_Proekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Data.Services
{
    public interface IBrandsService
    {
        Task<IEnumerable<Brand>> GetAllAsync();
        Task<Brand> GetByIdAsync(int id);
        Task AddAsync(Brand brand);
        Task<Brand> UpdateAsync(int id, Brand newBrand);
        Task DeleteAsync(int id);

    }
}
