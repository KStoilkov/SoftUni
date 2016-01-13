namespace StudentSystem.Data
{
    using Migrations;
    using Models;
    using System.Data.Entity;

    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
            : base("name=StudentSystemContext")
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());
        }

        public virtual IDbSet<Course> Courses { get; set; }
        public virtual IDbSet<Homework> Homeworks { get; set; }
        public virtual IDbSet<Resource> Resources { get; set; }
        public virtual IDbSet<Student> Students { get; set; }
    }
}