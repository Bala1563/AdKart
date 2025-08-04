using AdKartShared.Enums;
using System.ComponentModel.DataAnnotations;

namespace AdKartDomain.Entities
{
    public class Transaction : BaseEntity
    {
        // This stores the Id of the Receiver (UserId, CoinsContainerId, TransientCoinsContainerId)
        [Required]
        public string TransferedTo { get; set; }

        [Required]
        public TransactionType Type { get; set; }

        [Required]
        public decimal TransferedCoins { get; set; }

        [Required]
        public TransactionFrom From { get; set; }

        [Required]
        public TransactionTo To { get; set; }
    }
}