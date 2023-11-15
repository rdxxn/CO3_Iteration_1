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
    public partial class LeaderBoard : Form
    {
        public LeaderBoard()
        {
            InitializeComponent();
        }

        private void LeaderBoard_Load(object sender, EventArgs e)
        {

        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //Exits the program fully when pressing x button
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show(); //Opens LeaderBoard form
            mainMenu.Size = new Size(Convert.ToInt32(this.Width), Convert.ToInt32(this.Height)); //Matches the mainMenu forms size with the size of the MainMenu form
            if (this.WindowState == FormWindowState.Maximized) { mainMenu.WindowState = FormWindowState.Maximized; } //If the MainMenu form was maximised, Maximise the mainMenu form
            mainMenu.DesktopLocation = new Point(Convert.ToInt32(this.DesktopLocation.X), Convert.ToInt32(this.DesktopLocation.Y)); //Matches the position of mainMenu form with the MainMenu form
            this.Hide(); //Hides LeaderBoard form
        }
    }
}
