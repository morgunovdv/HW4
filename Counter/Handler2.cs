﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Handler2
    {
        public delegate void Message();

        Message mes = Mess;

        

        public static void Mess()
        {
            Console.WriteLine("Уже 77, давно пора было начать!");
        }
    }
}
