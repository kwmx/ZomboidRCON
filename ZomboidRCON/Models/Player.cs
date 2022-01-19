using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomboidRCON.Models
{
    public enum AccessLevel
    {
        Admin,
        Moderator,
        Overseer,
        GM,
        Observer,
        None,
        Unknown
    }
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isOnline { get; set; }
        public AccessLevel accessLevel { get; set; }
    }
}
