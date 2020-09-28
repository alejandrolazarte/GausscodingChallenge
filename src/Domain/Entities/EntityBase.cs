using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class EntityBase
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public bool IsDeleted { get; set; }
    }
}
