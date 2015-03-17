namespace DynamicType
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;

    public class Program
    {
        public static void Main()
        {
            dynamic dyn = 5;
            dyn = new Student();
            dyn.Name = "Pesho";
            // Console.WriteLine(dyn.Name);

            int result = Sum<int>(5, 10);
            string text = Sum<string>("Pesho", "Gosho");
            // Console.WriteLine(text);

            object obj = new Student();
            // obj.Name = "Pesho"; does not compile

            dynamic expandingObject = new ExpandoObject();

            expandingObject.Age = 100;
            expandingObject.Name = "Az sym kofti obekt";

            expandingObject.SayHello = new Func<string>(
                () => expandingObject.Name + " " + expandingObject.Age);

            // Console.WriteLine(expandingObject.SayHello());

            var properties = (IDictionary<string, object>)expandingObject;

            foreach (var pair in properties)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }

            properties.Add("Money", 1000.0M);

            Console.WriteLine(expandingObject.Money);

            properties.Add("ChangeMoney", new Action<decimal>((x) => expandingObject.Money = x));

            expandingObject.ChangeMoney(2000.0M);

            Console.WriteLine(expandingObject.Money);

            var collectionVar = new List<string> { "Pesho" };
            object collectionObj = new List<string> { "Pesho" };
            dynamic collectionDyn = new List<string> { "Pesho" };

            collectionVar.Add("Gosho"); // works as list
            // collectionObj.Add("Nycki"); // useless 
            collectionDyn.Add2("Vankata"); // compiles but gives exception

            foreach (var name in collectionDyn)
            {
                Console.WriteLine(name);
            }
        } 

        public static T Sum<T>(dynamic first, dynamic second)
        {
            return first + second;
        }
    }
}
