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
        public Sound(Chord.Chords chord)
        {
            this.chord = chord;
        }

        public bool Play()
        {
            chordSound.Play();
            //TODO: Реализовать метод
            return true;
        }
    }
}
