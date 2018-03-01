using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = ReadFile("C:/Users/guill/Desktop/Hash2018/a_example.in");
           
            /*
            foreach(int[] a in input)
            {
                foreach(int b in a)
                {
                    Console.Write(b + " ");
                }
                Console.Write('\n');
            }
            Console.ReadKey();*/
        }
        private static int[][] ReadFile(string path)
        {

            //list of lines, blank lines are removed 
            string[] lines = File.ReadAllLines(path).Where(arg =>
                                !string.IsNullOrWhiteSpace(arg)).ToArray();

            // Split every lines and Trim  
            return lines.Select(x => x.Split(' ').Select(y => Convert.ToInt32(y.Trim())).ToArray()).ToArray();
        }
    }
}
