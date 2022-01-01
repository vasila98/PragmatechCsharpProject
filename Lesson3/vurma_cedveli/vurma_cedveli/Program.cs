using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vurma_cedveli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin: ");
            int eded=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hesablama");
            Cedvel(eded);

        }
        public static int Cedvel(int eded)
        {
            for (int i=1; i<11; i++)
            {
              
             Console.WriteLine(eded*i);
                
            }
            return 1;
            
            
            
            
           

           
      
        }
    }
}
