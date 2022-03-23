using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
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
        public MemoryStream Resource;

        public void Play()
        {
            using (GZipStream gz = new GZipStream(Resource, CompressionMode.Decompress))
                new System.Media.SoundPlayer(gz).Play();
        }
        public void Play2()
        {
            using (GZipStream gz = new GZipStream(Resource, CompressionMode.Decompress))
                new System.Media.SoundPlayer(gz).Play();
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
                    this.Resource = new MemoryStream(Properties.Resources.Am);
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
