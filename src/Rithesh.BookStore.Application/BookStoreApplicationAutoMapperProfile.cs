using AutoMapper;
using Rithesh.BookStore.DTOs;
using Rithesh.BookStore.Models;

namespace Rithesh.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<ClientDTO, Client>().ReverseMap();
    }
}
