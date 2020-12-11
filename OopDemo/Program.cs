using System;

namespace OopDemo
{

    interface IInsan
    {
        void Konus(string metin);
        void Yuru();
        void SetAdSoyad(string adSoyad);
        void SetYas(int yas);
        void SetCinsiyet(char cinsiyet);
        void SetAdres(string adres);
    }

    interface IOgrenci : IInsan
    {
        void SetOgrenciNo();
    }

    interface IOgretmen : IInsan
    {
        void SetBrans();
    }

    class Insan : IInsan
    {
        public Insan(int yas, string adSoyad)
        {
            Console.WriteLine("Ogrenci Yasi : {0}", yas); 
        }

        public int yas;
        public string adSoyad;
        public char cinsiyet;
        public string adres;

        public void Konus(string metin)
        {
            Console.WriteLine(metin);
        }

        public void Yuru(){}

        public void SetAdSoyad(string adSoyad)
        {
            this.adSoyad = adSoyad;
        }

        public void SetYas(int yas)
        {
            this.yas = yas;
        }

        public void SetCinsiyet(char cinsiyet)
        {
            this.cinsiyet = cinsiyet;
        }

        public void SetAdres(string adres)
        {
            this.adres = adres;
        }
    }

    class Ogrenci : Insan
    {
        public readonly string Okul;
        public DateTime DogumTarihi;

        public Ogrenci(int yas, string adSoyad) : base(yas,adSoyad)
        {
            this.adSoyad = "Alihan Bayraktar";
        }

        public void GetAdSoyad()
        {
            Console.WriteLine(this.adSoyad);
        }

        public void GetYas()
        {
            Console.WriteLine(this.yas);
        }

        public void GetCinsiyet()
        {
            Console.WriteLine(this.cinsiyet);
        }

        public void GetAdres()
        {
            Console.WriteLine(this.adres);
        }

        public void SetDogumTarihi(DateTime dogumTarihi)
        {
            this.DogumTarihi = dogumTarihi;
        }

        public void GetDogumTarihi()
        {
            Console.WriteLine(this.DogumTarihi);
        }
    }

    //class Ogretmen : Insan, IOgretmen
    //{

    //}

    //class Sinif : Ogrenci
    //{

    //    public void SinifAc()
    //    {

    //    }

    //    public void OgrenciAta()
    //    {

    //    }

    //    public void OgretmenAta()
    //    {

    //    }
    //}

    class MainClass
    {
        static void Main(string[] args)
        {
            var ogrenci = new Ogrenci(18, "Omur UCUM");
            //var sinif = new Sinif();
            //sinif.adSoyad = "Omur UCUM";
            //sinif.cinsiyet = 'E';
            //sinif.DogumTarihi = new DateTime(1983,3,15);
            //sinif.adres = "Unalan Mah Unalan cad Bogazici Sitesi Uskudar";
            //sinif.SetAdSoyad(sinif.adSoyad);
            //sinif.GetAdSoyad();   
        }
    }
}
