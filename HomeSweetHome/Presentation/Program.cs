using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeSweetHome
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FamilyConditions> families = new List<FamilyConditions>();

            Console.WriteLine("Cadastre sua família: ");
            Console.WriteLine("");

            for (int i = 0; i < 2; i++) //substituir pela quantidade n de famílias
            {
                FamilyConditions family = new FamilyConditions();
                
                families.Add(family.CreateFamily());
            }

            families = families.OrderByDescending(e => e.Score).ToList();
            Console.WriteLine("Classificação das famílias: ");
            Console.WriteLine("");
            foreach (var item in families)
            {              
                item.ListFamilyInformations();
            }

            Console.ReadKey();
        }
    }
}
