using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loader
{
    public partial class Form1 : Form
    {
        bool MousePressed = false;
        Point clickPosition;
        Point moveStartPosition;
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void close(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = "admin";

            if (textBox1.Text == key)
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("не чел,мимо вопроса, иди нахуй");
                Application.Exit();
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e )
        {
            MousePressed = true;
            clickPosition = Cursor.Position;
            moveStartPosition = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e )
        {
            if (MousePressed)
            {
                Size frmOffset = new Size(Point.Subtract(Cursor.Position, new Size(clickPosition)));
               this.Location = Point.Add(moveStartPosition, frmOffset);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MousePressed = false;
        }
    }
}

