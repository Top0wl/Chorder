using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Chorder
{
    public class AmChordSound : IChordSound
    {
        public bool Play()
        {
            try
            {
                using (MemoryStream fileOut = new MemoryStream(Properties.Resources.Am))
                using (GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress))
                    new System.Media.SoundPlayer();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
