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

        public delegate void MyDelegate(string message);

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
            string textBox = richTextBox1.Text;
            module.ExecuteScript(textBox);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "";
            BeginInvoke(new MyDelegate(DelegateMethod), message);
        }

        public void DelegateMethod(string message)
        {
            richTextBox1.Text = message;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            module.ExecuteScript("loadstring(game:HttpGet(\"https://pastebin.com/raw/CdjvXLpn\"))()");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            module.ExecuteScript("loadstring(game:HttpGet(\"https://pastebin.com/raw/RmD3qNp7\", true))()");
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
            return;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            return;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
