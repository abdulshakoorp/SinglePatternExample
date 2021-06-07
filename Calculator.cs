using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_SingletonPatternExample1
{
    public class Calculator
    {
        private readonly Logger _logger;
        public Calculator()
        {
            _logger = Logger.GetLogger();
        }

        public void Divide(int a, int b)
        {
            try
            {
                var result = a / b;
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
            }
        }
    }
}
