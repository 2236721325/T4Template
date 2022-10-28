using Base.Shared.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Template.Models
{
    public class User:BaseEntity<Guid>
    {
        public string Account { get; set; }
        public string Name { get; set; }
    }
}
