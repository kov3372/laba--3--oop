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

        Pen penB = new Pen(Color.Black, 3);
        Pen penW = new Pen(Color.White, 3);
        public Form1()
        {

            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
              
                if (emblem.re)
                {
                    emblem.Draw(pic, penW);
                    emblem.MoveR();
                    emblem.Draw(pic, penB);
                }
                else
                {
                    emblem.RotateEmbleb(pic, penW);
                    emblem.MoveR();
                    emblem.RotateEmbleb(pic, penB);
                }
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

                if (emblem.re)
                {
                    emblem.Draw(pic, penW);
                    emblem.Enlarge();
                    emblem.Draw(pic, penB);
                }
                else
                {
                    emblem.RotateEmbleb(pic, penW);
                    emblem.Enlarge();
                    emblem.RotateEmbleb(pic, penB);
                }

           
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
                
                emblem.Draw(pic,penB);
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


                if (emblem.re)
                {
                    emblem.Draw(pic, penW);
                   
                }
                else
                {
                    emblem.RotateEmbleb(pic, penW);
                   
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

              
                if (emblem.re)
                {
                    emblem.Draw(pic, penW);
                    emblem.Reduce();
                    emblem.Draw(pic, penB);
                }
                else
                {
                    emblem.RotateEmbleb(pic, penW);
                    emblem.Reduce();
                    emblem.RotateEmbleb(pic, penB);
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                if (emblem.re)
                {
                    emblem.Draw(pic, penW);
                    emblem.EndUp();
                    emblem.Draw(pic, penB);
                }
                else
                {
                    emblem.RotateEmbleb(pic, penW);
                    emblem.EndUp();
                    emblem.RotateEmbleb(pic, penB);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                emblem.Draw(pic, penW);
                emblem.Draw(pic, penB);
                emblem.EndDown();
                emblem.Show();
                emblem.Draw(pic, penB);


                if (emblem.re)
                {
                    emblem.Draw(pic, penW);
                    emblem.EndDown();
                    emblem.Draw(pic, penB);
                }
                else
                {
                    emblem.RotateEmbleb(pic, penW);
                    emblem.EndDown();
                    emblem.RotateEmbleb(pic, penB);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                if(emblem.re)
                {
                    emblem.Draw(pic, penW);
                    emblem.MoveL();
                    emblem.Draw(pic, penB);
                }
                else
                {
                    emblem.RotateEmbleb(pic, penW);
                    emblem.MoveL();
                    emblem.RotateEmbleb(pic, penB);
                }
               
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
          
                if (emblem.re)
                {
                    emblem.Draw(pic, penW);
                    emblem.MoveDown();
                    emblem.Draw(pic, penB);
                }
                else
                {
                    emblem.RotateEmbleb(pic, penW);
                    emblem.MoveDown();
                    emblem.RotateEmbleb(pic, penB);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

          
                if (emblem.re)
                {
                    emblem.Draw(pic, penW);
                    emblem.MoveUp();
                    emblem.Draw(pic, penB);
                }
                else
                {
                    emblem.RotateEmbleb(pic, penW);
                    emblem.MoveUp();
                    emblem.RotateEmbleb(pic, penB);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
          
                if (emblem.re)
                {
                    emblem.Draw(pic, penW);
                    emblem.EndRight();
                    emblem.Draw(pic, penB);
                }
                else
                {
                    emblem.RotateEmbleb(pic, penW);
                    emblem.EndRight();
                    emblem.RotateEmbleb(pic, penB);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
           
                if (emblem.re)
                {
                    emblem.Draw(pic, penW);
                    emblem.EndLeft();
                    emblem.Draw(pic, penB);
                }
                else
                {
                    emblem.RotateEmbleb(pic, penW);
                    emblem.EndLeft();
                    emblem.RotateEmbleb(pic, penB);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;

                if(emblem.re)
                {
                    emblem.Draw(pic, penW);
                    emblem.RotateEmbleb(pic,penB);
                }
                else
                {
                  
                    emblem.RotateEmbleb(pic, penW);
                    emblem.Draw(pic, penB);
                }

                
              
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
        }
    }
}
