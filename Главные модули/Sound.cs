using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chorder
{
    public class Sound
    {
        public IChordSound chordSound;
        private Chord.Chords chord;

        public Sound()
        {

        }
        public Sound(Chord.Chords chord, IChordSound chordSound)
        {
            this.chord = chord;
            this.chordSound = chordSound;
        }

        public bool Play()
        {
            chordSound.Play();
            return true;
        }
    }
}
