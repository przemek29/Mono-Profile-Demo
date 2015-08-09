using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MonoProfileDemo
{
    public partial class Form1 : Form
    {
        public int i = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void GarbageButton_CLick(object sender, EventArgs e)
        {
           // GC.RegisterForFullGCNotification(1, 1);
           // GC.ReRegisterForFinalize(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(i);
            i++;
        }
    }

}
