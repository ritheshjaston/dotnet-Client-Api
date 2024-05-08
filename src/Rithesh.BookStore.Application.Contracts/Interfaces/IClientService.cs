using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rithesh.BookStore.DTOs;

namespace Rithesh.BookStore.Interfaces
{
    public interface IClientService
    {
        Task<IActionResult> GetListAsync();
        Task<IActionResult> GetByIdAsync(Guid id);
        Task<IActionResult> CreateAsync(ClientDTO client);
        Task<IActionResult> UpdateAsync(ClientDTO client);
        Task<IActionResult> DeleteAsync(Guid id);
    }
}
