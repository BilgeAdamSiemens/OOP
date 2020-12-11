using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Threading;
namespace OOPTekrar
{

    /*
        Inheritance
        Is-A
        Araba bir Moturlu bir Aractir
        Car IS A Vehicle
    */

    /*
        Composition
        Has-a iliskisi
        Arabanin Motoru vardir
        Car HAS A Engine
    */

    public class Start
    {
        public DateTime startTime {get; set;}

        public Start()
        {
            startTime = DateTime.Now;
        }
    }

    public class Stop
    {
        public DateTime stopTime { get; set; }

        public Stop()
        {
            stopTime = DateTime.Now;
        }
    }

    public class MainClassTests
    {
        static void Main(string[] args) 
        {
            //Composition
            DbMigration dbMigration = new DbMigration(new ErrorLogger());
            
            dbMigration.Migrate();
            
            var logger = new ErrorLogger();
            logger._Message = "Integration icindeki arkadas calisti";
            var integration = new Integration(logger);

            dbMigration.Migrate();
            integration.Integrate();
            /*
                Start str = new Start();
                Console.WriteLine(str.startTime);
                Thread.Sleep(2000);
                Stop stp = new Stop();
                Console.WriteLine(stp.stopTime);
                var diffTotalMS = stp.stopTime.Subtract(str.startTime).TotalMilliseconds;
                var diffMS = stp.stopTime.Subtract(str.startTime).Milliseconds;
                Console.WriteLine("Dif total milliS : {0} DMS : {1}", diffTotalMS,diffMS);
            */

            Indexer index = new Indexer(1, '2');
            index.val[1] = "asd";
            index.val[2] = "merhaba";
            index.val[3] = "alihan";
            index.val[4] = "serdar";

            index[1] = "zeki";
            index[2] = "mina";
            index[3] = "serhat";
            index[4] = "omur";
            index[5] = "serdar";

 

            //Indexer index = new Indexer(1,'2');
            //index.Name = "Alihan";
            //index.Age[0] =  5;
            //index.Age[1] = 10;
            //Console.WriteLine(index.Age[1]);

            ////out && ref
            //index.Surname = "UCUM";
            //Console.WriteLine(index.Surname);

            //index.Address = "Istanbul";
            //Console.WriteLine(index.Address);

            //var person = new Person(1);

            //var person2 = new Person
            //{
            //    Name = "Serdar",
            //    Age = 20
            //};

        }

    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(int id) { }
        public Person(int id, string firstName) { }
        public Person(int id, string firstName, string lastName) { }
        public Person(int id, DateTime birthDate) { }
    }
}
