using System;
using System.Collections.Generic;
using System.Text;

namespace UpCasting_and_DownCasting
{
    class Word : IPrintable
    {
        public void PrintFile()
        {
            Console.WriteLine("Word cap edildi");
        }
    }
}
