namespace Module4HW3.Entities
{
    internal class Employee
    {
        public Employee(int employeeId, string firstName, string lastName, DateTime hiredDate, DateTime? dateOfBirth)
        {
            EmployeeId = employeeId;
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            HiredDate = hiredDate;
            DateOfBirth = dateOfBirth;
        }

        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HiredDate { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int? OfficeId { get; set; }

        public Office? Office { get; set; }
        public int? TitleId { get; set; }

        public Title? Title { get; set; }

        public EmployeeProject? EmployeeProject { get; set; }
    }
}
