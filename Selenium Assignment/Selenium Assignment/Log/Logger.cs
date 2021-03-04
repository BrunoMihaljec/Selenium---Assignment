using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace Selenium_Assignment.Log
{
    public static class Logger
    {
        public static void XmlRun()
        {
            XmlConfigurator.Configure();
        }
        public static ILog logger = LogManager.GetLogger(typeof(Program)); 
    }

}
