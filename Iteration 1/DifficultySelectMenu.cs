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
    public partial class DifficultySelectMenu : Form
    {
        public DifficultySelectMenu()
        {
            InitializeComponent();
        }

        private void DifficultySelectMenu_Load(object sender, EventArgs e)
        {

        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Exits the program fully when pressing x button
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MapSelectMenu mapSelectMenu = new MapSelectMenu();
            mapSelectMenu.Show(); //Opens LeaderBoard form
            mapSelectMenu.Size = new Size(Convert.ToInt32(this.Width), Convert.ToInt32(this.Height)); //Matches the mapSelectMenu forms size with the size of the MainMenu form
            if (this.WindowState == FormWindowState.Maximized) { mapSelectMenu.WindowState = FormWindowState.Maximized; } //If the MainMenu form was maximised, Maximise the mapSelectMenu form
            mapSelectMenu.DesktopLocation = new Point(Convert.ToInt32(this.DesktopLocation.X), Convert.ToInt32(this.DesktopLocation.Y)); //Matches the position of mapSelectMenu form with the MainMenu form
            this.Hide(); //Hides MainMenu form
        }
    }
}
