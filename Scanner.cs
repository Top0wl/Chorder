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

        public Chord Read(object chordString)
        {
            //TODO: Реализовать чтение строки с аккордами и возвращением соответствующего аккорда
            return new Chord();
        }

        public Chord Read()
        {
            //TODO: Реализовать чтение строки с аккордами и возвращением соответствующего аккорда
            currentIndex++;
            return new Chord();
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
