using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELacak.Model.Entities
{
    public class User
    {
        public User()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100)]
        [Index(IsUnique = true)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string FullName { get; set; }
        public byte[] SignatureImage { get; set; }

        [MaxLength(100)]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public string DefaultUrl { get; set; }

        public bool IsActive { get; set; }

        public bool IsSuperAdmin { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
