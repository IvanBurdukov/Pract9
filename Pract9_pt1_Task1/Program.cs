using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pract9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double l = Convert.ToDouble(Console.ReadLine());
                double r = 1 / (2 * Math.PI);
                Console.WriteLine(r);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}