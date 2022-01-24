using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week5_DemoBank_Entities.Concrete
{
    public class OperationClaim 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
