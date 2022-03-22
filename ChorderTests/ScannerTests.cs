﻿using Chorder;
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
            String chordsString = "Am E G F";
            Chord chord;
            Scanner scanner = new Scanner(chordString);
            while (chord = scanner.Read())
            {
                Assert.NotNull(chord);
            }
        }
    }
}
