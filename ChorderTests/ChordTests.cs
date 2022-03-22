using System;
using Chorder;
using NUnit.Framework;

namespace ChorderTests
{
    class ChordTests
    {
        [Test]
        public void ChordClassCreationTest()
        {
            Chord chord = new Chord();
            Assert.NotNull(chord);
        }

        public void ChordPlayTest()
        {
            Chord chord = new Chord("Am");
            try
            {
                chord.Play();
                Assert.Pass();
            }
            catch (Exception e)
            {
                Assert.Fail();
            }

        }
    }
}
