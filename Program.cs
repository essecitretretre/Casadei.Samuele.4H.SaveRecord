using System;

namespace Casadei.Samuele._4H.SaveRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SaveRecord - 2021 - samuele.casadei@ittsrimini.edu.it");

            //Leggere un file csv con i comuni s trasformarlo in una list<comune>
            Comuni c = new Comuni("Comuni.csv");
            Console.WriteLine($"Ho letto{c.count}");
            
            //Scrivere la List<Comune> in un file binario
            //Rileggere il file binario in una List<Comune>
        }
    }
}
