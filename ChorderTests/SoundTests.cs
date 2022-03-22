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
    }
}
