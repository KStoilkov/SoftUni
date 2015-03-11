using System.Text;

namespace _01.School
{
    using System;

    public class Student : Person
    {
        private long uniqueClassNumber;

        public long UniqueClassNumber
        {
            get { return this.uniqueClassNumber; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Unique Class Number cannot be less than 0.");
                }
                this.uniqueClassNumber = value;
            }
        }

        public Student(string name, long uniqueClassNumber , string details)
            : base(name, details)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public Student(string name, long uniqueClassNumber)
            : this (name, uniqueClassNumber, null)
        {
            
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(" Student name: " + this.Name + ", Class number: " + this.UniqueClassNumber);

            if (this.Details != null)
            {
                result.Append(", " + this.Details);
            }
            return result.ToString();
        }
    }
}
