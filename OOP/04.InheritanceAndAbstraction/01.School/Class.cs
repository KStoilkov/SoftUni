namespace _01.School
{
    using System.Text;
    using System.Collections.Generic;

    public class Class : IDetails
    {
        private List<Teacher> setOfTeachers;
        private string uniqueTextIdentifier;
        private string details;

        public List<Teacher> SetOfTeachers { get; set; }
        public string UniqueTextIdentifier { get; set; }
        public string Details { get; set; }

        public Class(List<Teacher> setOfTeachers,
            string uniqueTextIdentifier, string details)
        {
            this.SetOfTeachers = setOfTeachers;
            this.UniqueTextIdentifier = uniqueTextIdentifier;
            this.Details = details;
        }

        public Class(List<Teacher> setOfTeachers,
                string uniqueTextIdentifier)
            : this(setOfTeachers, uniqueTextIdentifier, null)
        {
            
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(UniqueTextIdentifier);
            result.AppendLine("Class Teachers: ");

            foreach (var teacher in this.SetOfTeachers)
            {
                result.AppendLine(teacher.ToString());
            }

            if (this.Details != null)
            {
                result.AppendLine("Details: " + this.Details);
            }

            return result.ToString();
        }
    }
}
