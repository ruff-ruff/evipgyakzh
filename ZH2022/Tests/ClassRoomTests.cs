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

        [Fact]
        public void TestHeightInClass()
        {
            var cr = new ClassRoom();
            var pg = new PersonGrower();
            pg.N = 2;
            for (int i = 1; i < 4; i++)
            {
                var p = new Person($"{i}. István", 18, 180+i*2);
                cr.Add(p);
            }
            var tallest = cr.GetTallestPerson();
            var laszlo = new Person("IV. László", 36, 190);
            Assert.NotEqual(tallest, laszlo);
            cr.Add(laszlo);
            tallest = cr.GetTallestPerson();
            Assert.Equal(tallest, laszlo);
        }
    }
}
