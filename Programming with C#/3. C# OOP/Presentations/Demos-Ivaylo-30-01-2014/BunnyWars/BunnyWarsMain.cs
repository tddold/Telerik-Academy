namespace BunnyWars
{
    using Animals;
    using Bunnies;
    using System;
    using System.Collections.Generic;

    class BunnyWarsMain
    {
        static void ChangeBunny(Bunny bunny)
        {
            bunny.Health = 0;
        }

        static void Main()
        {
            Bunny vankataBunny = new Bunny("Vankata");
            ulong currentVankataCarrots = vankataBunny.AddCarrots(100);

            Bunny peshoBunny = new Bunny("Peshoooo", ColorType.Blue);
            ulong currentPeshoCarrots = peshoBunny.AddCarrots(2000);

            string vankataName = vankataBunny.Name;

            vankataBunny.Color = ColorType.Red;
            ColorType color = vankataBunny.Color;

            vankataBunny.Retire();

            vankataBunny.Health -= 250;

            vankataBunny.Retire();

            string someString = "Somethin";

            string anotherString = someString ?? "Default";

            Bunny baiGosho = new Bunny("Goshooo");

            // Console.WriteLine(baiGosho.Health);

            ChangeBunny(baiGosho);

            // Console.WriteLine(baiGosho.Health);

            var bunnies = new List<Bunny>();

            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                Bunny currentBunny = new Bunny(new string((char)i, 10));
                currentBunny.Health = random.Next(0, 100);
                bunnies.Add(currentBunny);
            }

            //foreach (var bunny in bunnies)
            //{
            //    Console.WriteLine(bunny.Name + " " + bunny.Health);
            //}

            var vankataAndPesho = new List<Bunny>
            {
                vankataBunny,
                peshoBunny          
            };

            //foreach (var bunny in vankataAndPesho)
            //{
            //    Console.WriteLine(bunny.Name);
            //}

            AirCraft firstAirCraft = new AirCraft(vankataBunny, 50);
            AirCraft secondAirCraft = new AirCraft(peshoBunny, 100);

            firstAirCraft.Attack(secondAirCraft);

            Console.WriteLine(secondAirCraft.Pilot.Health);

            firstAirCraft.Move(new Coordinates(15, 20));
            secondAirCraft.Move(new Coordinates(25, 40));

            double distance = AirCraft.CalculateDistance(firstAirCraft, secondAirCraft);

            Console.WriteLine(distance);

            Console.WriteLine(vankataBunny.Damage);

            ColorType colorType = ColorType.Blue;

            Console.WriteLine((int)colorType);

            Bunny bunny = new Bunny("Bunnyyy");
            Console.WriteLine(bunny);

            object bunny2 = new Bunny("dsadsadsadas");
        }
    }
}
