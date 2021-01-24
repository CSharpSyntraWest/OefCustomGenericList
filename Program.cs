using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Oefening_CustomGenericList
{


    using System;
    using Generic;

    class Program
    {
        static void Main()
        {
            GenericList<int> elements = new GenericList<int>();

            // Lege lijst
            Console.WriteLine(elements);
            Console.WriteLine("Aantal: {0}", elements.Count);
            Console.WriteLine("Capaciteit: {0}", elements.Capacity);

            // Auto-grow functionaliteit
            elements = new GenericList<int>(3);
            elements.Add(1);
            elements.Add(2);
            elements.Add(3);
            elements.Add(4);

            Console.WriteLine("\n" + elements);
            Console.WriteLine("Aantal: {0}", elements.Count);
            Console.WriteLine("Capaciteit: {0}", elements.Capacity);

            // Insert, RemoveAt
            elements.Clear();

            elements.Insert(0, 4);
            elements.Insert(0, 3);
            elements.Insert(0, 2);
            elements.Insert(0, 1);

            elements.RemoveAt(0);
            elements.RemoveAt(elements.Count - 1);

            Console.WriteLine("\n" + elements);
            Console.WriteLine("Aantal: {0}", elements.Count);
            Console.WriteLine("Capaciteit: {0}", elements.Capacity);

            // Contains, IndexOf
            Console.WriteLine("\nBevat element 2: {0}", elements.Contains(2));
            Console.WriteLine("Index van element 3: {0}", elements.IndexOf(3));

            // Max, Min
            Console.WriteLine("\nMin: {0}", elements.Min());
            Console.WriteLine("Max: {0}", elements.Max());

            Console.ReadKey();
        }
    }
}
