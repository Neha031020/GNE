using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOClass
{
    public class CounterPartyDTO
    {
        public int CounterPartyId { get; set; }

        public string PartyName { get; set; } = null!;
    }
}
