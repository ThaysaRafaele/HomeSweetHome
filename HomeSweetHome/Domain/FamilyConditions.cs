using HomeSweetHome.Enumerators;
using System;

namespace HomeSweetHome
{
    public class FamilyConditions : Family
    {
        public FamilyConditions() : base()
        {
            this.Dependents = 0;
            this.Score = 0;
        }

        public FamilyConditions(string name, double income, int dependents, int score)
            : base(name, income)
        {
            this.Dependents = dependents;
            this.Score = score;
        }

        public int Dependents { get; set; }
        public int Score { get; set; }

        public FamilyConditions CreateFamily()
        {
            Console.WriteLine("Nome Do Representante da família:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Renda da família:");
            this.Income = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantidade de dependentes:");
            this.Dependents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            this.Score = this.GetScore(this.Income, this.Dependents);
            
            return this;
        }

        public void ListFamilyInformations()
        {
            Console.WriteLine("Nome Do Representante da família: " + this.Name);
            Console.WriteLine("Renda da família: " + this.Income);
            Console.WriteLine("Quantidade de dependentes: " + this.Dependents);
            Console.WriteLine("Pontuação: " + this.Score);
            Console.WriteLine("");
        }

        public int GetScore(double income, int dependents)
        {
            int score = 0;
            if (income < 901)
                score += Convert.ToInt32(EnumIncomeType.P0);
            if (income >= 901 && Income <= 1500.00)
                score += Convert.ToInt32(EnumIncomeType.P1);
            if (dependents >= 3)
                score += Convert.ToInt32(EnumDependents.D3);
            if (dependents >= 1 && Dependents < 3)
                score += Convert.ToInt32(EnumDependents.D1D2);

            return score;
        }
    }
}
