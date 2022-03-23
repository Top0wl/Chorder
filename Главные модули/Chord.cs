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
        public Chord()
        {

        }
        public Chord(string chordString)
        {
            Chords.TryParse(chordString, out ch);
            Resource = new MemoryStream((byte[])Properties.Resources.ResourceManager.GetObject(chordString));
        }
    }
}
