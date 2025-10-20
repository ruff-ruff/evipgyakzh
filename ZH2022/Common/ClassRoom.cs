using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ClassRoom
    {
        private List<Person> students = new List<Person>();

        public void Add(Person person)
        {
            students.Add(person);
        }
        public int Count()
        {
            return students.Count();
        }
    }
}
