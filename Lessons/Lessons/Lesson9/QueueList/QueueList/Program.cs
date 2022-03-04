using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> melumat = new Queue<string>();
            melumat.Enqueue("ravi");
            melumat.Enqueue("nurlan");
            melumat.Enqueue("qurbani");
            melumat.Enqueue("fezail");
            melumat.Enqueue("huseyn");
            melumat.Enqueue("araz");
            melumat.Enqueue("aydan");
            melumat.Enqueue("yusif");
            melumat.Enqueue("aysel");
            melumat.Enqueue("sebuss");
            melumat.Enqueue("vesi");
            melumat.Enqueue("elmar");
            melumat.Enqueue("rehman");

            melumat.Reverse<string>();

            if (melumat.Count > 10)
            {

                int say = melumat.Count - 9;

                for (int j = 0; j < say; j++)
                {

                    melumat.Dequeue();

                }

                melumat.Enqueue("Minaa Xanimm");


            }



            foreach (var item in melumat)
            {

                Console.WriteLine(item);
            }



        }
    }
}
