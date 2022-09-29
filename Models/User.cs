using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DTS_API.Models
{
    public class User
    {
        public Employee employee { get; set; }
        [Key, ForeignKey("Employee")]
        public int Id { get; set; }
        public string Password { get; set; }
    }
}
