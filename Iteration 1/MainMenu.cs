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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlayClick(object sender, EventArgs e)
        {
            MapSelectMenu MapSelectMenuForm = new MapSelectMenu();
            MapSelectMenuForm.Show(); //Opens LeaderBoard form
            MapSelectMenuForm.Size = new Size(Convert.ToInt32(this.Width), Convert.ToInt32(this.Height)); //Matches the MapSelectMenu forms size with the size of the MainMenu form
            if (this.WindowState == FormWindowState.Maximized) { MapSelectMenuForm.WindowState = FormWindowState.Maximized; } //If the MainMenu form was maximised, Maximise the MapSelectMenu form
            MapSelectMenuForm.DesktopLocation = new Point(Convert.ToInt32(this.DesktopLocation.X), Convert.ToInt32(this.DesktopLocation.Y)); //Matches the position of MapSelectMenu form with the previous MainMenu form
            this.Hide(); //Hides MainMenu form
        }

        private void QuitClick(object sender, EventArgs e)
        {
            Application.Exit(); //Exits the program
        }

        private void LeaderBoardClick(object sender, EventArgs e)
        {
            LeaderBoard LeaderBoardForm = new LeaderBoard();
            LeaderBoardForm.Show(); //Opens LeaderBoard form
            LeaderBoardForm.Size = new Size(Convert.ToInt32(this.Width), Convert.ToInt32(this.Height)); //Matches the LeaderBoard forms size with the size of the MainMenu form
            if(this.WindowState == FormWindowState.Maximized){ LeaderBoardForm.WindowState = FormWindowState.Maximized; } //If the MainMenu form was maximised, Maximise the LeaderBoard form
            LeaderBoardForm.DesktopLocation = new Point(Convert.ToInt32(this.DesktopLocation.X), Convert.ToInt32(this.DesktopLocation.Y)); //Matches the position of LeaderBoard form with the previous MainMenu form
            this.Hide(); //Hides MainMenu form
        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //fixes f94cb34 bug
        }
    }
}
