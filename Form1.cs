using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_4_Task_1
{
    public partial class Form1 : Form
    {
        private Triangle triangle;//triangle
        private EquilTriangle equil_triangle;//equil_triangle


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            triangle = null;
            equil_triangle = null;
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                if (a == b && b == c)
                {
                    equil_triangle = new EquilTriangle(a, b, c);
                    MessageBox.Show("Створено рівносторонній трикутник.");
                }
                else
                {
                    triangle = new Triangle(a, b, c);
                    MessageBox.Show("Створено трикутник.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось створити трикутник");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (triangle != null)
                MessageBox.Show( $"Периметр трикутника: {triangle.GetPerimetr().ToString()}" );
            else if (equil_triangle != null)
                MessageBox.Show($"Периметр рівностороннього трикутника: {equil_triangle.GetPerimetr().ToString()}");
            else
                MessageBox.Show("Спочатку створіть будь-який трикутник.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (triangle != null)
                MessageBox.Show( $"Перший(альфа) кут = {triangle.GetAlpha().ToString()}." );
            else if (equil_triangle != null)
                MessageBox.Show($"Перший(альфа) кут = {equil_triangle.GetAlpha().ToString()}.");
            else
                MessageBox.Show("Спочатку створіть будь-який трикутник.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (triangle != null)
                MessageBox.Show($"Другий(бета) кут = {triangle.GetBetta().ToString()}.");
            else if (equil_triangle != null)
                MessageBox.Show($"Другий(бета) кут = {equil_triangle.GetBetta().ToString()}.");
            else
                MessageBox.Show("Спочатку створіть будь-який трикутник.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (triangle != null)
                MessageBox.Show($"Третій(гамма) кут = {triangle.GetGamma().ToString()}.");
            else if (equil_triangle != null)
                MessageBox.Show($"Третій(гамма) кут = {equil_triangle.GetGamma().ToString()}.");
            else
                MessageBox.Show("Спочатку створіть будь-який трикутник.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (equil_triangle != null)
                MessageBox.Show($"Площа рівностороннього трикутника: {equil_triangle.GetArea().ToString()}" );
            else
                MessageBox.Show("Рівньостороннього трикутника не створено.");
        }

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
