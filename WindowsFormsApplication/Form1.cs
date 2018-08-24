using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        int youClickeddme;
        const string youclickText = "You Clicked me {0} times";
        public Form1()
        {
            InitializeComponent();
            youClickeddme = 0;
            textBox1.Text = String.Format(youclickText, youClickeddme);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Format(youclickText, ++youClickeddme);
        }
    }
}
