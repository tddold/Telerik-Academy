/*Problem 3. Animal hierarchy
 * Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs,
 * frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
 * Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only 
 * female and tomcats can be only male. Each animal produces a specific sound.
 * Create arrays of different kinds of animals and calculate the average age of each kind of animal 
 * using a static method (you may use LINQ).*/

namespace Animal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class AnimalsMain
    {
        public static void Main()
        {
            Console.WriteLine("Animals");
            PrintSeparateLine();

            Dog[] dogs = new Dog[]
            {
                new Dog(3, "Zico", "Male"),
                new Dog(2, "Sharo", "Male"),
                new Dog(3, "Kiko", "Male"),
                new Dog(6, "Reks", "Male"),
                new Dog(4, "Suzi", "Female"),
                new Dog(5, "Riko", "Male")
            };

            Kitten[] kittens = new Kitten[]
            {
                new Kitten(1, "Pufi"),
                new Kitten(2, "Tufi"),
                new Kitten(1, "Rufi"),
                new Kitten(1, "Popi"),
                new Kitten(2, "Loli"),
                new Kitten(1, "Zuzi")
            };

            Tomcat[] tomcats = new Tomcat[]
            {
                new Tomcat(15, "Roko"),
                new Tomcat(10, "Zoro"),
                new Tomcat(25, "Ziko"),
                new Tomcat(20, "Tom"),
                new Tomcat(15, "Bob"),
                new Tomcat(10, "Soko")
            };

            Frog[] frogs = new Frog[]
            {
                new Frog(5, "Frog", "Male"),
                new Frog(4, "Grog", "Male"),
                new Frog(5, "Deri", "Female"),
                new Frog(3, "Beri", "Female"),
                new Frog(6, "Geri", "Female"),
                new Frog(5, "Drog", "Male")
            };

            Dictionary<string, double> averegeAges = new Dictionary<string, double>();

            averegeAges.Add("Dog", CalculateAverageAge(dogs));
            averegeAges.Add("Kitten", CalculateAverageAge(kittens));
            averegeAges.Add("Tomcat", CalculateAverageAge(tomcats));
            averegeAges.Add("Frog", CalculateAverageAge(frogs));

            foreach (var item in averegeAges)
            {
                Console.WriteLine("{0, -7} --> {1,5:F2} years (average)", item.Key, item.Value);
            }

            PrintSeparateLine();
        }

        private static double CalculateAverageAge(Animals[] animals)
        {
            var newAnimals = animals
                .Select(x => x.Age);
            double averageAge = 0;
            double count = 0;

            foreach (var age in newAnimals)
            {
                averageAge += age;
                count++;
            }

            return averageAge / count;
        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
