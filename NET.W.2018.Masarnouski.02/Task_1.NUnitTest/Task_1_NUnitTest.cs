using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NET.W._2018.Masarnouski._02;

namespace Task_1.NUnitTest
{
    public class Task_1_NUnitTest
    {
        [Test]
        public void numberSourse1_numberIn2_start1_end3_120returned()
        {
          
            Assert.That(NET.W._2018.Masarnouski._02.Task_1.InsertNumber(1, 2, 1, 3),
                Is.EqualTo(5));
        }
    }
}
