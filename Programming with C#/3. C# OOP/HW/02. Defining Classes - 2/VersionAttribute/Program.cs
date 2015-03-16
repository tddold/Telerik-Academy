/*Problem 11. Version attribute
 * Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and 
 * holds a version in the format major.minor (e.g. 2.11).
 * Apply the version attribute to a sample class and display its version at runtime.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VersionAttribute
{
  
    // using Attribute;

    [Version(2.11)]
    public class Program
    {
        public static void Main()
        {
            Type type = typeof(Program);
            // typeof returns the type of the given thing and all its attributes
            object[] allAttributes =
              type.GetCustomAttributes(false);
            // making an object[] with all the attributes in this class
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("{0}.{1}", attr.magor, attr.minor);
                // printing the attributes properties
            }
        }
        
    }
}
