using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_Level2_Shoot
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g
        Spaceship spaceship = new Spaceship();//create object called spaceship
        List<Missile> missiles = new List<Missile>(); //declare a list  missiles from the missile class

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            spaceship.drawSpaceship(g);
            foreach (Missile m in missiles)
            {
                m.draw(g);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            spaceship.moveSpaceship(e.X);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                missiles.Add(new Missile(spaceship.spaceRec));
            }
        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
