using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Obg.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Budget { get; set; }
        public DateOnly StartDate { get; set; }
        public int DepartmentHeadId { get; set; }
        public Department()
        {

        }
    }
}
