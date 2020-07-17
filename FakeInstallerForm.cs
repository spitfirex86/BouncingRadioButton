using System;
using System.Drawing;
using System.Windows.Forms;

namespace BouncingRadioButton
{
    public partial class FakeInstallerForm : Form
    {
        public FakeInstallerForm()
        {
            InitializeComponent();
        }

        private Random rnd = new Random();
        private float angle = 0.85f;
        private float speed = 20;

        private void frameTimer_Tick(object sender, EventArgs e)
        {
            double Dist() => speed / (1 + Math.Abs(angle));
            void RndAngle() => angle += (float)((rnd.NextDouble() - 0.5f)/10f);

            int x = ball.Location.X;
            int y = ball.Location.Y;

            double dist = Dist();
            int newX = (int)(x + dist);
            int newY = (int)(y + dist * angle);

            if (newX+ball.Height > groupBox1.ClientRectangle.Right || newX < groupBox1.ClientRectangle.Left)
            {
                speed = -speed;
                angle = -angle;
                newX = (int)(x + Dist());
                RndAngle();
            }

            if (newY+ball.Height > groupBox1.ClientRectangle.Bottom || newY < groupBox1.ClientRectangle.Top + 5)
            {
                angle = -angle;
                newY = (int)(y + Dist() * angle);
                RndAngle();
            }

            ball.Location = new Point(newX, newY);
        }

        private void ball_FocusEnter(object sender, EventArgs e)
        {
            yesOffer.Select();
        }

        private void ball_MouseEnter(object sender, EventArgs e)
        {
            if (!frameTimer.Enabled)
            {
                frameTimer.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
