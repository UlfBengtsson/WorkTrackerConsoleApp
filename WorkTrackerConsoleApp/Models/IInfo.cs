using System;
using System.Collections.Generic;
using System.Text;

namespace WorkTrackerConsoleApp.Models
{
    interface IInfo
    {
        const string INFOSTART = "----- info -----";
        string Info();

    }
}
