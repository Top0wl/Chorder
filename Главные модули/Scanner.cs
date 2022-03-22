using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chorder
{
    public class Scanner
    {
        private String chordString;
        private List<String> listStrings;
        private int currentIndex = 0;

        public Scanner()
        {

        }

        public Scanner(String chordString)
        {
            this.chordString = chordString;
            String[] array = chordString.Split(' ');
            listStrings = new List<string>(array);
        }

        public Chord Read(string chordString)
        {
            return new Chord(chordString);
        }
        /// <summary>
        /// Прочитать следующий аккорд
        /// </summary>
        /// <returns>Аккорд</returns>
        public Chord Read()
        {
            string stringChord = listStrings[currentIndex];
            Chord chord = new Chord(stringChord);
            currentIndex++;
            return chord;
        }
        /// <summary>
        /// Метод проверяет есть ли следующий аккорд в строке
        /// </summary>
        /// <returns>True - в строке есть следующий элемент; False - в строке нет следующего элемента</returns>
        public bool Next()
        {
            if (currentIndex + 1 <= listStrings.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
