using AreaLibrary;

namespace TestAreaLib
{
    [TestClass]
    public class TestDisc
    {
        [TestMethod]
        public void TestArea()
        {
            (double, double)[] testCases =
            [
                (1, Math.PI),
                (2, 4 * Math.PI),
                (1 / Math.Sqrt(Math.PI), 1),
            ];

            double precision = 1e-10;
            foreach (var (radius, expectedArea) in testCases)
            {
                Assert.AreEqual(expectedArea, new Disc(radius).Area, precision);
            }
        }
    }
}