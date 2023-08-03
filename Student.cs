using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedActivity5
{
    public class Student
    {
        [Key] // Indicates that this property is the primary key in the database table.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-generates the value for this field.
        public int StudentId { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
