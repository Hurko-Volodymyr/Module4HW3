using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW3.Entities
{
    internal class EmployeeProject
    {
        public EmployeeProject(int employeeProjectId, decimal rate, DateTime startedDate, int employeeId, Employee employee, int projectId, Project project)
        {
            EmployeeProjectId = employeeProjectId;
            Rate = rate;
            StartedDate = startedDate;
            EmployeeId = employeeId;
            Employee = employee ?? throw new ArgumentNullException(nameof(employee));
            ProjectId = projectId;
            Project = project ?? throw new ArgumentNullException(nameof(project));
        }

        public int EmployeeProjectId { get; set; }
        public decimal Rate { get; set; }
        public DateTime StartedDate { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
