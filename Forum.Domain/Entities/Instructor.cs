using Forum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain.Entities
{
    public class Instructor(string name) : BaseEntity
    {
        public string Name { get; set; } = name;
    }
}
