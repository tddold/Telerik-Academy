namespace Attribute
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    // this makes sure that this attribut can be used for struct
    // class interface enum and method
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
    AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]
   

    public class VersionAttribute : System.Attribute
    {
        // making two varibles for magor and minor
        public int magor { get; private set; }
        public int minor { get; private set; }        

        public VersionAttribute(int magor, int minor)
        {
            this.magor = magor;
            this.minor = minor;
        }
    }
}
