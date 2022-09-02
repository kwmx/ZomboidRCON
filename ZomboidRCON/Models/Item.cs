using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomboidRCON.Models
{
    public enum ItemType
    {
        Ammo,
        Baggage,
        Throwables,
        Camping,
        Consumables,
        Drinks,
        Engineering,
        Farming,
        Firearms,
        Food,
        Fruit,
        Illumination,
        Literature,
        Medical,
        Melee,
        Seeds,
        Stationery,
        Tools,
        Trapping,
        Unique,
        Unused,
        Vegetables,
        WeaponParts,
        Other
    }
    public class Item
    {
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public Variant[]? Variants { get; set; }
        public bool isStock { get; set; }
        public Uri? Wiki { get; set; }
    }
}
