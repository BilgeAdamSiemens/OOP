using System;
namespace OOPTekrar
{
    interface IMotorlu
    {

        //property set ve get olacak
        int Mesafe { get; set; }
        
        //interface'lerde constructor olmaz!!!
        //property ve metod bildirimi yapilabilir
        //access modifier (erisim bildirgeci) c# 8 den sonra geldi
        //access modifier yazmasak da default da public oluyor
        //public void HareketeGec();

        void HareketeGec(int adimSayisi);
    }
}
