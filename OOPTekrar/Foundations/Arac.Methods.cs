using System;
namespace OOPTekrar
{
    public partial class Arac
    {
        //method degiskenlerin isleme girdigi tipler
        protected void HareketEt()
        {
            Console.WriteLine("Parametresiz HareketEt Metodu");
        }

        //accessModifier returnType methodName(paramTipi paramAdi,...) { }
        //yapici method = constructor
        public Arac()
        {
            Console.WriteLine("Base olmadan calisti");
        }

        public Arac(string c)
        {
            Console.WriteLine("Tek parametreli Arac yapici metodu {0}", c);
        }

        public Arac(int a, int b)
        {
            Console.WriteLine("Cift parametreli Arac yapici metodu");
        }
    }
}
