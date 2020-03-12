using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorSoapLibrary;

namespace CalculatorGUI {
    public partial class Form1 : Form {
        CalculatorSoapDLL calculatorLibrary = new CalculatorSoapDLL();
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
          
            label1.Text = calculatorLibrary.Add(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            label1.Text = calculatorLibrary.Subtract(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e) {
            label1.Text = calculatorLibrary.Multiply(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();

        }

        private void button3_Click(object sender, EventArgs e) {
            label1.Text = calculatorLibrary.Divide(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();

        }
    }
}
