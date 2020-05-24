using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    // Note: We cannot create a instance of the abstract class.
    // One way : call the print method by creating the instance of the derived class.
    // An abstract method, can not be declared as private or protected.
    // an abstract method must be 'public'. or internal.

    // When overriding a abstract method in the derived class, --
    // -- the 'Access  Specifyer' of the overrided method should --
    // -- always be same.
    
    public abstract class Customer
    {
       internal abstract void Print();
    }

    public class Program2 : Customer
    {
        internal override void Print()
        {
            Console.WriteLine("Lets Print Something : Learn how to use abstarct class.");
        }

        public static void Main(string[] args)
        {
           
            Program2 Pr = new Program2();
            Pr.Print();

            // Second Way : Through the parent class reference variable, --
            // -- we can create the instance of the derived class, and call the method.
            Customer Cr = new Program2();
            Cr.Print();
            

            Console.ReadKey();
        }
    }
}
