using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMohamady.Models
{
    internal class StudentModel
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(25)]
        public string Branch { get; set; }
        public int Age { get; set; }

        public GradeModel grade { get; set; }

        [ForeignKey("department")]
        public int DepartmentId { get; set; }
        public DepartmentModel department { get; set; }
    }
}
