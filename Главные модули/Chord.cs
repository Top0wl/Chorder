using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chorder
{
    /// <summary>
    /// Класс аккорд
    /// </summary>
    public class Chord
    {
        /// <summary>
        /// Перечисление аккордов
        /// </summary>
        public enum Chords
        {
            Am,
            A,
            E,
            Em,
            F,
            Fm,
            G,
            Gm,
            D,
            Dm
        }
        /// <summary>
        /// Название аккорда
        /// </summary>
        public Chords ch;
        /// <summary>
        /// Ссылка на ресурс (аудоифайл)
        /// </summary>
        public MemoryStream Resource;
        /// <summary>
        /// Проиграть аккорд
        /// </summary>
        public void Play()
        {
            try
            {
                using (GZipStream gz = new GZipStream(Resource, CompressionMode.Decompress))
                    new System.Media.SoundPlayer(gz).PlaySync();
            }
            catch (Exception ex)
            {

            }
        }
        /// <summary>
        /// Конструктор аккорда
        /// </summary>
        public Chord()
        {

        }
        /// <summary>
        /// Конструктор аккорда
        /// </summary>
        /// <param name="chordString">Строка с аккордом</param>
        public Chord(string chordString)
        {
            Chords.TryParse(chordString, out ch);
            Resource = new MemoryStream((byte[])Properties.Resources.ResourceManager.GetObject(chordString));
        }
        /// <summary>
        /// Конструктор аккорда
        /// </summary>
        /// <param name="chordString">Строка с аккордом</param>
        /// <param name="type">Тип перебора</param>
        public Chord(string chordString, int type)
        {
            Chords.TryParse(chordString, out ch);
            try
            {
                Resource = new MemoryStream(
                    (byte[]) Properties.Resources.ResourceManager.GetObject("_" + type + "_" + chordString));
            }
            catch (Exception e)
            {

            }
        }
        /// <summary>
        /// Конструктор аккорда
        /// </summary>
        /// <param name="chordString">Строка с аккордом</param>
        /// <param name="type">Тип боя вниз, вверх</param>
        public Chord(string chordString, string type)
        {
            Chords.TryParse(chordString, out ch);
            try
            {
                Resource = new MemoryStream(
                    (byte[]) Properties.Resources.ResourceManager.GetObject("_" + type + "_" + chordString));
            }
            catch (Exception e)
            {

            }
        }
    }
}
