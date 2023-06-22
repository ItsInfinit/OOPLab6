using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InfOOPLab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Створення об'єктів прямих зі значень полів на формі
                Line line1 = new Line(
                    double.Parse(textBox1.Text),
                    double.Parse(textBox2.Text),
                    double.Parse(textBox3.Text));

                Line line2 = new Line(
                    double.Parse(textBox4.Text),
                    double.Parse(textBox5.Text),
                    double.Parse(textBox6.Text));

                // Перевірка, чи існують прямі
                bool linesExist = CheckLinesExist(line1, line2);

                // Виведення результату на форму
                label6.Text = linesExist ? "Lines exist" : "Lines do not exist";
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckLinesExist(Line line1, Line line2)
        {
            // Розрахунок значення d
            double d = line1.A * line2.B - line2.A * line1.B;

            // Перевірка, чи d не дорівнює нулю
            return d != 0;
        }

         public struct Line
        {
             public double A { get; }
             public double B { get; }
             public double C { get; }

             public Line(double a, double b, double c)
             {
                 A = a;
                 B = b;
                 C = c;
             }
    }
    }
}
