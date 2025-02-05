using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract11_3_Shengals
{
    public partial class Robot : Form
    {
        public Robot()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Robot robot1 = new Robot();
            Robot robot2 = new Robot();
            Robot robot3 = new Robot();
            Random rn = new Random();
            int b = rn.Next(0, 100);
            robot1.Min(b);

            robot1.kollife = Convert.ToInt32(textBox1.Text);
            label1.Text = "Количество жизней робота 1 в начале игры: " + robot1.kollife;

            robot2.kollife = Convert.ToInt32(textBox2.Text);
            label4.Text = "Количество жизней робота 2 в начале игры: " +robot2.kollife;

            robot3.kollife = Convert.ToInt32(textBox3.Text);
            label6.Text = "Количество жизней робота 3 в начале игры: " +robot3.kollife;

            int a = robot1.kollife;
            robot1.Kol(a, robot1.kollife);
            label2.Text = "Количество жизней робота 1 в конце игры: " + Convert.ToString(robot1.Getlife());

            robot2.Kol(a, robot1.kollife);
            label5.Text = "Количество жизней робота 2 в конце игры: " + Convert.ToString(robot2.Getlife());

            robot3.Kol(a, robot1.kollife);
            label7.Text = "Количество жизней робота 3 в конце игры: " + Convert.ToString(robot3.Getlife());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Robot robot1 = new Robot();
            Random rn = new Random();
            int b = rn.Next(0, 100);
            robot1.Min(b);
            robot1.kollife = Convert.ToInt32(textBox1.Text);
            label1.Text = "Количество жизней робота 1 в начале игры: " + robot1.kollife;
            robot1.Min(robot1.kollife);
            label2.Text = "Количество жизней робота 1 после игры: " + Convert.ToString(robot1.Getlife());
        }
    }
}
