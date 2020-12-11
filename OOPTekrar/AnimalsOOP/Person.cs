﻿using System;
namespace OOPTekrar.AnimalsOOP
{
    public class Person : Animal
    {
        public Person()
        {
            base.Age = 20;
        }

        public void IsDinnerTime()
        {
            bool checkDinnerTime = true;

            if(checkDinnerTime)
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

        public void TimeToWalk()
        {
            bool checkWalkTime = true;

            if(checkWalkTime)
            {
                var action = new Walkable();
                action.Walk();
            }
        }
    }
}
