using Logging.Base_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Loggers
{
    public class ScreenLogger : LogBase
    {
        public static void PrintLogToScreen()
        {
            foreach(var entry in ScreenLog)
            {
                //TODO : Print Log to Screen
            }
        }
    }
}
