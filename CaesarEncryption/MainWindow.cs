using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarEncryption
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private string ReverseString(string s)
        {
            string result = "";
            string temp = "";
            foreach (char letter in s)
            {
                    temp = result;
                    result = letter + temp;
            }
            return result;
        }
        private int LetterToNumber(char letter)
        {
            int number = -1;
            switch(letter)
            {
                case 'a':
                    number = 0;
                    break;
                case 'b':
                    number = 1;
                    break;
                case 'c':
                    number = 2;
                    break;
                case 'd':
                    number = 3;
                    break;
                case 'e':
                    number = 4;
                    break;
                case 'f':
                    number = 5;
                    break;
                case 'g':
                    number = 6;
                    break;
                case 'h':
                    number = 7;
                    break;
                case 'i':
                    number = 8;
                    break;
                case 'j':
                    number = 9;
                    break;
                case 'k':
                    number = 10;
                    break;
                case 'l':
                    number = 11;
                    break;
                case 'm':
                    number = 12;
                    break;
                case 'n':
                    number = 13;
                    break;
                case 'o':
                    number = 14;
                    break;
                case 'p':
                    number = 15;
                    break;
                case 'q':
                    number = 16;
                    break;
                case 'r':
                    number = 17;
                    break;
                case 's':
                    number = 18;
                    break;
                case 't':
                    number = 19;
                    break;
                case 'u':
                    number = 20;
                    break;
                case 'v':
                    number = 21;
                    break;
                case 'w':
                    number = 22;
                    break;
                case 'x':
                    number = 23;
                    break;
                case 'y':
                    number = 24;
                    break;
                case 'z':
                    number = 25;
                    break;
                default:
                    break;
            }
            return number;
        }
        private char NumberToLetter(int number)
        {
            char letter = ' ';
            switch(number)
            {
                case 0:
                    letter = 'a';
                    break;
                case 1:
                    letter = 'b';
                    break;
                case 2:
                    letter = 'c';
                    break;
                case 3:
                    letter = 'd';
                    break;
                case 4:
                    letter = 'e';
                    break;
                case 5:
                    letter = 'f';
                    break;
                case 6:
                    letter = 'g';
                    break;
                case 7:
                    letter = 'h';
                    break;
                case 8:
                    letter = 'i';
                    break;
                case 9:
                    letter = 'j';
                    break;
                case 10:
                    letter = 'k';
                    break;
                case 11:
                    letter = 'l';
                    break;
                case 12:
                    letter = 'm';
                    break;
                case 13:
                    letter = 'n';
                    break;
                case 14:
                    letter = 'o';
                    break;
                case 15:
                    letter = 'p';
                    break;
                case 16:
                    letter = 'q';
                    break;
                case 17:
                    letter = 'r';
                    break;
                case 18:
                    letter = 's';
                    break;
                case 19:
                    letter = 't';
                    break;
                case 20:
                    letter = 'u';
                    break;
                case 21:
                    letter = 'v';
                    break;
                case 22:
                    letter = 'w';
                    break;
                case 23:
                    letter = 'x';
                    break;
                case 24:
                    letter = 'y';
                    break;
                case 25:
                    letter = 'z';
                    break;
                default:
                    break;
            }
            return letter;
        }
        private string CaesarCrypt(int key)
        {
            string input = this.tbxInput.Text;
            string output = "";
            //MessageBox.Show(s);
            foreach (char letter in input)
            {
                output += NumberToLetter((LetterToNumber(letter) + key) % 26);
            }
            return output;
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            this.tbxOutput.Text = "";
            for (int i = 1; i < 26; i++)
            {
                this.tbxOutput.Text += "k = " + i + ":\t" + CaesarCrypt(i) + "\t" + ReverseString(CaesarCrypt(i)) + "\r\n";
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {

        }
    }
}
