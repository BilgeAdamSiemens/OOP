using System;
namespace OopDemo2
{
    public class Vendor : Users 
    {
        public Vendor(){}

        public string shopName;

        public int score(int param)
        {
            // Select sum(point) from vendorPoint where id = vendorId;
            int score = 10;
            return score;
        }

        public void Main(string[] args)
        {
            var response = this.score(5);
        }

    }
}
