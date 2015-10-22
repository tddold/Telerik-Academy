namespace EntityFrameworkModel
{
    using System.Collections.Generic;
    using System.Data.Linq;

    public partial class Employee
    {
        public EntitySet<Territory> TerritoryProperty
        {
            get
            {
                EntitySet<Territory> territory = new EntitySet<Territory>();
                territory.AddRange(this.Territories);
                return territory;
            }
        }
    }
}
