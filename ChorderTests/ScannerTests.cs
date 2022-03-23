using Chorder;
using NUnit.Framework;
using System;

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
        [Test]
        public void ScannerReadStringWithChord()
        {
            String chordString = "Am";
            Scanner scanner = new Scanner();
            Chord chord = scanner.Read(chordString);
            Assert.NotNull(chord);
        }
        [Test]
        public void ScannerReadStringWithChords()
        {
            String chordsString = "Am Am";
            Chord chord;
            Scanner scanner = new Scanner(chordsString);
            while (scanner.Next())
            {
                chord = scanner.Read();
                Assert.NotNull(chord);
            }
        }
        [Test]
        public void ScannerReadAmChord()
        {
            String chordsString = "Am";
            Scanner scanner = new Scanner(chordsString);
            Chord readChord = scanner.Read();

            Chord createChord = new Chord();
            createChord.ch = Chord.Chords.Am;

            if (readChord.ch == createChord.ch)
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
