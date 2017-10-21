using CommonValidations;
using System;

namespace ConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = Validations.BePhoneNumber("+4258235783");
            Console.WriteLine(result);
        }
    }
}
