using System;
namespace OOPTekrar
{
    public class ErrorLogger
    {
        public string _Message { get; set; }

        public void Log()
        {
            Console.WriteLine(_Message);
        }

        protected void WriteMessage()
        {
            Console.WriteLine("ErrorLogger icindeki WriteMessage");
        }
    }
}
