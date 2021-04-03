using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolishNotationArithmeticCalculator
{
    public partial class Form2 : Form
    {
        Stack<string> PolishStack = new Stack<string>();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            PolishNotation();
            foreach (string item in PolishStack) {

                label3.Text += item;
                
            }

            
        }


        public void PolishNotation()
        {
           string[] TempArray = textBox1.Text.ToString().Split(' ');
            Array.Reverse(TempArray);

            foreach(string item in TempArray)
            {

                switch (item)
                {
                    case  "+":
                        int Number1, Number2;
                        Number1 =Int32.Parse(PolishStack.Pop());
                        Number2 = Int32.Parse(PolishStack.Pop());
                        PolishStack.Push((Number1 + Number2).ToString());
                        break;

                    case "-":
                        int Number3, Number4;
                        Number3 = Int32.Parse(PolishStack.Pop());
                        Number4 = Int32.Parse(PolishStack.Pop());
                        PolishStack.Push((Number3 - Number4).ToString());
                        break;

                    case "*":
                        int Number5, Number6;
                        Number5 = Int32.Parse(PolishStack.Pop());
                        Number6 = Int32.Parse(PolishStack.Pop());
                        PolishStack.Push((Number5 * Number6).ToString());
                        break;

                    case "/":
                        int Number7, Number8;
                        Number7 = Int32.Parse(PolishStack.Pop());
                        Number8 = Int32.Parse(PolishStack.Pop());
                        PolishStack.Push((Number7 / Number8).ToString());
                        break;

                    default:
                        PolishStack.Push(item);
                        break;

                }

            }
              
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
