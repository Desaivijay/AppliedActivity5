using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedActivity5
{
    public class Course
    {
        [Key] // Indicates that this property is the primary key in the database table.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-generates the value for this field.
        public int CourseId { get; set; }

        public string Name { get; set; }
        public string Instructor { get; set; }
        public string Description { get; set; }
    }
}
