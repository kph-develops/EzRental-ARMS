using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAMSDaLayer
{
    public class CountryDTO
    {
        public byte CountryID { get; set; }
        public String CountryCode2Char { get; set; }

        public String CountryCode3Char { get; set; }
        public String CountryName { get; set; }
    }
}
