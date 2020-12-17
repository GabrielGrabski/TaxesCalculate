using System;
using System.Collections.Generic;
using TaxCalculation.Entities;

namespace TaxCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");

                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: U$");
                double anualIncome = double.Parse(Console.ReadLine());

                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                } 
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer tp in list)
            {
                double tax = tp.CalculateTaxes();
                Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2"));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2"));
        }
    }
}
