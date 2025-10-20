using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ModifierTests
    {
        [Fact]
        public void TestGrowerTest()
        {
            var p = new Person("Béla", 13, 155);
            var pg = new PersonGrower();
            pg.N = 5;
            Assert.Equal(155, p.Height);
            pg.Modify(p);
            Assert.Equal(160, p.Height);
        }
    }
}
