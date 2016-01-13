namespace StudentSystem.Models
{
    using enums;
    using System.ComponentModel.DataAnnotations;

    public class Resource
    {
        public Resource()
        {

        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public TypeOfResource TypeOfResource { get; set; }

        [Required]
        public string URL { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
