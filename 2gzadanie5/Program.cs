using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace _2gzadanie5
{
    class program
    {
        static void Main()
        {
            int value, Value;
            value = Int32.Parse(Interaction.InputBox("Введите целое число больше 1000"));
            Value = value / 1000 % 10;
            MessageBox.Show("В числе " + value + "\nтысяч = " + Value);
        }
    }
}