using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chorder
{
    public partial class Form1 : Form
    { 
        public enum Mode
        {
            ProMode,
            Perebor,
            Boj,
        }
        private Mode currentMode;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButtonCheck();
            Scanner scanner = new Scanner(richTextBox1.Text.ToString(), currentMode);
            while (scanner.Next())
            {
                Chord chord = scanner.Read();
                chord.Play();
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void radioButtonCheck()
        {
            if (radioButton3.Checked)
                currentMode = Mode.ProMode;
            if (radioButton2.Checked)
                currentMode = Mode.Boj;
            if (radioButton2.Checked)
                currentMode = Mode.Perebor;
        }
    }
}
