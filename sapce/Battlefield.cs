using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sapce
{
    public partial class Battlefield : Form
    {
        Starship starship;
        Bullet bullet;
        public Battlefield()
        {
            InitializeComponent();
            InitBattlefield();
        }

        private void InitBattlefield()

        {
            starship = new Starship();
            starship.Left = ClientRectangle.Width - (ClientRectangle.Width/2 +starship.Width/2);
            starship.Top = 300;
            this.Controls.Add(starship);
        }
        private void FireBullet()
        {
            bullet = new Bullet();
            bullet.Top = starship.Top;
            bullet.Left = starship.Left +(starship.Width/2-bullet.Width/2);
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Battlefield_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                FireBullet();
            }
        }
    }
}
