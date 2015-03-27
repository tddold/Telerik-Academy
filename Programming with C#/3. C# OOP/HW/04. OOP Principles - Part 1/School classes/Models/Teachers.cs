namespace School_classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Teachers : Person
    {
        private List<Disciplines> discipline;

        public Teachers(string name, params Disciplines[] discipline)
            :base(name)
        {
            this.Discipline = new List<Disciplines>();
            this.Discipline.AddRange(discipline);
        }

        public List<Disciplines> Discipline
        {
            get
            {
                return new List<Disciplines>(this.discipline);
            }

            private set
            {
                this.discipline = value;
            }
        }

        public void SddDiscipline(Disciplines discipline)
        {
            this.discipline.Add(discipline);
        }

        public void RemoveDiscipline(Disciplines discipline)
        {
            this.discipline.Remove(discipline);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(string.Format("Name Mr. {0}", this.Name));
            sb.Append(string.Join(", ", this.Discipline));

            return sb.ToString();
        }
    }
}
