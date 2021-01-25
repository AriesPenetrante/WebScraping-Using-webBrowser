using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using System.Globalization;
using System.Net.Http;
using System.Threading;
using Timer = System.Threading.Timer;


namespace WebScraping_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void scrape()

        {

            string browserContents = webBrowser.DocumentText;

            outputTextBox.Text = browserContents;
        

           // MatchCollection authorM = Regex.Matches(browserContents, @"author\s*(.+?)\s", RegexOptions.Singleline);

           // outputTextBox.Text = Convert.ToString(authorM);
           


        }






            private void scrapeBtn_Click(object sender, EventArgs e)
        {

            scrape();



        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = string.Empty;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
