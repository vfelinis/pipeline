using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Pipeline.Core;

namespace Pipeline.Tests
{
    [TestFixture]
    public class MainServiceTests
    {
        [Test]
        public void HelloTest()
        {
            var service = new MainService();
            var expected = "Hello Mike";

            var actual = service.Hello("Hello", "Mike");

            Assert.AreEqual(expected, actual);
        }
    }
}
