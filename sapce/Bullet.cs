using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace sapce
{
    class Bullet : PictureBox
    {
        private Timer timerMove;
        public Bullet()
        {
            InitBullet();
        }
        private void InitBulletMove()
        {
            timerMove = new Timer();
            timerMove.Interval = 20;
            timerMove.Start();
        }
        private void TimerBulletMove_Tick(object sender, EventArgs e)
        {

        }
        private void InitBullet()
        {
            this.BackColor = Color.OrangeRed;
            this.Height = 10;
            this.Width = 10;
        }
    }
}
