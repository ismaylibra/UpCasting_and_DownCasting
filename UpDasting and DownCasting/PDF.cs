using System;
using System.Collections.Generic;
using System.Text;

namespace UpCasting_and_DownCasting
{
    class PDF : IPrintable
    {
        public void PrintFile()
        {
            Console.WriteLine("PDF cap edildi");
        }
    }
}
