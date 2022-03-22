using Chorder;
using NUnit.Framework;

namespace ChorderTests
{
    public class ScannerTests
    {
        [Test]
        public void ScannerClassCreationTest()
        {
            Scanner scanner = new Scanner();
            Assert.NotNull(scanner);
        }
    }
}
