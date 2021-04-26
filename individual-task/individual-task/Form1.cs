using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individual_task
{
    public partial class Form1 : Form
    {
        CEmblem b;
        int count = 0;
        public Form1()
        {
                                
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                emblem.Hide();
                emblem.Draw(pic);
                emblem.MoveR();
                emblem.Show();
                emblem.Draw(pic);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                emblem.Hide();
                emblem.Draw(pic);
                emblem.Enlarge();
                emblem.Show();
                emblem.Draw(pic);
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            CEmblem ob = new CEmblem(new Random().Next(0, 500), new Random().Next(0, 435), "эмблема" + " " + count, 80);                  
            comboBox1.Items.Add(ob);
            count++;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                emblem.Show();
                emblem.Draw(pic);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                        
                emblem.Hide();
                emblem.Draw(pic);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                emblem.Hide();
                emblem.Draw(pic);
                emblem.Reduce();
                emblem.Show();
                emblem.Draw(pic);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                emblem.Hide();
                emblem.Draw(pic);
                emblem.EndUp();
                emblem.Show();
                emblem.Draw(pic);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                emblem.Hide();
                emblem.Draw(pic);
                emblem.EndDown();
                emblem.Show();
                emblem.Draw(pic);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                emblem.Hide();
                emblem.Draw(pic);
                emblem.MoveL();
                emblem.Show();
                emblem.Draw(pic);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                emblem.Hide();
                emblem.Draw(pic);
                emblem.MoveDown();
                emblem.Show();
                emblem.Draw(pic);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                emblem.Hide();
                emblem.Draw(pic);
                emblem.MoveUp();
                emblem.Show();
                emblem.Draw(pic);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                emblem.Hide();
                emblem.Draw(pic);
                emblem.EndRight();
                emblem.Show();
                emblem.Draw(pic);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                emblem.Hide();
                emblem.Draw(pic);
                emblem.EndLeft();
                emblem.Show();
                emblem.Draw(pic);
            }
        }
    }
}
