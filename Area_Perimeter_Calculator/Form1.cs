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

namespace Area_Perimeter_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboShape.Items.Add("Square");
            comboShape.Items.Add("Rectangle");
            comboShape.Items.Add("Triangle");
            comboShape.Items.Add("Circle");
            comboCalType.Items.Add("Area");
            comboCalType.Items.Add("Perimeter");
            textBox1stEdge.Enabled = false;
            textBox2ndEdge.Enabled = false;
            textBox3rdEdge.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                switch (comboShape.Text)
                {
                    case "Square":
                        switch (comboCalType.Text)
                        {
                            case "Area":
                                Square sa = new Square(int.Parse(textBox1stEdge.Text));
                                MessageBox.Show(sa.calculateArea().ToString());
                                break;
                            case "Perimeter":
                                Square sp = new Square(int.Parse(textBox1stEdge.Text), 4);
                                MessageBox.Show(sp.calculatePerimeter().ToString());
                                break;
                        }
                        break;
                    case "Rectangle":
                        switch (comboCalType.Text)
                        {
                            case "Area":
                                Rectangle ra = new Rectangle(int.Parse(textBox1stEdge.Text), int.Parse(textBox2ndEdge.Text));
                                MessageBox.Show(ra.calculateArea().ToString());
                                break;
                            case "Perimeter":
                                Rectangle rp = new Rectangle(int.Parse(textBox1stEdge.Text), int.Parse(textBox2ndEdge.Text), 2);
                                MessageBox.Show(rp.calculatePerimeter().ToString());
                                break;
                        }
                        break;
                    case "Triangle":
                        switch (comboCalType.Text)
                        {
                            case "Area":
                                Triangle ta = new Triangle(int.Parse(textBox1stEdge.Text), int.Parse(textBox2ndEdge.Text), 1, 2);
                                MessageBox.Show(ta.calculateArea().ToString());
                                break;
                            case "Perimeter":
                                Triangle tp = new Triangle(int.Parse(textBox1stEdge.Text), int.Parse(textBox2ndEdge.Text), int.Parse(textBox3rdEdge.Text));
                                MessageBox.Show(tp.calculatePerimeter().ToString());
                                break;
                        }
                        break;
                    case "Circle":
                        switch (comboCalType.Text)
                        {
                            case "Area":
                                Circle ca = new Circle(int.Parse(textBox1stEdge.Text), 3.14);
                                MessageBox.Show(ca.calculateArea().ToString());
                                break;
                            case "Perimeter":
                                Circle cp = new Circle(int.Parse(textBox1stEdge.Text), 3.14, 2);
                                MessageBox.Show(cp.calculatePerimeter().ToString());
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboCalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboShape.Text == "Square" && comboCalType.Text == "Area")
            {
                textBox1stEdge.Enabled = true;
                textBox2ndEdge.Enabled = false;
                textBox3rdEdge.Enabled = false;
            }
            if (comboShape.Text == "Square" && comboCalType.Text == "Perimeter")
            {
                textBox1stEdge.Enabled = true;
                textBox2ndEdge.Enabled = false;
                textBox3rdEdge.Enabled = false;
            }
            if (comboShape.Text == "Rectangle" && comboCalType.Text == "Area")
            {
                textBox1stEdge.Enabled = true;
                textBox2ndEdge.Enabled = true;
                textBox3rdEdge.Enabled = false;
            }
            if (comboShape.Text == "Rectangle" && comboCalType.Text == "Perimeter")
            {
                textBox1stEdge.Enabled = true;
                textBox2ndEdge.Enabled = true;
                textBox3rdEdge.Enabled = false;
            }
            if (comboShape.Text == "Triangle" && comboCalType.Text == "Area")
            {
                textBox1stEdge.Enabled = true;
                textBox2ndEdge.Enabled = true;
                textBox3rdEdge.Enabled = false;
            }
            if (comboShape.Text == "Triangle" && comboCalType.Text == "Perimeter")
            {
                textBox1stEdge.Enabled = true;
                textBox2ndEdge.Enabled = true;
                textBox3rdEdge.Enabled = true;
            }
            if (comboShape.Text == "Circle" && comboCalType.Text == "Area")
            {
                textBox1stEdge.Enabled = true;
                textBox2ndEdge.Enabled = false;
                textBox3rdEdge.Enabled = false;
            }
            if (comboShape.Text == "Circle" && comboCalType.Text == "Perimeter")
            {
                textBox1stEdge.Enabled = true;
                textBox2ndEdge.Enabled = false;
                textBox3rdEdge.Enabled = false;
            }
        }

        
    }
}
