using Chorder;
using NUnit.Framework;
using System;

namespace ChorderTests
{
    class SoundTests
    {
        [Test]
        public void SoundClassCreationTest()
        {
            Sound sound = new Sound();
            Assert.NotNull(sound);
        }
        [Test]
        public void SoundPlayTest()
        {
            Sound sound = new Sound(Chord.Chords.Am);
            bool check = sound.Play();
            if (check)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
