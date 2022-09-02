using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomboidRCON.ItemsPack
{
    public class ItemsPackage
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public UpdateSystem.Version Version { get; set; }
        public List<Models.Item> Items { get; set; }
        public List<Models.Vehicle> Vehicles { get; set; }

    }
}
