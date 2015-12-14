using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syncify_GUI
{
    public partial class Form1 : Form
    {
        public void consoleWrite(String s)
        {
            var text = DateTime.Now.ToString("|HH:mm:ss| ") + s;
            listBox_console.Items.Add(text);
            listBox_console.TopIndex = listBox_console.Items.Count - 1;
            status_console.Text = s;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label_version.Text = Res
            consoleWrite("RENDERING GUI............OK");
            consoleWrite("READY");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //listBox_console.Visible = true;
            consoleWrite("Connect button clicked");
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void button_about_Click(object sender, EventArgs e)
        {
            consoleWrite("About button clicked.");
            About about = new About();
            about.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
