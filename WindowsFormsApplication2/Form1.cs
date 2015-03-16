using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //hypersource C# - Environment
            //System Info
            textBox0.Text = System.Environment.MachineName.ToString();
            textBox1.Text = System.Environment.OSVersion.ToString();
            textBox2.Text = System.Environment.ProcessorCount.ToString();
            textBox3.Text = System.Environment.SystemDirectory.ToString();
            textBox4.Text = System.Environment.TickCount.ToString();
            textBox5.Text = System.Environment.UserDomainName.ToString();
            textBox6.Text = System.Environment.UserName.ToString();
            textBox7.Text = System.Environment.Version.ToString();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
