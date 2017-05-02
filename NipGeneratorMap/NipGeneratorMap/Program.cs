using Microsoft.Practices.Unity;
using NipGeneratorMap.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipGeneratorMap
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();

            container.RegisterType<Interfaces.IGeneratorMapy, GeneratorKonsolowyMapy>();
            container.RegisterType<Interfaces.IKonwerterWysokosciNaZnak, KonwerterWysokosciNaZnak>();
            container.RegisterType<Interfaces.IKonwerterZnakuNaWysokosc, KonwerterZnakuNaWysokoscAcme>();
            container.RegisterType<Interfaces.IDostarczycielWysokosci, PlikowyDostarczycielWysokosci>();
            container.RegisterType<Interfaces.IDostarczycielZnakowAsci, DostarczycielZnakow>();

            var generator = container.Resolve<Interfaces.IGeneratorMapy>();
            generator.GenerujMape(@"MapyAcme\Mapa2.txt");
            Console.ReadKey();
        }
    }
}
