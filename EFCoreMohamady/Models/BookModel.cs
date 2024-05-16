using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMohamady.Models
{
    internal class BookModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Author { get; set; }
        public DateTime publishDate { get; set; }

        public ICollection<StudentModel> students { get; set; }
    }
}
