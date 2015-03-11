namespace _03.StudentClass
{
    using System;

    public class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                this.OnPropertyChange("Name", this.Name, value);
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }    

                this.OnPropertyChange("Age", this.Age.ToString(), value.ToString());
                this.age = value;
            }
        }

        private void OnPropertyChange(string propertyName, string oldValue, string newValue)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(
                    this,
                    new PropertyChangedEventArgs(propertyName, oldValue, newValue));    
            }
            
        }
    }
}
