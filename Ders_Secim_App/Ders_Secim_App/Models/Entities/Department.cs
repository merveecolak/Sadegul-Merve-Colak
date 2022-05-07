using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders_Secim_App.Models.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentOfHead { get; set; }

        public List<Student> Students { get; set; }
    }
}
