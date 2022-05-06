﻿using System;

namespace UpCasting_and_DownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintable word = new Word();
            IPrintable pdf = new PDF();
            IPrintable excel = new Excel();
            MainPrintFile word1 = new MainPrintFile(word);
            MainPrintFile pdf1 = new MainPrintFile(pdf);
            MainPrintFile excel1 = new MainPrintFile(excel);
        }   
    }
}

