using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week5_DemoBank_Entities.Concrete
{
    public class UserOperationClaim 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
