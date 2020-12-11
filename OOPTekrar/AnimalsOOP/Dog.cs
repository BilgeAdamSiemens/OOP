using System;
namespace OOPTekrar.AnimalsOOP
{
    public class Dog : Animal
    {
        public Dog()
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

        public void TimeToPuppy()
        {
            bool checkPuppyTime = true;

            if (checkPuppyTime)
            {
                var action = new Walkable();
                action.Walk();
            }
        }
    }
}
