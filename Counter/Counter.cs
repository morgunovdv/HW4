using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Counter
    {
        public  delegate void Message();
        Message mes = Handler1.Mess;

        public void GetCount(int n)
        {
            for (int i = 1; i<n+1; i++)
            {
                Console.WriteLine(i);
                if (i == 77)
                {
                    mes += Handler2.Mess;
                    mes();
                    break;
                }
            }
        }
    }
}
