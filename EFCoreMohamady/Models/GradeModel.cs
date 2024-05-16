using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMohamady.Models
{
    internal class GradeModel
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        public int BooksCount { get; set; }
        public DateTime EnterDate { get; set; } = DateTime.Now;

        [ForeignKey("student")]
        public int studentId { get; set; }
        public StudentModel student { get; set; }
    }
}
