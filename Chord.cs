using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chorder
{
    public class Chord
    {
        public enum Chords
        {
            Am,
            A,
            E,
            Em,
            F,
            G
            //TODO: Дописать аккорды
        }
        public Chords ch;
        public Sound sound;

        public void Play()
        {
            sound.Play();
        }

        public Chord()
        {

        }

        public Chord(string chordString)
        {
            switch (chordString)
            {
                case "Am":
                {
                    this.ch = Chords.Am;
                    sound = new Sound(Chords.Am, new AmChordSound());
                    break;
                }
                case "A":
                {
                    this.ch = Chords.A;
                    break;
                }
                //TODO: Дописать реализации
                default:
                {
                    break;
                }
            }
        }

    }
}
