using System;
using System.IO;
using System.IO.Compression;
using Chorder;
using NUnit.Framework;
using System.Media;

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
        [Test]
        public void ChordAmClassCreationTest()
        {
            Chord chord = new Chord("Am");
            Assert.NotNull(chord);
        }
        [Test]
        public void Chord4AmClassCreationTest()
        {
            Chord chord = new Chord("Am", 4);
            Assert.NotNull(chord);
        }
        [Test]
        public void ChordPlayTest()
        {
            Chord chord = new Chord("Am");
            try
            {
                chord.Play();
                //Assert.Pass даёт пустой exception...
                Assert.True(true);
            }
            catch (Exception e)
            {
               Assert.Fail();
            }

        }
    }
}
