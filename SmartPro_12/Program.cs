using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end;

            Console.Write("Start[Small]: ");
            start = int.Parse(Console.ReadLine());

            Console.Write("End[Big]: ");
            end = int.Parse(Console.ReadLine());

            Console.Clear();
            if (start > end) {
                Console.WriteLine("ErrCode.Fatal");
            }
            else {
                for (int i = start; i <= end; i++) {
                    Console.WriteLine("Sıra no: " + i);
                }
            }
            Console.ReadKey();
            Console.Clear();

            /******************************************************/

            Console.Write("Start[Big]: ");
            start = int.Parse(Console.ReadLine());

            Console.Write("End[Small]: ");
            end = int.Parse(Console.ReadLine());

            Console.Clear();
            if (start < end) {
                Console.WriteLine("ErrCode.Fatal");
            }
            else { 
                for (int i = start; i >= end; i--) {
                    Console.WriteLine("Sıra no: " + i);
                }
            }   
            Console.ReadKey();
        }
    }
}
