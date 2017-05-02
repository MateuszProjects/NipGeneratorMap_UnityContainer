using NipGeneratorMap.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipGeneratorMap.Classes
{
    public class KonwerterWysokosciNaZnak : Interfaces.IKonwerterWysokosciNaZnak
    {
        private IDostarczycielZnakowAsci _dostarczycielZnakow;

        public KonwerterWysokosciNaZnak(IDostarczycielZnakowAsci dostarczycielZnakow)
        {
            _dostarczycielZnakow = dostarczycielZnakow;
        }
        public string WysokoscNaZnak(int wartoscWysokosci)
        {
            if(_dostarczycielZnakow.ZnakWysokosci().GetLowerBound(0) <= wartoscWysokosci && _dostarczycielZnakow.ZnakWysokosci().GetUpperBound(0)>= wartoscWysokosci)
            {
                return _dostarczycielZnakow.ZnakWysokosci()[wartoscWysokosci];
            }

            return _dostarczycielZnakow.ZnakiNieokreslonejWysokosci();
        }
    }
}
