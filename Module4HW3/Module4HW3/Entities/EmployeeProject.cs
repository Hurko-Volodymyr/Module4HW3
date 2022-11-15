using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW3.Entities
{
    internal class EmployeeProject
    {
        public EmployeeProject(int employeeProjectId, decimal rate, DateTime startedDate)
        {
            EmployeeProjectId = employeeProjectId;
            Rate = rate;
            StartedDate = startedDate;
        }

        public int EmployeeProjectId { get; set; }
        public decimal Rate { get; set; }
        public DateTime StartedDate { get; set; }
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public int? ProjectId { get; set; }
        public Project? Project { get; set; }
    }
}
