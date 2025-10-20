using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ClassRoomTests
    {
        [Fact]
        public void TestAddition()
        {
            var cr = new ClassRoom();
            cr.Add(Person.GetMe());
            cr.Add(Person.GetMe());
            cr.Add(Person.GetMe());
            Assert.Equal(3, cr.Count());
        }
    }
}
