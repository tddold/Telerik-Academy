/*Problem 11. Version attribute
Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
Apply the version attribute to a sample class and display its version at runtime.*/


namespace Attribute
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    [Version(2, 11)]
    class VersionDemo
    {
        static void Main()
        {
            // typeof returns the type of the given thing and all its attributes
            Type type = typeof(VersionDemo);

            // making an object[] with all the attributes in this class
            object[] allAttributes = type.GetCustomAttributes(false);

            // printing the attributes properties
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("Version: {0}.{1}", attr.magor, attr.minor);

            }

            Console.WriteLine();
        }
    }
}