using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Garden
{
    class Garden
    {
        static void Main()
        {
            //StreamReader reader = new StreamReader("..\\..\\input.txt");
            //Console.SetIn(reader);

            const double tomatoPrice = 0.5;
            const double carrotPrice = 0.6;
            const double cucumberPrice = 0.4;
            const double cabbagePrice = 0.3;
            const double potatoPrice = 0.25;
            const double beansPrice = 0.4;
            const int totalArea = 250;

            double tomaSeed = double.Parse(Console.ReadLine());
            int tomaArea = int.Parse(Console.ReadLine());
            double cucamberSeed = double.Parse(Console.ReadLine());
            int cucamberArea = int.Parse(Console.ReadLine());
            double potatoSeed = double.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            double carrotSeed = double.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());            
            double cabbageSeed = double.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());            
            double beansSeed = double.Parse(Console.ReadLine());

            double totalCost = tomaSeed * tomatoPrice + carrotSeed * carrotPrice + cucamberSeed * cucumberPrice +
                                cabbageSeed * cabbagePrice + potatoSeed * potatoPrice + beansSeed * beansPrice;


            int beansArea = totalArea - tomaArea - cucamberArea - potatoArea - carrotArea - cabbageArea;

            // print
            if (beansArea < 0)
            {
                Console.WriteLine("Total costs: {0:F2}", totalCost);
                Console.WriteLine("Insufficient area");
            }
            else if (beansArea == 0)
            {
                Console.WriteLine("Total costs: {0:F2}", totalCost);
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Total costs: {0:F2}", totalCost);
                Console.WriteLine("Beans area: {0}", beansArea);
            }
            
        }
    }
}
