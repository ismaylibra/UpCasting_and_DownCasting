using System;
using System.Collections.Generic;
using System.Text;

namespace UpCasting_and_DownCasting
{
    class Excel : IPrintable
    {
        public void PrintFile()
        {
            Console.WriteLine("Excel cap edildi");
        }
    }
}
