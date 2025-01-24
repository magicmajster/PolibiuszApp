using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PolibiuszApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static readonly Dictionary<char, string> EncryptMap = new Dictionary<char, string>()
        {
            { 'A', "11" }, { 'B', "12" }, { 'C', "13" }, { 'D', "14" }, { 'E', "15" },
            { 'F', "21" }, { 'G', "22" }, { 'H', "23" }, { 'I', "24" }, { 'K', "25" },
            { 'L', "31" }, { 'M', "32" }, { 'N', "33" }, { 'O', "34" }, { 'P', "35" },
            { 'Q', "41" }, { 'R', "42" }, { 'S', "43" }, { 'T', "44" }, { 'U', "45" },
            { 'V', "51" }, { 'W', "52" }, { 'X', "53" }, { 'Y', "54" }, { 'Z', "55" }
        };

        static readonly Dictionary<string, char> DecryptMap = new Dictionary<string, char>()
        {
            { "11", 'A' }, { "12", 'B' }, { "13", 'C' }, { "14", 'D' }, { "15", 'E' },
            { "21", 'F' }, { "22", 'G' }, { "23", 'H' }, { "24", 'I' }, { "25", 'K' },
            { "31", 'L' }, { "32", 'M' }, { "33", 'N' }, { "34", 'O' }, { "35", 'P' },
            { "41", 'Q' }, { "42", 'R' }, { "43", 'S' }, { "44", 'T' }, { "45", 'U' },
            { "51", 'V' }, { "52", 'W' }, { "53", 'X' }, { "54", 'Y' }, { "55", 'Z' }
        };

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.ToUpper().Replace("J", "I");
            txtOutput.Text = Encrypt(input);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            txtOutput.Text = Decrypt(input);
        }

        static string Encrypt(string input)
        {
            List<string> result = new List<string>();

            foreach (char c in input)
            {
                if (EncryptMap.ContainsKey(c))
                {
                    result.Add(EncryptMap[c]);
                }
            }

            return string.Join(" ", result);
        }

        static string Decrypt(string input)
        {
            string[] pairs = input.Split(' ');
            List<char> result = new List<char>();

            foreach (string pair in pairs)
            {
                if (DecryptMap.ContainsKey(pair))
                {
                    result.Add(DecryptMap[pair]);
                }
            }

            return new string(result.ToArray());
        }

    }
}
