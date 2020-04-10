using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace sapce
{
    class Starship : PictureBox 
    {
        public Starship()
        {
            InitShip();
        }
        private void InitShip()
        {
            this.BackColor = Color.DarkOrange;
            this.Height = 40;
            this.Width = 100;
        }
    }
}
