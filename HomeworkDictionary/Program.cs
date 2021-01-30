using System;
using System.Collections.Generic;

namespace HomeworkDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(312,"Ankara") ;
            dictionary.Add(212, "İstanbul Avr");
            dictionary.Add(216, "İstanbul And");
            dictionary.Add(232, "İzmir");
            dictionary.Add(374, "Bolu");
            dictionary.Add(222, "Eskişehir");
            dictionary.Add(378, "Bartın");

            Console.WriteLine("Count : " + dictionary.Count);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                
            }
        }

    }
}
