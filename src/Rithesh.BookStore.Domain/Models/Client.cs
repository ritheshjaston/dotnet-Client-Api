using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Rithesh.BookStore.Models
{
    public class Client:AggregateRoot<Guid>
    {

        public string? Firstname { get; set; }

        public string? Lastname { get; set;}

        public string? Address { get; set; }
    }
}
