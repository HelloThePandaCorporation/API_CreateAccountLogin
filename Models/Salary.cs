using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DTC_CRUD_MVC.Models
{
    public class Salary
    {
        [Key]
        public int SalaryId { get; set; }
        public string SalaryType { get; set; }
        public float SalaryNominal { get; set; }

    }
}
