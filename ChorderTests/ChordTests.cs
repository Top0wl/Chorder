using Chorder;
using NUnit.Framework;

namespace ChorderTests
{
    class ChordTests
    {
        [Test]
        public void ScannerClassCreationTest()
        {
            Chord chord = new Chord();
            Assert.NotNull(chord);
        }
    }
}
