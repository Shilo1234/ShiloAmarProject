using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiloAmarsProj.Controls
{
    public partial class admissonControl : UserControl
    {
        public admissonControl()
        {

            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registaretionFormControl x = new registaretionFormControl;
            Mainclass.showcontrol(x, Content);
        }

        private void admissonControl_Load(object sender, EventArgs e)
        {

        }
    }
}
