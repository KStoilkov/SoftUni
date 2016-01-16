namespace _04.ATMDatabase
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CardAccount
    {
        public CardAccount()
        {

        }

        [Key]
        public int Id { get; set; }

        [MaxLength(10)]
        [Required]
        public string CardNumber { get; set; }

        [MaxLength(10)]
        [Required]
        public string CardPIN { get; set; }

        [Column(TypeName = "Money")]
        [ConcurrencyCheck]
        public decimal CardCash { get; set; }
    }
}
