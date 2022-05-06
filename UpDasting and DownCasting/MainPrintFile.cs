using System;
using System.Collections.Generic;
using System.Text;

namespace UpCasting_and_DownCasting
{
    class MainPrintFile
    {
        public MainPrintFile(IPrintable print)
        {
            print.PrintFile();
        }
    }
}
