using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class HintMain : Form
    {
        public HintMain()
        {
            InitializeComponent();
        }

        public void setCoords(int x, int y) {
            Coords.Text = String.Format("{0}px {1}px", x, y);
            this.Location = new System.Drawing.Point(x + 15, y + 15);
        }

        public void reveal()
        {
            this.Show();
            Coords.Visible = true;
            Label.Visible = true;
        }

        private void HintMain_Load(object sender, EventArgs e)
        {

        }
    }
}
