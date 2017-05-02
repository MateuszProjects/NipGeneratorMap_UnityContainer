using NipGeneratorMap.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipGeneratorMap.Classes
{
    public class GeneratorKonsolowyMapy : Interfaces.IGeneratorMapy
    {
        private IKonwerterWysokosciNaZnak _konwerter;
        private IDostarczycielWysokosci _dostarczyciel;

        public GeneratorKonsolowyMapy(IKonwerterWysokosciNaZnak konwerter, IDostarczycielWysokosci dostarczyciel)
        {
            _konwerter = konwerter;
            _dostarczyciel = dostarczyciel;
        }

        public void GenerujMape(string sciezkaPlikuWejsciowego)
        {
            throw new NotImplementedException();
        }
    }
}
