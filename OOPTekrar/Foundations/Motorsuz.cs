using System;
namespace OOPTekrar
{
    class Motorsuz : Arac
    {
        new public string model = "";
        //base = Temel Sinif (Miras alinan) icerisindeki
        //yapici metodlarinin isleme girmesini saglayan anahtar kelimedir
        public Motorsuz() : base("merhaba")
        {
            this.model = "volvo xc 90";
            this.renk = "Mor";
            this.HareketEt();
            //Arac sinifindakileri temsil ediyor
            base.HareketEt();
            base.model = "Ferrari";
            
        }

        new public void HareketEt()
        {
            Console.WriteLine("Parametresiz HareketEt Metodu");
        }
    }
}
