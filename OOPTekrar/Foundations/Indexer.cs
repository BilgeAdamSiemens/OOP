using System;
namespace OOPTekrar
{
    //params indexer
    public class Indexer
    {
        public string Name { set; get; }
        //property => field ve metodlari birlestirir
        //property'lerde out ve ref kullanilmiyor

        public string Address { set; get; }

        //[] parantezlerin degiskenin onunde kullanilmasi
        //sadece indexer oldugunu tayin eder.
        public int []Age { set; get; }

        public string []val = new string[3];

        public string this[int index]
        {
            get
            {
                return val[index];
            }

            set
            {
                val[index] = value;
            }
        }

        //field => class ya da struct icinde tanimlana bilen degisken
        public string Surname;

        //params istedigim kadar belirlenen tipte degisken girebiliyorum
        public Indexer(params int[] sayilar)
        {
        }

        public Indexer(string name)
        {
        }

        public Indexer(string name,int age)
        {
        }
    }
}
