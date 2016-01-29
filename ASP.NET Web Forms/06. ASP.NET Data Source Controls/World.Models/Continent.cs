namespace World.Models
{
    using System.Collections.Generic;

    public class Continent
    {

        public Continent()
        {
            this.countries = new HashSet<Country>();
        }

        public int Id { get; set; }

        public string Name { get; set; }
        ICollection<Country> countries;

        public virtual ICollection<Country> Countries
        {
            get { return countries; }

            set { countries = value; }
        }
    }
}
