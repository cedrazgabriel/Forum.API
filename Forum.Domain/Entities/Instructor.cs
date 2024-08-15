using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain.Entities
{
    public class Instructor(string name, string? id)
    {
        public string Id { get; set; } = id ?? Guid.NewGuid().ToString();
        public string Name { get; set; } = name;
    }
}
