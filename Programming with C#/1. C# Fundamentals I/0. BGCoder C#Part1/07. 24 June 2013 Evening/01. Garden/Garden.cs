using System;

class Garden

{
    static void Main()
    {
        const double tomatPrice = 0.5;
        const double cucumberPrice = 0.4;
        const double potatoPrice = 0.25;
        const double carrotPrice = 0.6;
        const double cabbagePrice = 0.3;
        const double beansPrice = 0.4;
        const double totalArea = 250;


        double tomatoSeed = double.Parse(Console.ReadLine());
        double tomatoArea = double.Parse(Console.ReadLine());
        double cucumberSeed = double.Parse(Console.ReadLine());
        double cucumberArea = double.Parse(Console.ReadLine());
        double potatoSeed = double.Parse(Console.ReadLine());
        double potatoArea = double.Parse(Console.ReadLine());
        double carrotSeed = double.Parse(Console.ReadLine());
        double carrotArea = double.Parse(Console.ReadLine());
        double cabbageSeed = double.Parse(Console.ReadLine());
        double cabbageArea = double.Parse(Console.ReadLine());
        double beansSeed = double.Parse(Console.ReadLine());

        //Console.WriteLine(tomatoSeed + "-" + tomatoArea);
        //Console.WriteLine(cucumberSeed + "-" + cucumberArea);
        //Console.WriteLine(potatoSeed + "-" + potatoArea);

        double tomatoCost = tomatoSeed * tomatPrice;
        double cucmberCost = cucumberSeed * cucumberPrice;
        double potatoCost = potatoSeed * potatoPrice;
        double carrotCost = carrotSeed * carrotPrice;
        double cabbageCost = cabbageSeed * cabbagePrice;
        double beansCost = beansSeed * beansPrice;

        double totalCost = tomatoCost + cucmberCost + potatoCost + carrotCost + cabbageCost + beansCost;
        Console.WriteLine("Total costs:{0: 0.00}", totalCost);

        double currentArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;

        if (currentArea > totalArea)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (currentArea == totalArea)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Beans area:{0: 0}", totalArea- currentArea);
        }
    }
}