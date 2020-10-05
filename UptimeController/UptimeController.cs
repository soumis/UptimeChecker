using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UptimeCheckerController
{
    public class UptimeController
    {
        public delegate void CallbackDelegate(string status);

        public void CheckUptime(CallbackDelegate reportUptime)
        {
            reportUptime("Initiazing...");
        }
    }
}
