using System;
using System.Collections.Generic;
using System.Text;

namespace ELacak.Services.DAO
{
    public class CompanyDao
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte[] Icon { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
