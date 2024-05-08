using Microsoft.AspNetCore.Mvc;
using Rithesh.BookStore.DTOs;
using Rithesh.BookStore.Interfaces;
using Rithesh.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Rithesh.BookStore
{
    public class ClientService : ApplicationService, IClientService, ITransientDependency
    {

        private readonly IRepository<Client, Guid> _clientrepositry;

        public ClientService(IRepository<Client, Guid> clientrepositry)
        {
            _clientrepositry = clientrepositry;
        }

        public async Task<IActionResult> CreateAsync(ClientDTO client)
        {
            try
            {
                var clientMappedObject = ObjectMapper.Map<ClientDTO, Client>(client);
                var clientObject = await this._clientrepositry.InsertAsync(clientMappedObject);
                return new OkObjectResult(clientObject);
            }
            catch (Exception ex)
            {
                return new BadRequestResult();
            }
        }

        public async Task<IActionResult> DeleteAsync(Guid Id)
        {
            await this._clientrepositry.DeleteAsync(Id);
            return new OkResult();

        }
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var clientObj = await this._clientrepositry.GetAsync(id);
            return new ObjectResult(clientObj);
        }
        public async Task<IActionResult> GetListAsync()
        {
            var clientList = await this._clientrepositry.GetListAsync();
            return new ObjectResult(clientList);
        }
        public async Task<IActionResult> UpdateAsync(ClientDTO client)
        {
            try
            {
                var clientObject = await this._clientrepositry.FindAsync(client.Id);
                if (clientObject != null)
                {
                    ObjectMapper.Map<ClientDTO, Client>(client, clientObject);
                    var clientReturnedObject = await this._clientrepositry.UpdateAsync(clientObject);

                    return new OkObjectResult(clientReturnedObject);
                }
                else
                {
                    return new BadRequestResult();
                }
            }
            catch (Exception ex)
            {
                return new BadRequestResult();
            }
        }
    }

}
