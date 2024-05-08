using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Rithesh.BookStore.DTOs
{
    public class ClientDTO:EntityDto<Guid>
    {
        public string? Firstname { get; set; }

        public string? Lastname { get; set; }

        public string? Address { get; set; }
    }
}
