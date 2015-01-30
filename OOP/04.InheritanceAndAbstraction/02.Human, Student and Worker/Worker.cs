namespace _02.Human__Student_and_Worker
{
    using System;

    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be less than 0.");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Work hours per day cannot be less than 0.");
                }
                this.workHoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName, double weekSalary, 
            int workHoursPerDay) : base (firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            return ((this.WeekSalary / 5) / this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return string.Format(this.FirstName + " " + this.LastName + " | " + this.MoneyPerHour().ToString("F"));
        }
    }
}
