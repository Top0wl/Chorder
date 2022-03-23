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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scanner scanner = new Scanner(richTextBox1.Text.ToString());
            while (scanner.Next())
            {
                Chord chord = scanner.Read();
                chord.Play();
            }
        }
    }
}
