namespace VersionAttribute
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
    AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]

    public class Attribute : System.Attribute
    {
        public int magor { get; private set; }
        public int minor { get; private set; }

        public Attribute(int mogor, int minor) 
        {
            this.magor = magor;
            this.minor = minor;
        }
    }
}
