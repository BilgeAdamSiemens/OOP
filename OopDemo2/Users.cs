using System;
namespace OopDemo2
{
    public class Users
    {
        public Users(){}
        
        public int type;
        public string nameSurname;
        public DateTime registerDate;
        public string userName;
        public string passWord;
        public string address;

        public int score(int givePoint)
        {
            int score = 5 * givePoint;
            return score;
        }
    }
}
