using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using ShiloAmarsProj.Controls;
using System.Windows.Forms;

namespace ShiloAmarsProj
{
    public partial class fullDashBoard : MainWin
    {
        public fullDashBoard()
        {
            InitializeComponent();
        }

        private void fullDashBoard_Load(object sender, EventArgs e)
        {

        }

        public void showcontrols(Control control)
        {
            Content.Controls.Clear();
            control.Dock =DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            Content.Controls.Add(control);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admissonControl x = new admissonControl();
            showcontrols(x); 
        }
    }
}
