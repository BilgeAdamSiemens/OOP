using System;
namespace OOPTekrar
{
    //bir class birden fazla interface alabilir
    //fakat bir class birden fazla class'dan miras alamaz
    public class Motorlu : IMotorlu, IArac
    {

        //default da bu degiskenin access modifier'i private'dir
        public string aracAdi;
        
        private string aracModeli;

        public int Mesafe
        {
            // get ya da set kismini fonksiyon seklinde tanimlayip
            // islem sonrasinda geri donderebiliriz
            get;
            set;
        }

        public Motorlu()
        {
            Arac arc = new Arac(100, 10);
            arc.renk = "Kirmizi";
            arc.lastikSayisi = 5;

            this.HareketEt(50);
            this.Hizlandir();

            // runtime'a gecene kadar dynamic tipinin ne oldugunu bilmez
            //dynamic a = "string"; // late
            // compile time de ne oldugu bellidir. Performasa bir etkisi yoktur
            var b = "string";
            string c = "string"; //early

            //Console.WriteLine(a + " " + b + " " + c);

        }

        public void HareketEt(int a)
        {
            Console.WriteLine("Motorlu Class icindeki HareketEt Metodu");
        }

        public void HareketEt(int a, string b)
        {
            Console.WriteLine("Motorlu Class icindeki HareketEt Metodu");
        }

        public void Hizlandir()
        {
            Arac arc = new Arac(100, 10);
        }

        public void HareketeGec()
        {

        }

        public void HareketeGec(int adimSayisi)
        {

        }
    }
}
