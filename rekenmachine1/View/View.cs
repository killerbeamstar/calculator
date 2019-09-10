using rekenmachine1.Control;
using rekenmachine1.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rekenmachine1
{
    public partial class Form1 : Form, IView
    {
        rekenmachine1.Control.Control Control1;
        
            public Form1(rekenmachine1.Control.Control Control1)
        {
            this.Control1 = Control1;
            Control1.SetView(this);
            InitializeComponent();
        }

        private void cijfer1_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer1.Text);
        }        

        private void cijfer2_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer2.Text);

        }

        private void cijfer3_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer3.Text);

        }

        private void cijfer4_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer4.Text);

        }

        private void cijfer5_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer5.Text);

        }

        private void cijfer6_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer6.Text);

        }

        private void cijfer7_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer7.Text);

        }

        private void cijfer8_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer8.Text);

        }

        private void cijfer9_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer9.Text);

        }

        private void cijfer0_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer0.Text);

        }

        private void komma_Click(object sender, EventArgs e)
        {
            Control1.click(komma.Text);

        }

        private void keer_Click(object sender, EventArgs e)
        {
            Control1.click(keer.Text);

        }

        private void delen_Click(object sender, EventArgs e)
        {
            Control1.click(delen.Text);

        }

        private void plus_Click(object sender, EventArgs e)
        {
            Control1.click(plus.Text);

        }

        private void min_Click(object sender, EventArgs e)
        {
            Control1.click(min.Text);

        }

        private void AC_Click(object sender, EventArgs e)
        {
            Control1.nothing();
        }

        private void som_Click(object sender, EventArgs e)
        {
            Control1.calculate(textBox1.Text);
        }

        public void empty()
        {

            textBox1.Text = "";
        }

        public void toTextbox(string text)
        {
            textBox1.Text = textBox1.Text + text;
        }

        public void response(string text)
        {
            Convert.ToDouble(text);
            textBox1.Text = text.ToString();
        }
    }
}
