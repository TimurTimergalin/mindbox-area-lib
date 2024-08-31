using AreaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAreaLib
{
    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void TestArea()
        {
            (double, double, double, double)[] testCases =
                [
                    (3, 4, 5, 6),
                    (5, 6, 5, 12),
                    (8, 5, 5, 12)
                ];

            double precision = 1e-10;
            foreach (var (a, b, c, expectedArea) in testCases)
            {
                Assert.AreEqual(expectedArea, new Triangle(a, b, c).Area, precision);
            }
        }

        [TestMethod]
        public void TestIsRight()
        {
            (double, double, double, bool)[] testCases =
                [
                (3, 4, 5, true),
                (5, 4, 3, true),
                (5, 4, 4, false),
                (5, 13, 12, true)
                ];

            foreach (var (a, b, c, ans) in testCases)
            {
                Assert.AreEqual(new Triangle(a, b, c).IsRight(), ans);
            }
        }
    }
}
