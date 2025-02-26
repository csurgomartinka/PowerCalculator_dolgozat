using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatvanyozas
{
    public class PowerCalculator
    {
        public double CalCulatePower(int basee, int exponent)
        {
            double megoldas = 1;
            if (exponent >= 0)
            {
                for (int i = 0; i < exponent; i++)
                {
                    megoldas = megoldas * basee;
                }
            }
            else
            {
                megoldas = basee;
                for (int i = 0; i >= exponent; i--)
                {
                    megoldas = megoldas / basee;
                }
            }
            
            return megoldas;
        }
        static void Main(string[] args)
        {
            Console.Write("Add meg az első számot: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg a második számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            var Calculator = new PowerCalculator();
            Console.WriteLine($"Az eredmény: {Calculator.CalCulatePower(szam1,szam2)}");

            Console.ReadKey();
        }
    }
}
