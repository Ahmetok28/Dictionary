using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> sehiler= new MyDictionary<string>();
            sehiler.Add("Giresun"); 
            sehiler.Add("Bursa"); 
            sehiler.Add("İstanbul"); 
            sehiler.Add("Ankara");
            
            sehiler.Add("Sakarya");
            Console.WriteLine(sehiler.Length);
            Console.WriteLine();

            foreach (var item in sehiler.Items)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
