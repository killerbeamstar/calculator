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
    public partial class Form1 : Form, IView //use IView as interface
    {
        rekenmachine1.Control.Control Control1;
        /// <summary>
        /// use the created control and call it control1
        /// </summary>
        /// <param name="Control1"></param>
        public Form1(rekenmachine1.Control.Control Control1) 
        {
            this.Control1 = Control1; 
            Control1.SetView(this); //send the view to control
            InitializeComponent();
        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cijfer1_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer1.Text);
        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cijfer2_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer2.Text);

        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cijfer3_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer3.Text);
        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cijfer4_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer4.Text);
        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cijfer5_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer5.Text);
        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cijfer6_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer6.Text);
        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cijfer7_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer7.Text);
        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cijfer8_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer8.Text);
        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cijfer9_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer9.Text);
        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cijfer0_Click(object sender, EventArgs e)
        {
            Control1.click(cijfer0.Text);
        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void komma_Click(object sender, EventArgs e)
        {
            Control1.click(komma.Text);
        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keer_Click(object sender, EventArgs e)
        {
            Control1.click(keer.Text);
        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delen_Click(object sender, EventArgs e)
        {
            Control1.click(delen.Text);
        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plus_Click(object sender, EventArgs e)
        {
            Control1.click(plus.Text);
        }
        /// <summary>
        /// send the number to control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void min_Click(object sender, EventArgs e)
        {
            Control1.click(min.Text);
        }
        /// <summary>
        /// empties the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AC_Click(object sender, EventArgs e)
        {
            Control1.nothing();
        }
        /// <summary>
        /// run calculate and send the text in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void som_Click(object sender, EventArgs e)
        {
            Control1.calculate(textBox1.Text); 
        }
        /// <summary>
        /// put nothig in the textbox
        /// </summary>
        public void empty()
        {
            textBox1.Text = ""; 
        }
        /// <summary>
        /// put the text in textbox
        /// </summary>
        /// <param name="text"></param>
        public void toTextbox(string text)
        {
            textBox1.Text = textBox1.Text + text;//
        }
        /// <summary>
        /// put the text in the textbox
        /// </summary>
        /// <param name="text"></param>
        public void response(string text)
        {
            textBox1.Text = text;
        }
    }
}
