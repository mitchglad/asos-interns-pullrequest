using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var service = new Service();

            var place = service.GetServiceString();
            
            Console.WriteLine("hello, " + place);
        }
    }
}
