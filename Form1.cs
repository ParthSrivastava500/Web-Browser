using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Search_engine
{
    public partial class WebWeaver : Form
    {
        public WebWeaver()
        {
            InitializeComponent();
        }
        private void NavigateToPage()
        { 
          button2.Enabled = false;
            textBox1.Enabled = false;
            webBrowser1.Navigate(textBox1.Text);
            toolStripStatusLabel1.Text = "Commencing testcase";
        
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is made by Walker Talker");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)ConsoleKey.Enter) 
            {
                webBrowser1.Navigate(textBox1.Text);
            }
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button2.Enabled = true;
            textBox1.Enabled= true;
            toolStripStatusLabel1.Text = "commencement completed";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            //commenting to let you know to do nothing under this class because that's how that loading works ;)
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // historyToolStripMenuItem_Click.Text("yeah");
        }

        private void historyToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
