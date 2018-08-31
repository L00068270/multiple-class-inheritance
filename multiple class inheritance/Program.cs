using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_class_inheritance
{
    class Program
    {
        public static void Main()
        {
            Customer4 c4 = new Customer4();
            c4.Print();
            Console.WriteLine("Please press ENTER to terminate program");
            Console.Read();
        }
    }

    /********************************************************************************
     * class Customer1 has a virtual Print() method - this is super base class
     * class Customer2 & class Customer3 derive from class Customer1
     ********************************************************************************/

    class Customer1
    {
        public virtual void Print()
        {
            Console.WriteLine("Customer Print Implementation");
        }
    }
    /*class Customer2 overrides the Print() method it inherited from class Customer1*/
    class Customer2 : Customer1
    {
        public override void Print()
        {
            Console.WriteLine("Customer 2 Print Implementation");
        }
    }
    /*class Customer3 overrides the Print() method it inherited from class Customer1*/
    class Customer3 : Customer1
    {
        public override void Print()
        {
            Console.WriteLine("Customer 3 Print Implementation");
        }
    }
    /*class Customer4 is inheriting from both class Customer2 and class Customer3*/
    class Customer4 : Customer2
    {

    }
}
