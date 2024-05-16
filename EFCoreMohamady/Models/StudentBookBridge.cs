using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCoreMohamady.Models
{
    internal class StudentBookBridge
    {
        [ForeignKey("student")]
        public int studentId { get; set; }
        public StudentModel student { get; set; }

        [ForeignKey("book")]
        public int bookId { get; set; }
        public BookModel book { get; set; }
    }
}
