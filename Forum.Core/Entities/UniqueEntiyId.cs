using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Core.Entities;
public class UniqueEntiyId (string? value = null)
{
    private string value { get; set; } = value ?? Guid.NewGuid().ToString();

    public string toString() => value;

    public string toValue() => value;

}
