using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzed.Entities.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Concept> Concepts { get; set; }
    }
}
