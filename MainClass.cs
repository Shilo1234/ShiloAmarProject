using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using ShiloAmarsProj.Controls;
using MaterialSkin.Controls;

namespace ShiloAmarsProj
{
    class MainClass
    {
        public MainClass()
        {
         
        }
        
        public static void viewWindow(fullDashBoard x,loginWin y, Form  z)
        {
            x.Show();
            x.WindowState = FormWindowState.Maximized;


        }
        public static void showcontrol(Control control,Panel x)
        {
            x.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            x.Controls.Add(control);
        }







    }
}
