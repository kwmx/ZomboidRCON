using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomboidRCON.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Variant[]? Variants { get; set; }
        public bool isStock { get; set; }
    }
}
