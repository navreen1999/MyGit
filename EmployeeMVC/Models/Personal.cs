using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMVC.Models
{
    public class Personal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Qualification { get; set; }
        public string IsEmployed { get; set; }
        public string NoticePeriod { get; set; }
        public int CurrentCTC { get; set; }
    }
}
