using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyalphabetic_ciphers___Vigenère
{
    public partial class VigenèreCipher : Form
    {
        public VigenèreCipher()
        {
            InitializeComponent();
        }

        private string VigenereEncrypt(string text, string key)
        {
            string result = "";
            key = key.ToUpper();
            int keyIndex = 0;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    int shift = key[keyIndex] - 'A';
                    result += (char)(((c - offset + shift) % 26) + offset);
                    keyIndex = (keyIndex + 1) % key.Length;
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }

        private string VigenereDecrypt(string text, string key)
        {
            string result = "";
            key = key.ToUpper();
            int keyIndex = 0;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    int shift = key[keyIndex] - 'A';
                    result += (char)(((c - offset - shift + 26) % 26) + offset);
                    keyIndex = (keyIndex + 1) % key.Length;
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            Result_txt.Text = "";
            string text = Text_txt.Text;
            string key = Key_txt.Text;

            if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(key))
            {
                Result_txt.Text = VigenereEncrypt(text, key);
            }
            else
            {
                MessageBox.Show("Please enter both text and key.");
            }
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            Result_txt.Text = "";
            string text = Text_txt.Text;
            string key = Key_txt.Text;

            if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(key))
            {
                Result_txt.Text = VigenereDecrypt(text, key);
            }
            else
            {
                MessageBox.Show("Please enter both text and key.");
            }
        }
    }
}
