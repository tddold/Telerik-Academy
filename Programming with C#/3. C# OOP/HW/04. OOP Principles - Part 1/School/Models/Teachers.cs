using School.Interfaces;

namespace School.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
   

    public class Teachers : Person
    {
        private List<Disciplines> disciplines;

        public Teachers(string name, params Disciplines[] disciplines)
            : base(name)
        {
            this.disciplines = new List<Disciplines>();
            this.disciplines.AddRange(disciplines);
        }

        public List<Disciplines> Disciplines
        {
            get { return new List<Disciplines>(this.disciplines); }
        }

        public void AddDiscipline(Disciplines disciplines)
        {
            this.disciplines.Add(disciplines);
        }

        public void RemoveDiscipline(Disciplines disciplinee)
        {
            this.disciplines.Remove(disciplinee);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Name: " + base.Name);
            sb.AppendLine("Discipline: ");
            sb.AppendLine(string.Join(", ", Disciplines));

            return sb.ToString();
        }
    }
}
