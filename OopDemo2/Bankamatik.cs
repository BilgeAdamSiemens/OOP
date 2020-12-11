using System;
using System.Collections.Generic;
namespace OopDemo2
{
    public class Bankamatik
    {
        public Bankamatik(){}

        public void GetMoney()
        {
            Console.WriteLine("Cekmek istediginiz para miktarini girin");
            double money = double.Parse(Console.ReadLine());


        }

        //1000
        public static Dictionary<int, int> ReturnMoneys(int money)
        {



            Dictionary<int, int> response = new Dictionary<int, int>();


            //FIFO
            Queue<int> divides = new Queue<int>();
            divides.Enqueue(200);
            divides.Enqueue(100);
            divides.Enqueue(50);
            divides.Enqueue(20);
            divides.Enqueue(10);
            divides.Enqueue(5);
            
            while (divides.Count > 0)
            {
                int divide = divides.Dequeue();
                int howMany = money / divide;

                response.Add(divide, howMany);

                money %= divide;
            }

            return response;

        }
    }
}
