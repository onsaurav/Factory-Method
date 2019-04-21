using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creator = new Creator[2];
            creator[0] = new ConcreateCreatorA();
            creator[1] = new ConcreateCreatorB();

            foreach (Creator cr in creator)
            {
                Product product = cr.FactoryMethod();
                Console.WriteLine("Created {0}",product.GetType().Name);
            }

            Console.ReadKey();
        }
    }
}
