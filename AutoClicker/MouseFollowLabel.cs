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
    public partial class MouseFollowLabel : UserControl
    {
        public MouseFollowLabel()
        {
            InitializeComponent();
        }

        public void setCoords(int x, int y) => Coords.Text = String.Format("{0}px {1}px", x, y);

        private void MouseFollowLabel_Load(object sender, EventArgs e)
        {

        }
    }
}
