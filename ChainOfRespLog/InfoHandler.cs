﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    class InfoHandler : LogHandlerBase
    {
        public override void log(string message, LOG_LEVEL log_level)
        {
            if (log_level == LOG_LEVEL.INFO)
            {
                Console.WriteLine("Info : {0}", message);
            }
            if (next != null)
            {
                next.log(message, log_level);
            }
        }
    }
}
