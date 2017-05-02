using NipGeneratorMap.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipGeneratorMap.Classes
{
    class PlikowyDostarczycielWysokosci : IDostarczycielWysokosci
    {
        private IKonwerterZnakuNaWysokosc _konwerter;
        
        public PlikowyDostarczycielWysokosci(IKonwerterZnakuNaWysokosc konwerter)
        {
            _konwerter = konwerter;
        }
        public int[][] Wysokosci(string sciezkaPlikuWejsciowego)
        {
            using (var streamReader = new StreamReader(sciezkaPlikuWejsciowego))
            {
                var dlugoscMapy = int.Parse(streamReader.ReadLine());
                var wysokoscMapy = int.Parse(streamReader.ReadLine());

                int[][] wartoscWysokosci = new int[dlugoscMapy][];

                for(int i=0; i<dlugoscMapy; i++)
                {
                    wartoscWysokosci[i] = new int[wysokoscMapy];
                }

                for(int i=0; i<wartoscWysokosci.Length; i++)
                {
                    for(int j=0; j<wartoscWysokosci[i].Length; j++)
                    {
                        wartoscWysokosci[i][j] = _konwerter.ZnakNaWysokosc((char)streamReader.Read());
                    }

                    streamReader.ReadLine();
                }
                return wartoscWysokosci;
            }

             
        }
    }
}
