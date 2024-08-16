using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Core.Entities
{
    public class BaseEntity(string? id = null)
    {
        private string _id { get; set; } = id ?? Guid.NewGuid().ToString();
    } 
}
