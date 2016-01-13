namespace StudentSystem.Models
{
    using enums;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Homework
    {
        public Homework()
        {

        }

        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        [Required]
        public ContentType ContentType { get; set; }

        [Required]
        public DateTime SubmissionDate { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}
