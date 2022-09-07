using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ms6case3.Models
{
    public class StudentModel
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int marks { get; set; }
    }
}
