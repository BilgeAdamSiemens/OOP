using System;
namespace OopDemo2
{
    public class Products : ProductSpecifications
    {
        public Products(){}

        public string name;
        public int price;
        public int stockAmount;
        //kategoryi arrayList olarak tanimlayin
        public string[] category;
        public string description;
        public string[] comments;
        public string[] features;
    }
}
