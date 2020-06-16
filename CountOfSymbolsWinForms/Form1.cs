using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace CountOfSymbolsWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbFirstString.Text = "t5qr33d56q3";
            tbSymbols.Text = "536";

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            int count = 0;//счетчик
            foreach (Char c in tbSymbols.Text)//посимволньно сравниваем две стоки
            {
                foreach (Match m in Regex.Matches(tbFirstString.Text, c.ToString()))//если символы совпадают то увеличиваем счетчик на 1
                    count++;
                tbResult.Text += c.ToString() + "=" + count.ToString()+ Environment.NewLine;//выводим результат для символа в консоль
                count = 0;//обнуляем счетчик
            }

        }
    }
}

