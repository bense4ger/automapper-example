using System;
using automapper.example.domain.services;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MappingConfig.Configure();

                var fooId = Guid.NewGuid();
                var barId = Guid.NewGuid();
                var fooBarId = Guid.NewGuid();

                var service = new ApplicationService();

                var foo = service.GetFooById(fooId);
                var bar = service.GetBarById(barId);
                var fooBar = service.GetFooBarById(fooBarId);

                Console.WriteLine(foo);
                Console.WriteLine(bar);
                Console.WriteLine(fooBar);

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
