using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DTS_API.Models
{
    public class UserRole
    {
        [Key]
        public int id { get; set; }
        public User user { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        
        public Role role { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        
    }
}
