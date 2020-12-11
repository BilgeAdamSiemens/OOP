using System;
namespace OOPTekrar
{
    //default da internal olarak gelir
    partial class Arac
    {
        //field
        /* Access Modifier => Erisim Belirleyici
         * public = Her yerden erisebilirim (Kalitim ve object olusturarak)
         * private = Sadece tanimlandigi sinifi icerisinde kullanilir
         * protected = tanimlandigi sinif ve miras alan tarafindan ulasilebilir
         * internal = Sadece bulundugu projede erisilebilir ve kalitim ile aktarilir 
         */
        public string renk;
        protected string model;
        public int maxHiz;
        internal int lastikSayisi;
        //property
        public int koltuk { get; set; }

        
    }
}
