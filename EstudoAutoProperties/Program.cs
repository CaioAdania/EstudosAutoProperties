using EstudoAutoProperties.Entities;
using System.Globalization;

namespace EstudoAutoProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p);
           
        }
    }
}
