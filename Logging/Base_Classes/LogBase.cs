using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Base_Classes
{
    public class LogBase
    {
        protected static List<string> ScreenLog = new List<string>();

        protected static void AddToScreenLog<T>(T toAdd)
        {
            ScreenLog.Add(toAdd.ToString());
        }
    }
}
