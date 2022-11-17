using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonNode marcelo = new PersonNode("Marcelo", 48);
            PersonNode franco = new PersonNode("Franco", 29);
            PersonNode bruno = new PersonNode("Bruno", 23);
            PersonNode hijoFranco = new PersonNode("hijoFranco", 15);

            marcelo.AddChildren(franco);
            marcelo.AddChildren(bruno);
            franco.AddChildren(hijoFranco);

            AgeSumVisitor ageSumVisitor = new AgeSumVisitor();
            ageSumVisitor.Visit(marcelo);
            Console.WriteLine(ageSumVisitor.summary);

            OlderChildVisitor olderChildVisitor = new OlderChildVisitor();
            olderChildVisitor.Visit(marcelo);
            Console.WriteLine(olderChildVisitor.older.Name);

            LargestNameVisitor largestNameVisitor = new LargestNameVisitor();
            largestNameVisitor.Visit(marcelo);
            Console.WriteLine(largestNameVisitor.largest.Name);
        }
    }
}
