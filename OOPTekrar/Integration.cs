using System;
namespace OOPTekrar
{
    public class Integration
    {
        private readonly ErrorLogger _logger;

        public Integration(ErrorLogger logger)
        {
            _logger = logger;
        }

        public void Integrate()
        {
            _logger.Log();
        }
    }
}
