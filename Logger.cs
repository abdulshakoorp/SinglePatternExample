﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_SingletonPatternExample1
{
    sealed class Logger
    {
        private static readonly Logger _logger = new Logger();
        public static Logger GetLogger()
        {
            return _logger;
        }

        public void Log(string message)
        {
            Console.WriteLine("An Exception Occured : " + message);
        }
    }
}
