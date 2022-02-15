using Integrirani_Sistemi_Proekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Data.Services
{
    public interface IShopsService
    {
        Task<IEnumerable<Shop>> GetAllAsync();
        Task<Shop> GetByIdAsync(int id);
        Task AddAsync(Shop shop);
        Task<Shop> UpdateAsync(int id, Shop newShop);
        Task DeleteAsync(int id);

    }
}
