using System;
namespace OOPTekrar
{
    public class DbMigration
    {
        private readonly ErrorLogger _logger;

        public DbMigration(ErrorLogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            //Console.WriteLine(_logger._Message);
            _logger.Log();
        }
    }
}
