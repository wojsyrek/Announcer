using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncerCore.Models.Manager
{
    public class SystemModel
    {
        public Guid Id { get; set; }
        public string SystemName { get; set; }
        public string SystemType { get; set; }
        public string? Description { get; set; }
    }
}
