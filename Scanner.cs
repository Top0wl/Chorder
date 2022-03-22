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

        public Scanner()
        {

        }

        public Scanner(String chordString)
        {
            this.chordString = chordString;
        }

        public Chord Read(object chordString)
        {
            //TODO: Реализовать чтение строки с аккордами и возвращением соответствующего аккорда
            return new Chord();
        }

        public Chord Read()
        {
            //TODO: Реализовать чтение строки с аккордами и возвращением соответствующего аккорда
            return new Chord();
        }
        public bool Next()
        {
            //TODO: Реализовать проверку, есть ли следующий элемент
            Random random = new Random();
            var num = random.Next(1, 3);
            if (num == 1)
                return true;
            else
                return false;
        }
    }
}
