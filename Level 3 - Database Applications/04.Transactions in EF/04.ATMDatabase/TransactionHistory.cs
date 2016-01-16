namespace _04.ATMDatabase
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class TransactionHistory
    {
        public TransactionHistory()
        {

        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string CardNumber { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        [Column(TypeName = "Money")]
        public decimal WithdrawAmount { get; set; }
    }
}
