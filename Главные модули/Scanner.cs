using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private Form1.Mode currentMode = Form1.Mode.ProMode;


        public Scanner()
        {

        }

        public Scanner(String chordString)
        {
            this.chordString = chordString;
            String[] array = chordString.Split(' ');
            listStrings = new List<string>(array);
        }
        public Scanner(String chordString, Form1.Mode currentMode)
        {
            this.chordString = chordString;
            this.currentMode = currentMode;
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
            switch (currentMode)
            {
                case Form1.Mode.ProMode:
                {
                    string stringChord = listStrings[currentIndex];
                    String[] stringChords = stringChord.Split('_');
                    Chord chord;
                    if (stringChords.Length > 1)
                    {
                        //Значит там есть какой-то тип
                        chord = new Chord(stringChords[1].ToString(), Int32.Parse(stringChords[0].ToString()));
                    }
                    else
                    {
                        chord = new Chord(stringChord);
                    }
                    currentIndex++;
                    return chord;
                    break;
                }
                default:
                {
                    string stringChord = listStrings[currentIndex];
                    Chord chord = new Chord(stringChord);
                    currentIndex++;
                    return chord;
                    break;
                }
            }
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
