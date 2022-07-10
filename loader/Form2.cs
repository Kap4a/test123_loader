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
    public partial class Form2 : Form
    {
        bool MousePressed = false;
        Point clickPosition;
        Point moveStartPosition;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

            cokctil.login = textBox1.Text;
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            MousePressed = true;
            clickPosition = Cursor.Position;
            moveStartPosition = this.Location;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (MousePressed)
            {
                Size frmOffset = new Size(Point.Subtract(Cursor.Position, new Size(clickPosition)));
                this.Location = Point.Add(moveStartPosition, frmOffset);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            MousePressed = false;
        }
    }
}

