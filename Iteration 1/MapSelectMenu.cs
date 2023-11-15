using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iteration_1
{
    public partial class MapSelectMenu : Form
    {
        public MapSelectMenu()
        {
            InitializeComponent();
        }

        private void MapSelectMenu_Load(object sender, EventArgs e)
        {

        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //fixes f94cb34 bug
        }
    }
}
