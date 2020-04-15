using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloatingText
{
    public partial class MovingText: UserControl
    {
        int x, y;

        public MovingText()
        {
            InitializeComponent();
            label1.Text = "Zostań w domu!";
            label1.Font = new Font(" ", 22, FontStyle.Bold);
            timer1.Interval = 1;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.SetBounds(x, y, 1, 1);
            x++;
            if(x>=1000)
            {
                x = 0;
            }
        }
    }
}
