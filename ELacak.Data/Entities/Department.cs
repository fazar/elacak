using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELacak.Model.Entities
{
    public class Department
    {
        public Department()
        {
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(10)]
        [Index(IsUnique = true)]
        public string Code { get; set; }
        [MaxLength(150)]
        [Index(IsUnique = true)]
        public string Name { get; set; }
        public Company Company { get; set; }
        public bool IsActive { get; set; }
        public bool IsSSO { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<DocumentType> DocumentTypes { get; set; }
    }
}
