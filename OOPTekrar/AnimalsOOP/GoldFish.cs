using System;
namespace OOPTekrar.AnimalsOOP
{
    public class GoldFish : Animal
    {
        public GoldFish()
        {
        }

        public void IsDinnerTime()
        {
            bool checkDinnerTime = true;

            if (checkDinnerTime)
            {
                Eat();
            }
        }

        public void IsSleepTime()
        {
            bool checkSleepTime = true;

            if (checkSleepTime)
            {
                Sleep();
            }
        }
    }
}
