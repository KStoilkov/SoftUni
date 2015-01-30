namespace _01.School
{
    using System.Text;
    using System.Collections.Generic;

    public class School
    {
        private List<Class> classesOfStudents;

        public List<Class> ClassesOfStudents { get; set; }

        public School(List<Class> classesOfStudents)
        {
            this.ClassesOfStudents = classesOfStudents;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var classOfStudent in this.ClassesOfStudents)
            {
                result.AppendLine(classOfStudent.ToString());
            }

            return result.ToString();
        }
    }
}
