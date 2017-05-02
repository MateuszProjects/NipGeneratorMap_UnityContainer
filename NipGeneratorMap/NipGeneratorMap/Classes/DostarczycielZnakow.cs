using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipGeneratorMap.Classes
{
    class DostarczycielZnakow : Interfaces.IDostarczycielZnakowAsci
    {
        static readonly string[] _znakiWysokosci = { " ", "`", ".", ":", "/", "+", "o", "s", "y", "d", "m", "N", "M" };
        static readonly string _znakiNieokreslonejWysokosci = "█";

        public string ZnakiNieokreslonejWysokosci()
        {
            return _znakiNieokreslonejWysokosci;
        }

        public string[] ZnakWysokosci()
        {
            return _znakiWysokosci;
        }
    }
}
