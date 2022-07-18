using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamsExecutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EasyExploits.Module module = new EasyExploits.Module();

        Point lastPoint;

        private string one = string.Empty;

        Boolean onelmao = true;
        Boolean two = false;
        Boolean three = false;

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textBox1 = richTextBox1.Text;
            string textBox2 = richTextBox2.Text;
            string textBox3 = richTextBox3.Text;
            

            if (onelmao == true)
            {
                module.ExecuteScript(textBox1);
            }
            else if (two == true)
            {
                module.ExecuteScript(textBox2);
            }
            else if (three == true)
            {
                module.ExecuteScript(textBox3);
            }
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            module.ExecuteScript("loadstring(game:HttpGet(\"https://pastebin.com/raw/CdjvXLpn\"))()");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            module.ExecuteScript("loadstring(game:HttpGet(\"https://pastebin.com/raw/0MLPL32f\", true))()");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ada-mmmm/Yeat-Executor");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            module.ExecuteScript("loadstring(game:HttpGet(\"https://raw.githubusercontent.com/TheXploiterYT/scripts/main/ctrlclicktpfornooblol\", true))()");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            return;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            return;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;

            onelmao = true;
            two = false;
            three = false;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            richTextBox2.Visible = true;
            richTextBox3.Visible = false;

            onelmao = false;
            two = true;
            three = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = true;

            onelmao = false;
            two = false;
            three = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            module.ExecuteScript("loadstring(game:HttpGet(\"https://pastebin.com/raw/ptMwyJA8\"))()");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            module.ExecuteScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            module.ExecuteScript("loadstring(game:HttpGet(\"https://gist.githubusercontent.com/redninjaawesome/539336c48e73107232933475d8e6120a/raw/f95fcd6db11128acd1a200e8866f806d3a102098/gistfile1.txt\"))()");
        }
    }
}
