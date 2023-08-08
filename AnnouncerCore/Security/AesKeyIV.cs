using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncerCore.Security
{
    public class AesKeyIV
    {
        public byte[] Key { get; set; }
        public byte[] IV { get; set; }
    }
}
