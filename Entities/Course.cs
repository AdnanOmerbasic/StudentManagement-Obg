using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Obg.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Credits { get; set; }
        public int? InstructorId { get; set; }
        public Course()
        {

        }
    }
}
