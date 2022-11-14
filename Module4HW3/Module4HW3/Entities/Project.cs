namespace Module4HW3.Entities
{
    internal class Project
    {
        public Project(int projectId, string name, decimal budjet, DateTime startedDate, EmployeeProject employeeProject)
        {
            ProjectId = projectId;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Budjet = budjet;
            StartedDate = startedDate;
            EmployeeProject = employeeProject ?? throw new ArgumentNullException(nameof(employeeProject));
        }

        public int ProjectId { get; set; }
        public string Name { get; set; }
        public decimal Budjet { get; set; }
        public DateTime StartedDate { get; set; }
        public EmployeeProject EmployeeProject { get; set; }
    }
}
