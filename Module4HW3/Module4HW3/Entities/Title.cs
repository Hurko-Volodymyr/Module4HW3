using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW3.Entities
{
    internal class Title
    {
        public Title(int titleId, string name)
        {
            TitleId = titleId;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public int TitleId { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
