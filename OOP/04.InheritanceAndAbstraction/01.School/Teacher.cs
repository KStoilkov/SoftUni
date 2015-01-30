namespace _01.School
{
    using System.Text;
    using System.Collections.Generic;

    public class Teacher : Person
    {
        private List<Discipline> disciplines; 

        public List<Discipline> Disciplines { get; set; }

        public Teacher(string name, List<Discipline> disciplines, string details)
            : base(name, details)
        {
            this.Disciplines = disciplines;
        }

        public Teacher(string name, List<Discipline> setOfDisciplines)
            : this(name, setOfDisciplines, null)
        {
            
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            
            result.Append(" Name: " + this.Name);
            result.Append(" Courses:");
            foreach (var discipline in this.Disciplines)
            {
                result.Append(discipline + ",");
            }

            if (this.Details != null)
            {
                result.Append(" Details: " + this.Details);
            }

            return result.ToString();
        }
    }
}
