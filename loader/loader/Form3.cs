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
    public partial class Form3 : Form
    {
        bool MousePressed = false;
        Point clickPosition;
        Point moveStartPosition;

        private Form activateForm;
        private void OpenGlobalPanel(Form chieldForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            
            activateForm = chieldForm;
            chieldForm.TopLevel = false;
            chieldForm.FormBorderStyle = FormBorderStyle.None;
            chieldForm.Dock = DockStyle.Fill;
            this.globalPanel.Controls.Add(chieldForm);
            this.globalPanel.Tag = chieldForm;
            chieldForm.BringToFront();
            chieldForm.Show();
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label4.Text = cokctil.login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenGlobalPanel(new menu.global(),sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenGlobalPanel(new menu.about(), sender);
        }

       

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MousePressed = true;
            clickPosition = Cursor.Position;
            moveStartPosition = this.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (MousePressed)
            {
                Size frmOffset = new Size(Point.Subtract(Cursor.Position, new Size(clickPosition)));
                this.Location = Point.Add(moveStartPosition, frmOffset);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            MousePressed = false;
        }
    }
}
