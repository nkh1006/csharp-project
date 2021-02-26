using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Diary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"D:\temp\" + textBox1.Text + ".txt", textBox2.Text + Environment.NewLine + Environment.NewLine + "현재시간 : " + DateTime.Now.ToShortDateString()); ;
        }
    }
}
