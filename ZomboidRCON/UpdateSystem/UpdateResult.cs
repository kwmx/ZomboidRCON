using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomboidRCON.UpdateSystem
{
    public enum UpdateStatus
    {
        Current,
        UpdateNeeded,
        Error
    }
    public class UpdateResult
    {
        public UpdateStatus UpdateStatus { get; set; }
        public GithubApi.Release? Release { get; set; }
        public string? Message { get; set; }
        
    }
}
