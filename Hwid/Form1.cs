using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hwid
{
    public partial class Form1 : Form
    {
        public static string HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
        public Form1()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = HWID;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HWID);
        }
    }
}
