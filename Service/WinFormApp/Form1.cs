using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var param = int.Parse(textBox1.Text);
            var client = new ServiceReference1.ContractClient("WSHttpBinding_IContract");

            label1.Text = client.ReturnInt(param).ToString();
            //label1.Text = client.ReturnString(param).ToString();
            

            client.Close();
        }
    }
}
