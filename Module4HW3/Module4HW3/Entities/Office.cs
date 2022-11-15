using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW3.Entities
{
    internal class Office
    {
        public Office(int officeId, string title, string location)
        {
            OfficeId = officeId;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Location = location ?? throw new ArgumentNullException(nameof(location));
        }

        public int OfficeId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
